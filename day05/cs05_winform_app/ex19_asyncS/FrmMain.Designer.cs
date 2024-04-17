namespace ex19_asyncS
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
            groupBox1 = new GroupBox();
            BtnCancel = new Button();
            BtnAsyncCopy = new Button();
            BtnSyncCopy = new Button();
            PrgCopy = new ProgressBar();
            BtnSetTarget = new Button();
            BtnGetSource = new Button();
            TxtTarget = new TextBox();
            TxtSource = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnCancel);
            groupBox1.Controls.Add(BtnAsyncCopy);
            groupBox1.Controls.Add(BtnSyncCopy);
            groupBox1.Controls.Add(PrgCopy);
            groupBox1.Controls.Add(BtnSetTarget);
            groupBox1.Controls.Add(BtnGetSource);
            groupBox1.Controls.Add(TxtTarget);
            groupBox1.Controls.Add(TxtSource);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "비동기 전송";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(222, 111);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(97, 45);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnAsyncCopy
            // 
            BtnAsyncCopy.Location = new Point(123, 111);
            BtnAsyncCopy.Name = "BtnAsyncCopy";
            BtnAsyncCopy.Size = new Size(93, 45);
            BtnAsyncCopy.TabIndex = 8;
            BtnAsyncCopy.Text = "비동기화 복사";
            BtnAsyncCopy.UseVisualStyleBackColor = true;
            BtnAsyncCopy.Click += BtnAsyncCopy_Click;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(25, 111);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(92, 45);
            BtnSyncCopy.TabIndex = 7;
            BtnSyncCopy.Text = "동기화 복사";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            BtnSyncCopy.Click += BtnSyncCopy_Click;
            // 
            // PrgCopy
            // 
            PrgCopy.Location = new Point(25, 162);
            PrgCopy.Name = "PrgCopy";
            PrgCopy.Size = new Size(294, 23);
            PrgCopy.TabIndex = 6;
            // 
            // BtnSetTarget
            // 
            BtnSetTarget.Location = new Point(287, 82);
            BtnSetTarget.Name = "BtnSetTarget";
            BtnSetTarget.Size = new Size(32, 23);
            BtnSetTarget.TabIndex = 5;
            BtnSetTarget.Text = "...";
            BtnSetTarget.UseVisualStyleBackColor = true;
            BtnSetTarget.Click += BtnSetTarget_Click;
            // 
            // BtnGetSource
            // 
            BtnGetSource.Location = new Point(287, 56);
            BtnGetSource.Name = "BtnGetSource";
            BtnGetSource.Size = new Size(32, 23);
            BtnGetSource.TabIndex = 4;
            BtnGetSource.Text = "...";
            BtnGetSource.UseVisualStyleBackColor = true;
            BtnGetSource.Click += BtnGetSource_Click;
            // 
            // TxtTarget
            // 
            TxtTarget.Location = new Point(69, 82);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.ReadOnly = true;
            TxtTarget.Size = new Size(216, 23);
            TxtTarget.TabIndex = 3;
            // 
            // TxtSource
            // 
            TxtSource.Location = new Point(69, 53);
            TxtSource.Name = "TxtSource";
            TxtSource.ReadOnly = true;
            TxtSource.Size = new Size(212, 23);
            TxtSource.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 90);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "타겟 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 56);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "소스 :";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 247);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "비동기 파일복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCancel;
        private Button BtnAsyncCopy;
        private Button BtnSyncCopy;
        private ProgressBar PrgCopy;
        private Button BtnSetTarget;
        private Button BtnGetSource;
        private TextBox TxtTarget;
        private TextBox TxtSource;
        private Label label2;
        private Label label1;
    }
}
