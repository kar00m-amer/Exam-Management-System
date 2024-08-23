using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_system
{
    public partial class Question_0cs : Form
    {
        public Question_0cs()
        {
            InitializeComponent();
           GetSubjects();
            //DescriptionAttribute();
            DisplayQuestions();
        }

       /* private void DescriptionAttribute()
        {
            throw new NotImplementedException();
        }*/

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-098USF1\MSSQLSERVER1;database=quiz;Integrated Security=True");

       private void GetSubjects()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select SNmae from subjectTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SNmae", typeof(string));
            dt.Load(rdr);
            SubjectCB.ValueMember = "SNmae";
            SubjectCB.DataSource = dt;
            conn.Close();
        }

        private void Reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCB.SelectedIndex = 0;
        }


        private void DisplayQuestions()
        {

            conn.Open();
            string Query = "select * from QuestionTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionsDGV.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO QuestionTb1 (QDesc, QO1 , QO2 , QO3, QO4, QA, QS) VALUES (@Qd, @O1, @O2, @O3, @O4, @Qan, @Qsu)", conn);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCB.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    conn.Close(); // Ensure the connection is closed even if an exception occurs
                }
            }

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update QuestionTb1 set QDesc=@Qd,QO1=@O1,QO2=@O2,QO3=@O3,QO4=@O4, QA=@Qan ,QS=@Qsu where QId=@QKey ", conn);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@QKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Update");
                    Reset();
                    DisplayQuestions();

                    conn.Close();
                }

                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }

            }
        }


        int Key = 0;

        private void QuestionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            QuestTb.Text = QuestionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Op1Tb.Text = QuestionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Op2Tb.Text = QuestionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Op3Tb.Text = QuestionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            Op4Tb.Text = QuestionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AnswerTb.Text = QuestionsDGV.SelectedRows[0].Cells[6].Value.ToString();
            SubjectCB.SelectedValue = QuestionsDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (QuestTb.Text == "")

            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(QuestionsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidate_0 can = new Candidate_0();
            can.Show();
            this.Hide();


        }

        private void label5_Click(object sender, EventArgs e)
        {
            Candidate_0 can = new Candidate_0();
            can.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Subject_0 Obj = new Subject_0();
            Obj.Show();
            this.Hide();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            Subject_0 Obj = new Subject_0();
            Obj.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            log_in_0 log_In = new log_in_0();
            log_In.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void QuestTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void SubjectCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
