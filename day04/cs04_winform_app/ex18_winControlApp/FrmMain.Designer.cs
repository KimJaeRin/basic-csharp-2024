namespace ex18_winControlApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            label1 = new Label();
            ChkBold = new CheckBox();
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            CboFonts = new ComboBox();
            ChkItalic = new CheckBox();
            groupBox2 = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            BtnAddChild = new Button();
            BtnAddRoot = new Button();
            LsvDummy = new ListView();
            TrvDummy = new TreeView();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            TxtLog = new TextBox();
            BtnStop = new Button();
            BtnThread = new Button();
            BtnNothread = new Button();
            PrgProcess = new ProgressBar();
            BtnLoad = new Button();
            PicNormal = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            GrbEditor = new GroupBox();
            BtnFileSave = new Button();
            BtnFileLoad = new Button();
            RtxEditor = new RichTextBox();
            BgwProgress = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).BeginInit();
            GrbEditor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔고딕코딩", 9F);
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 12);
            label1.TabIndex = 0;
            label1.Text = "폰트 :";
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕코딩", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(339, 34);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(60, 16);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "볼드체";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("나눔고딕코딩", 9F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕코딩", 9F);
            TxtSampleText.Location = new Point(6, 61);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(508, 19);
            TxtSampleText.TabIndex = 4;
            TxtSampleText.Text = "Hello, C#!  ";
            TxtSampleText.TextAlign = HorizontalAlignment.Right;
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕코딩", 9F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(62, 32);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(258, 20);
            CboFonts.TabIndex = 3;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕코딩", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(421, 34);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(72, 16);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭체";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 117);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 프로그레스바";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(17, 73);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(485, 27);
            PrgDummy.Step = 1;
            PrgDummy.Style = ProgressBarStyle.Continuous;
            PrgDummy.TabIndex = 1;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(6, 22);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(508, 45);
            TrbDummy.TabIndex = 0;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(12, 257);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(520, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창, 모달리스창";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(421, 42);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(75, 30);
            BtnQuestion.TabIndex = 3;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(271, 42);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(112, 30);
            BtnMsgBox.TabIndex = 2;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(136, 42);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(96, 30);
            BtnModaless.TabIndex = 1;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(17, 42);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(81, 30);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(BtnAddRoot);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Location = new Point(12, 363);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(520, 208);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(261, 164);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(89, 38);
            BtnAddChild.TabIndex = 3;
            BtnAddChild.Text = "자식추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(166, 164);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(89, 38);
            BtnAddRoot.TabIndex = 2;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(291, 23);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(205, 135);
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(6, 23);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(205, 135);
            TrvDummy.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Controls.Add(BtnLoad);
            groupBox5.Controls.Add(PicNormal);
            groupBox5.Location = new Point(562, 32);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(267, 533);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽쳐박스";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(TxtLog);
            groupBox6.Controls.Add(BtnStop);
            groupBox6.Controls.Add(BtnThread);
            groupBox6.Controls.Add(BtnNothread);
            groupBox6.Controls.Add(PrgProcess);
            groupBox6.Location = new Point(15, 267);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(236, 249);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "스레드, 백그라운드워커";
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(6, 35);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(224, 119);
            TxtLog.TabIndex = 4;
            // 
            // BtnStop
            // 
            BtnStop.Enabled = false;
            BtnStop.Location = new Point(156, 214);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 3;
            BtnStop.Text = "중지";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnThread
            // 
            BtnThread.Location = new Point(80, 214);
            BtnThread.Name = "BtnThread";
            BtnThread.Size = new Size(75, 23);
            BtnThread.TabIndex = 2;
            BtnThread.Text = "스레드";
            BtnThread.UseVisualStyleBackColor = true;
            BtnThread.Click += BtnThread_Click;
            // 
            // BtnNothread
            // 
            BtnNothread.Location = new Point(4, 214);
            BtnNothread.Name = "BtnNothread";
            BtnNothread.Size = new Size(75, 23);
            BtnNothread.TabIndex = 1;
            BtnNothread.Text = "노스레드";
            BtnNothread.UseVisualStyleBackColor = true;
            BtnNothread.Click += BtnNothread_Click;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(0, 160);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(230, 23);
            PrgProcess.TabIndex = 0;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(176, 208);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // PicNormal
            // 
            PicNormal.BackColor = SystemColors.Control;
            PicNormal.Location = new Point(15, 41);
            PicNormal.Name = "PicNormal";
            PicNormal.Size = new Size(236, 161);
            PicNormal.TabIndex = 0;
            PicNormal.TabStop = false;
            PicNormal.Click += PicNormal_Click;
            // 
            // GrbEditor
            // 
            GrbEditor.Controls.Add(BtnFileSave);
            GrbEditor.Controls.Add(BtnFileLoad);
            GrbEditor.Controls.Add(RtxEditor);
            GrbEditor.Location = new Point(835, 44);
            GrbEditor.Name = "GrbEditor";
            GrbEditor.Size = new Size(256, 521);
            GrbEditor.TabIndex = 5;
            GrbEditor.TabStop = false;
            GrbEditor.Text = "텍스트 에디터";
            // 
            // BtnFileSave
            // 
            BtnFileSave.Location = new Point(151, 466);
            BtnFileSave.Name = "BtnFileSave";
            BtnFileSave.Size = new Size(99, 38);
            BtnFileSave.TabIndex = 3;
            BtnFileSave.Text = "파일 저장";
            BtnFileSave.UseVisualStyleBackColor = true;
            BtnFileSave.Click += BtnFileSave_Click;
            // 
            // BtnFileLoad
            // 
            BtnFileLoad.Location = new Point(6, 466);
            BtnFileLoad.Name = "BtnFileLoad";
            BtnFileLoad.Size = new Size(103, 38);
            BtnFileLoad.TabIndex = 2;
            BtnFileLoad.Text = "로드";
            BtnFileLoad.UseVisualStyleBackColor = true;
            BtnFileLoad.Click += BtnFileLoad_Click;
            // 
            // RtxEditor
            // 
            RtxEditor.Location = new Point(6, 27);
            RtxEditor.Name = "RtxEditor";
            RtxEditor.Size = new Size(244, 424);
            RtxEditor.TabIndex = 0;
            RtxEditor.Text = "";
            // 
            // BgwProgress
            // 
            BgwProgress.DoWork += BgwProgress_DoWork;
            BgwProgress.ProgressChanged += BgwProgress_ProgressChanged;
            BgwProgress.RunWorkerCompleted += BgwProgress_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1103, 625);
            Controls.Add(GrbEditor);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).EndInit();
            GrbEditor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CheckBox ChkBold;
        private GroupBox groupBox1;
        private ComboBox CboFonts;
        private CheckBox ChkItalic;
        private TextBox TxtSampleText;
        private GroupBox groupBox2;
        private ProgressBar PrgDummy;
        private TrackBar TrbDummy;
        private GroupBox groupBox3;
        private Button BtnModal;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnAddChild;
        private Button BtnAddRoot;
        private GroupBox groupBox5;
        private Button BtnLoad;
        private PictureBox PicNormal;
        private OpenFileDialog DlgOpenImage;
        private GroupBox GrbEditor;
        private RichTextBox RtxEditor;
        private Button BtnFileSave;
        private Button BtnFileLoad;
        private GroupBox groupBox6;
        private TextBox TxtLog;
        private Button BtnStop;
        private Button BtnThread;
        private Button BtnNothread;
        private ProgressBar PrgProcess;
        private System.ComponentModel.BackgroundWorker BgwProgress;
    }
}
