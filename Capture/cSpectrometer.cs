using NetOceanDirect;

namespace Capture
{
    public class cSpectrometer
    {
        private readonly cCalibrationFile calibrationFile = new();

        private readonly NetOceanDirect.OceanDirect ocean = OceanDirect.getInstance();

        private mSpectrometerSettings SpectrometerSettings = new();
        private int DeviceID { get; set; }
        public double[]? spectrometerWavelengths { get; private set; }
        public double[]? spectrometerCalibrationData { get; private set; }
        public double[]? darkScanData { get; private set; }
        public double[]? lightScanData { get; private set; }
        public double[]? absoluteSpectralIrradianceData { get; private set; }


        /// <summary>
        /// A list of possible spectrometer initialisation states.
        /// </summary>
        private enum IniProcessState
        {
            LoadCalibrationFile,
            GetAllSpectrometers,
            OpenDevice,
            GetAllSerialNo,
            TestSerialNo,
            StrobeEn,
            SetIntegrationTime,
            ScansToAverage,
            BoxCarWidth,
            ElectricDark,
            NonLinearityCorrection,
            TriggerMode,
            CloseDevice
        }

        //  Ocean Direct Error Codes
        //  ------------------------
        //  0 Successful/no error.
        //  1 Undefined error.
        //  2 No device found.
        //  3 Could not close device.
        //  4 Feature not implemented.
        //  5 No such feature on device.
        //  6 Data transfer error.
        //  7 Invalid user buffer provided.
        //  8 Input was out of bounds.
        //  9 Spectrometer was saturated.
        //  10 Value not found.
        //  11 Divide By Zero Error(Cannot Divide by Zero).
        //  12 Non-Invertible Matrix Error(Matrix Has No Inverse).
        //  13 Array Length Error(Array Lengths Don't Match).
        //  14 Array Index Out of Bounds (Check Your Array Length? Is it Zero?).
        //  15 Invalid Argument(Check Input Parameter).
        //  16 Empty Vector(Check Input Parameter).
        //  17 Color Conversion Error(Check Values).
        //  18 No Peak Found Error(Input Spectrum Has No Peaks).
        //  19 Illegal State Error(Unexpected State).
        //  20 Minimum Integration Time Reached(Lamp is too bright).
        //  21 Maximum Integration Time Reached(Lamp is too dim).
        //  22 Please ensure that your lamp is on.
        //  23 Not enough buffer space.
        //  24 Command not supported by device.
        //  25 Integration time is below the “safe” minimum when averaging is enabled.

        /// <summary>
        /// A list of possible spectrometer initialisation error codes.
        /// </summary>
        public enum ErrorMessage
        {
            /*
             * Ocean Direct error codes.
             */
            None = 0,
            UndefinedError = 1,
            NoDeviceFound = 2,
            CouldNotCloseDevice = 3,
            FeatureNotImplemented = 4,
            NoSuchFeature = 5,
            DataTransferError = 6,
            InvalidUserBufferProvided = 7,
            InputOutOfBounds = 8,
            SpectrometerSaturated = 9,
            ValueNotFound = 10,
            DivideByZeroError = 11,
            NonInvertibleMatrixError = 12,
            ArrayLengthError = 13,
            ArrayIndexOutOfBounds = 14,
            InvalidArgument = 15,
            EmptyVector = 16,
            ColorConversionError = 17,
            NoPeakFoundError = 18,
            IllegalStateError = 19,
            MinimumIntegrationTimeReached = 20,
            MaximumIntegrationTimeReached = 21,
            PleaseEnsureLampOn = 22,
            NotEnoughBufferSpace = 23,
            CommandNotSupported = 24,
            IntegrationTimeBelowSafeMinimum = 25,
            /* 
             * Custom error codes.
             */
            ConnectionFailed,
            NoDevicesFound,
            NullDataFound,
            FailCalFileParse,
            FailOpenDevice,
            FailGetSerialNumber,
            FailTestSerialNumber,
            FailToLocateCalFileDevice,
            FailCloseDevice
        }

