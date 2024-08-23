using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace exam_system
{
    public partial class Exam_0 : Form
    {
        public Exam_0()
        {
            InitializeComponent();
            FetchQustions();
            multirandom();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-098USF1\MSSQLSERVER1;database=quiz;Integrated Security=True");
        String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
         //   TimeLP1_Click.Start();
        }
        private void Exams_Load(object sender, EventArgs e)
        {
           // Timer.Start();
        }
        string[] Ua = new string[10];
        private void Q101_CheckedChanged(object sender, EventArgs e)
        {
            Ua[0] = Q101.Text;
        }
        private void Q102_CheckedChanged(object sender, EventArgs e)
        {
            Ua[0] = Q102.Text;
        }
        private void Q103_CheckedChanged(object sender, EventArgs e)
        {
            Ua[0] = Q103.Text;
        }
        private void Q104_CheckedChanged(object sender, EventArgs e)
        {
            Ua[0] = Q104.Text;
        }
        private int GenerateRand()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            MessageBox.Show("" + x + "and" + y + "and" + z);

            return x;

        }
        int[] Keys = new int[10];

        private void multirandom()
        {

            Random rnd = new Random();
            HashSet<int> numbers = new HashSet<int>();

            while (numbers.Count < 10) // Generate 10 unique random numbers
            {
                numbers.Add(rnd.Next(1, 11)); // Ensure the range covers 1 to 10, inclusive
            }

            Keys = numbers.ToArray();


        }

        private void FetchQustions()
        {
            try
            {
                int Qnum = GenerateRand();
                conn.Open();
                string Query = "select * from QuestionTb1 where QId=" + Keys[0] + "";
                SqlCommand cmd = new SqlCommand(Query, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q1.Text = dr["QDesc"].ToString();
                        Q101.Text = dr["Q01"].ToString();
                        Q102.Text = dr["Q02"].ToString();
                        Q103.Text = dr["Q03"].ToString();
                        Q104.Text = dr["Q04"].ToString();
                        a1 = dr["QA"].ToString();


                    }
                }
                string Query1 = "select * from QuestionTb1 where QId=" + Keys[1] + "";
                cmd = new SqlCommand(Query1, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q1.Text = dr["QDesc"].ToString();
                        Q101.Text = dr["Q01"].ToString();
                        Q102.Text = dr["Q02"].ToString();
                        Q103.Text = dr["Q03"].ToString();
                        Q104.Text = dr["Q04"].ToString();
                        a1 = dr["QA"].ToString();


                    }
                }
                string Query2 = "select * from QuestionTb1 where QId=" + Keys[2] + "";
                cmd = new SqlCommand(Query2, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q2.Text = dr["QDesc"].ToString();
                        Q201.Text = dr["Q01"].ToString();
                        Q202.Text = dr["Q02"].ToString();
                        Q203.Text = dr["Q03"].ToString();
                        Q204.Text = dr["Q04"].ToString();
                        a2 = dr["QA"].ToString();


                    }
                }
                string Query3 = "select * from QuestionTb1 where QId=" + Keys[3] + "";
                cmd = new SqlCommand(Query3, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q3.Text = dr["QDesc"].ToString();
                        Q301.Text = dr["Q01"].ToString();
                        Q302.Text = dr["Q02"].ToString();
                        Q303.Text = dr["Q03"].ToString();
                        Q304.Text = dr["Q04"].ToString();
                        a3 = dr["QA"].ToString();


                    }
                }
                string Query4 = "select * from QuestionTb1 where QId=" + Keys[4] + "";
                cmd = new SqlCommand(Query1, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q4.Text = dr["QDesc"].ToString();
                        Q401.Text = dr["Q01"].ToString();
                        Q402.Text = dr["Q02"].ToString();
                        Q403.Text = dr["Q03"].ToString();
                        Q404.Text = dr["Q04"].ToString();
                        a4 = dr["QA"].ToString();


                    }
                }
                string Query5 = "select * from QuestionTb1 where QId=" + Keys[5] + "";
                cmd = new SqlCommand(Query5, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q5.Text = dr["QDesc"].ToString();
                        Q501.Text = dr["Q01"].ToString();
                        Q502.Text = dr["Q02"].ToString();
                        Q503.Text = dr["Q03"].ToString();
                        Q504.Text = dr["Q04"].ToString();
                        a5 = dr["QA"].ToString();


                    }
                }
                string Query6 = "select * from QuestionTb1 where QId=" + Keys[6] + "";
                cmd = new SqlCommand(Query6, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q6.Text = dr["QDesc"].ToString();
                        Q601.Text = dr["Q01"].ToString();
                        Q602.Text = dr["Q02"].ToString();
                        Q603.Text = dr["Q03"].ToString();
                        Q604.Text = dr["Q04"].ToString();
                        a6 = dr["QA"].ToString();


                    }
                }
                string Query7 = "select * from QuestionTb1 where QId=" + Keys[7] + "";
                cmd = new SqlCommand(Query1, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q7.Text = dr["QDesc"].ToString();
                        Q701.Text = dr["Q01"].ToString();
                        Q702.Text = dr["Q02"].ToString();
                        Q703.Text = dr["Q03"].ToString();
                        Q704.Text = dr["Q04"].ToString();
                        a7 = dr["QA"].ToString();


                    }
                }
                string Query8 = "select * from QuestionTb1 where QId=" + Keys[8] + "";
                cmd = new SqlCommand(Query8, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q8.Text = dr["QDesc"].ToString();
                        Q801.Text = dr["Q01"].ToString();
                        Q802.Text = dr["Q02"].ToString();
                        Q803.Text = dr["Q03"].ToString();
                        Q804.Text = dr["Q04"].ToString();
                        a8 = dr["QA"].ToString();


                    }
                }
                string Query9 = "select * from QuestionTb1 where QId=" + Keys[9] + "";
                cmd = new SqlCommand(Query9, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q9.Text = dr["QDesc"].ToString();
                        Q901.Text = dr["Q01"].ToString();
                        Q902.Text = dr["Q02"].ToString();
                        Q903.Text = dr["Q03"].ToString();
                        Q904.Text = dr["Q04"].ToString();
                        a9 = dr["QA"].ToString();


                    }
                }
                string Query10 = "select * from QuestionTb1 where QId=" + Keys[10] + "";
                cmd = new SqlCommand(Query10, conn);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 1; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q10.Text = dr["QDesc"].ToString();
                        Q1001.Text = dr["Q01"].ToString();
                        Q1002.Text = dr["Q02"].ToString();
                        Q1003.Text = dr["Q03"].ToString();
                        Q1004.Text = dr["Q04"].ToString();
                        a10 = dr["QA"].ToString();


                    }
                }
                conn.Close();
            }
            catch (Exception EX)
            {

            }
        }
        int Score = 0;
        private void CheckQ1()
        {

            if (Q101.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q101.Text;
            }
            else if (Q102.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q102.Text;
            }
            else if (Q103.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q103.Text;
            }
            else if (Q104.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q104.Text;
            }
            if (Ua[0] == a1)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ2()
        {
            if (Q201.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q201.Text;
            }
            else if (Q202.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q202.Text;
            }
            else if (Q203.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q203.Text;
            }
            else if (Q204.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q104.Text;
            }
            if (Ua[1] == a2)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Q1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click_1(object sender, EventArgs e)
        {

            int Score = 0;
            CheckQ1();
            CheckQ2();
            CheckQ3();
            CheckQ4();
            CheckQ5();
            CheckQ6();
            CheckQ7();
            CheckQ8();
            CheckQ9();
            CheckQ10();
            MessageBox.Show("" + Score);

        }

        private void TimeLP1_Click(object sender, EventArgs e)
        {

        }

        private void CheckQ3()
        {
            if (Q301.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q301.Text;
            }
            else if (Q302.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q102.Text;
            }
            else if (Q303.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q303.Text;
            }
            else if (Q304.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q304.Text;
            }
            if (Ua[2] == a3)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ4()
        {
            if (Q401.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q401.Text;
            }
            else if (Q302.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q402.Text;
            }
            else if (Q403.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q403.Text;
            }
            else if (Q404.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q404.Text;
            }
            if (Ua[3] == a4)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ5()
        {
            if (Q501.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q501.Text;
            }
            else if (Q502.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q502.Text;
            }
            else if (Q503.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q503.Text;
            }
            else if (Q504.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q504.Text;
            }
            if (Ua[4] == a5)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ6()
        {
            if (Q601.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q601.Text;
            }
            else if (Q602.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q602.Text;
            }
            else if (Q603.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q603.Text;
            }
            else if (Q604.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q604.Text;
            }
            if (Ua[5] == a6)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ7()
        {
            if (Q701.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q701.Text;
            }
            else if (Q702.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q702.Text;
            }
            else if (Q703.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q703.Text;
            }
            else if (Q704.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q704.Text;
            }
            if (Ua[6] == a7)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ8()
        {
            if (Q801.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q801.Text;
            }
            else if (Q802.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q802.Text;
            }
            else if (Q803.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q803.Text;
            }
            else if (Q804.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q804.Text;
            }
            if (Ua[7] == a8)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }
        private void CheckQ9()
        {
            if (Q701.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q901.Text;
            }
            else if (Q902.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q902.Text;
            }
            else if (Q903.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q903.Text;
            }
            else if (Q904.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q904.Text;
            }
            if (Ua[8] == a9)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }

        private void CheckQ10()
        {
            if (Q1001.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1001.Text;
            }
            else if (Q1002.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1002.Text;
            }
            else if (Q1003.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1003.Text;
            }
            else if (Q1004.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1004.Text;
            }
            if (Ua[9] == a10)
            {
                Score = Score + 1;
            }

            else
            {
                Score = Score;
            }

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int Score = 0;
            CheckQ1();
            CheckQ2();
            CheckQ3();
            CheckQ4();
            CheckQ5();
            CheckQ6();
            CheckQ7();
            CheckQ8();
            CheckQ9();
            CheckQ10();
            MessageBox.Show("" + Score);





        }
    }
}
