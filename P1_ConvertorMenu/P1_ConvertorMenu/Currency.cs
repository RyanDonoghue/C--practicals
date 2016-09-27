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
    public partial class Currency : Form
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gbpin.Text) == false)
            {
                gbpout.Text = decimal.Multiply(decimal.Parse(eurin.Text), 0.87M).ToString();
            }
            if (string.IsNullOrEmpty(gbpin.Text) == false)
            {
                eurout.Text = decimal.Multiply(decimal.Parse(gbpin.Text), 1.153M).ToString();
            }
        }
    }
}
