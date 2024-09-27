namespace Project09_3
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
            this.gbox_car = new System.Windows.Forms.GroupBox();
            this.cb_benz = new System.Windows.Forms.CheckBox();
            this.cb_bmw = new System.Windows.Forms.CheckBox();
            this.cb_audi = new System.Windows.Forms.CheckBox();
            this.cb_porsche = new System.Windows.Forms.CheckBox();
            this.gbox_tang = new System.Windows.Forms.GroupBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.rich_result = new System.Windows.Forms.RichTextBox();
            this.rdo_pour = new System.Windows.Forms.RadioButton();
            this.rdo_pick = new System.Windows.Forms.RadioButton();
            this.rdo_raw = new System.Windows.Forms.RadioButton();
            this.gbox_car.SuspendLayout();
            this.gbox_tang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_car
            // 
            this.gbox_car.Controls.Add(this.cb_porsche);
            this.gbox_car.Controls.Add(this.cb_audi);
            this.gbox_car.Controls.Add(this.cb_bmw);
            this.gbox_car.Controls.Add(this.cb_benz);
            this.gbox_car.Location = new System.Drawing.Point(61, 65);
            this.gbox_car.Name = "gbox_car";
            this.gbox_car.Size = new System.Drawing.Size(107, 156);
            this.gbox_car.TabIndex = 0;
            this.gbox_car.TabStop = false;
            this.gbox_car.Text = "좋아하는 자동차";
            // 
            // cb_benz
            // 
            this.cb_benz.AutoSize = true;
            this.cb_benz.Location = new System.Drawing.Point(7, 34);
            this.cb_benz.Name = "cb_benz";
            this.cb_benz.Size = new System.Drawing.Size(52, 16);
            this.cb_benz.TabIndex = 0;
            this.cb_benz.Text = "benz";
            this.cb_benz.UseVisualStyleBackColor = true;
            // 
            // cb_bmw
            // 
            this.cb_bmw.AutoSize = true;
            this.cb_bmw.Location = new System.Drawing.Point(6, 68);
            this.cb_bmw.Name = "cb_bmw";
            this.cb_bmw.Size = new System.Drawing.Size(52, 16);
            this.cb_bmw.TabIndex = 1;
            this.cb_bmw.Text = "bmw";
            this.cb_bmw.UseVisualStyleBackColor = true;
            // 
            // cb_audi
            // 
            this.cb_audi.AutoSize = true;
            this.cb_audi.Location = new System.Drawing.Point(6, 100);
            this.cb_audi.Name = "cb_audi";
            this.cb_audi.Size = new System.Drawing.Size(48, 16);
            this.cb_audi.TabIndex = 2;
            this.cb_audi.Text = "audi";
            this.cb_audi.UseVisualStyleBackColor = true;
            // 
            // cb_porsche
            // 
            this.cb_porsche.AutoSize = true;
            this.cb_porsche.Location = new System.Drawing.Point(6, 134);
            this.cb_porsche.Name = "cb_porsche";
            this.cb_porsche.Size = new System.Drawing.Size(70, 16);
            this.cb_porsche.TabIndex = 3;
            this.cb_porsche.Text = "porsche";
            this.cb_porsche.UseVisualStyleBackColor = true;
            // 
            // gbox_tang
            // 
            this.gbox_tang.Controls.Add(this.rdo_raw);
            this.gbox_tang.Controls.Add(this.rdo_pick);
            this.gbox_tang.Controls.Add(this.rdo_pour);
            this.gbox_tang.Location = new System.Drawing.Point(248, 65);
            this.gbox_tang.Name = "gbox_tang";
            this.gbox_tang.Size = new System.Drawing.Size(118, 150);
            this.gbox_tang.TabIndex = 1;
            this.gbox_tang.TabStop = false;
            this.gbox_tang.Text = "탕수육 먹는 방법";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(168, 263);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "결정하기";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // rich_result
            // 
            this.rich_result.Location = new System.Drawing.Point(102, 292);
            this.rich_result.Name = "rich_result";
            this.rich_result.Size = new System.Drawing.Size(215, 96);
            this.rich_result.TabIndex = 3;
            this.rich_result.Text = "#좋아하는 자동차와 탕수육 먹는법#";
            // 
            // rdo_pour
            // 
            this.rdo_pour.AutoSize = true;
            this.rdo_pour.Location = new System.Drawing.Point(7, 47);
            this.rdo_pour.Name = "rdo_pour";
            this.rdo_pour.Size = new System.Drawing.Size(71, 16);
            this.rdo_pour.TabIndex = 0;
            this.rdo_pour.TabStop = true;
            this.rdo_pour.Text = "부어먹기";
            this.rdo_pour.UseVisualStyleBackColor = true;
            // 
            // rdo_pick
            // 
            this.rdo_pick.AutoSize = true;
            this.rdo_pick.Location = new System.Drawing.Point(7, 89);
            this.rdo_pick.Name = "rdo_pick";
            this.rdo_pick.Size = new System.Drawing.Size(71, 16);
            this.rdo_pick.TabIndex = 1;
            this.rdo_pick.TabStop = true;
            this.rdo_pick.Text = "찍어먹기";
            this.rdo_pick.UseVisualStyleBackColor = true;
            // 
            // rdo_raw
            // 
            this.rdo_raw.AutoSize = true;
            this.rdo_raw.Location = new System.Drawing.Point(7, 128);
            this.rdo_raw.Name = "rdo_raw";
            this.rdo_raw.Size = new System.Drawing.Size(71, 16);
            this.rdo_raw.TabIndex = 2;
            this.rdo_raw.TabStop = true;
            this.rdo_raw.Text = "그냥먹기";
            this.rdo_raw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 422);
            this.Controls.Add(this.rich_result);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.gbox_tang);
            this.Controls.Add(this.gbox_car);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbox_car.ResumeLayout(false);
            this.gbox_car.PerformLayout();
            this.gbox_tang.ResumeLayout(false);
            this.gbox_tang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_car;
        private System.Windows.Forms.CheckBox cb_benz;
        private System.Windows.Forms.CheckBox cb_porsche;
        private System.Windows.Forms.CheckBox cb_audi;
        private System.Windows.Forms.CheckBox cb_bmw;
        private System.Windows.Forms.GroupBox gbox_tang;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.RichTextBox rich_result;
        private System.Windows.Forms.RadioButton rdo_raw;
        private System.Windows.Forms.RadioButton rdo_pick;
        private System.Windows.Forms.RadioButton rdo_pour;
    }
}

