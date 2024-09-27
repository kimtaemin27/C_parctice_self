namespace Project09_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_action = new System.Windows.Forms.TextBox();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(125, 49);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 21);
            this.tb_type.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "버튼 종류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "동작";
            // 
            // tb_action
            // 
            this.tb_action.Location = new System.Drawing.Point(125, 85);
            this.tb_action.Name = "tb_action";
            this.tb_action.Size = new System.Drawing.Size(100, 21);
            this.tb_action.TabIndex = 3;
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(38, 255);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(100, 21);
            this.tb_x.TabIndex = 4;
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(170, 255);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(100, 21);
            this.tb_y.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "x좌표";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "y좌표";
            // 
            // pb_image
            // 
            this.pb_image.Image = ((System.Drawing.Image)(resources.GetObject("pb_image.Image")));
            this.pb_image.Location = new System.Drawing.Point(331, 30);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(219, 258);
            this.pb_image.TabIndex = 8;
            this.pb_image.TabStop = false;
            this.pb_image.DoubleClick += new System.EventHandler(this.pb_image_DoubleClick);
            this.pb_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 320);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.tb_action);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_type);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_action;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_image;
    }
}

