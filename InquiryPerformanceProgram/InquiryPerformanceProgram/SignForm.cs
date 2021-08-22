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
    public partial class SignForm : Form
    {

        public SignForm()
        {
            InitializeComponent();
            yearCombo();
            monthCombo();
            dayCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=1234";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAadapter = new MySqlDataAdapter();

                MySqlCommand selectCommend = new MySqlCommand("INSERT INTO users.data VALUES ('"
                + this.ID.Text + "','" + this.PW.Text + "','" + this.Email.Text + "','"
                + this.Phone.Text + "','" + this.Year_combo.Text + "','" + this.Month_combo.Text + "','" + this.day_combo.Text + "','"
                + this.man_button.Text + "');", myConn);
                MySqlDataReader myReader;

                myConn.Open();
                myReader = selectCommend.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 0)
                {
                    this.Hide();
                    MessageBox.Show("회원가입이 되었습니다");
                    SelectForm f2 = new SelectForm();
                    f2.ShowDialog();
                }

                else
                {
                    MessageBox.Show("유저이름과 비밀번호가 적합하지 않습니다.");
                }
                myReader.Close();
            }
              
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void monthCombo()
            {
            for(int i=1;i<=12;i++) 
            {
                Month_combo.Items.Add(i);
            }
        }

        void dayCombo()
        {
            for (int i = 1; i <= 31; i++)
            {
                day_combo.Items.Add(i);
            }
        }

        void yearCombo()
        {
            for (int i = 1900; i <= 2000; i++)
            {
                Year_combo.Items.Add(i);
            }
        }
    }
}

