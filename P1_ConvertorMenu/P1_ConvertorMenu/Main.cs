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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_length_Click(object sender, EventArgs e)
        {
            Length lencalc = new Length();
            lencalc.Show();
        }

        private void btn_temperature_Click(object sender, EventArgs e)
        {
            Temperature temptool = new Temperature();
            temptool.Show();
        }

        private void btn_currency_Click(object sender, EventArgs e)
        {
            
            Currency lengthtool = new Currency();
            lengthtool.Show();
        }
    }
}
