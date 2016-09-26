using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_MultiConvertor
{
    public partial class MultiConv : Form
    {
        //field names
        // f2ibox_1
        // f2ibox_2
        // i2fbox_1
        // i2fbox_2
        // g2ebox_1
        // g2ebox_2
        // e2gbox_1
        // e2gbox_2
        // c2f_box1
        // c2fbox_2
        // f2cbox_1
        // f2cbox_2

        // conversion rates
        decimal f2irate = 12M;
        decimal i2frate = 0.0833333M;
        decimal p2erate = 1.17M;
        decimal e2prate = 0.86M;
        decimal c2frate = 0.5556M;
        decimal f2crate = 1.8M;




        public MultiConv()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_f2i_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(f2ibox_1.Text) == false)
            {
                f2ibox_2.Text = "";
                f2ibox_2.Text += decimal.Multiply(decimal.Parse(f2ibox_1.Text), f2irate);
            }
        }

        private void btn_p2e_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(p2ebox_1.Text) == false)
            {
                p2ebox_2.Text = "";
                p2ebox_2.Text += decimal.Multiply(decimal.Parse(p2ebox_1.Text), p2erate);
            }
        }

        private void btn_c2f_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(c2fbox_1.Text) == false)
            {
                c2fbox_2.Text = "";
                c2fbox_2.Text += decimal.Multiply((decimal.Parse(c2fbox_1.Text) - 32), c2frate );
            }
        }

        private void btn_i2f_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(i2fbox_1.Text) == false)
            {
                i2fbox_2.Text = "";
                i2fbox_2.Text += decimal.Multiply(decimal.Parse(i2fbox_1.Text), i2frate);
            }
        }

        private void btn_e2p_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(e2pbox_1.Text) == false)
            {
                e2pbox_2.Text = "";
                e2pbox_2.Text += decimal.Multiply(decimal.Parse(e2pbox_1.Text), e2prate);
            }
        }

        private void btn_f2c_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(f2cbox_1.Text) == false)
            {
                f2cbox_2.Text = "";
                f2cbox_2.Text += decimal.Multiply(decimal.Parse(f2ibox_1.Text), f2crate) + 32;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2cbox_2.Text = "";
            e2pbox_2.Text = "";
            i2fbox_2.Text = "";
            c2fbox_2.Text = "";
            p2ebox_2.Text = "";
            f2ibox_2.Text = "";
        }
    }
}
