using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_system
{
    public partial class Admin_log_in : Form
    {
        public Admin_log_in()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubjectCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


            {

                if (PasswordTb.Text == "")

                {

                    MessageBox.Show("Enter the Password");

                }
                else if (PasswordTb.Text == "admin")

                {

                    Question_0cs Obj = new Question_0cs();

                    Obj.Show();

                    Obj.Show();

                }

                else

                {
                    MessageBox.Show("Wrong Admin Password");
                    PasswordTb.Text = "";


                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            log_in_0 Obj = new log_in_0();

            Obj.Show();

            this.Hide();

        }
    }

}
