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
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(celin.Text) == false)
            {
                fahrout.Text = (decimal.Multiply(decimal.Parse(celin.Text), 1.8M) + 32M).ToString();
            }
            if (string.IsNullOrEmpty(fahrin.Text) == false)
            {
                celout.Text = (decimal.Divide(decimal.Parse(fahrin.Text) - 32 , 1.8M)).ToString();
            }
        }

        internal class Form1
        {
        }
    }
}