        /// <summary>
        /// This function initialises the Ocean Insight spectrometer detailed in the calibration file. The location of the 
        /// calibration file is passed to the function as a path.
        /// </summary>
        public ErrorMessage Initialise(String path, mSpectrometerSettings settings)
        {
            IniProcessState state = IniProcessState.LoadCalibrationFile;
            ErrorMessage error = ErrorMessage.None;

            List<Devices> devices = new();

            String serialNo = String.Empty;

            int i = 0, errorCode = 0;

            bool run = true;

            while (run)
            {
                run = false;

                switch (state)
                {
                    case IniProcessState.LoadCalibrationFile:

                        if (calibrationFile.Parse(path) == cCalibrationFile.ErrorCode.NoError)
                        {
                            spectrometerWavelengths = calibrationFile.Wavelength;
                            spectrometerCalibrationData = calibrationFile.Energy;

                            state = IniProcessState.GetAllSpectrometers;
                            run = true;
                        }
                        else
                        {
                            error = ErrorMessage.FailCalFileParse;
                        }

                        break;

                    case IniProcessState.GetAllSpectrometers:

                        devices = ocean.findDevices().ToList();

                        if (devices.Count > 0)
                        {
                            state = IniProcessState.OpenDevice;
                            run = true;
                        }
                        else
                        {
                            error = ErrorMessage.NoDevicesFound;
                        }
                        break;

                    case IniProcessState.OpenDevice:

                        ocean.openDevice(devices[i].Id, ref errorCode);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.GetAllSerialNo;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;

                    case IniProcessState.GetAllSerialNo:

                        serialNo = ocean.getSerialNumber(devices[i].Id, ref errorCode);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.TestSerialNo;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;

                    case IniProcessState.TestSerialNo:

                        if (serialNo == calibrationFile.Spectrometer)
                        {
                            DeviceID = devices[i].Id;
                            state = IniProcessState.SetIntegrationTime;

                        }
                        else
                        {
                            state = IniProcessState.CloseDevice;
                            run = true;
                        }

                        break;

                    case IniProcessState.CloseDevice:

                        ocean.closeDevice(i, ref errorCode);

                        if (errorCode == 0)
                        {
                            error = ErrorMessage.FailCloseDevice;
                        }
                        else
                        {
                            if (++i >= devices.Count)
                            {
                                error = ErrorMessage.FailToLocateCalFileDevice;
                            }
                            else
                            {
                                state = IniProcessState.OpenDevice;
                                run = true;
                            }
                        }

                        break;

                    case IniProcessState.StrobeEn:
                        state = IniProcessState.SetIntegrationTime;
                        run = true;
                        break;

                    case IniProcessState.SetIntegrationTime:

                        ocean.setIntegrationTimeMicros(DeviceID, ref errorCode, (uint)settings.IntegrationTime);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.ScansToAverage;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;

                    case IniProcessState.ScansToAverage:

                        ocean.setScansToAverage(DeviceID, ref errorCode, (uint)settings.ScansToAverage);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.BoxCarWidth;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;


                    case IniProcessState.BoxCarWidth:

                        ocean.setBoxcarWidth(DeviceID, ref errorCode, (uint)settings.BoxcarWidth);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.ElectricDark;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;

                    case IniProcessState.ElectricDark:

                        ocean.applyElectricDarkCorrection(DeviceID, ref errorCode, settings.ElectricDark);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.NonLinearityCorrection;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;

                    case IniProcessState.NonLinearityCorrection:

                        ocean.applyNonLinearityCorrection(DeviceID, ref errorCode, settings.NonlinearityCorrection);

                        if (errorCode == 0)
                        {
                            state = IniProcessState.TriggerMode;
                            run = true;
                        }
                        else
                        {
                            error = (ErrorMessage)errorCode;
                        }

                        break;

                    case IniProcessState.TriggerMode:
                        break;

                    default: break;
                }
            }

            return (error);
        }


        /// <summary>
        /// This function tests the connection with an initialises spectrometer by requesting the serial number from
        /// the device and comparing it with the calibration file.
        /// </summary>
        private ErrorMessage CheckConnection()
        {
            ErrorMessage error;

            int errorCode = (int)ErrorMessage.UndefinedError;

            string serialNo = ocean.getSerialNumber(DeviceID, ref errorCode);

            error = (ErrorMessage)errorCode;

            if (error == ErrorMessage.None)
            {
                if (serialNo != calibrationFile.Spectrometer)
                {
                    error = ErrorMessage.FailTestSerialNumber;
                }
            }

            return error;
        }

