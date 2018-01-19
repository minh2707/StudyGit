using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baitap1
{
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();

            btnInHoa.Enabled = false;
            btnInThuong.Enabled = false;
            btnReplace.Enabled = false;
            btnSearch.Enabled = false;
            btnThoat.Enabled = true;
            txtReplace.ReadOnly = true;
            txtSearch.ReadOnly = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int vitri = txtInput.Text.IndexOf(txtSearch.Text);
            string vitriTimThay = Convert.ToString(vitri) + ", ";
            while (vitri != -1)
            {
                vitri = txtInput.Text.IndexOf(txtSearch.Text, vitri + txtSearch.Text.Length);
                vitriTimThay += Convert.ToString(vitri) + ", ";
            }
            txtKQ.Text = "Vị trí tìm thấy: " + vitriTimThay;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtKQ.Text = txtInput.Text.Replace(txtSearch.Text, txtReplace.Text);
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {

        }

        private void onChange(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0)
            {
                btnInHoa.Enabled = false;
                btnInThuong.Enabled = false;
                btnReplace.Enabled = false;
                btnSearch.Enabled = false;
                txtReplace.ReadOnly = true;
                txtSearch.ReadOnly = true;

            }
            else
            {
                btnInHoa.Enabled = true;
                btnInThuong.Enabled = true;
                btnReplace.Enabled = true;
                btnSearch.Enabled = true;
                txtReplace.ReadOnly = false;
                txtSearch.ReadOnly = false;
            }
        }
    }
}
