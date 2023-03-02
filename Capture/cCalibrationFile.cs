using System.Globalization;

namespace Capture
{
    internal class cCalibrationFile
    {
        public enum ErrorCode
        {
            NoError = 0,
            CalibrationFileNotFound,
            NoWaveLengthData,
        }

        public DateTime Date { get; private set; }

        /// <summary>
        /// The Spectrometer String stores the serial number of the spectrometer used to create the calibration file.
        /// </summary>
        public String Spectrometer { get; private set; } = String.Empty;
        public String Lamp_SN { get; private set; } = String.Empty;
        public double Integration_Time_s { get; private set; }
        public int Scans_To_Average { get; private set; }
        public int Boxcar_Width { get; private set; }
        public String Light_Capture { get; private set; } = String.Empty;
        public double[]? Wavelength { get; private set; }
        public double[]? Energy { get; private set; } /* uJoule/count */

        /// <summary>
        /// This function returns a DateTime object consistant with the date found in an Ocean Insight calibration file.
        /// </summary>
        private static DateTime ParseDate(String date)
        {
            DateTime d = new();

            /*
             * Sample calibration file date: "Mon Aug 01 09:20:08 BST 2022"
             */
            try
            {
                d = DateTime.ParseExact(date, "ddd MMM dd HH':'mm':'ss 'BST' yyyy", null);
            }
            catch (FormatException)
            {
                /* ToDo: The funcuntion must be made to return an error flag for this condition.*/
                MessageBox.Show("Unable to parse the calibration file date: " + date, "Error!", MessageBoxButtons.OK);
            }

            return (d);
        }

        /// <summary>
        /// This function reduces the Ocean Insight calibration file down into its component parts and stores the information
        /// in public class variables.
        /// </summary>
        public ErrorCode Parse(String path)
        {
            List<double> wavelenghts = new();
            List<double> energy = new();
            ErrorCode error = ErrorCode.NoError;

            if (File.Exists(path))
            {
                var fileData = File.ReadLines(path);

                foreach (var line in fileData)
                {
                    if (line.Contains('\t'))
                    {
                        string[] element = line.Split('\t');

                        switch (element[0])
                        {
                            case "Date:":
                                Date = ParseDate(element[1]);
                                break;
                            case "Spectrometer:":
                                Spectrometer = element[1];
                                break;
                            case "Lamp SN:":
                                Lamp_SN = element[1];
                                break;
                            case "Integration Time (sec):":
                                Integration_Time_s = double.Parse(element[1], CultureInfo.InvariantCulture);
                                break;
                            case "Scans to average:":
                                Scans_To_Average = int.Parse(element[1]);
                                break;
                            case "Boxcar width:":
                                Boxcar_Width = int.Parse(element[1]);
                                break;
                            case "Integrating sphere":
                                Light_Capture = element[0];
                                break;
                            default:
                                wavelenghts.Add(double.Parse(element[0], CultureInfo.InvariantCulture));
                                energy.Add(double.Parse(element[1], CultureInfo.InvariantCulture));
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Calibration file not found: " + path, "Error!", MessageBoxButtons.OK);
                error = ErrorCode.CalibrationFileNotFound;
            }

            /*
             * An assumption is being made that if any wavelengths are found then all waveleght are found.
             */
            if (wavelenghts.Count > 0)
            {
                Wavelength = wavelenghts.ToArray();
                Energy = energy.ToArray();
            }
            else
            {
                error = ErrorCode.NoWaveLengthData;
            }

            return error;
        }
    }

}
