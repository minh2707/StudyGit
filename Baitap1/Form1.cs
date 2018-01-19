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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtX1.Clear();
            txtX2.Clear();
            txtA.Focus();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c, x1 = 0, x2 = 0;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text); 
            c = double.Parse(txtC.Text);
            if (a == 0)
            {
                if (b == 0)
                    MessageBox.Show("Phuong trinh vo nghiem");
                else
                    x1 = -b / a;
            }
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
            
                MessageBox.Show("pt vo nghiem");
            else if (delta == 0)
                x1 = x2 = -b / (2 * a);
            else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            }
            txtX1.Text = x1.ToString();
            txtX2.Text = x2.ToString();
                
          }
                
    }
}
