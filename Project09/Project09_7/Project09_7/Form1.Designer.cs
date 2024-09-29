namespace Project09_7
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
            this.cb_ctrl = new System.Windows.Forms.CheckBox();
            this.cb_alt = new System.Windows.Forms.CheckBox();
            this.cb_shift = new System.Windows.Forms.CheckBox();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_ctrl
            // 
            this.cb_ctrl.AutoSize = true;
            this.cb_ctrl.Location = new System.Drawing.Point(61, 66);
            this.cb_ctrl.Name = "cb_ctrl";
            this.cb_ctrl.Size = new System.Drawing.Size(43, 16);
            this.cb_ctrl.TabIndex = 0;
            this.cb_ctrl.Text = "Ctrl";
            this.cb_ctrl.UseVisualStyleBackColor = true;
            // 
            // cb_alt
            // 
            this.cb_alt.AutoSize = true;
            this.cb_alt.Location = new System.Drawing.Point(61, 103);
            this.cb_alt.Name = "cb_alt";
            this.cb_alt.Size = new System.Drawing.Size(38, 16);
            this.cb_alt.TabIndex = 1;
            this.cb_alt.Text = "Alt";
            this.cb_alt.UseVisualStyleBackColor = true;
            // 
            // cb_shift
            // 
            this.cb_shift.AutoSize = true;
            this.cb_shift.Location = new System.Drawing.Point(61, 143);
            this.cb_shift.Name = "cb_shift";
            this.cb_shift.Size = new System.Drawing.Size(48, 16);
            this.cb_shift.TabIndex = 2;
            this.cb_shift.Text = "Shift";
            this.cb_shift.UseVisualStyleBackColor = true;
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(156, 123);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(100, 21);
            this.tb_key.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "눌린 키";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.cb_shift);
            this.Controls.Add(this.cb_alt);
            this.Controls.Add(this.cb_ctrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_ctrl;
        private System.Windows.Forms.CheckBox cb_alt;
        private System.Windows.Forms.CheckBox cb_shift;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Label label1;
    }
}

