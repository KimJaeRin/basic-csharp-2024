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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsingTime));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어라운드 Bold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(5, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // FrmUsingTime
            // 
            AutoScaleDimensions = new SizeF(4F, 8F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 136);
            Controls.Add(label1);
            Font = new Font("나눔스퀘어라운드 Bold", 5.24999952F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmUsingTime";
            Padding = new Padding(11, 60, 11, 10);
            SizeGripStyle = SizeGripStyle.Hide;
            Style = MetroFramework.MetroColorStyle.Silver;
            Text = "사용 시간";
            Load += FrmUsingTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}