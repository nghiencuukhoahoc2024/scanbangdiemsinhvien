using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_WinformScan
{

    public partial class frmtcMH : Form
    {
        private string maHP;
        dbConnection db = new dbConnection();
        public frmtcMH( string maHP)
        {
            InitializeComponent();
            this.maHP = maHP;
        }

        private void frmtc_Load(object sender, EventArgs e)
        {
            string tenHP = db.getTenHP(maHP);
            lblTenMH.Text = tenHP;
        }

        private void lbltc_Click(object sender, EventArgs e)
        {

        }
    }
}
