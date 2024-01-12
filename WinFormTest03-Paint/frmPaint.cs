using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest03_Paint
{
    public partial class frmPaint : Form
    {
        Graphics g = null;
        Pen pen = null;
        Brush brush = null;
        Bitmap bmCanvas = null; // drawing 수행

        int dMode = 0; // 0:Not, 1:pen, 2:line, 3:rect, 4:cir, 5:text = 드로잉모드
        int dFlag = 0; // 0:open, 1:pressed = 마우스 버튼
        Point p1, p2, p3;
        Point cp1, cp2, cp3; // screen 좌표계
        public frmPaint()
        {
            InitializeComponent();
            frmPaint_ResizeEnd(null, null);
            pen = new Pen(Color.Red, 2.0f); // 선 두께 2
            sbLabel4.Text = "";            
        }

        private void frmPaint_ResizeEnd(object sender, EventArgs e) // 크기조정 후 수행작업
        {            
            int draw_X = Canvas.Width, draw_Y = Canvas.Height;      // Canvas size
            if(bmCanvas == null)
            {
                bmCanvas = new Bitmap(draw_X, draw_Y);
                Canvas.Image = bmCanvas;
            }
            else
            {
                Bitmap tBmp = new Bitmap(draw_X, draw_Y);       // 임시 bitmap 영역, no image
                Graphics tg = Graphics.FromImage(tBmp);         // image로부터 가져와 임시 저장
                tg.DrawImage(bmCanvas, 0, 0);                   // bmCanvas image를 백업
                bmCanvas.Dispose();                             // 기존 image 해제
                bmCanvas = tBmp;                                // 새 bitmap으로 만든다
                Canvas.Image = bmCanvas;                        // bitmap을 image로 만든다                
            }
            g = Graphics.FromImage(bmCanvas);                   // Graphics영역을 image로부터 가져온다
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e) // 마우스 눌림
        {
            dFlag = 1; p1 = e.Location; p2 = e.Location; p3 = e.Location;
            cp1 = cp2 = cp3 = ((Control) sender).PointToScreen(p1);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {            
            if(e.X < 0 || e.Y < 0 || e.X > Canvas.Width || e.Y > Canvas.Height) return; // 영역 외
            if (dFlag != 0) // 마우스 눌리면 동작
            switch(dMode)
            {
                case 1: // pen draw
                    g.DrawLine(pen, p1, e.Location); // 시작:p1, 끝:현재점
                    Canvas.Invalidate();
                    p1 = e.Location;
                    break;
                case 2: // line draw
                    cp3 = PointToScreen(e.Location);
                    ControlPaint.DrawReversibleLine(cp1, cp2, DefaultBackColor);
                    ControlPaint.DrawReversibleLine(cp1, cp3, DefaultBackColor);
                    cp2 = cp3;
                    //g.DrawLine(pen, p1, e.Location);
                    break;
                case 3: // rect draw
                case 4: // circle draw
                default: break;                
            }            
            string str = $"{e.X} x {e.Y}"; // 마우스 좌표
            sbLabel1.Text = str;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) // 마우스 안눌림
        {
            switch(dMode)
            {
                case 2:
                    g.DrawLine(pen, p1, e.Location);
                    Canvas.Invalidate();
                    break;
                    default: break;
            }
            dFlag = 0;
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            dMode = 1; // 연필 그리기
            sbLabel4.Text = "연필 그리기";
        }

        private void mnuLine_Click(object sender, EventArgs e)
        {
            dMode = 2; // 선 그리기
            sbLabel4.Text = "선 그리기";
        }

        private void mnuRect_Click(object sender, EventArgs e)
        {
            dMode = 3; // 사각형 그리기
            sbLabel4.Text = "사각형 그리기";
        }

        private void frmPaint_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                frmPaint_ResizeEnd(sender, e);
        }

        private void mnuTestSine_Click(object sender, EventArgs e)
        {
            mnuErase_Click(sender, e);
            List<double> data = new List<double>();
            for(int i = 0; i < 360; i++)
            {   // Pi = 3.141592
                data.Add(Math.Sin(3.141592/180*i));
            }
            // X, Y axis
            int l=0, t=0, r=Canvas.Width, b=Canvas.Height;
            int range = r - l - 40; // 길이
            int step = range / 360; // 간격
            int amp = -(b - 20) / 2;// 증폭계수, Y축 변위
            int xOffset = 20;
            int yOffest = b / 2;            
            g.DrawLine(pen, new Point(l + 20, b / 2), new Point(r - 20, b / 2)); // X
            g.DrawLine(pen, new Point(l + 20, 10), new Point(l + 20, b - 10));   // Y
            PointF p1, p2;
            p1 = new PointF(xOffset, yOffest);
            for (int i = 0; i < 360; i++)
            {
                p2 = new PointF(i * step + xOffset, (float)data[i] *amp + yOffest);
                data.Add(Math.Sin(i));
                g.DrawLine(pen, p1, p2);
                p1 = p2;
            }
            Canvas.Invalidate();
        }

        private void mnuCircle_Click(object sender, EventArgs e)
        {
            dMode = 4; // 원 그리기
            sbLabel4.Text = "원 그리기";
        }

        private void mnuText_Click(object sender, EventArgs e)
        {
            dMode = 5; // 문자 입력
            sbLabel4.Text = "문자";
        }

       
        private void mnuErase_Click(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            Canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 드로잉
            Pen pen = new Pen(Color.Red);
            Point p1 = new Point(Left, Top);
            Point p2 = new Point(Right, Bottom);
            Point p3 = new Point(Left, Bottom);
            Point p4 = new Point(Right, Top);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);
        }
    }
}
