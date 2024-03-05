namespace configurationfile
{
    partial class Form1
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
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LicenceBox = new System.Windows.Forms.ComboBox();
            this.AccelerometerBox = new System.Windows.Forms.ComboBox();
            this.Fill = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Hammer = new System.Windows.Forms.TextBox();
            this.Accelerometer = new System.Windows.Forms.TextBox();
            this.Licence = new System.Windows.Forms.TextBox();
            this.HammerBox = new System.Windows.Forms.ComboBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 2;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Controls.Add(this.LicenceBox, 1, 2);
            this.MainPanel.Controls.Add(this.AccelerometerBox, 1, 1);
            this.MainPanel.Controls.Add(this.Fill, 0, 3);
            this.MainPanel.Controls.Add(this.Read, 1, 3);
            this.MainPanel.Controls.Add(this.Hammer, 0, 0);
            this.MainPanel.Controls.Add(this.Accelerometer, 0, 1);
            this.MainPanel.Controls.Add(this.Licence, 0, 2);
            this.MainPanel.Controls.Add(this.HammerBox, 1, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.Size = new System.Drawing.Size(656, 190);
            this.MainPanel.TabIndex = 0;
            // 
            // LicenceBox
            // 
            this.LicenceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicenceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenceBox.FormattingEnabled = true;
            this.LicenceBox.Location = new System.Drawing.Point(331, 97);
            this.LicenceBox.Name = "LicenceBox";
            this.LicenceBox.Size = new System.Drawing.Size(322, 40);
            this.LicenceBox.TabIndex = 7;
            // 
            // AccelerometerBox
            // 
            this.AccelerometerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccelerometerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.AccelerometerBox.FormattingEnabled = true;
            this.AccelerometerBox.Location = new System.Drawing.Point(331, 50);
            this.AccelerometerBox.Name = "AccelerometerBox";
            this.AccelerometerBox.Size = new System.Drawing.Size(322, 40);
            this.AccelerometerBox.TabIndex = 6;
            // 
            // Fill
            // 
            this.Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill.Location = new System.Drawing.Point(3, 144);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(322, 43);
            this.Fill.TabIndex = 0;
            this.Fill.Text = "Fill Informations";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Read
            // 
            this.Read.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Read.Location = new System.Drawing.Point(331, 144);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(322, 43);
            this.Read.TabIndex = 1;
            this.Read.Text = "Read Informations";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Hammer
            // 
            this.Hammer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Hammer.Location = new System.Drawing.Point(3, 3);
            this.Hammer.Name = "Hammer";
            this.Hammer.Size = new System.Drawing.Size(322, 39);
            this.Hammer.TabIndex = 2;
            // 
            // Accelerometer
            // 
            this.Accelerometer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Accelerometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Accelerometer.Location = new System.Drawing.Point(3, 50);
            this.Accelerometer.Name = "Accelerometer";
            this.Accelerometer.Size = new System.Drawing.Size(322, 39);
            this.Accelerometer.TabIndex = 3;
            // 
            // Licence
            // 
            this.Licence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Licence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Licence.Location = new System.Drawing.Point(3, 97);
            this.Licence.Name = "Licence";
            this.Licence.Size = new System.Drawing.Size(322, 39);
            this.Licence.TabIndex = 4;
            // 
            // HammerBox
            // 
            this.HammerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HammerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.HammerBox.FormattingEnabled = true;
            this.HammerBox.Location = new System.Drawing.Point(331, 3);
            this.HammerBox.Name = "HammerBox";
            this.HammerBox.Size = new System.Drawing.Size(322, 40);
            this.HammerBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 190);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.ComboBox LicenceBox;
        private System.Windows.Forms.ComboBox AccelerometerBox;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox Hammer;
        private System.Windows.Forms.TextBox Accelerometer;
        private System.Windows.Forms.TextBox Licence;
        private System.Windows.Forms.ComboBox HammerBox;
    }
}

