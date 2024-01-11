using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest02_DBM
{
    public partial class frmDBManager : Form
    {
        public frmDBManager()
        {
            InitializeComponent();
        }

        string GetFileName(string sPath) // 경로에서 파일이름 추출
        {
            string[] sa = sPath.Split('\\');            
            return sa[sa.Length -1];
        }

        SqlConnection sqlConn = new SqlConnection(); // 연결
        SqlCommand sqlCom = new SqlCommand();        // 실행
        string sConn;                                
        private void mnuOpen_Click(object sender, EventArgs e)
        {   // DB file select            
            openFileDialog1.Filter = "MS-SQL Datebase file|*.mdf"; // DB file선택을 위한 openFileDialog1 필터를 설정

            if (DialogResult.OK == openFileDialog1.ShowDialog())   // 선택된 DB file경로를 가져와 연결문자열 생성
            {   
                sConn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.ConnectionString = sConn;   // SqlConnection 객체의 연결 문자열을 설정
                sqlConn.Open();                     // DB연결
                sqlCom.Connection = sqlConn;        // SqlCommand 객체가 SqlConnection 객체를 사용하도록 설정
                sbLabel1.BackColor = Color.Green;
                sbLabel1.Text = GetFileName(openFileDialog1.FileName);
            }
        }

        ArrayList ColName = new ArrayList(); // 필드이름(데이터베이스 테이블의 열 이름)을 저장하는 List
        List<object[]> RunSql(string sql)    // Select 쿼리와 그 외 쿼리를 실행 함수
        {
            List<object[]> result = new List<object[]>(); // 결과 저장 List초기화, 배열 각 요소는 쿼리 결과 열에 해당
            sqlCom.CommandText = sql; // SqlCommand에 전달된 SQL 쿼리 설정
            try // try-catch문 예외처리
            {
                if (sql.Trim().ToLower().Substring(0, 6) == "select") // 입력된 SQL 쿼리가 SELECT 문인지 확인
                {
                    SqlDataReader sr = sqlCom.ExecuteReader();        // 쿼리를 실행하고 결과를 SqlDataReader에 저장
                    ColName.Clear(); // ArrayList는 새 데이터를 준비하기 위해 지워짐
                    for (int i = 0; i < sr.FieldCount; i++)
                    {
                        ColName.Add(sr.GetName(i));                   // 필드 이름을 ColName ArrayList에 추가
                    }
                    for (; sr.Read();) // 1 recoed read
                    {
                        object[] oarr = new object[sr.FieldCount];    // 각 필드의 값을 저장할 객체 배열을 생성
                        sr.GetValues(oarr);                           // 레코드의 각 필드 값을 읽어와 배열에 저장
                        result.Add(oarr);                             // 결과 리스트에 배열 추가

                        //string str = ""; // 1 Line add
                        //for (int i = 0; i < sr.FieldCount; i++)
                        //{
                        //    object o = sr.GetValue(i);
                        //    if (i == 0) str = $"{o}";
                        //    else        str += $",{o}";
                        //}
                    }
                    sr.Close(); // SqlDataReader를 닫음
                }
                else
                {
                    int n = sqlCom.ExecuteNonQuery(); // SELECT 이외의 쿼리 실행
                }
                sbLabel3.Text = "OK";
                return result;
            }
            catch(Exception ex)
            {   // 오류가 발생하면 오류 메시지를 표시하고 null 반환
                //MessageBox.Show(ex.Message);
                sbLabel3.AutoSize = true;
                sbLabel3.Text = ex.Message;
                return null;
            }            
        }

        private void menuRun_Click(object sender, EventArgs e)
        {
            string sql = tbSql.SelectedText; // 블록지정된 구문을 가져옴
            if(sql == "") sql = tbSql.Text;  // 블록 없으면 tbSql.Text에서 SQL 쿼리를 가져옴
            List<object[]> r = RunSql(sql);  // SQL쿼리를 전달 데이터베이스에서 실행하고 결과를 받아옴
            if (r == null) return;           // 반환된 결과 null이면 더 이상 진행하지 않는다

            dataView.Rows.Clear();           // 데이터를 표시하기 전 초기화
            dataView.Columns.Clear();
            // 열 추가
            for (int i = 0; i < ColName.Count; i++)     // colName 생성
            {
                string colName = (string)ColName[i];    // ColName리스트 각 열의 이름을 가져와 데이터그리드 뷰에 열 추가
                dataView.Columns.Add(colName, colName); // 열의 이름은 colName 변수에 할당.이 이름으로 데이터그리드 뷰에 열 추가
            }
            // 데이터그리드 뷰에 레코드 추가
            for (int i = 0; i < r.Count; i++)           // 1 record read.데이터그리드 뷰에 새로운 행 추가
            {                
                int nRow = dataView.Rows.Add();         // 1 Line add.nRow는 추가된 행의 인덱스
                object [] o = r[i];                     // o 배열 각 값을 ColName 리스트의 열 인덱스 j에 맞춰 데이터 그리드 뷰의 해당 행과 열에 할당
                for (int j = 0; j < ColName.Count; j++)
                {                  
                    dataView.Rows[nRow].Cells[j].Value = o[j];                    
                }               
            }
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSql.Font = fontDialog1.Font;
                sbLabel2.Text = tbSql.Font.Name;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(tbSql.Text);
                sw.Close();
                fs.Close();
            }
        }
    }
}
