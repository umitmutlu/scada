namespace scada_bitirme
{
    partial class KuyuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuyuForm));
            this.timer_forGETdata = new System.Windows.Forms.Timer(this.components);
            this.label_kazan1 = new System.Windows.Forms.Label();
            this.label_kuyu1 = new System.Windows.Forms.Label();
            this.label_kazan2 = new System.Windows.Forms.Label();
            this.button_hepsi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_kuyu1 = new System.Windows.Forms.Button();
            this.button_kazan2 = new System.Windows.Forms.Button();
            this.button_kazan1 = new System.Windows.Forms.Button();
            this.groupBox_kazan1 = new System.Windows.Forms.GroupBox();
            this.lblMusluk_kazan1 = new System.Windows.Forms.Label();
            this.lblSu_kazan1 = new System.Windows.Forms.Label();
            this.lblMuslukDot_kazan1 = new System.Windows.Forms.Label();
            this.groupBox_kazan2 = new System.Windows.Forms.GroupBox();
            this.lblMusluk_kazan2 = new System.Windows.Forms.Label();
            this.lblSu_kazan2 = new System.Windows.Forms.Label();
            this.lblMuslukDot_kazan2 = new System.Windows.Forms.Label();
            this.groupBox_kuyu1 = new System.Windows.Forms.GroupBox();
            this.lblMusluk2_kuyu1 = new System.Windows.Forms.Label();
            this.lblMusluk2Dot_kuyu1 = new System.Windows.Forms.Label();
            this.lblMusluk1_kuyu1 = new System.Windows.Forms.Label();
            this.lblSu_kuyu1 = new System.Windows.Forms.Label();
            this.lblMusluk1Dot_kuyu1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picture_kuyuMusluk = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.picture_rightKazan = new System.Windows.Forms.PictureBox();
            this.picture_leftKazan = new System.Windows.Forms.PictureBox();
            this.picture_leftMusluk = new System.Windows.Forms.PictureBox();
            this.picture_leftSu = new System.Windows.Forms.PictureBox();
            this.picture_rightMusluk = new System.Windows.Forms.PictureBox();
            this.picture_rightSu = new System.Windows.Forms.PictureBox();
            this.picture_kuyu = new System.Windows.Forms.PictureBox();
            this.picture_kuyuDolu = new System.Windows.Forms.PictureBox();
            this.picture_boru1 = new System.Windows.Forms.PictureBox();
            this.serialPort_Arduino = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_kazan1.SuspendLayout();
            this.groupBox_kazan2.SuspendLayout();
            this.groupBox_kuyu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kuyuMusluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rightKazan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_leftKazan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_leftMusluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_leftSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rightMusluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rightSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kuyu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kuyuDolu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_boru1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_forGETdata
            // 
            this.timer_forGETdata.Tick += new System.EventHandler(this.Timer_forGETdata);
            // 
            // label_kazan1
            // 
            this.label_kazan1.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kazan1.Location = new System.Drawing.Point(62, 751);
            this.label_kazan1.Name = "label_kazan1";
            this.label_kazan1.Size = new System.Drawing.Size(239, 50);
            this.label_kazan1.TabIndex = 9;
            this.label_kazan1.Text = "Kazan1";
            this.label_kazan1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_kuyu1
            // 
            this.label_kuyu1.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kuyu1.Location = new System.Drawing.Point(441, 218);
            this.label_kuyu1.Name = "label_kuyu1";
            this.label_kuyu1.Size = new System.Drawing.Size(807, 50);
            this.label_kuyu1.TabIndex = 10;
            this.label_kuyu1.Text = "Kuyu1";
            this.label_kuyu1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_kazan2
            // 
            this.label_kazan2.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kazan2.Location = new System.Drawing.Point(1397, 751);
            this.label_kazan2.Name = "label_kazan2";
            this.label_kazan2.Size = new System.Drawing.Size(239, 50);
            this.label_kazan2.TabIndex = 11;
            this.label_kazan2.Text = "Kazan2";
            this.label_kazan2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_hepsi
            // 
            this.button_hepsi.AutoSize = true;
            this.button_hepsi.Location = new System.Drawing.Point(8, 144);
            this.button_hepsi.Name = "button_hepsi";
            this.button_hepsi.Size = new System.Drawing.Size(1656, 40);
            this.button_hepsi.TabIndex = 12;
            this.button_hepsi.Text = "Veri Kaydı (Hepsi)";
            this.button_hepsi.UseVisualStyleBackColor = true;
            this.button_hepsi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_kuyu1);
            this.groupBox1.Controls.Add(this.button_kazan2);
            this.groupBox1.Controls.Add(this.button_kazan1);
            this.groupBox1.Controls.Add(this.button_hepsi);
            this.groupBox1.Controls.Add(this.groupBox_kazan1);
            this.groupBox1.Controls.Add(this.groupBox_kazan2);
            this.groupBox1.Controls.Add(this.groupBox_kuyu1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1671, 190);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gösterge Paneli";
            // 
            // button_kuyu1
            // 
            this.button_kuyu1.AutoSize = true;
            this.button_kuyu1.Location = new System.Drawing.Point(436, 100);
            this.button_kuyu1.Name = "button_kuyu1";
            this.button_kuyu1.Size = new System.Drawing.Size(800, 40);
            this.button_kuyu1.TabIndex = 16;
            this.button_kuyu1.Text = "Veri Kaydı (KUYU1)";
            this.button_kuyu1.UseVisualStyleBackColor = true;
            this.button_kuyu1.Click += new System.EventHandler(this.Button_kuyu1_Click);
            // 
            // button_kazan2
            // 
            this.button_kazan2.Location = new System.Drawing.Point(1242, 100);
            this.button_kazan2.Name = "button_kazan2";
            this.button_kazan2.Size = new System.Drawing.Size(422, 40);
            this.button_kazan2.TabIndex = 15;
            this.button_kazan2.Text = "Veri Kaydı";
            this.button_kazan2.UseVisualStyleBackColor = true;
            this.button_kazan2.Click += new System.EventHandler(this.Button_kazan2_Click);
            // 
            // button_kazan1
            // 
            this.button_kazan1.Location = new System.Drawing.Point(8, 100);
            this.button_kazan1.Name = "button_kazan1";
            this.button_kazan1.Size = new System.Drawing.Size(422, 40);
            this.button_kazan1.TabIndex = 14;
            this.button_kazan1.Text = "Veri Kaydı";
            this.button_kazan1.UseVisualStyleBackColor = true;
            this.button_kazan1.Click += new System.EventHandler(this.Button_kazan1_Click);
            // 
            // groupBox_kazan1
            // 
            this.groupBox_kazan1.Controls.Add(this.lblMusluk_kazan1);
            this.groupBox_kazan1.Controls.Add(this.lblSu_kazan1);
            this.groupBox_kazan1.Controls.Add(this.lblMuslukDot_kazan1);
            this.groupBox_kazan1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_kazan1.Location = new System.Drawing.Point(8, 19);
            this.groupBox_kazan1.Name = "groupBox_kazan1";
            this.groupBox_kazan1.Size = new System.Drawing.Size(422, 75);
            this.groupBox_kazan1.TabIndex = 14;
            this.groupBox_kazan1.TabStop = false;
            this.groupBox_kazan1.Text = "KAZAN1";
            // 
            // lblMusluk_kazan1
            // 
            this.lblMusluk_kazan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMusluk_kazan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusluk_kazan1.Location = new System.Drawing.Point(227, 16);
            this.lblMusluk_kazan1.Name = "lblMusluk_kazan1";
            this.lblMusluk_kazan1.Size = new System.Drawing.Size(189, 56);
            this.lblMusluk_kazan1.TabIndex = 14;
            this.lblMusluk_kazan1.Text = "Musluk : NaN";
            this.lblMusluk_kazan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSu_kazan1
            // 
            this.lblSu_kazan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSu_kazan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu_kazan1.Location = new System.Drawing.Point(6, 16);
            this.lblSu_kazan1.Name = "lblSu_kazan1";
            this.lblSu_kazan1.Size = new System.Drawing.Size(189, 56);
            this.lblSu_kazan1.TabIndex = 0;
            this.lblSu_kazan1.Text = "Su Seviyesi : NaN";
            this.lblSu_kazan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMuslukDot_kazan1
            // 
            this.lblMuslukDot_kazan1.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMuslukDot_kazan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuslukDot_kazan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuslukDot_kazan1.Location = new System.Drawing.Point(201, 16);
            this.lblMuslukDot_kazan1.Name = "lblMuslukDot_kazan1";
            this.lblMuslukDot_kazan1.Size = new System.Drawing.Size(20, 56);
            this.lblMuslukDot_kazan1.TabIndex = 1;
            this.lblMuslukDot_kazan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_kazan2
            // 
            this.groupBox_kazan2.Controls.Add(this.lblMusluk_kazan2);
            this.groupBox_kazan2.Controls.Add(this.lblSu_kazan2);
            this.groupBox_kazan2.Controls.Add(this.lblMuslukDot_kazan2);
            this.groupBox_kazan2.Location = new System.Drawing.Point(1242, 19);
            this.groupBox_kazan2.Name = "groupBox_kazan2";
            this.groupBox_kazan2.Size = new System.Drawing.Size(422, 75);
            this.groupBox_kazan2.TabIndex = 15;
            this.groupBox_kazan2.TabStop = false;
            this.groupBox_kazan2.Text = "KAZAN2";
            // 
            // lblMusluk_kazan2
            // 
            this.lblMusluk_kazan2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMusluk_kazan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusluk_kazan2.Location = new System.Drawing.Point(227, 16);
            this.lblMusluk_kazan2.Name = "lblMusluk_kazan2";
            this.lblMusluk_kazan2.Size = new System.Drawing.Size(189, 56);
            this.lblMusluk_kazan2.TabIndex = 17;
            this.lblMusluk_kazan2.Text = "Musluk : NaN";
            this.lblMusluk_kazan2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSu_kazan2
            // 
            this.lblSu_kazan2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSu_kazan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu_kazan2.Location = new System.Drawing.Point(6, 16);
            this.lblSu_kazan2.Name = "lblSu_kazan2";
            this.lblSu_kazan2.Size = new System.Drawing.Size(189, 56);
            this.lblSu_kazan2.TabIndex = 15;
            this.lblSu_kazan2.Text = "Su Seviyesi : NaN";
            this.lblSu_kazan2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMuslukDot_kazan2
            // 
            this.lblMuslukDot_kazan2.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMuslukDot_kazan2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuslukDot_kazan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuslukDot_kazan2.Location = new System.Drawing.Point(201, 16);
            this.lblMuslukDot_kazan2.Name = "lblMuslukDot_kazan2";
            this.lblMuslukDot_kazan2.Size = new System.Drawing.Size(20, 56);
            this.lblMuslukDot_kazan2.TabIndex = 16;
            this.lblMuslukDot_kazan2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_kuyu1
            // 
            this.groupBox_kuyu1.Controls.Add(this.lblMusluk2_kuyu1);
            this.groupBox_kuyu1.Controls.Add(this.lblMusluk2Dot_kuyu1);
            this.groupBox_kuyu1.Controls.Add(this.lblMusluk1_kuyu1);
            this.groupBox_kuyu1.Controls.Add(this.lblSu_kuyu1);
            this.groupBox_kuyu1.Controls.Add(this.lblMusluk1Dot_kuyu1);
            this.groupBox_kuyu1.Location = new System.Drawing.Point(436, 19);
            this.groupBox_kuyu1.Name = "groupBox_kuyu1";
            this.groupBox_kuyu1.Size = new System.Drawing.Size(800, 75);
            this.groupBox_kuyu1.TabIndex = 15;
            this.groupBox_kuyu1.TabStop = false;
            this.groupBox_kuyu1.Text = "KUYU1";
            // 
            // lblMusluk2_kuyu1
            // 
            this.lblMusluk2_kuyu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMusluk2_kuyu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusluk2_kuyu1.Location = new System.Drawing.Point(579, 16);
            this.lblMusluk2_kuyu1.Name = "lblMusluk2_kuyu1";
            this.lblMusluk2_kuyu1.Size = new System.Drawing.Size(215, 56);
            this.lblMusluk2_kuyu1.TabIndex = 19;
            this.lblMusluk2_kuyu1.Text = "Musluk (Kazan2): NaN";
            this.lblMusluk2_kuyu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusluk2Dot_kuyu1
            // 
            this.lblMusluk2Dot_kuyu1.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMusluk2Dot_kuyu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMusluk2Dot_kuyu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusluk2Dot_kuyu1.Location = new System.Drawing.Point(553, 16);
            this.lblMusluk2Dot_kuyu1.Name = "lblMusluk2Dot_kuyu1";
            this.lblMusluk2Dot_kuyu1.Size = new System.Drawing.Size(20, 56);
            this.lblMusluk2Dot_kuyu1.TabIndex = 18;
            this.lblMusluk2Dot_kuyu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusluk1_kuyu1
            // 
            this.lblMusluk1_kuyu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMusluk1_kuyu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusluk1_kuyu1.Location = new System.Drawing.Point(6, 16);
            this.lblMusluk1_kuyu1.Name = "lblMusluk1_kuyu1";
            this.lblMusluk1_kuyu1.Size = new System.Drawing.Size(215, 56);
            this.lblMusluk1_kuyu1.TabIndex = 17;
            this.lblMusluk1_kuyu1.Text = "Musluk (Kazan1) : NaN";
            this.lblMusluk1_kuyu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSu_kuyu1
            // 
            this.lblSu_kuyu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSu_kuyu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu_kuyu1.Location = new System.Drawing.Point(253, 16);
            this.lblSu_kuyu1.Name = "lblSu_kuyu1";
            this.lblSu_kuyu1.Size = new System.Drawing.Size(294, 56);
            this.lblSu_kuyu1.TabIndex = 15;
            this.lblSu_kuyu1.Text = "Su Seviyesi : NaN";
            this.lblSu_kuyu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusluk1Dot_kuyu1
            // 
            this.lblMusluk1Dot_kuyu1.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMusluk1Dot_kuyu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMusluk1Dot_kuyu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusluk1Dot_kuyu1.Location = new System.Drawing.Point(227, 16);
            this.lblMusluk1Dot_kuyu1.Name = "lblMusluk1Dot_kuyu1";
            this.lblMusluk1Dot_kuyu1.Size = new System.Drawing.Size(20, 56);
            this.lblMusluk1Dot_kuyu1.TabIndex = 16;
            this.lblMusluk1Dot_kuyu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // picture_kuyuMusluk
            // 
            this.picture_kuyuMusluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_kuyuMusluk.Image = global::scada_bitirme.Properties.Resources.muslukBos;
            this.picture_kuyuMusluk.Location = new System.Drawing.Point(490, 721);
            this.picture_kuyuMusluk.Name = "picture_kuyuMusluk";
            this.picture_kuyuMusluk.Size = new System.Drawing.Size(64, 53);
            this.picture_kuyuMusluk.TabIndex = 15;
            this.picture_kuyuMusluk.TabStop = false;
            this.picture_kuyuMusluk.Click += new System.EventHandler(this.Picture_kuyuMusluk_Click);
            // 
            // button_start
            // 
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button_start.Image = global::scada_bitirme.Properties.Resources.icons8_start_64;
            this.button_start.Location = new System.Drawing.Point(813, 741);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(70, 70);
            this.button_start.TabIndex = 6;
            this.button_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // picture_rightKazan
            // 
            this.picture_rightKazan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_rightKazan.Image = global::scada_bitirme.Properties.Resources.rightKazan0;
            this.picture_rightKazan.Location = new System.Drawing.Point(62, 457);
            this.picture_rightKazan.Name = "picture_rightKazan";
            this.picture_rightKazan.Size = new System.Drawing.Size(239, 280);
            this.picture_rightKazan.TabIndex = 0;
            this.picture_rightKazan.TabStop = false;
            this.picture_rightKazan.Click += new System.EventHandler(this.Picture_rightKazan_Click);
            // 
            // picture_leftKazan
            // 
            this.picture_leftKazan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_leftKazan.Image = global::scada_bitirme.Properties.Resources.leftKazan0;
            this.picture_leftKazan.Location = new System.Drawing.Point(1397, 457);
            this.picture_leftKazan.Name = "picture_leftKazan";
            this.picture_leftKazan.Size = new System.Drawing.Size(239, 280);
            this.picture_leftKazan.TabIndex = 3;
            this.picture_leftKazan.TabStop = false;
            this.picture_leftKazan.Click += new System.EventHandler(this.Picture_leftKazan_Click);
            // 
            // picture_leftMusluk
            // 
            this.picture_leftMusluk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_leftMusluk.Image = global::scada_bitirme.Properties.Resources.leftMusluk;
            this.picture_leftMusluk.Location = new System.Drawing.Point(1323, 676);
            this.picture_leftMusluk.Name = "picture_leftMusluk";
            this.picture_leftMusluk.Size = new System.Drawing.Size(77, 42);
            this.picture_leftMusluk.TabIndex = 4;
            this.picture_leftMusluk.TabStop = false;
            // 
            // picture_leftSu
            // 
            this.picture_leftSu.Image = global::scada_bitirme.Properties.Resources.su;
            this.picture_leftSu.Location = new System.Drawing.Point(1325, 710);
            this.picture_leftSu.Name = "picture_leftSu";
            this.picture_leftSu.Size = new System.Drawing.Size(9, 40);
            this.picture_leftSu.TabIndex = 5;
            this.picture_leftSu.TabStop = false;
            // 
            // picture_rightMusluk
            // 
            this.picture_rightMusluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_rightMusluk.Image = global::scada_bitirme.Properties.Resources.rightMusluk;
            this.picture_rightMusluk.Location = new System.Drawing.Point(300, 675);
            this.picture_rightMusluk.Name = "picture_rightMusluk";
            this.picture_rightMusluk.Size = new System.Drawing.Size(75, 41);
            this.picture_rightMusluk.TabIndex = 1;
            this.picture_rightMusluk.TabStop = false;
            this.picture_rightMusluk.Click += new System.EventHandler(this.Picture_rightMusluk_Click);
            // 
            // picture_rightSu
            // 
            this.picture_rightSu.Image = global::scada_bitirme.Properties.Resources.su;
            this.picture_rightSu.Location = new System.Drawing.Point(364, 710);
            this.picture_rightSu.Name = "picture_rightSu";
            this.picture_rightSu.Size = new System.Drawing.Size(9, 40);
            this.picture_rightSu.TabIndex = 2;
            this.picture_rightSu.TabStop = false;
            // 
            // picture_kuyu
            // 
            this.picture_kuyu.BackColor = System.Drawing.Color.Transparent;
            this.picture_kuyu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_kuyu.Image = global::scada_bitirme.Properties.Resources.kuyu;
            this.picture_kuyu.Location = new System.Drawing.Point(448, 355);
            this.picture_kuyu.Name = "picture_kuyu";
            this.picture_kuyu.Size = new System.Drawing.Size(800, 340);
            this.picture_kuyu.TabIndex = 7;
            this.picture_kuyu.TabStop = false;
            this.picture_kuyu.Click += new System.EventHandler(this.Picture_kuyu_Click);
            // 
            // picture_kuyuDolu
            // 
            this.picture_kuyuDolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_kuyuDolu.Image = global::scada_bitirme.Properties.Resources.kuyuDolu;
            this.picture_kuyuDolu.Location = new System.Drawing.Point(448, 271);
            this.picture_kuyuDolu.Name = "picture_kuyuDolu";
            this.picture_kuyuDolu.Size = new System.Drawing.Size(800, 445);
            this.picture_kuyuDolu.TabIndex = 8;
            this.picture_kuyuDolu.TabStop = false;
            this.picture_kuyuDolu.Click += new System.EventHandler(this.Picture_kuyuDolu_Click);
            // 
            // picture_boru1
            // 
            this.picture_boru1.BackColor = System.Drawing.Color.Transparent;
            this.picture_boru1.Image = ((System.Drawing.Image)(resources.GetObject("picture_boru1.Image")));
            this.picture_boru1.Location = new System.Drawing.Point(221, 366);
            this.picture_boru1.Name = "picture_boru1";
            this.picture_boru1.Size = new System.Drawing.Size(528, 428);
            this.picture_boru1.TabIndex = 14;
            this.picture_boru1.TabStop = false;
            // 
            // serialPort_Arduino
            // 
            this.serialPort_Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_Arduino_DataReceived);
            // 
            // KuyuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1695, 836);
            this.Controls.Add(this.picture_kuyuMusluk);
            this.Controls.Add(this.label_kazan1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_kazan2);
            this.Controls.Add(this.label_kuyu1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.picture_rightKazan);
            this.Controls.Add(this.picture_leftKazan);
            this.Controls.Add(this.picture_leftMusluk);
            this.Controls.Add(this.picture_leftSu);
            this.Controls.Add(this.picture_rightMusluk);
            this.Controls.Add(this.picture_rightSu);
            this.Controls.Add(this.picture_kuyu);
            this.Controls.Add(this.picture_kuyuDolu);
            this.Controls.Add(this.picture_boru1);
            this.Name = "KuyuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KuyuForm_FormClosed);
            this.Load += new System.EventHandler(this.KuyuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_kazan1.ResumeLayout(false);
            this.groupBox_kazan2.ResumeLayout(false);
            this.groupBox_kuyu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_kuyuMusluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rightKazan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_leftKazan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_leftMusluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_leftSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rightMusluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rightSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kuyu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kuyuDolu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_boru1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_rightKazan;
        private System.Windows.Forms.PictureBox picture_rightMusluk;
        private System.Windows.Forms.PictureBox picture_rightSu;
        private System.Windows.Forms.PictureBox picture_leftKazan;
        private System.Windows.Forms.PictureBox picture_leftMusluk;
        private System.Windows.Forms.PictureBox picture_leftSu;
        private System.Windows.Forms.Timer timer_forGETdata;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PictureBox picture_kuyu;
        private System.Windows.Forms.PictureBox picture_kuyuDolu;
        private System.Windows.Forms.Label label_kazan1;
        private System.Windows.Forms.Label label_kuyu1;
        private System.Windows.Forms.Label label_kazan2;
        private System.Windows.Forms.Button button_hepsi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSu_kazan1;
        private System.Windows.Forms.GroupBox groupBox_kazan2;
        private System.Windows.Forms.GroupBox groupBox_kuyu1;
        private System.Windows.Forms.GroupBox groupBox_kazan1;
        private System.Windows.Forms.Label lblMusluk_kazan1;
        private System.Windows.Forms.Label lblMuslukDot_kazan1;
        private System.Windows.Forms.Label lblMusluk_kazan2;
        private System.Windows.Forms.Label lblSu_kazan2;
        private System.Windows.Forms.Label lblMuslukDot_kazan2;
        private System.Windows.Forms.Button button_kazan1;
        private System.Windows.Forms.Button button_kuyu1;
        private System.Windows.Forms.Button button_kazan2;
        private System.Windows.Forms.Label lblMusluk2_kuyu1;
        private System.Windows.Forms.Label lblMusluk2Dot_kuyu1;
        private System.Windows.Forms.Label lblMusluk1_kuyu1;
        private System.Windows.Forms.Label lblSu_kuyu1;
        private System.Windows.Forms.Label lblMusluk1Dot_kuyu1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox picture_boru1;
        private System.Windows.Forms.PictureBox picture_kuyuMusluk;
        private System.IO.Ports.SerialPort serialPort_Arduino;
    }
}