using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_system
{

    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private object timer1;

        public object MyProgress { get; private set; }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        int Count = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Chrono -= 1;

            Count += 1;

            loading.Value = Count;
            label4.Text = Count + " % ";
            if (loading.Value == 100)
            {

                loading.Value = 0;

                timer2.Stop();

                // MessageBox.Show("Time Over");

                log_in_0 log1 = new log_in_0();
                log1.Show();
                this.Hide();
            }
        }


    }
}
