using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMRCalculatorBaryshev
{
    public partial class Form1 : Form
    {
        float bmr;
        float r;
        float v;
        float let;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rasschet_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            let = float.Parse(vozrast.Text);
            bmr = (float)(66 + (13.7 * v) + (5 * r) - (6.8 * let));
            rezult.Text = bmr.ToString();
            label11.Text = (bmr * 1.2).ToString("#.##");
            label12.Text = (bmr * 1.375).ToString("#.##");
            label13.Text = (bmr * 1.55).ToString("#.##");
            label14.Text = (bmr * 1.725).ToString("#.##");
            label15.Text = (bmr * 1.9).ToString("#.##");
        }
    }
}
