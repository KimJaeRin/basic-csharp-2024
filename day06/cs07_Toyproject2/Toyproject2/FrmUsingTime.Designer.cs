namespace Toyproject2
{
    partial class FrmUsingTime
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
            textBoxUsageTime = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxUsageTime
            // 
            textBoxUsageTime.BackColor = Color.White;
            textBoxUsageTime.Font = new Font("나눔스퀘어라운드 Bold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBoxUsageTime.Location = new Point(60, 61);
            textBoxUsageTime.Name = "textBoxUsageTime";
            textBoxUsageTime.Size = new Size(119, 25);
            textBoxUsageTime.TabIndex = 0;
            textBoxUsageTime.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어라운드 Bold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(65, 41);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "시스템 구동 시간";
            // 
            // FrmUsingTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 131);
            Controls.Add(label1);
            Controls.Add(textBoxUsageTime);
            Name = "FrmUsingTime";
            Resizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Style = MetroFramework.MetroColorStyle.Silver;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsageTime;
        private Label label1;
    }
}