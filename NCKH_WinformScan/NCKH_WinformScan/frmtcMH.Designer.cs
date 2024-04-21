namespace NCKH_WinformScan
{
    partial class frmtcMH
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
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.numSTC = new System.Windows.Forms.NumericUpDown();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMH.Location = new System.Drawing.Point(11, 9);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(133, 16);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Kỹ thuật lập trình 1";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(12, 33);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(0, 16);
            this.lblMaMH.TabIndex = 0;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltc.Location = new System.Drawing.Point(13, 64);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(113, 16);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "Số tín chỉ/ đvht:";
            this.lbltc.Click += new System.EventHandler(this.lbltc_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiem.Location = new System.Drawing.Point(13, 116);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(65, 16);
            this.lblDiem.TabIndex = 1;
            this.lblDiem.Text = "Điểm HP:";
            this.lblDiem.Click += new System.EventHandler(this.lbltc_Click);
            // 
            // numSTC
            // 
            this.numSTC.Location = new System.Drawing.Point(149, 64);
            this.numSTC.Name = "numSTC";
            this.numSTC.Size = new System.Drawing.Size(58, 22);
            this.numSTC.TabIndex = 2;
            // 
            // numDiem
            // 
            this.numDiem.Location = new System.Drawing.Point(149, 110);
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(58, 22);
            this.numDiem.TabIndex = 2;
            // 
            // frmtcMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 158);
            this.Controls.Add(this.numDiem);
            this.Controls.Add(this.numSTC);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblTenMH);
            this.MaximumSize = new System.Drawing.Size(350, 205);
            this.MinimumSize = new System.Drawing.Size(350, 205);
            this.Name = "frmtcMH";
            this.Text = "\"";
            this.Load += new System.EventHandler(this.frmtc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.NumericUpDown numSTC;
        private System.Windows.Forms.NumericUpDown numDiem;
    }
}