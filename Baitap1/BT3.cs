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
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();

            listA.Items.Add("Huỳnh Phương Anh");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listA.Items.Add("Lưu Tân Đức");
            listB.Items.Add("Hoàng Hồ Nam");
            listB.Items.Add("Lê Anh Trung");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            listA.Items.Add(hoten);
            txtHoTen.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection dsChonLopA = listA.SelectedItems;
            ListView.SelectedListViewItemCollection dsChonLopb = listB.SelectedItems;

            if (dsChonLopA.Count > 0) {
                while (dsChonLopA.Count != 0)
                {
                    listA.Items[dsChonLopA[0].Index].Remove();
                }
            }

            if (dsChonLopb.Count > 0)
            {
                while (dsChonLopb.Count != 0)
                {
                    listB.Items[dsChonLopb[0].Index].Remove();
                }
                
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection dsChonLopA = listA.SelectedItems;

            if (dsChonLopA.Count > 0)
            {
                while(dsChonLopA.Count != 0) {
                    listB.Items.Add(dsChonLopA[0].Text);
                    listA.Items[dsChonLopA[0].Index].Remove();
                }
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection dsChonLopB = listB.SelectedItems;

            if (dsChonLopB.Count > 0)
            {
                while (dsChonLopB.Count != 0)
                {
                    listA.Items.Add(dsChonLopB[0].Text);
                    listB.Items[dsChonLopB[0].Index].Remove();
                }
                
            }
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            while (listA.Items.Count != 0)
            {
                listB.Items.Add(listA.Items[0].Text);
                listA.Items[0].Remove();
            }
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            while (listB.Items.Count != 0)
            {
                listA.Items.Add(listB.Items[0].Text);
                listB.Items[0].Remove();
            }
        }
    }
}
