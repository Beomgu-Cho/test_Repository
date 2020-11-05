using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = dlg.sRet;
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

                    sS_Label5.Text = openFileDialog1.SafeFileName;
                    sS_Label5.BackColor = Color.ForestGreen;

                    sS_Label1.Text = "Database Opened.";
                    sS_Label1.BackColor = Color.BlueViolet;
                    statusStrip1.BackColor = Color.AliceBlue;

                    RefreshTables();
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
            sS_Combo1.Text = "facility";
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
                    sCmd.ExecuteNonQuery();
                else
                {
                    if (DB_Grid1.Rows.Count != 0)
                    {
                        DB_Grid1.Rows.Clear();
                        DB_Grid1.Columns.Clear();
                    }

                    SqlDataReader sr = sCmd.ExecuteReader();  // record 단위로 명령처리

                    for (int i = 0; i < sr.FieldCount; i++)
                        DB_Grid1.Columns.Add(sr.GetName(i), sr.GetName(i));

                    for (int i = 0; sr.Read(); i++)   // 읽을 record가 있으면 true
                    {                               // 없으면 false
                        DB_Grid1.Rows.Add();

                        for (int ii = 0; ii < sr.FieldCount; ii++)
                        {
                            DB_Grid1.Rows[i].Cells[ii].Value = sr.GetValue(ii).ToString().Trim();
                        }
                    }
                    string[] ssql = sql.Trim().Split(' ');

                    if (ssql[1] == "*")
                        sS_Combo1.Text = ssql.Last();
                    else
                        sS_Combo1.Text = "";

                    sr.Close();
                    DB_Grid1.Rows[0].Cells[0].ToolTipText = "";
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
            string str = TB_SQLterminer.Text.Trim();
            // 마지막 문장추출 (ENTER KEY 입력기준)
            // ENTER 입력시 실제 텍스트에는 '\r\n' 으로 입력됨.

            string[] bStr = str.Split(';');
            // 11/4/2020 구분자 변경 '\r' --> ';'
            // 세미콜론 이전의 텍스트를 실행
            // Trim() ==> 화이트스페이스 제거
            if (e.KeyChar == '\r')
            {
                try
                {
                    if (bStr.Last() == "")
                    {
                        for (int i = 0; i < bStr.Length; i++)
                        {
                            string result = bStr[bStr.Length - (2 + i)].Trim();

                            if (result != "")
                            {
                                RunSql(result);
                                break;
                            }
                        }
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                // for (int i = 0; i < bStr.Length; i++)
                // {
                //     if (result == "")
                //     {
                //         result = bStr[bStr.Length - (i + 1)].Trim();
                //         continue;
                //     }
                //     else
                //     {
                //         break;
                //     }
                // }        
                // 처음 텍스트를 받아올 때 문장 전체의 텍스트에 Trim() 을 이용하면 간단하게 해결   
            }
        }

        private void MN_DBUpdate_Click(object sender, EventArgs e)
        {          // update [table_name] set [Header]=[info] where [key]=[key_info's_row]
            try
            {
                string tName = sS_Combo1.Text;
                string KeyHead = DB_Grid1.Columns[0].HeaderText;

                for (int i = 0; i < DB_Grid1.RowCount; i++)
                {
                    if (DB_Grid1.Rows[i].Cells[0].ToolTipText != "!")
                    {
                        for (int ii = 0; ii < DB_Grid1.ColumnCount; ii++)
                        {

                            if (DB_Grid1.Rows[i].Cells[ii].ToolTipText == ".")
                            {
                                string sHead = DB_Grid1.Columns[ii].HeaderText;
                                string sValue = $"{DB_Grid1.Rows[i].Cells[ii].Value}";
                                string KeyValue = $"{DB_Grid1.Rows[i].Cells[0].Value}";

                                string sqlCmd = $"update {tName} set {sHead}=N'{sValue}' where {KeyHead}='{KeyValue}'";

                                RunSql(sqlCmd);

                                DB_Grid1.Rows[i].Cells[ii].ToolTipText = "";
                            }
                        }
                    }
                    else
                    {
                        string Insert_cmd = $"insert into {tName} values (";

                        for (int ii = 0; ii < DB_Grid1.ColumnCount; ii++)
                        {
                            // insert into [table_name] values ([va1], [val2], ..., [val])

                            Insert_cmd += $"'{DB_Grid1.Rows[i].Cells[ii].Value}'";
                            if (ii != DB_Grid1.ColumnCount - 1)
                                Insert_cmd += ",";
                        }
                        Insert_cmd += ")";

                        RunSql(Insert_cmd);
                    }
                }
                sS_Label3.Text = "sucessfully Changed!!";
            }
            catch (Exception e1)
            {
                sS_Label3.Text = e1.Message;
                sS_Label3.BackColor = Color.IndianRed;
            }
        }

        public void DB_Grid1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            if (DB_Grid1.Rows[y].Cells[x].ToolTipText != "!")
                DB_Grid1.Rows[y].Cells[x].ToolTipText = ".";
        }

        private void sS_Combo1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string str = e.ClickedItem.Text;
            string sql = $"select * from {str}";
            sS_Combo1.Text = str;

            RunSql(sql);

            DB_Grid1.Rows[0].Cells[0].ToolTipText = "";
        }

        private void MN_TableClose_Click(object sender, EventArgs e)
        {
            DB_Grid1.Rows.Clear();
            DB_Grid1.Columns.Clear();
        }

        private void MN_SQLstart_Click(object sender, EventArgs e)
        {
            string str = TB_SQLterminer.SelectedText.Trim();

            RunSql(str);
        }

        private void MN_TableSave_Click(object sender, EventArgs e)
        {   // create table [table_name] ([col_name] nchar(20), ...)
            string sTable = sS_Combo1.Text;
            if (sTable == "")
            {
                Form_Input dlg = new Form_Input();
                dlg.ShowDialog();
                sTable = dlg.sRet;

                string sql = $"create table {sTable} (";
                for (int i = 0; i < DB_Grid1.ColumnCount; i++)
                {
                    string sCol = $"{DB_Grid1.Columns[i].HeaderText} nchar(20)";
                    if (i != DB_Grid1.ColumnCount - 1)
                        sCol += ",";

                    sql += sCol;
                }
                sql += ")";

                RunSql(sql);

                // insert into [table_name] values ([va1], [val2], ..., [val])
                for (int i = 0; i < DB_Grid1.RowCount - 1; i++)
                {
                    sql = $"insert into {sTable} values (";
                    for (int ii = 0; ii < DB_Grid1.ColumnCount; ii++)
                    {
                        sql += $"'{DB_Grid1.Rows[i].Cells[ii].Value}'";
                        if (ii < DB_Grid1.ColumnCount - 1)
                            sql += ",";
                    }

                    sql += ")";

                    RunSql(sql);
                }
            }
            else
            {
                try
                {
                    string tName = sS_Combo1.Text;
                    string KeyHead = DB_Grid1.Columns[0].HeaderText;

                    for (int i = 0; i < DB_Grid1.ColumnCount; i++)
                    {
                        for (int ii = 0; ii < DB_Grid1.RowCount - 1; ii++)
                        {
                            if (DB_Grid1.Rows[ii].Cells[i].ToolTipText == ".")
                            {
                                string sHead = DB_Grid1.Columns[i].HeaderText;
                                string sValue = (string)DB_Grid1.Rows[ii].Cells[i].Value;
                                string KeyValue = (string)DB_Grid1.Rows[ii].Cells[0].Value;

                                string sqlCmd = $"update {tName} set {sHead}=N'{sValue}' where {KeyHead}=N'{KeyValue}'";

                                RunSql(sqlCmd);

                                DB_Grid1.Rows[ii].Cells[i].ToolTipText = "";
                            }
                        }
                    }
                    sS_Label3.Text = "sucessfully Changed!!";
                }
                catch (Exception e1)
                {
                    sS_Label3.Text = e1.Message;
                    sS_Label3.BackColor = Color.IndianRed;
                }
            }
        }

        private void sS_Label1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                RefreshTables();
            }
            catch
            {
                sConn.ConnectionString = sConnString;
                RefreshTables();
            }
        }

        private void RefreshTables()
        {
            sS_Combo1.DropDownItems.Clear();      // 기존 테이블의 아이템 삭제...
            DataTable dt = sConn.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = dt.Rows[i].ItemArray[2].ToString();  // ItemArray[2] 가 table 이름

                sS_Combo1.DropDownItems.Add(str);
                sS_Combo1.Text = "";
            }
        }

        private void sS_Label1_MouseDown(object sender, MouseEventArgs e)
        {
            sS_Label1.BorderStyle = Border3DStyle.Sunken;
        }

        private void sS_Label1_MouseUp(object sender, MouseEventArgs e)
        {
            sS_Label1.BorderStyle = Border3DStyle.Etched;
        }

        private void DB_Grid1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DB_Grid1.Rows[e.RowCount - 1].Cells[0].ToolTipText = "!";
        }

        private void MN_delCol_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DB_Grid1.SelectedCells.Count; i++)
            {
                int y = DB_Grid1.SelectedCells[i].ColumnIndex;

                string colHead = DB_Grid1.Columns[y].HeaderText;
                if (sS_Combo1.Text != "")
                {
                    string cmd = $"alter table {sS_Combo1.Text} drop column {colHead}";

                    RunSql(cmd);
                } 
            }
        }

        private void MN_delRow_Click(object sender, EventArgs e)
        {
            string key = DB_Grid1.Columns[0].HeaderText;
            for (int i = 0; i < DB_Grid1.SelectedCells.Count; i++)
            {
                int x = DB_Grid1.SelectedCells[i].RowIndex;

                string key_val = (string)DB_Grid1.Rows[x].Cells[0].Value;
                if (sS_Combo1.Text != "")
                {
                    string cmd = $"delete {sS_Combo1.Text} where {key}={key_val}";

                    RunSql(cmd);
                }
            }
        }

        private void MN_TableDelete_Click(object sender, EventArgs e)
        {
            string cmd = "drop table ";

            if (sS_Combo1.Text != "")
            {
                cmd += sS_Combo1.Text;
                RunSql(cmd);
            }
        }

        private void MN_CSVImport_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Grid1.Rows.Clear();
                DB_Grid1.Columns.Clear();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    // StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    string str = sr.ReadLine();
                    string[] sCols = str.Split(',');

                    for (int i = 0; i < sCols.Length; i++)
                        DB_Grid1.Columns.Add(sCols[i], sCols[i]);

                    for (int i = 0; ; i++)
                    {
                        str = sr.ReadLine();
                        if (str == null)
                            break;

                        DB_Grid1.Rows.Add();
                        for (int ii = 0; ii < sCols.Length; ii++)
                        {
                            DB_Grid1.Rows[i].Cells[ii].Value = (string)GetToken(ii, str, ",").Trim();
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                sS_Label3.Text = e1.Message;
            }
        }

        private void MN_CSVSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                string str = "";
                for (int i = 0; i < DB_Grid1.ColumnCount; i++)
                {
                    str += DB_Grid1.Columns[i].HeaderText;
                    if (i < DB_Grid1.ColumnCount - 1)
                        str += ",";
                }
                sw.WriteLine(str);

                for (int i = 0; i < DB_Grid1.RowCount - 1; i++)
                {
                    str = "";
                    for (int ii = 0; ii < DB_Grid1.ColumnCount; ii++)
                    {
                        str += (string)DB_Grid1.Rows[i].Cells[ii].Value;
                        if (ii < DB_Grid1.ColumnCount - 1)
                            str += ",";
                    }
                    sw.WriteLine(str);
                }
            }
        }
    }
}
/*       
 *       [   SQL Commend   ]
 * 
 *       <JOIN>
 *       select * from facility inner join fGps on facility.fcode=fGps.fcode;
 *       select id, facility.fcode, fname, fmodel, floc_x, floc_y from facility inner join fgps on facility.fcode=fgps.fcode;
 *       <AS>
 *       select id, A.fcode, fname, fmodel, floc_x, floc_y from facility as A inner join fgps as B on A.fcode=B.fcode;
 *       <DELETE>
 *       delete [table_name] where [key]=[key_value]
 *
 */
