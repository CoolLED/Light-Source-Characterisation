namespace Capture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetupSpectrometer = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.comboBoxMicroscopeManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxMicroscopeModel = new System.Windows.Forms.ComboBox();
            this.comboBoxMicroscopeArm = new System.Windows.Forms.ComboBox();
            this.comboBoxMicroscopeOptic = new System.Windows.Forms.ComboBox();
            this.comboBoxLightsourceManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxLightsourceModel = new System.Windows.Forms.ComboBox();
            this.comboBoxLightsourceWavelength = new System.Windows.Forms.ComboBox();
            this.comboBoxAttachmentMethod = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHardwareToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem1.Text = "Hardware";
            // 
            // addHardwareToolStripMenuItem
            // 
            this.addHardwareToolStripMenuItem.Name = "addHardwareToolStripMenuItem";
            this.addHardwareToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addHardwareToolStripMenuItem.Text = "Add Hardware";
            this.addHardwareToolStripMenuItem.Click += new System.EventHandler(this.addHardwareToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSetupSpectrometer, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.buttonCapture, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeManufacturer, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeModel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeArm, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeOptic, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLightsourceManufacturer, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLightsourceModel, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLightsourceWavelength, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxAttachmentMethod, 2, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(683, 592);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonSetupSpectrometer
            // 
            this.buttonSetupSpectrometer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetupSpectrometer.Location = new System.Drawing.Point(133, 410);
            this.buttonSetupSpectrometer.Name = "buttonSetupSpectrometer";
            this.buttonSetupSpectrometer.Size = new System.Drawing.Size(417, 68);
            this.buttonSetupSpectrometer.TabIndex = 5;
            this.buttonSetupSpectrometer.Text = "Set Up Spectrometer";
            this.buttonSetupSpectrometer.UseVisualStyleBackColor = true;
            this.buttonSetupSpectrometer.Click += new System.EventHandler(this.buttonSetupSpectrometer_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCapture.Enabled = false;
            this.buttonCapture.Location = new System.Drawing.Point(133, 484);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(417, 68);
            this.buttonCapture.TabIndex = 6;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // comboBoxMicroscopeManufacturer
            // 
            this.comboBoxMicroscopeManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeManufacturer.FormattingEnabled = true;
            this.comboBoxMicroscopeManufacturer.Location = new System.Drawing.Point(133, 42);
            this.comboBoxMicroscopeManufacturer.Name = "comboBoxMicroscopeManufacturer";
            this.comboBoxMicroscopeManufacturer.Size = new System.Drawing.Size(417, 23);
            this.comboBoxMicroscopeManufacturer.TabIndex = 7;
            this.comboBoxMicroscopeManufacturer.Text = "Select Microscope Manufacturer";
            // 
            // comboBoxMicroscopeModel
            // 
            this.comboBoxMicroscopeModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeModel.FormattingEnabled = true;
            this.comboBoxMicroscopeModel.Location = new System.Drawing.Point(133, 89);
            this.comboBoxMicroscopeModel.Name = "comboBoxMicroscopeModel";
            this.comboBoxMicroscopeModel.Size = new System.Drawing.Size(417, 23);
            this.comboBoxMicroscopeModel.TabIndex = 8;
            this.comboBoxMicroscopeModel.Text = "Select Microscope Model";
            // 
            // comboBoxMicroscopeArm
            // 
            this.comboBoxMicroscopeArm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeArm.FormattingEnabled = true;
            this.comboBoxMicroscopeArm.Location = new System.Drawing.Point(133, 136);
            this.comboBoxMicroscopeArm.Name = "comboBoxMicroscopeArm";
            this.comboBoxMicroscopeArm.Size = new System.Drawing.Size(417, 23);
            this.comboBoxMicroscopeArm.TabIndex = 9;
            this.comboBoxMicroscopeArm.Text = "Select Microscope Arm";
            // 
            // comboBoxMicroscopeOptic
            // 
            this.comboBoxMicroscopeOptic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeOptic.FormattingEnabled = true;
            this.comboBoxMicroscopeOptic.Location = new System.Drawing.Point(133, 183);
            this.comboBoxMicroscopeOptic.Name = "comboBoxMicroscopeOptic";
            this.comboBoxMicroscopeOptic.Size = new System.Drawing.Size(417, 23);
            this.comboBoxMicroscopeOptic.TabIndex = 10;
            this.comboBoxMicroscopeOptic.Text = "Select Microscope Optic";
            // 
            // comboBoxLightsourceManufacturer
            // 
            this.comboBoxLightsourceManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLightsourceManufacturer.FormattingEnabled = true;
            this.comboBoxLightsourceManufacturer.Location = new System.Drawing.Point(133, 230);
            this.comboBoxLightsourceManufacturer.Name = "comboBoxLightsourceManufacturer";
            this.comboBoxLightsourceManufacturer.Size = new System.Drawing.Size(417, 23);
            this.comboBoxLightsourceManufacturer.TabIndex = 11;
            this.comboBoxLightsourceManufacturer.Text = "Select Lightsource Manufacturer";
            // 
            // comboBoxLightsourceModel
            // 
            this.comboBoxLightsourceModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLightsourceModel.FormattingEnabled = true;
            this.comboBoxLightsourceModel.Location = new System.Drawing.Point(133, 277);
            this.comboBoxLightsourceModel.Name = "comboBoxLightsourceModel";
            this.comboBoxLightsourceModel.Size = new System.Drawing.Size(417, 23);
            this.comboBoxLightsourceModel.TabIndex = 12;
            this.comboBoxLightsourceModel.Text = "Select Lightsource Model";
            // 
            // comboBoxLightsourceWavelength
            // 
            this.comboBoxLightsourceWavelength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLightsourceWavelength.FormattingEnabled = true;
            this.comboBoxLightsourceWavelength.Location = new System.Drawing.Point(133, 324);
            this.comboBoxLightsourceWavelength.Name = "comboBoxLightsourceWavelength";
            this.comboBoxLightsourceWavelength.Size = new System.Drawing.Size(417, 23);
            this.comboBoxLightsourceWavelength.TabIndex = 13;
            this.comboBoxLightsourceWavelength.Text = "Select Lightsource Wavlength";
            // 
            // comboBoxAttachmentMethod
            // 
            this.comboBoxAttachmentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAttachmentMethod.FormattingEnabled = true;
            this.comboBoxAttachmentMethod.Location = new System.Drawing.Point(133, 371);
            this.comboBoxAttachmentMethod.Name = "comboBoxAttachmentMethod";
            this.comboBoxAttachmentMethod.Size = new System.Drawing.Size(417, 23);
            this.comboBoxAttachmentMethod.TabIndex = 14;
            this.comboBoxAttachmentMethod.Text = "Select Attachment Method";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 643);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Source Characterisation - Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSetupSpectrometer;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem addHardwareToolStripMenuItem;
        private Button buttonCapture;
        private ComboBox comboBoxMicroscopeManufacturer;
        private ComboBox comboBoxMicroscopeModel;
        private ComboBox comboBoxMicroscopeArm;
        private ComboBox comboBoxMicroscopeOptic;
        private ComboBox comboBoxLightsourceManufacturer;
        private ComboBox comboBoxLightsourceModel;
        private ComboBox comboBoxLightsourceWavelength;
        private ComboBox comboBoxAttachmentMethod;
    }
}