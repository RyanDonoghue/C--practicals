using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Menu
{
    public partial class Form1 : Form
    {
        public bool active;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_tocalc_Click(object sender, EventArgs e)
        {
            P1_Calculator.Form1 calculator = new P1_Calculator.Form1();
            calculator.Show();
        }
        private void btn_tocurr_Click(object sender, EventArgs e)
        {
            P1_CurrencyConvertor.Form1 currency = new P1_CurrencyConvertor.Form1();
            currency.Show();
        }
        private void btn_multi_Click(object sender, EventArgs e)
        {
            P1_MultiConvertor.MultiConv multiconvertor = new P1_MultiConvertor.MultiConv();
            multiconvertor.Show();
        }
    }
}
