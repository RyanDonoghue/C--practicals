using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_CurrencyConvertor
{
    public partial class Form1 : Form
    {
        char option;
        bool optionselected = false;
        string current = "";
        decimal currentconverted;
        string previous = "";
        bool hasprevious = false;
        decimal calculation;
        //conversion rates
        decimal eurusd = 1.12M;
        decimal eurgbp = 0.86M;
        decimal usdeur = 0.90M;
        decimal usdgbp = 0.77M;
        decimal gbpeur = 1.17M;
        decimal gbpusd = 1.30M;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_todollar_Click(object sender, EventArgs e)
        {
            currentCurr.Text = "";
            currentCurr.Text += "USD";
            if ( hasprevious == true)
            {
                current = previous;
            }

            else
            {
                if (string.IsNullOrEmpty(numberbox.Text) == false)
                {
                    current = numberbox.Text;
                    currentconverted = decimal.Parse(current);
                }
            }

            if (optionselected == true)
            {
                switch (option)
                {
                    case 'E':
                        numberbox.Text = "";
                        calculation = decimal.Multiply(currentconverted, eurusd);
                        numberbox.Text += calculation;
                        break;
                    case 'D':
                        // do nothing, currency is already in dollars
                        break;
                        case 'P':
                        numberbox.Text = "";
                        numberbox.Text += decimal.Multiply(decimal.Parse(current), gbpusd);
                        break;
                }
            }

            optionselected = true;
            option = 'D';
            
        }

        private void btn_toeuro_Click(object sender, EventArgs e)
        {
            currentCurr.Text = "";
            currentCurr.Text += "EUR";
            if (hasprevious == true)
            {
                current = previous;
            }
            else
            {
                if (string.IsNullOrEmpty(numberbox.Text) == false)
                {
                    current = numberbox.Text;
                }
            }
            if (optionselected == true)
            {
                switch (option)
                {
                    case 'E':
                        // do nothing, currency is already in euro
                        break;
                    case 'D':
                        numberbox.Text = "";
                        numberbox.Text += decimal.Multiply(decimal.Parse(current), usdeur);
                        break;
                    case 'P':
                        numberbox.Text = "";
                        numberbox.Text += decimal.Multiply(decimal.Parse(current), gbpeur);
                        break;
                }
            }
            optionselected = true;
            option = 'E';
        }

        private void btn_topound_Click(object sender, EventArgs e)
        {
            currentCurr.Text = "";
            currentCurr.Text += "GBP";
            if (hasprevious == true)
            {
                current = previous;
            }
            else
            {
                if (string.IsNullOrEmpty(numberbox.Text) == false)
                {
                    current = numberbox.Text;
                }
            }
            if (optionselected == true)
            {
                switch (option)
                {
                    case 'E':
                        numberbox.Text = "";
                        numberbox.Text += decimal.Multiply(decimal.Parse(current), eurgbp);
                        break;
                    case 'D':
                        numberbox.Text = "";
                        numberbox.Text += decimal.Multiply(decimal.Parse(current), usdgbp);
                        break;
                    case 'P':
                        // do nothing, currency is already in pounds
                        break;
                }
            }
            optionselected = true;
            option = 'P';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            optionselected = false;
            hasprevious = false;
            currentCurr.Text = "";
            numberbox.Text = "";
        }
    }
}
