namespace 박성준_201911529_개인과제
{
    partial class Form1
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
            this.btnPatentLoading = new System.Windows.Forms.Button();
            this.patentInfoLoadingList = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CSVFileOpenBtn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatentLoading
            // 
            this.btnPatentLoading.Location = new System.Drawing.Point(50, 46);
            this.btnPatentLoading.Name = "btnPatentLoading";
            this.btnPatentLoading.Size = new System.Drawing.Size(254, 51);
            this.btnPatentLoading.TabIndex = 0;
            this.btnPatentLoading.Text = "특허정보 CSV 파일로 바꾸기";
            this.btnPatentLoading.UseVisualStyleBackColor = true;
            this.btnPatentLoading.Click += new System.EventHandler(this.btnPatentLoading_Click);
            // 
            // patentInfoLoadingList
            // 
            this.patentInfoLoadingList.Location = new System.Drawing.Point(50, 128);
            this.patentInfoLoadingList.Multiline = true;
            this.patentInfoLoadingList.Name = "patentInfoLoadingList";
            this.patentInfoLoadingList.ReadOnly = true;
            this.patentInfoLoadingList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patentInfoLoadingList.Size = new System.Drawing.Size(681, 251);
            this.patentInfoLoadingList.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPatentLoading);
            this.tabPage1.Controls.Add(this.patentInfoLoadingList);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "특허 로딩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "특허 처리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CSVFileOpenBtn);
            this.panel1.Controls.Add(this.filePathTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 100);
            this.panel1.TabIndex = 1;
            // 
            // CSVFileOpenBtn
            // 
            this.CSVFileOpenBtn.Location = new System.Drawing.Point(565, 24);
            this.CSVFileOpenBtn.Name = "CSVFileOpenBtn";
            this.CSVFileOpenBtn.Size = new System.Drawing.Size(176, 44);
            this.CSVFileOpenBtn.TabIndex = 1;
            this.CSVFileOpenBtn.Text = "CSV파일 가져오기";
            this.CSVFileOpenBtn.UseVisualStyleBackColor = true;
            this.CSVFileOpenBtn.Click += new System.EventHandler(this.CSVFileOpenBtn_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(27, 34);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(493, 28);
            this.filePathTextBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(786, 412);
            this.dataGridView.TabIndex = 0;
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.FileName = "openFileDlg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatentLoading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CSVFileOpenBtn;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog dlgFileOpen;
        public System.Windows.Forms.TextBox patentInfoLoadingList;
    }
}

