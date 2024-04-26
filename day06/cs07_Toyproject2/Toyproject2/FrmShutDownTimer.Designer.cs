namespace Toyproject2
{
    partial class FrmShutDownTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownHours = new NumericUpDown();
            numericUpDownMinutes = new NumericUpDown();
            numericUpDownSeconds = new NumericUpDown();
            BtnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnCancle = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(22, 73);
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(38, 21);
            numericUpDownHours.TabIndex = 0;
            // 
            // numericUpDownMinutes
            // 
            numericUpDownMinutes.Location = new Point(95, 73);
            numericUpDownMinutes.Name = "numericUpDownMinutes";
            numericUpDownMinutes.Size = new Size(38, 21);
            numericUpDownMinutes.TabIndex = 0;
            // 
            // numericUpDownSeconds
            // 
            numericUpDownSeconds.Location = new Point(168, 73);
            numericUpDownSeconds.Name = "numericUpDownSeconds";
            numericUpDownSeconds.Size = new Size(38, 21);
            numericUpDownSeconds.TabIndex = 0;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(43, 138);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(75, 25);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += buttonStartShutdown_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어라운드 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(66, 76);
            label1.Name = "label1";
            label1.Size = new Size(23, 18);
            label1.TabIndex = 2;
            label1.Text = "시";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("나눔스퀘어라운드 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(139, 76);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 3;
            label2.Text = "분";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔스퀘어라운드 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(212, 76);
            label3.Name = "label3";
            label3.Size = new Size(23, 18);
            label3.TabIndex = 4;
            label3.Text = "초";
            // 
            // BtnCancle
            // 
            BtnCancle.Location = new Point(123, 138);
            BtnCancle.Name = "BtnCancle";
            BtnCancle.Size = new Size(75, 25);
            BtnCancle.TabIndex = 5;
            BtnCancle.Text = "중지";
            BtnCancle.UseVisualStyleBackColor = true;
            BtnCancle.Click += BtnCancle_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 21);
            textBox1.TabIndex = 6;
            // 
            // FrmShutDownTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 188);
            Controls.Add(textBox1);
            Controls.Add(BtnCancle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnStart);
            Controls.Add(numericUpDownSeconds);
            Controls.Add(numericUpDownMinutes);
            Controls.Add(numericUpDownHours);
            Font = new Font("나눔스퀘어라운드 Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Name = "FrmShutDownTimer";
            Padding = new Padding(20, 60, 20, 17);
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Silver;
            Text = "종료 타이머";
            Load += FrmShutDownTimer_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownHours;
        private NumericUpDown numericUpDownMinutes;
        private NumericUpDown numericUpDownSeconds;
        private Button BtnStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnCancle;
        private TextBox textBox1;
    }
}