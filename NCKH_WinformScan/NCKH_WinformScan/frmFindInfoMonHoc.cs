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
    public partial class frmTransformPoin : Form
    {
        //private dtoMonHoc[] dtoMH;
        private frmtcMH frmMH;
        dbConnection db = new dbConnection();

        public frmTransformPoin()
        {
            InitializeComponent();
            PopulateChecklistBox();
        }

        private void frmTransformPoin_Load(object sender, EventArgs e)
        {
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtGridChuyenDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chLMonHoc.DataSource = db.getBang("HocPhan");
            chLMonHoc.DisplayMember = "TenHP";
            chLMonHoc.ValueMember = "MaHP";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PopulateChecklistBox()
        {
            DataTable dataTable = db.getBang("HocPhan");

            chLMonHoc.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                string tenMH = row["TenHP"].ToString(); // Lấy tên môn học từ cột "TenHP"
                chLMonHoc.Items.Add(tenMH);
            }

            chLMonHoc.CheckOnClick = true;
        }
        

        private void chLMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (chLMonHoc.SelectedItem != null)
            //{
            //    int selectedIndex = chLMonHoc.SelectedIndex;
            //    DataRowView dtrView = (DataRowView)chLMonHoc.SelectedItem;
            //    string maHP = dtrView["MaHP"].ToString();

            //    if (chLMonHoc.GetItemChecked(chLMonHoc.SelectedIndex) && chLMonHoc.CheckOnClick)
            //    {
            //        if (frmMH == null || frmMH.IsDisposed)
            //        {
            //            frmMH = new frmtcMH(maHP);
            //            frmMH.Show();
            //        }
            //        else
            //        {
            //            frmMH.Focus();
            //        }
            //    }
            //}
            //else
            //{
            //    if (frmMH != null && frmMH.Visible)
            //    {
            //        frmMH.Close();
            //    }
            //}
            if (chLMonHoc.SelectedItem != null)
            {
                int selectedIndex = chLMonHoc.SelectedIndex;
                string tenHP = chLMonHoc.SelectedItem.ToString(); // Lấy tên môn học được chọn
                string maHP = ((DataRowView)chLMonHoc.SelectedItem)["MaHP"].ToString(); // Lấy mã môn học từ dòng được chọn

                if (chLMonHoc.GetItemChecked(selectedIndex) && chLMonHoc.CheckOnClick)
                {
                    if (frmMH == null || frmMH.IsDisposed)
                    {
                        frmMH = new frmtcMH(maHP);
                        frmMH.Show();
                    }
                    else
                    {
                        frmMH.Focus();
                    }
                }
            }
            else
            {
                if (frmMH != null && frmMH.Visible)
                {
                    frmMH.Close();
                }
            }
        }
    }
}