        /// <summary>
        /// Uses the light scan data, dark scan data, calibration file data, integration time in microseconds and collection
        /// area in square centimetres to calculate the absolute spectral irradiance.
        /// </summary>
        /// <returns>
        /// Error an error flag - 0 when calulation was successfull or 1 when an error has ocurred.
        /// </returns>
        public ErrorMessage ProcessSpectrum (double collectionArea, int integrationTime)
        {
            ErrorMessage error = ErrorMessage.UndefinedError;
            List<double> asi = new();

            if ((lightScanData != null) && (darkScanData != null) && (calibrationFile.Energy != null))
            {
                /*
                 * TODO: This is a hack to provide the array 'absoluteSpectralIrradianceData' with a dimension.
                 * There must be a better way like: malloc.
                 * 
                 * IS THIS WHY THE ASI AND CAL FILE MATCHING UP IN CSV?!
                 *
                 */
                absoluteSpectralIrradianceData = calibrationFile.Energy;

                for (int i = 0; i < calibrationFile.Energy.Count(); i++)
                {
                    /*
                     * Compute the energy.
                     * (light scan counts - dark scan counts) * joules per count
                     */
                    absoluteSpectralIrradianceData[i] = ((lightScanData[i] - darkScanData[i]) * calibrationFile.Energy[i]);

                    /*
                     * Compute the dLp
                     */
                    double dLp = 0.396;
                    if (i < calibrationFile.Energy.Count()-1)
                    {
                        dLp = calibrationFile.Wavelength[i+1] - calibrationFile.Wavelength[i];
                    }

                    /*
                     * Compute the power - Watts (Joules/Second)
                     */
                    absoluteSpectralIrradianceData[i] = ((absoluteSpectralIrradianceData[i] * 1000000) / (integrationTime * dLp));

                    /*
                     * Scaling for the collection area.
                     */
                    absoluteSpectralIrradianceData[i] = absoluteSpectralIrradianceData[i] / collectionArea;
                }
            }
            else
            {
                error = ErrorMessage.NullDataFound;
                clearBuffers();
            }

            return (error);
        }

        /// <summary>
        /// Captures spectral information and stores it in the dark scan data array.
        /// </summary>
        /// <returns>An error code.</returns>
        public ErrorMessage DarkScan()
        {
            ErrorMessage error;
            int errorCode = (int)ErrorMessage.UndefinedError;

            /*
             * Since a new dark scan is being attempted, any strored absolute spectral irradiance
             * valus are invalidated.
             */
            absoluteSpectralIrradianceData = null;

            if (CheckConnection() == ErrorMessage.None)
            {
                darkScanData = ocean.getSpectrum(DeviceID, ref errorCode);
                error = (ErrorMessage)errorCode;
            }
            else
            {
                error = ErrorMessage.ConnectionFailed;
            }

            if (error != ErrorMessage.None) darkScanData = null;

            return error;
        }

        /// <summary>
        /// Captures spectral information and stores it in the light scan data array.
        /// </summary>
        /// <returns>An error code.</returns>
        public ErrorMessage LightScan()
        {
            ErrorMessage error;
            int errorCode = (int)ErrorMessage.UndefinedError;

            /*
             * Since a new dark scan is being attempted, any strored absolute spectral irradiance
             * valus are invalidated.
             */
            absoluteSpectralIrradianceData = null;

            if (CheckConnection() == ErrorMessage.None)
            {
                lightScanData = ocean.getSpectrum(DeviceID, ref errorCode);
                error = (ErrorMessage)errorCode;
            }
            else
            {
                error = ErrorMessage.ConnectionFailed;
            }

            if (error != ErrorMessage.None) lightScanData = null;

            return error;
        }

        /// <summary>
        /// Closes an initialised spectrometer.
        /// </summary>
        /// <returns>
        /// Error message.
        /// </returns>
        public ErrorMessage close()
        {
            ErrorMessage error;
            int errorCode = (int)ErrorMessage.UndefinedError;

            ocean.closeDevice(DeviceID, ref errorCode);

            error = (ErrorMessage)errorCode;

            ocean.Dispose();
            clearBuffers();

            return (error);
        }

        /// <summary>
        /// Flushes out any stored spectral data.
        /// </summary>
        private void clearBuffers()
        {
            darkScanData = null;
            lightScanData = null;
            absoluteSpectralIrradianceData = null;
        }
    }
}