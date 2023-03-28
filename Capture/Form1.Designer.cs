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
            this.labelMicroscopeManufacturer = new System.Windows.Forms.Label();
            this.labelMicroscopeModel = new System.Windows.Forms.Label();
            this.labelMicroscopeArm = new System.Windows.Forms.Label();
            this.labelMicroscopeOptic = new System.Windows.Forms.Label();
            this.labelLightsourceManufacturer = new System.Windows.Forms.Label();
            this.labelLightsourceModel = new System.Windows.Forms.Label();
            this.labelLightsourceWavelength = new System.Windows.Forms.Label();
            this.labelAttachmentMethod = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSetupSpectrometer, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.buttonCapture, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeManufacturer, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeModel, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeArm, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMicroscopeOptic, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLightsourceManufacturer, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLightsourceModel, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLightsourceWavelength, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxAttachmentMethod, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelMicroscopeManufacturer, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelMicroscopeModel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelMicroscopeArm, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelMicroscopeOptic, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelLightsourceManufacturer, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelLightsourceModel, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelLightsourceWavelength, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelAttachmentMethod, 2, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.119318F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172236F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.172237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.17439F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.69918F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.69918F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.102273F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(683, 557);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonSetupSpectrometer
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonSetupSpectrometer, 2);
            this.buttonSetupSpectrometer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetupSpectrometer.Location = new System.Drawing.Point(139, 337);
            this.buttonSetupSpectrometer.Name = "buttonSetupSpectrometer";
            this.buttonSetupSpectrometer.Size = new System.Drawing.Size(402, 81);
            this.buttonSetupSpectrometer.TabIndex = 5;
            this.buttonSetupSpectrometer.Text = "Set Up Spectrometer";
            this.buttonSetupSpectrometer.UseVisualStyleBackColor = true;
            this.buttonSetupSpectrometer.Click += new System.EventHandler(this.buttonSetupSpectrometer_Click);
            // 
            // buttonCapture
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonCapture, 2);
            this.buttonCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCapture.Enabled = false;
            this.buttonCapture.Location = new System.Drawing.Point(139, 424);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(402, 81);
            this.buttonCapture.TabIndex = 6;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // comboBoxMicroscopeManufacturer
            // 
            this.comboBoxMicroscopeManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeManufacturer.FormattingEnabled = true;
            this.comboBoxMicroscopeManufacturer.Location = new System.Drawing.Point(343, 30);
            this.comboBoxMicroscopeManufacturer.Name = "comboBoxMicroscopeManufacturer";
            this.comboBoxMicroscopeManufacturer.Size = new System.Drawing.Size(198, 23);
            this.comboBoxMicroscopeManufacturer.TabIndex = 7;
            this.comboBoxMicroscopeManufacturer.Text = "Select Microscope Manufacturer";
            // 
            // comboBoxMicroscopeModel
            // 
            this.comboBoxMicroscopeModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeModel.FormattingEnabled = true;
            this.comboBoxMicroscopeModel.Location = new System.Drawing.Point(343, 69);
            this.comboBoxMicroscopeModel.Name = "comboBoxMicroscopeModel";
            this.comboBoxMicroscopeModel.Size = new System.Drawing.Size(198, 23);
            this.comboBoxMicroscopeModel.TabIndex = 8;
            this.comboBoxMicroscopeModel.Text = "Select Microscope Model";
            // 
            // comboBoxMicroscopeArm
            // 
            this.comboBoxMicroscopeArm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeArm.FormattingEnabled = true;
            this.comboBoxMicroscopeArm.Location = new System.Drawing.Point(343, 108);
            this.comboBoxMicroscopeArm.Name = "comboBoxMicroscopeArm";
            this.comboBoxMicroscopeArm.Size = new System.Drawing.Size(198, 23);
            this.comboBoxMicroscopeArm.TabIndex = 9;
            this.comboBoxMicroscopeArm.Text = "Select Microscope Arm";
            // 
            // comboBoxMicroscopeOptic
            // 
            this.comboBoxMicroscopeOptic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMicroscopeOptic.FormattingEnabled = true;
            this.comboBoxMicroscopeOptic.Location = new System.Drawing.Point(343, 147);
            this.comboBoxMicroscopeOptic.Name = "comboBoxMicroscopeOptic";
            this.comboBoxMicroscopeOptic.Size = new System.Drawing.Size(198, 23);
            this.comboBoxMicroscopeOptic.TabIndex = 10;
            this.comboBoxMicroscopeOptic.Text = "Select Microscope Optic";
            // 
            // comboBoxLightsourceManufacturer
            // 
            this.comboBoxLightsourceManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLightsourceManufacturer.FormattingEnabled = true;
            this.comboBoxLightsourceManufacturer.Location = new System.Drawing.Point(343, 186);
            this.comboBoxLightsourceManufacturer.Name = "comboBoxLightsourceManufacturer";
            this.comboBoxLightsourceManufacturer.Size = new System.Drawing.Size(198, 23);
            this.comboBoxLightsourceManufacturer.TabIndex = 11;
            this.comboBoxLightsourceManufacturer.Text = "Select Lightsource Manufacturer";
            // 
            // comboBoxLightsourceModel
            // 
            this.comboBoxLightsourceModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLightsourceModel.FormattingEnabled = true;
            this.comboBoxLightsourceModel.Location = new System.Drawing.Point(343, 225);
            this.comboBoxLightsourceModel.Name = "comboBoxLightsourceModel";
            this.comboBoxLightsourceModel.Size = new System.Drawing.Size(198, 23);
            this.comboBoxLightsourceModel.TabIndex = 12;
            this.comboBoxLightsourceModel.Text = "Select Lightsource Model";
            // 
            // comboBoxLightsourceWavelength
            // 
            this.comboBoxLightsourceWavelength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLightsourceWavelength.FormattingEnabled = true;
            this.comboBoxLightsourceWavelength.Location = new System.Drawing.Point(343, 264);
            this.comboBoxLightsourceWavelength.Name = "comboBoxLightsourceWavelength";
            this.comboBoxLightsourceWavelength.Size = new System.Drawing.Size(198, 23);
            this.comboBoxLightsourceWavelength.TabIndex = 13;
            this.comboBoxLightsourceWavelength.Text = "Select Lightsource Wavlength";
            // 
            // comboBoxAttachmentMethod
            // 
            this.comboBoxAttachmentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAttachmentMethod.FormattingEnabled = true;
            this.comboBoxAttachmentMethod.Location = new System.Drawing.Point(343, 303);
            this.comboBoxAttachmentMethod.Name = "comboBoxAttachmentMethod";
            this.comboBoxAttachmentMethod.Size = new System.Drawing.Size(198, 23);
            this.comboBoxAttachmentMethod.TabIndex = 14;
            this.comboBoxAttachmentMethod.Text = "Select Attachment Method";
            // 
            // labelMicroscopeManufacturer
            // 
            this.labelMicroscopeManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicroscopeManufacturer.AutoSize = true;
            this.labelMicroscopeManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMicroscopeManufacturer.Location = new System.Drawing.Point(139, 34);
            this.labelMicroscopeManufacturer.Name = "labelMicroscopeManufacturer";
            this.labelMicroscopeManufacturer.Size = new System.Drawing.Size(198, 15);
            this.labelMicroscopeManufacturer.TabIndex = 15;
            this.labelMicroscopeManufacturer.Text = "Select Microscope Manufacturer:";
            this.labelMicroscopeManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMicroscopeModel
            // 
            this.labelMicroscopeModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicroscopeModel.AutoSize = true;
            this.labelMicroscopeModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMicroscopeModel.Location = new System.Drawing.Point(139, 73);
            this.labelMicroscopeModel.Name = "labelMicroscopeModel";
            this.labelMicroscopeModel.Size = new System.Drawing.Size(198, 15);
            this.labelMicroscopeModel.TabIndex = 16;
            this.labelMicroscopeModel.Text = "Select Microscope Model:";
            this.labelMicroscopeModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMicroscopeArm
            // 
            this.labelMicroscopeArm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicroscopeArm.AutoSize = true;
            this.labelMicroscopeArm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMicroscopeArm.Location = new System.Drawing.Point(139, 112);
            this.labelMicroscopeArm.Name = "labelMicroscopeArm";
            this.labelMicroscopeArm.Size = new System.Drawing.Size(198, 15);
            this.labelMicroscopeArm.TabIndex = 17;
            this.labelMicroscopeArm.Text = "Select Microscope Arm:";
            this.labelMicroscopeArm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMicroscopeOptic
            // 
            this.labelMicroscopeOptic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicroscopeOptic.AutoSize = true;
            this.labelMicroscopeOptic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMicroscopeOptic.Location = new System.Drawing.Point(139, 151);
            this.labelMicroscopeOptic.Name = "labelMicroscopeOptic";
            this.labelMicroscopeOptic.Size = new System.Drawing.Size(198, 15);
            this.labelMicroscopeOptic.TabIndex = 18;
            this.labelMicroscopeOptic.Text = "Select Microscope Optic:";
            this.labelMicroscopeOptic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLightsourceManufacturer
            // 
            this.labelLightsourceManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLightsourceManufacturer.AutoSize = true;
            this.labelLightsourceManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLightsourceManufacturer.Location = new System.Drawing.Point(139, 190);
            this.labelLightsourceManufacturer.Name = "labelLightsourceManufacturer";
            this.labelLightsourceManufacturer.Size = new System.Drawing.Size(198, 15);
            this.labelLightsourceManufacturer.TabIndex = 20;
            this.labelLightsourceManufacturer.Text = "Select Lightsource Manufacturer:";
            this.labelLightsourceManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLightsourceModel
            // 
            this.labelLightsourceModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLightsourceModel.AutoSize = true;
            this.labelLightsourceModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLightsourceModel.Location = new System.Drawing.Point(139, 229);
            this.labelLightsourceModel.Name = "labelLightsourceModel";
            this.labelLightsourceModel.Size = new System.Drawing.Size(198, 15);
            this.labelLightsourceModel.TabIndex = 19;
            this.labelLightsourceModel.Text = "Select Lightsource Model:";
            this.labelLightsourceModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLightsourceWavelength
            // 
            this.labelLightsourceWavelength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLightsourceWavelength.AutoSize = true;
            this.labelLightsourceWavelength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLightsourceWavelength.Location = new System.Drawing.Point(139, 268);
            this.labelLightsourceWavelength.Name = "labelLightsourceWavelength";
            this.labelLightsourceWavelength.Size = new System.Drawing.Size(198, 15);
            this.labelLightsourceWavelength.TabIndex = 21;
            this.labelLightsourceWavelength.Text = "Select Lightsource Wavelength:";
            this.labelLightsourceWavelength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAttachmentMethod
            // 
            this.labelAttachmentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAttachmentMethod.AutoSize = true;
            this.labelAttachmentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttachmentMethod.Location = new System.Drawing.Point(139, 307);
            this.labelAttachmentMethod.Name = "labelAttachmentMethod";
            this.labelAttachmentMethod.Size = new System.Drawing.Size(198, 15);
            this.labelAttachmentMethod.TabIndex = 22;
            this.labelAttachmentMethod.Text = "Select Attachment Method:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 581);
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
            this.tableLayoutPanel2.PerformLayout();
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
        private Label labelMicroscopeManufacturer;
        private Label labelMicroscopeModel;
        private Label labelMicroscopeArm;
        private Label labelMicroscopeOptic;
        private Label labelLightsourceManufacturer;
        private Label labelLightsourceModel;
        private Label labelLightsourceWavelength;
        private Label labelAttachmentMethod;
    }
}