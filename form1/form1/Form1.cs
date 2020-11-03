﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 생성된 UI class 는 .cs 파일과 .Designer.cs 에 각각 partial class 로 나누어 생성됨
namespace form1
{
    public partial class TEST_Field : Form
    {
        public TEST_Field()
        {
            InitializeComponent();
        }

        string sConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beomgu\source\repos\MyTable.mdf;Integrated Security = True; Connect Timeout = 30";
        
        SqlConnection sConn = new SqlConnection();
        SqlCommand sCmd = new SqlCommand();

        private void MN_addCol_Click(object sender, EventArgs e)
        {
            Form_Input dlg = new Form_Input();
            dlg.ShowDialog();
            string str = dlg.sRet;

            if (str != "")
            {
                DB_Grid1.Columns.Add(str, str);
            }
        }

        private void MN_addRow_Click(object sender, EventArgs e)
        {
            DB_Grid1.Rows.Add();
        }

        public string GetToken(int index, string str, string sdel)
        {         // str 문자열을 'sDel' 구분자로 분할하여 그 중 index 번째의 문자열을 반환
                  // GetToken(3, "1|2|3|4|5", "|") ==> "4" 반환
            string[] sArr = str.Split(sdel[0]);
            return sArr[index];
        }

        private void MN_dbOpen_Click(object sender, EventArgs e)
        {
            try 
            {
                openFileDialog1.ValidateNames = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] sArr1 = sConnString.Split(';');
                    string sConnStr = $"{sArr1[0]};AttachDbFilename={openFileDialog1.FileName};{sArr1[2]};{sArr1[3]}";

                    sConn.ConnectionString = sConnStr;
                    sConn.Open();
                    sCmd.Connection = sConn;

                    sS_Label1.Text = "Database Opened.";
                    sS_Label1.BackColor = Color.BlueViolet;
                    statusStrip1.BackColor = Color.AliceBlue;

                    DataTable dt = sConn.GetSchema("Tables");

                    for (int i=0; i<dt.Rows.Count; i++)
                    {
                        string str = dt.Rows[i].ItemArray[2].ToString();  // ItemArray[2] 가 table 이름
                        sS_Label2.Text = "Tables";
                        st_combobox1.Items.Add(str);
                        st_combobox1.Text = str;
                    }
                }
            }
            catch (Exception e1)
            {    // database file open error ocured!!
                MessageBox.Show(e1.Message);

                sS_Label1.Text = "Database Open Failed!!!!";
                statusStrip1.BackColor = Color.IndianRed;
            }
        }

        private void MN_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MN_dbClose_Click(object sender, EventArgs e)
        {
            sConn.Close();
            sS_Label1.Text = "Database Closed.";
            sS_Label1.BackColor = Color.DimGray;
        }

        private void MN_TestCmd1_Click(object sender, EventArgs e)
        {
            // For SQL coding test
            string sTime = DateTime.Now.ToString();
            // string sTime = $"{DateTime.Now:s}";  // 시간 규격을 국제 표준에 맞춰줌
            string str = $"insert into fStatus values ('10001', '10.50', '50.00', '02.00', '{sTime}')";
            // SQL insert 문
            RunSql(str);
        }

        private void MN_TestCmd2_Click(object sender, EventArgs e)
        {
            RunSql("select * from facility");
        }

        /* 함수 일반화 #n
           함수명 : public void RunSqlNone(string sql)
           인수 : string sql ==> 조회값이 없는 SQL 명령어 (Insert, Update, Delete)
                                 Select 문을 제외한 나머지 모두
                                      -> SELECT * FROM [table_name]
           리턴 : void                                                           */
        public void RunSql(string sql)
        {
            try
            {   // 첫번째 단어를 분리하고 소문자로 변환
                string s1 = GetToken(0, sql, " ").ToLower();
                sCmd.CommandText = sql;

                if (s1 != "select")
                {
                    sCmd.ExecuteNonQuery();
                }
                else
                {
                    SqlDataReader sr = sCmd.ExecuteReader();  // record 단위로 명령처리
                    for (int i=0; i<sr.FieldCount; i++)
                    {
                        DB_Grid1.Columns.Add(sr.GetName(i), sr.GetName(i));                    
                    }
                    for (int i=0; sr.Read(); i++)   // 읽을 record가 있으면 true
                    {                               // 없으면 false
                        DB_Grid1.Rows.Add();
                        for (int ii=0; ii<sr.FieldCount; ii++)
                        {
                            DB_Grid1.Rows[i].Cells[ii].Value = sr.GetValue(ii);
                        }
                    }
                }

                sS_Label3.Text = "Sucessfully Apply.";
                sS_Label3.BackColor = Color.CadetBlue;
            }
            catch (Exception e1)
            {
                sS_Label3.Text = e1.Message;
                sS_Label3.BackColor = Color.IndianRed;
            }
        }

        private void TB_SQLterminer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string str = TB_SQLterminer.Text;

                RunSql(str);
            }
        }

       
    }
}