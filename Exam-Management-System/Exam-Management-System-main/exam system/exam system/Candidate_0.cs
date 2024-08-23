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
    public partial class Candidate_0 : Form
    {
        public Candidate_0()
        {
            InitializeComponent();
            DisplayCandidates();
        }

        private void Reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            PasswordTb.Text = "";
        }
        public Candidate_0(SqlConnection conn)
        {
            this.conn = conn;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-098USF1\MSSQLSERVER1;database=quiz;Integrated Security=True");

        private void DisplayCandidates()              
        {

            conn.Open();
            string Query = "select * from CandidateTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidateDGV.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    //int score = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CandidateTable (CName, CAge, CPass , CAdd, CPhone) VALUES (@Cn, @CA, @Cp, @Cad, @Cph)", conn);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", Convert.ToInt32(CAgeTb.Text));
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    //cmd.Parameters.AddWithValue("@Cs", Convert.ToInt32(score));
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", Convert.ToInt32(PhoneTb.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("candidate saved");
                    Reset();
                    DisplayCandidates();

                    conn.Close();

                }

                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }

            }



        }

        private void CNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CNameTb_MouseEnter(object sender, EventArgs e)
        {
            //CNameTb.Text = "";
        }

        private void CNameTb_MouseLeave(object sender, EventArgs e)
        {
            //CNameTb.Text = "Name";
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int key = 0;
        private void CandidateDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = CandidateDGV.SelectedRows[0].Cells[1].Value.ToString();
            CAgeTb.Text = CandidateDGV.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = CandidateDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddressTb.Text = CandidateDGV.SelectedRows[0].Cells[5].Value.ToString();
            PhoneTb.Text = CandidateDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (CNameTb.Text == "")

            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CandidateDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || CAgeTb.Text == "Age" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    int score = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update CandidateTable set CName=@Cn,CAge=@Ca,CPass=@Cp,CAdd=@Cad,Cphone=@Cph where Cid=@CKey ", conn);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", Convert.ToInt32(CAgeTb.Text));
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cs", Convert.ToInt32(score));
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);

                    cmd.Parameters.AddWithValue("@Cph", Convert.ToInt32(PhoneTb.Text));
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("candidate Update");
                    Reset();
                    DisplayCandidates();

                    conn.Close();
                }

                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }

            }


        }

        private void EditBTN_Click_1(object sender, EventArgs e)
        {

        }

        private void ResetBTN_Click_1(object sender, EventArgs e)
        {

        }

        private void CAgeTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CandidateDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Subject_0 Obj = new Subject_0();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Question_0cs que = new Question_0cs();
            que.Show();
            this.Hide();
        }
    }
}
