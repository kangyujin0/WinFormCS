namespace WinFormTest01_Base
{
    partial class frmBase
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.sbBase = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuANSI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUTF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sbBase.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMemo
            // 
            this.tbMemo.AcceptsReturn = true;
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.Location = new System.Drawing.Point(12, 27);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMemo.Size = new System.Drawing.Size(350, 270);
            this.tbMemo.TabIndex = 0;
            // 
            // sbBase
            // 
            this.sbBase.AllowMerge = false;
            this.sbBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2,
            this.sbLabel3});
            this.sbBase.Location = new System.Drawing.Point(0, 337);
            this.sbBase.Name = "sbBase";
            this.sbBase.Size = new System.Drawing.Size(504, 22);
            this.sbBase.TabIndex = 1;
            this.sbBase.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.ForeColor = System.Drawing.Color.Black;
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(10, 17);
            this.sbLabel1.Text = ".";
            // 
            // sbLabel2
            // 
            this.sbLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(13, 17);
            this.sbLabel2.Text = "..";
            // 
            // sbLabel3
            // 
            this.sbLabel3.Name = "sbLabel3";
            this.sbLabel3.Size = new System.Drawing.Size(16, 17);
            this.sbLabel3.Text = "...";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::WinFormTest01_Base.Properties.Resources.다운로드;
            this.btnOpen.Location = new System.Drawing.Point(377, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 68);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "button1";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.toolStripMenuItem2,
            this.menuExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(103, 22);
            this.menuNew.Text = "New";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(103, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(103, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(103, 22);
            this.menuExit.Text = "Exit";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFind,
            this.menuReplace});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(110, 22);
            this.menuFind.Text = "찾기";
            // 
            // menuReplace
            // 
            this.menuReplace.Name = "menuReplace";
            this.menuReplace.Size = new System.Drawing.Size(110, 22);
            this.menuReplace.Text = "바꾸기";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont,
            this.toolStripMenuItem1,
            this.menuANSI,
            this.menuUTF8});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(106, 22);
            this.menuFont.Text = "글꼴";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 6);
            // 
            // menuANSI
            // 
            this.menuANSI.Name = "menuANSI";
            this.menuANSI.Size = new System.Drawing.Size(106, 22);
            this.menuANSI.Text = "ANSI";
            this.menuANSI.Click += new System.EventHandler(this.menuANSI_Click);
            // 
            // menuUTF8
            // 
            this.menuUTF8.Name = "menuUTF8";
            this.menuUTF8.Size = new System.Drawing.Size(106, 22);
            this.menuUTF8.Text = "UTF-8";
            this.menuUTF8.Click += new System.EventHandler(this.menuUTF8_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(180, 22);
            this.menuAbout.Text = "About...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 359);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.sbBase);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbMemo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myMemo ver 1.5";
            this.sbBase.ResumeLayout(false);
            this.sbBase.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.StatusStrip sbBase;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripMenuItem menuReplace;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuANSI;
        private System.Windows.Forms.ToolStripMenuItem menuUTF8;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

