namespace Capture
{
    partial class FormHardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHardware));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLightsourceName = new System.Windows.Forms.Label();
            this.textBoxHardwareName = new System.Windows.Forms.TextBox();
            this.comboBoxHardwareTables = new System.Windows.Forms.ComboBox();
            this.labelHardwareValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelLightsourceName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHardwareName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxHardwareTables, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHardwareValue, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonAdd, 3);
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(64, 173);
            this.buttonAdd.Name = "buttonAdd";
            this.tableLayoutPanel1.SetRowSpan(this.buttonAdd, 2);
            this.buttonAdd.Size = new System.Drawing.Size(483, 62);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLightsourceName
            // 
            this.labelLightsourceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLightsourceName.AutoSize = true;
            this.labelLightsourceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLightsourceName.Location = new System.Drawing.Point(64, 43);
            this.labelLightsourceName.Name = "labelLightsourceName";
            this.labelLightsourceName.Size = new System.Drawing.Size(157, 15);
            this.labelLightsourceName.TabIndex = 1;
            this.labelLightsourceName.Text = "Add Hardware to:";
            this.labelLightsourceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHardwareName
            // 
            this.textBoxHardwareName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxHardwareName, 2);
            this.textBoxHardwareName.Location = new System.Drawing.Point(227, 107);
            this.textBoxHardwareName.Name = "textBoxHardwareName";
            this.textBoxHardwareName.Size = new System.Drawing.Size(320, 23);
            this.textBoxHardwareName.TabIndex = 5;
            this.textBoxHardwareName.Text = "Add Hardware Value";
            // 
            // comboBoxHardwareTables
            // 
            this.comboBoxHardwareTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxHardwareTables, 2);
            this.comboBoxHardwareTables.FormattingEnabled = true;
            this.comboBoxHardwareTables.Location = new System.Drawing.Point(227, 39);
            this.comboBoxHardwareTables.Name = "comboBoxHardwareTables";
            this.comboBoxHardwareTables.Size = new System.Drawing.Size(320, 23);
            this.comboBoxHardwareTables.TabIndex = 6;
            this.comboBoxHardwareTables.Text = "Select Hardware Table";
            // 
            // labelHardwareValue
            // 
            this.labelHardwareValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHardwareValue.AutoSize = true;
            this.labelHardwareValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHardwareValue.Location = new System.Drawing.Point(64, 111);
            this.labelHardwareValue.Name = "labelHardwareValue";
            this.labelHardwareValue.Size = new System.Drawing.Size(157, 15);
            this.labelHardwareValue.TabIndex = 7;
            this.labelHardwareValue.Text = "Value:";
            // 
            // FormHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHardware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Hardware";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAdd;
        private Label labelLightsourceName;
        private TextBox textBoxHardwareName;
        private ComboBox comboBoxHardwareTables;
        private Label labelHardwareValue;
    }
}