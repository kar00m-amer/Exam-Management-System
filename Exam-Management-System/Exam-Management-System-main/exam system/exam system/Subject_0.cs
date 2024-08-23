using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace exam_system
{
    public partial class Subject_0 : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-098USF1\MSSQLSERVER1;database=quiz;Integrated Security=True");
        private int key = 0;

        public Subject_0()
        {
            InitializeComponent();
            DisplaySubjects();
        }

        private void DisplaySubjects()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM SubjectTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SubjectsDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO SubjectTbl (SNmae) VALUES (@Sn)", conn);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject saved");
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close(); // إغلاق الاتصال هنا بعد الانتهاء من العملية
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE SubjectTbl SET SNmae=@Sn WHERE SId=@SKey", conn);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated");
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close(); // إغلاق الاتصال هنا بعد الانتهاء من العملية
                }
            }
        }


        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SubjectsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = SubjectsDGV.SelectedRows[0].Cells[1].Value.ToString();
            key = Convert.ToInt32(SubjectsDGV.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void Reset()
        {
            SNameTb.Text = "";
            key = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenCandidateForm();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenCandidateForm();
        }

        private void OpenCandidateForm()
        {
            Candidate_0 Obj = new Candidate_0();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenQuestionForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenQuestionForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenQuestionForm();
        }

        private void OpenQuestionForm()
        {
            Question_0cs Obj = new Question_0cs();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Candidate_0 can = new Candidate_0();
            can.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Question_0cs que = new Question_0cs();
            que.Show();
            this.Hide();
        }
    }
}
