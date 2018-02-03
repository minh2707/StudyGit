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
    public partial class BT4 : Form
    {
        List<int> arrPT = new List<int>();

        public BT4()
        {
            InitializeComponent();
			//abcasdsadsa
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            arrPT.Add(Int16.Parse(txtInput.Text));
            txtOutput.Text = txtOutput.Text + " " + txtInput.Text;
            txtInput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDemPhanTuLe_Click(object sender, EventArgs e)
        {
            int ptLe = 0;
            for (int i = 0; i < arrPT.Count; i++)
            {
                if (arrPT[i] % 2 != 0)
                {
                    ptLe++;
                }
            }

            txtKQ.Text = ptLe.ToString();
        }

        private void btnDemPhanTuChan_Click(object sender, EventArgs e)
        {
            int ptChan = 0;
            for (int i = 0; i < arrPT.Count; i++)
            {
                if (arrPT[i] % 2 == 0)
                {
                    ptChan++;
                }
            }

            txtKQ.Text = ptChan.ToString();
        }

        private void btnTinhTongMang_Click(object sender, EventArgs e)
        {
            int tong = 0;

            for (int i = 0; i < arrPT.Count; i++)
            {
                tong = tong + arrPT[i];
            }
            txtKQ.Text = tong.ToString();
        }

        private void btnXuatPhanTuLe_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "";
            List<int> arrTmp = new List<int>();
            for (int i = 0; i < arrPT.Count; i++)
            {
                if (arrPT[i] % 2 != 0)
                {
                    arrTmp.Add(arrPT[i]);
                }
            }

            for (int i = 0; i < arrTmp.Count; i++)
            {
                txtKQ.Text = txtKQ.Text + " " + arrTmp[i].ToString();
            }
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (arrPT.Count > 0) {
                int min = 0;
                int max = arrPT.Last<int>();

                for (int i = 0; i < arrPT.Count; i++)
                {
                    if (arrPT[i] < min)
                    {
                        min = arrPT[i];
                    }
                    else if (arrPT[i] > max)
                    {
                        max = arrPT[i];
                    }
                    else if (min > max)
                    {
                        min = max;
                        max = min;
                    }
                }

                txtKQ.Text = "Min: " + min.ToString() + ", Max: " + max.ToString();
            }
            
        }

        private void btnXuatCacSoNguyenTo_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "";
            for (int i = 0; i < arrPT.Count; i++)
            {
                if (kt_SoNguyenTo(arrPT[i]) == true)
                {
                    txtKQ.Text = txtKQ.Text + " " + arrPT[i].ToString();
                }
                else
                {

                }
            }
        }

        private bool kt_SoNguyenTo(int input)
        {
            if (input < 2) // Nếu số A nhỏ hơn 2
            {
                return false;// trả về false
            }
            else if (input > 2)// Nếu số A lớn hơn 2
            {
                if (input % 2 == 0)  // Xét xem A có chia hết cho 2 không?
                {
                    return false;// Nếu chia hết, return false.
                }
                for (int i = 3; i < Math.Sqrt((float)input); i += 2)  // xét từ 3 đến căn bậc 2 của số A
                {
                    if (input % i == 0)  // nếu A chia hết cho một số nào đó trong đoạn này
                    {
                        return false;// trả về kết quả sai
                    }
                }
            }
            return true;// sau tất cả các chỗ trên, nó mà không sai thì cuối cùng nó đúng :3
        }
    }
}
