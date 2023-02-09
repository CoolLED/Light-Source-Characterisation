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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addLightSourceManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLightSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMicrscopeManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMicroscopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.addLightSourceManufacturerToolStripMenuItem,
            this.addLightSourceToolStripMenuItem,
            this.addMicrscopeManufacturerToolStripMenuItem,
            this.addMicroscopeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem1.Text = "Hardware";
            // 
            // addLightSourceManufacturerToolStripMenuItem
            // 
            this.addLightSourceManufacturerToolStripMenuItem.Name = "addLightSourceManufacturerToolStripMenuItem";
            this.addLightSourceManufacturerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addLightSourceManufacturerToolStripMenuItem.Text = "Add Light Source Manufacturer";
            this.addLightSourceManufacturerToolStripMenuItem.Click += new System.EventHandler(this.addLightSourceManufacturerToolStripMenuItem_Click);
            // 
            // addLightSourceToolStripMenuItem
            // 
            this.addLightSourceToolStripMenuItem.Name = "addLightSourceToolStripMenuItem";
            this.addLightSourceToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addLightSourceToolStripMenuItem.Text = "Add Light Source";
            this.addLightSourceToolStripMenuItem.Click += new System.EventHandler(this.addLightSourceToolStripMenuItem_Click);
            // 
            // addMicrscopeManufacturerToolStripMenuItem
            // 
            this.addMicrscopeManufacturerToolStripMenuItem.Name = "addMicrscopeManufacturerToolStripMenuItem";
            this.addMicrscopeManufacturerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addMicrscopeManufacturerToolStripMenuItem.Text = "Add Microscope Manufacturer";
            this.addMicrscopeManufacturerToolStripMenuItem.Click += new System.EventHandler(this.addMicrscopeManufacturerToolStripMenuItem_Click);
            // 
            // addMicroscopeToolStripMenuItem
            // 
            this.addMicroscopeToolStripMenuItem.Name = "addMicroscopeToolStripMenuItem";
            this.addMicroscopeToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addMicroscopeToolStripMenuItem.Text = "Add Microscope";
            this.addMicroscopeToolStripMenuItem.Click += new System.EventHandler(this.addMicroscopeToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCapture, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 592);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCapture.Location = new System.Drawing.Point(183, 299);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(417, 68);
            this.buttonCapture.TabIndex = 5;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(183, 77);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel2.SetRowSpan(this.listBox1, 3);
            this.listBox1.Size = new System.Drawing.Size(417, 216);
            this.listBox1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ligh Source Characterisation - Capture";
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
        private ToolStripMenuItem addLightSourceToolStripMenuItem;
        private ToolStripMenuItem addMicroscopeToolStripMenuItem;
        private ToolStripMenuItem addMicrscopeManufacturerToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCapture;
        private ListBox listBox1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem addLightSourceManufacturerToolStripMenuItem;
    }
}