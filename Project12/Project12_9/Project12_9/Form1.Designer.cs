﻿namespace Project12_9
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
            this.btn_init = new System.Windows.Forms.Button();
            this.rdo_line = new System.Windows.Forms.RadioButton();
            this.rdo_rect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(13, 43);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "초기화";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // rdo_line
            // 
            this.rdo_line.AutoSize = true;
            this.rdo_line.Location = new System.Drawing.Point(13, 121);
            this.rdo_line.Name = "rdo_line";
            this.rdo_line.Size = new System.Drawing.Size(35, 16);
            this.rdo_line.TabIndex = 1;
            this.rdo_line.TabStop = true;
            this.rdo_line.Text = "선";
            this.rdo_line.UseVisualStyleBackColor = true;
            // 
            // rdo_rect
            // 
            this.rdo_rect.AutoSize = true;
            this.rdo_rect.Location = new System.Drawing.Point(81, 121);
            this.rdo_rect.Name = "rdo_rect";
            this.rdo_rect.Size = new System.Drawing.Size(47, 16);
            this.rdo_rect.TabIndex = 2;
            this.rdo_rect.TabStop = true;
            this.rdo_rect.Text = "사각";
            this.rdo_rect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 378);
            this.Controls.Add(this.rdo_rect);
            this.Controls.Add(this.rdo_line);
            this.Controls.Add(this.btn_init);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.RadioButton rdo_line;
        private System.Windows.Forms.RadioButton rdo_rect;
    }
}
