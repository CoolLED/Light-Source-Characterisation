namespace Capture
{
    partial class FormCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapture));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCaptureDarkScan = new System.Windows.Forms.Button();
            this.buttonCaptureIrradiance = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCaptureDarkScan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCaptureIrradiance, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonCaptureDarkScan
            // 
            this.buttonCaptureDarkScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCaptureDarkScan.Location = new System.Drawing.Point(61, 44);
            this.buttonCaptureDarkScan.Name = "buttonCaptureDarkScan";
            this.tableLayoutPanel1.SetRowSpan(this.buttonCaptureDarkScan, 2);
            this.buttonCaptureDarkScan.Size = new System.Drawing.Size(460, 76);
            this.buttonCaptureDarkScan.TabIndex = 0;
            this.buttonCaptureDarkScan.Text = "Capture Dark Scan";
            this.buttonCaptureDarkScan.UseVisualStyleBackColor = true;
            this.buttonCaptureDarkScan.Click += new System.EventHandler(this.buttonCaptureDarkScan_Click);
            // 
            // buttonCaptureIrradiance
            // 
            this.buttonCaptureIrradiance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCaptureIrradiance.Location = new System.Drawing.Point(61, 167);
            this.buttonCaptureIrradiance.Name = "buttonCaptureIrradiance";
            this.tableLayoutPanel1.SetRowSpan(this.buttonCaptureIrradiance, 2);
            this.buttonCaptureIrradiance.Size = new System.Drawing.Size(460, 76);
            this.buttonCaptureIrradiance.TabIndex = 1;
            this.buttonCaptureIrradiance.Text = "Capture Absolute Spectral Irradiance";
            this.buttonCaptureIrradiance.UseVisualStyleBackColor = true;
            this.buttonCaptureIrradiance.Click += new System.EventHandler(this.buttonCaptureIrradiance_Click);
            // 
            // FormCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Spectrum";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonCaptureDarkScan;
        private Button buttonCaptureIrradiance;
    }
}