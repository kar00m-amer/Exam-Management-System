using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_system
{
    public partial class log_in_0 : Form
    {
        public log_in_0()
        {
            InitializeComponent();
            GetSubjects();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-098USF1\MSSQLSERVER1;database=quiz;Integrated Security=True; Connect Timeout=30");
        public static String CandName = "", SubName = "";
        private void GetSubjects()
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SName FROM SubjectTbl", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("SName", typeof(string));
                dt.Load(rdr);

                ComboBox SubjectCB = new ComboBox();

                SubjectCB.ValueMember = "SName";
                SubjectCB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching subjects: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Admin_log_in Obj = new Admin_log_in();

            Obj.Show();

            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /* (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Candidate Name and Password");
            }
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select (*)from CandidateTbl where cpass='" + PasswordTb.Text + "' and Cname='" + UnameTb.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    ComboBox SubjectCB = new ComboBox();

                    CandName = UnameTb.Text;
                    SubName = SubjectCB.SelectedValue.ToString();
                    Exam_0 Obj = new Exam_0();
                    Obj.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Candidate Name or Password");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                conn.Close();
            }*/
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-098USF1\\MSSQLSERVER1; database = quiz; integrated security = True";
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectQuery = "SELECT * FROM loginTbl WHERE userName='" + UnameTb.Text + "' AND password='" + PasswordTb.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Exam_0 Obj = new Exam_0();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }


    }
}
