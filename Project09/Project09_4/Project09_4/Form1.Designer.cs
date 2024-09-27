namespace Project09_4
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
            this.combo_lang = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.list_lang = new System.Windows.Forms.ListBox();
            this.masktb_brith = new System.Windows.Forms.MaskedTextBox();
            this.masktb_tel = new System.Windows.Forms.MaskedTextBox();
            this.masktb_id = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datepick_brith = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // combo_lang
            // 
            this.combo_lang.FormattingEnabled = true;
            this.combo_lang.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Python",
            "C++",
            "Go",
            "PHP",
            "JSP",
            "ASP.Net"});
            this.combo_lang.Location = new System.Drawing.Point(43, 69);
            this.combo_lang.Name = "combo_lang";
            this.combo_lang.Size = new System.Drawing.Size(121, 20);
            this.combo_lang.TabIndex = 0;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(118, 152);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(45, 23);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = ">>";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2470, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // list_lang
            // 
            this.list_lang.FormattingEnabled = true;
            this.list_lang.ItemHeight = 12;
            this.list_lang.Location = new System.Drawing.Point(191, 69);
            this.list_lang.Name = "list_lang";
            this.list_lang.Size = new System.Drawing.Size(120, 160);
            this.list_lang.TabIndex = 5;
            // 
            // masktb_brith
            // 
            this.masktb_brith.Location = new System.Drawing.Point(425, 141);
            this.masktb_brith.Mask = "0000년 90월 90일";
            this.masktb_brith.Name = "masktb_brith";
            this.masktb_brith.Size = new System.Drawing.Size(100, 21);
            this.masktb_brith.TabIndex = 7;
            this.masktb_brith.ValidatingType = typeof(System.DateTime);
            this.masktb_brith.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masktb_brith_MaskInputRejected);
            // 
            // masktb_tel
            // 
            this.masktb_tel.Location = new System.Drawing.Point(425, 168);
            this.masktb_tel.Mask = "999999-9999999";
            this.masktb_tel.Name = "masktb_tel";
            this.masktb_tel.Size = new System.Drawing.Size(100, 21);
            this.masktb_tel.TabIndex = 8;
            // 
            // masktb_id
            // 
            this.masktb_id.Location = new System.Drawing.Point(425, 195);
            this.masktb_id.Name = "masktb_id";
            this.masktb_id.Size = new System.Drawing.Size(100, 21);
            this.masktb_id.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "출생년월일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "주민번호";
            // 
            // datepick_brith
            // 
            this.datepick_brith.Location = new System.Drawing.Point(339, 69);
            this.datepick_brith.Name = "datepick_brith";
            this.datepick_brith.Size = new System.Drawing.Size(200, 21);
            this.datepick_brith.TabIndex = 13;
            this.datepick_brith.ValueChanged += new System.EventHandler(this.datepick_brith_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 355);
            this.Controls.Add(this.datepick_brith);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masktb_id);
            this.Controls.Add(this.masktb_tel);
            this.Controls.Add(this.masktb_brith);
            this.Controls.Add(this.list_lang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.combo_lang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_lang;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_lang;
        private System.Windows.Forms.MaskedTextBox masktb_brith;
        private System.Windows.Forms.MaskedTextBox masktb_tel;
        private System.Windows.Forms.MaskedTextBox masktb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepick_brith;
    }
}

