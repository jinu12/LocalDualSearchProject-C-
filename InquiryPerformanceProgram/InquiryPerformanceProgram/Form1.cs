using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InquiryPerformanceProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=1234";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAadapter = new MySqlDataAdapter();


                MySqlCommand selectCommend = new MySqlCommand("SELECT * FROM users.data where ID='" + this.ID.Text + "'  and PW = '" + this.PW.Text + "';", myConn);


                MySqlDataReader myReader;
                myConn.Open();
                myReader = selectCommend.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }


                if (count == 1)
                {
                    this.Hide();
                    MessageBox.Show("유저이름과 비밀번호가 일치합니다");
                    SelectForm f2 = new SelectForm();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("유저이름과 패스워드가 일치하지 않습니다");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                SignForm f1 = new SignForm();
                f1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
