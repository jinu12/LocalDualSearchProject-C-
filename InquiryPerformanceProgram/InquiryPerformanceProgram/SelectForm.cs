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
    public partial class SelectForm : Form
    {
        private string connStr = "Server=localhost;Uid=root;Pwd=1234;Database=db2";
        public SelectForm()
        {
            InitializeComponent();
            CityCombo();
            ValueCombo();
            NumCombo();
            yearCombo();
            Cost();
            Pre_Sale();
            Rental_Sales();
            Business_Area_Facility();
        }




        private void Select_Button_Click(object sender, EventArgs e)
        {
            //다시눌렀을때 새로운 값을 만들어 주기위서 clear사용
            dataGridView1.Columns.Clear();
            //지역체크박스만 체크했을때
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                BindingSource bSource = new BindingSource();
                DataTable dbataset = new DataTable();
                conn.Open();

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                try
                {
                    if (checkBox1.Checked)
                    {
                        conn.Open();
                        //지역체크박스만 체크했을때
                        string sql = "SELECT * FROM realestate_business_sample WHERE year='" + yearcombo.Text + "';";

                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        sda.SelectCommand = cmd;
                        sda.Fill(dbataset);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            bSource.DataSource = dbataset;
                            dataGridView1.DataSource = bSource;
                            sda.Update(dbataset);
                        }
                        rdr.Close();

                    }
                    else if (checkBox1.Checked && checkBox2.Checked)
                    {
                        conn.Open();
                        //연도체크박스와 지역체크박스를 체크했을때

                        string value_sql = "SELECT * FROM realestate_business_sample WHERE year='" + yearcombo.Text + "' and City='" + citycombo.Text + "';";
                        MySqlCommand cmd = new MySqlCommand(value_sql, conn);
                        sda.SelectCommand = cmd;

                        sda.Fill(dbataset);
                        MySqlDataReader rdr2 = cmd.ExecuteReader();
                        while (rdr2.Read())
                        {
                            bSource.DataSource = dbataset;
                            dataGridView1.DataSource = bSource;
                            sda.Update(dbataset);
                        }

                        rdr2.Close();
                    }
                    else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                    {
                        conn.Open();

                        //연도체크박스와 지역체크박스와 프로젝트 수 를 체크했을때

                        string values_sql = "SELECT * FROM realestate_business_sample WHERE year='" + yearcombo.Text + "' " +
                        "and City='" + citycombo.Text +"'and Participation_Type='" + valuecombo.Text + "';";

                        MySqlCommand cmd = new MySqlCommand(values_sql, conn);
                        sda.SelectCommand = cmd;
                        sda.Fill(dbataset);
                        MySqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            bSource.DataSource = dbataset;
                            dataGridView1.DataSource = bSource;
                            sda.Update(dbataset);
                        }
                        rdr.Close();
                     }
               
                }
 

                  
        
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                conn.Close();

            }
        }

        void CheckText()
        {
            string sql_city = "SELECT DISTINCT City FROM realestate_business_sample WHERE City_Code ORDER BY City ASC; ";
            /*conn.Open();*/
            try
            {

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {

                    MySqlCommand cmd = new MySqlCommand(sql_city, conn);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        citycombo.Items.Add(R.GetString(0));
                        if (citycombo.Items.Equals(R.GetString(0)) == true)
                        {
                            checkBox1.Checked = true;
                        }
                    }
                    R.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CityCombo()
        {
            try
            {
                
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql_city = "SELECT DISTINCT City FROM realestate_business_sample WHERE City_Code ORDER BY City ASC; ";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(sql_city, conn);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        citycombo.Items.Add(R.GetString(0));
                        if (citycombo.Items.Equals(R.GetString(0))== true) {
                            checkBox1.Checked = true;
                        }
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ValueCombo()
        {
            try
            {
                using (MySqlConnection conn2 = new MySqlConnection(connStr))
                {
                    conn2.Open();
                    string value_city = "SELECT DISTINCT Participation_Type FROM realestate_business_sample WHERE City_Code ORDER BY Participation_Type ASC; ";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(value_city, conn2);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        valuecombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void NumCombo()
        {
            try
            {
                using (MySqlConnection conn3 = new MySqlConnection(connStr))
                {
                    conn3.Open();
                    string Number_city = "SELECT DISTINCT Project_Nmber_count FROM realestate_business_sample WHERE City_Code ORDER BY Project_Nmber_count ASC;";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(Number_city, conn3);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        NumberCombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void yearCombo()
        {
            try
            {
                using (MySqlConnection conn4 = new MySqlConnection(connStr))
                {
                    conn4.Open();
                    string year = "SELECT DISTINCT Year FROM realestate_business_sample WHERE Year;";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(year, conn4);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        yearcombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Cost()
        {
            try
            {
                using (MySqlConnection conn5 = new MySqlConnection(connStr))
                {
                    conn5.Open();
                    string cost = "SELECT DISTINCT Cost FROM realestate_business_sample WHERE Cost ORDER BY Cost ASC;";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(cost, conn5);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        CostCombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Pre_Sale()
        {
            try
            {
                using (MySqlConnection conn5 = new MySqlConnection(connStr))
                {
                    conn5.Open();
                    string pre = "SELECT DISTINCT Pre_Sale FROM realestate_business_sample WHERE Pre_Sale ORDER BY Pre_Sale ASC;";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(pre, conn5);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        presalecombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Rental_Sales()
        {
            try
            {
                using (MySqlConnection conn6 = new MySqlConnection(connStr))
                {
                    conn6.Open();
                    string lend = "SELECT DISTINCT Rental_Sales FROM realestate_business_sample WHERE Rental_Sales ORDER BY Rental_Sales ASC;";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(lend, conn6);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lentalcombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Business_Area_Facility()
        {
            try
            {
                using (MySqlConnection conn7 = new MySqlConnection(connStr))
                {
                    conn7.Open();
                    string lend = "SELECT DISTINCT Business_Area_Facility FROM realestate_business_sample WHERE Business_Area_Facility ORDER BY Business_Area_Facility ASC;";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기

                    MySqlCommand cmd = new MySqlCommand(lend, conn7);
                    MySqlDataAdapter sda = new MySqlDataAdapter();

                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        facilyareacombo.Items.Add(R.GetString(0));
                    }
                    R.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void SelectForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox9.Checked = false;

            yearcombo.ResetText();
            citycombo.ResetText();
            valuecombo.ResetText();
            NumberCombo.ResetText();
            presalecombo.ResetText();
            lentalcombo.ResetText();
            facilyareacombo.ResetText();
        }




        private void ChangeCheckBox(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void citycombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void valuecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void NumberCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void CostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void presalecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void lentalcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = true;
        }

        private void facilyareacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = true;
        }
    }
}