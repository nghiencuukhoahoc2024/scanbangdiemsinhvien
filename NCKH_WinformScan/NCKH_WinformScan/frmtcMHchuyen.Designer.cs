namespace NCKH_WinformScan
{
    partial class frmtcMHchuyen
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
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.numSTC = new System.Windows.Forms.NumericUpDown();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblTenMHChuyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC)).BeginInit();
            this.SuspendLayout();
            // 
            // numDiem
            // 
            this.numDiem.Location = new System.Drawing.Point(150, 110);
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(58, 22);
            this.numDiem.TabIndex = 7;
            // 
            // numSTC
            // 
            this.numSTC.Location = new System.Drawing.Point(150, 64);
            this.numSTC.Name = "numSTC";
            this.numSTC.Size = new System.Drawing.Size(58, 22);
            this.numSTC.TabIndex = 8;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiem.Location = new System.Drawing.Point(14, 116);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(65, 16);
            this.lblDiem.TabIndex = 5;
            this.lblDiem.Text = "Điểm HP:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltc.Location = new System.Drawing.Point(14, 64);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(113, 16);
            this.lbltc.TabIndex = 6;
            this.lbltc.Text = "Số tín chỉ/ đvht:";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(13, 33);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(0, 16);
            this.lblMaMH.TabIndex = 3;
            // 
            // lblTenMHChuyen
            // 
            this.lblTenMHChuyen.AutoSize = true;
            this.lblTenMHChuyen.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMHChuyen.Location = new System.Drawing.Point(12, 9);
            this.lblTenMHChuyen.Name = "lblTenMHChuyen";
            this.lblTenMHChuyen.Size = new System.Drawing.Size(133, 16);
            this.lblTenMHChuyen.TabIndex = 4;
            this.lblTenMHChuyen.Text = "Kỹ thuật lập trình 1";
            // 
            // frmtcMHchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 158);
            this.Controls.Add(this.numDiem);
            this.Controls.Add(this.numSTC);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblTenMHChuyen);
            this.MaximumSize = new System.Drawing.Size(350, 205);
            this.MinimumSize = new System.Drawing.Size(350, 205);
            this.Name = "frmtcMHchuyen";
            this.Text = "frmtcMHchuyen";
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDiem;
        private System.Windows.Forms.NumericUpDown numSTC;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblTenMHChuyen;
    }
}