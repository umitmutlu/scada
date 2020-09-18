namespace scada_bitirme
{
    partial class MySecondCustmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_users = new System.Windows.Forms.ComboBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_izleyici = new System.Windows.Forms.RadioButton();
            this.radioButton_kontrol = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(408, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 869);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_users);
            this.groupBox3.Controls.Add(this.button_kaydet);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(340, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 174);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı Yetkileri";
            // 
            // comboBox_users
            // 
            this.comboBox_users.FormattingEnabled = true;
            this.comboBox_users.Location = new System.Drawing.Point(6, 19);
            this.comboBox_users.Name = "comboBox_users";
            this.comboBox_users.Size = new System.Drawing.Size(200, 21);
            this.comboBox_users.TabIndex = 0;
            this.comboBox_users.SelectedIndexChanged += new System.EventHandler(this.ComboBox_users_SelectedIndexChanged);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(6, 132);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(200, 34);
            this.button_kaydet.TabIndex = 4;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.Button_kaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_izleyici);
            this.groupBox2.Controls.Add(this.radioButton_kontrol);
            this.groupBox2.Location = new System.Drawing.Point(6, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yetki Türü";
            // 
            // radioButton_izleyici
            // 
            this.radioButton_izleyici.AutoSize = true;
            this.radioButton_izleyici.Location = new System.Drawing.Point(6, 19);
            this.radioButton_izleyici.Name = "radioButton_izleyici";
            this.radioButton_izleyici.Size = new System.Drawing.Size(56, 17);
            this.radioButton_izleyici.TabIndex = 1;
            this.radioButton_izleyici.Text = "İzleyici";
            this.radioButton_izleyici.UseVisualStyleBackColor = true;
            // 
            // radioButton_kontrol
            // 
            this.radioButton_kontrol.AutoSize = true;
            this.radioButton_kontrol.Location = new System.Drawing.Point(6, 51);
            this.radioButton_kontrol.Name = "radioButton_kontrol";
            this.radioButton_kontrol.Size = new System.Drawing.Size(104, 17);
            this.radioButton_kontrol.TabIndex = 2;
            this.radioButton_kontrol.Text = "Sistem Yöneticisi";
            this.radioButton_kontrol.UseVisualStyleBackColor = true;
            // 
            // MySecondCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.groupBox1);
            this.Name = "MySecondCustmControl";
            this.Size = new System.Drawing.Size(1711, 875);
            this.Load += new System.EventHandler(this.MySecondCustmControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_users;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_izleyici;
        private System.Windows.Forms.RadioButton radioButton_kontrol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
