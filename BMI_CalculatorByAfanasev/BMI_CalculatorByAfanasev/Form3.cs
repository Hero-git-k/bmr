using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CalculatorByAfanasev
{
    public partial class bmr : Form
    {
        float bm;
        float r;
        float v;
        float l;
        public bmr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bmr_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            l = float.Parse(let.Text);
            bm = (float)(66 + (13.7 * l) + (5 * r) - (6.8 * v));
            label7.Text = bm.ToString();
            label13.Text = (bm * 1.2).ToString("##.##");
            label14.Text = (bm * 1.375).ToString("##.##");
            label15.Text = (bm * 1.55).ToString("##.##");
            label16.Text = (bm * 1.725).ToString("##.##");
            label17.Text =(bm * 1.9).ToString("##.##"); ;
            
        }
    }
}
