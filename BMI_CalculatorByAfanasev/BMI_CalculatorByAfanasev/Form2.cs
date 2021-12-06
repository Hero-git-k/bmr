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
    public partial class bmi : Form
    {
        float index;
        float r;
        float v;
        public bmi()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            r = r / 100;
            index = v / (r * r);
            x.Text = index.ToString("N");
            progressBar1.Value = (int)index;
            if (index<18.5)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI_CalculatorByAfanasev\BMI_CalculatorByAfanasev\Resources\bmi-underweight-icon.png");
            }
            else if (index <25)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI_CalculatorByAfanasev\BMI_CalculatorByAfanasev\Resources\bmi-underweight-icon.png");
            }
            else if (index <30)
            { pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI_CalculatorByAfanasev\BMI_CalculatorByAfanasev\Resources\bmi-overweight-icon.png"); }    
            else { pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI_CalculatorByAfanasev\BMI_CalculatorByAfanasev\Resources\bmi-obese-icon.png"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rost.Clear();
            ves.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
        }
    }
}
