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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtNhapso.Text != "")

                try
                {
                    lst1.Items.Add(txtNhapso.Text);
                    txtNhapso.Clear();
                    txtNhapso.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi" + ex);
                }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                int so = int.Parse(lst1.Items[i].ToString());
                so += 2;
                lst1.Items[i] = so;
            }

        }

        private void btnChandau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                if(int.Parse(lst1.Items[i].ToString())%2==0)
                {
                    lst1.SelectedIndex= i;
                    break;
                }
            }
        }

        private void btnLecuoi_Click(object sender, EventArgs e)
        {
            for (int i = lst1.Items.Count -1; i>0 ; i--)
                if (int.Parse(lst1.Items[i].ToString()) % 2 != 0)
                {
                    lst1.SelectedIndex = i;
                    break;
                }
        }

        private void btnXoachon_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndices.Count > 0)
                lst1.Items.RemoveAt(lst1.SelectedIndex);
        }

        private void btnXoadau_Click(object sender, EventArgs e)
        {
            lst1.Items.Remove(lst1.Items[0]);

        }

    }
}

