using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_ConvertorMenu
{
    public partial class Length : Form
    {
        public Length()
        {
            InitializeComponent();
        }

        private void Currency_Load(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(feetin.Text) == false)
            {
                inchout.Text = decimal.Multiply(decimal.Parse(feetin.Text), 12M).ToString();
            }
            if (string.IsNullOrEmpty(inchin.Text) == false)
            {
                feetout.Text = decimal.Multiply(decimal.Parse(inchin.Text), 0.083M).ToString();
            }
        }
    }
}
