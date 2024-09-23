namespace Project05_8
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
            this.tb_year = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.pbox_tti = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_tti)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(35, 44);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(100, 21);
            this.tb_year.TabIndex = 0;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(187, 42);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "알아보기";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // pbox_tti
            // 
            this.pbox_tti.Location = new System.Drawing.Point(35, 112);
            this.pbox_tti.Name = "pbox_tti";
            this.pbox_tti.Size = new System.Drawing.Size(227, 114);
            this.pbox_tti.TabIndex = 2;
            this.pbox_tti.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 258);
            this.Controls.Add(this.pbox_tti);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tb_year);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_tti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.PictureBox pbox_tti;
    }
}

