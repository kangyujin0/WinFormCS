using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest01_Base
{
    public partial class frmBase : Form
    {
        int EncMode = 0;    // 전역변수 0:UTF-8, 1:ANSI        
        public frmBase()
        {
            InitializeComponent();  // 생성자
            if(EncMode == 0 ) menuUTF8_Click(null, null);
            else              menuANSI_Click(null, null);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            menuOpen_Click(sender, e);
        }
        
        Encoding enc = Encoding.UTF8;   // Window 기본 인코딩
        private void menuOpen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();          // ShowDialog() = C++ DoModal과 같은 코드
            if (ret == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;                
                FileStream fs = new FileStream(fn, FileMode.Open);    // FileStream() = FILE *와 같은 코드
                StreamReader sr = new StreamReader(fs, enc);
                tbMemo.Text += sr.ReadToEnd();                        // file 모두 출력
                sr.Close();
                fs.Close();

                //while(true) // C# 무한루프 
                //{ 
                //    string str = sr.ReadLine();   // file 한 줄씩 출력
                //    if (str == null) break;
                //    tbMemo.Text += str;
                //}

            }
        }
        private void menuSave_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(tbMemo.Text);
                sw.Close();
                fs.Close();
            }
        }

        private void menuANSI_Click(object sender, EventArgs e)
        {   // UTF-8 ==> ANSI
            sbLabel1.Text = "ANSI";
            menuANSI.Checked = true;
            menuUTF8.Checked = false;
            enc = Encoding.Default;            
        }

        private void menuUTF8_Click(object sender, EventArgs e)
        {
            sbLabel1.Text = "UTF-8";
            menuANSI.Checked = false;
            menuUTF8.Checked = true;
            enc = Encoding.UTF8;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            string s = " ";
            frmAbout frmAbout = new frmAbout();
            DialogResult r = frmAbout.ShowDialog();
            if (r == DialogResult.OK) s = "About... OK";
            else                      s = "About... Cancel";
            sbLabel2.Text = s;
        }
    }
}
