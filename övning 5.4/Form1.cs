using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(tbxA.Text); 
            double tal2 = double.Parse(tbxB.Text);
            double tal3 = double.Parse(tbxC.Text);
            bool ordningsföljd = tal1 < tal2 && tal2 < tal3; // kollar om tal1 är minder än tal2
            string info = " Talen är i ordningsföljd: " + ordningsföljd.ToString();
            lblSvar.Text = info;   

        }
    }
}
