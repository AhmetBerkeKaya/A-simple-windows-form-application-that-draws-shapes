
namespace OdevNesne
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tPageAnaEkran = new System.Windows.Forms.TabPage();
            this.btnCizdir = new System.Windows.Forms.Button();
            this.tbxAci = new System.Windows.Forms.TextBox();
            this.lblAci = new System.Windows.Forms.Label();
            this.tbxCap = new System.Windows.Forms.TextBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.tbxKenar = new System.Windows.Forms.TextBox();
            this.lblKenar = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tbxBoy = new System.Windows.Forms.TextBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.tbxEn = new System.Windows.Forms.TextBox();
            this.lblEn = new System.Windows.Forms.Label();
            this.cbxRenk = new System.Windows.Forms.ComboBox();
            this.cbxAd = new System.Windows.Forms.ComboBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnİleriAnaEkran = new System.Windows.Forms.Button();
            this.btnTemizleAnaEkran = new System.Windows.Forms.Button();
            this.tPageAnaliz = new System.Windows.Forms.TabPage();
            this.listViewAnaliz = new System.Windows.Forms.ListView();
            this.btnTemizleAnaliz = new System.Windows.Forms.Button();
            this.btnİleriAnaliz = new System.Windows.Forms.Button();
            this.btnGeriAnaliz = new System.Windows.Forms.Button();
            this.tPageCizdir = new System.Windows.Forms.TabPage();
            this.pBoxCizim = new System.Windows.Forms.PictureBox();
            this.btnTemizleSekil = new System.Windows.Forms.Button();
            this.btnGitAnaEkran = new System.Windows.Forms.Button();
            this.btnGeriCizdir = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.tab1.SuspendLayout();
            this.tPageAnaEkran.SuspendLayout();
            this.tPageAnaliz.SuspendLayout();
            this.tPageCizdir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCizim)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tPageAnaEkran);
            this.tab1.Controls.Add(this.tPageAnaliz);
            this.tab1.Controls.Add(this.tPageCizdir);
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1280, 720);
            this.tab1.TabIndex = 0;
            // 
            // tPageAnaEkran
            // 
            this.tPageAnaEkran.BackColor = System.Drawing.Color.Teal;
            this.tPageAnaEkran.Controls.Add(this.lblBilgilendirme);
            this.tPageAnaEkran.Controls.Add(this.btnCizdir);
            this.tPageAnaEkran.Controls.Add(this.tbxAci);
            this.tPageAnaEkran.Controls.Add(this.lblAci);
            this.tPageAnaEkran.Controls.Add(this.tbxCap);
            this.tPageAnaEkran.Controls.Add(this.lblCap);
            this.tPageAnaEkran.Controls.Add(this.tbxKenar);
            this.tPageAnaEkran.Controls.Add(this.lblKenar);
            this.tPageAnaEkran.Controls.Add(this.btnYazdir);
            this.tPageAnaEkran.Controls.Add(this.tbxBoy);
            this.tPageAnaEkran.Controls.Add(this.lblBoy);
            this.tPageAnaEkran.Controls.Add(this.tbxEn);
            this.tPageAnaEkran.Controls.Add(this.lblEn);
            this.tPageAnaEkran.Controls.Add(this.cbxRenk);
            this.tPageAnaEkran.Controls.Add(this.cbxAd);
            this.tPageAnaEkran.Controls.Add(this.tbxId);
            this.tPageAnaEkran.Controls.Add(this.lblRenk);
            this.tPageAnaEkran.Controls.Add(this.lblAd);
            this.tPageAnaEkran.Controls.Add(this.lblid);
            this.tPageAnaEkran.Controls.Add(this.btnİleriAnaEkran);
            this.tPageAnaEkran.Controls.Add(this.btnTemizleAnaEkran);
            this.tPageAnaEkran.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tPageAnaEkran.ForeColor = System.Drawing.Color.DarkGreen;
            this.tPageAnaEkran.Location = new System.Drawing.Point(4, 25);
            this.tPageAnaEkran.Name = "tPageAnaEkran";
            this.tPageAnaEkran.Padding = new System.Windows.Forms.Padding(3);
            this.tPageAnaEkran.Size = new System.Drawing.Size(1272, 691);
            this.tPageAnaEkran.TabIndex = 0;
            this.tPageAnaEkran.Text = "Ana Ekran";
            this.tPageAnaEkran.Click += new System.EventHandler(this.tPageAnaEkran_Click);
            // 
            // btnCizdir
            // 
            this.btnCizdir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCizdir.Location = new System.Drawing.Point(382, 520);
            this.btnCizdir.Name = "btnCizdir";
            this.btnCizdir.Size = new System.Drawing.Size(503, 100);
            this.btnCizdir.TabIndex = 19;
            this.btnCizdir.Text = "ŞEKLİ ÇİZDİR";
            this.btnCizdir.UseVisualStyleBackColor = true;
            this.btnCizdir.Click += new System.EventHandler(this.btnCizdir_Click);
            // 
            // tbxAci
            // 
            this.tbxAci.Location = new System.Drawing.Point(549, 312);
            this.tbxAci.Multiline = true;
            this.tbxAci.Name = "tbxAci";
            this.tbxAci.Size = new System.Drawing.Size(336, 30);
            this.tbxAci.TabIndex = 18;
            this.tbxAci.Visible = false;
            // 
            // lblAci
            // 
            this.lblAci.AutoSize = true;
            this.lblAci.ForeColor = System.Drawing.Color.White;
            this.lblAci.Location = new System.Drawing.Point(382, 315);
            this.lblAci.Name = "lblAci";
            this.lblAci.Size = new System.Drawing.Size(43, 22);
            this.lblAci.TabIndex = 17;
            this.lblAci.Text = "AÇI";
            this.lblAci.Visible = false;
            // 
            // tbxCap
            // 
            this.tbxCap.Location = new System.Drawing.Point(549, 263);
            this.tbxCap.Name = "tbxCap";
            this.tbxCap.Size = new System.Drawing.Size(336, 30);
            this.tbxCap.TabIndex = 16;
            this.tbxCap.Visible = false;
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.ForeColor = System.Drawing.Color.White;
            this.lblCap.Location = new System.Drawing.Point(382, 266);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(48, 22);
            this.lblCap.TabIndex = 15;
            this.lblCap.Text = "ÇAP";
            this.lblCap.Visible = false;
            // 
            // tbxKenar
            // 
            this.tbxKenar.Location = new System.Drawing.Point(549, 263);
            this.tbxKenar.Name = "tbxKenar";
            this.tbxKenar.Size = new System.Drawing.Size(336, 30);
            this.tbxKenar.TabIndex = 14;
            this.tbxKenar.Visible = false;
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.ForeColor = System.Drawing.Color.White;
            this.lblKenar.Location = new System.Drawing.Point(382, 266);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(77, 22);
            this.lblKenar.TabIndex = 13;
            this.lblKenar.Text = "KENAR";
            this.lblKenar.Visible = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnYazdir.Location = new System.Drawing.Point(382, 399);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(503, 100);
            this.btnYazdir.TabIndex = 12;
            this.btnYazdir.Text = "BİLGİLERİ YAZDIR";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // tbxBoy
            // 
            this.tbxBoy.Location = new System.Drawing.Point(549, 312);
            this.tbxBoy.Name = "tbxBoy";
            this.tbxBoy.Size = new System.Drawing.Size(336, 30);
            this.tbxBoy.TabIndex = 11;
            this.tbxBoy.Visible = false;
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.ForeColor = System.Drawing.Color.White;
            this.lblBoy.Location = new System.Drawing.Point(382, 315);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(99, 22);
            this.lblBoy.TabIndex = 10;
            this.lblBoy.Text = "UZUNLUK";
            this.lblBoy.Visible = false;
            // 
            // tbxEn
            // 
            this.tbxEn.Location = new System.Drawing.Point(549, 263);
            this.tbxEn.Name = "tbxEn";
            this.tbxEn.Size = new System.Drawing.Size(336, 30);
            this.tbxEn.TabIndex = 9;
            this.tbxEn.Visible = false;
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.ForeColor = System.Drawing.Color.White;
            this.lblEn.Location = new System.Drawing.Point(382, 266);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(98, 22);
            this.lblEn.TabIndex = 8;
            this.lblEn.Text = "GENİŞLİK";
            this.lblEn.Visible = false;
            // 
            // cbxRenk
            // 
            this.cbxRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRenk.FormattingEnabled = true;
            this.cbxRenk.Items.AddRange(new object[] {
            "Kirmizi",
            "Mavi",
            "Yesil",
            "Sari",
            "Siyah"});
            this.cbxRenk.Location = new System.Drawing.Point(852, 149);
            this.cbxRenk.Name = "cbxRenk";
            this.cbxRenk.Size = new System.Drawing.Size(172, 30);
            this.cbxRenk.TabIndex = 7;
            // 
            // cbxAd
            // 
            this.cbxAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAd.FormattingEnabled = true;
            this.cbxAd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxAd.Items.AddRange(new object[] {
            "Daire",
            "Dikdörtgen",
            "Eşkenar Üçgen"});
            this.cbxAd.Location = new System.Drawing.Point(581, 149);
            this.cbxAd.Name = "cbxAd";
            this.cbxAd.Size = new System.Drawing.Size(172, 30);
            this.cbxAd.TabIndex = 6;
            this.cbxAd.SelectedIndexChanged += new System.EventHandler(this.cbxAd_SelectedIndexChanged);
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(316, 149);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(172, 30);
            this.tbxId.TabIndex = 5;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.ForeColor = System.Drawing.Color.White;
            this.lblRenk.Location = new System.Drawing.Point(777, 152);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(69, 22);
            this.lblRenk.TabIndex = 4;
            this.lblRenk.Text = "RENGİ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(531, 152);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 22);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "ADI";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(280, 152);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 22);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "ID";
            // 
            // btnİleriAnaEkran
            // 
            this.btnİleriAnaEkran.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnİleriAnaEkran.Location = new System.Drawing.Point(930, 520);
            this.btnİleriAnaEkran.Name = "btnİleriAnaEkran";
            this.btnİleriAnaEkran.Size = new System.Drawing.Size(300, 100);
            this.btnİleriAnaEkran.TabIndex = 1;
            this.btnİleriAnaEkran.Text = ">İLERİ";
            this.btnİleriAnaEkran.UseVisualStyleBackColor = true;
            this.btnİleriAnaEkran.Click += new System.EventHandler(this.btnİleriAnaEkran_Click);
            // 
            // btnTemizleAnaEkran
            // 
            this.btnTemizleAnaEkran.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTemizleAnaEkran.Location = new System.Drawing.Point(30, 520);
            this.btnTemizleAnaEkran.Name = "btnTemizleAnaEkran";
            this.btnTemizleAnaEkran.Size = new System.Drawing.Size(300, 100);
            this.btnTemizleAnaEkran.TabIndex = 0;
            this.btnTemizleAnaEkran.Text = "TEMİZLE";
            this.btnTemizleAnaEkran.UseVisualStyleBackColor = true;
            this.btnTemizleAnaEkran.Click += new System.EventHandler(this.btnTemizleAnaEkran_Click);
            // 
            // tPageAnaliz
            // 
            this.tPageAnaliz.BackColor = System.Drawing.Color.Teal;
            this.tPageAnaliz.Controls.Add(this.listViewAnaliz);
            this.tPageAnaliz.Controls.Add(this.btnTemizleAnaliz);
            this.tPageAnaliz.Controls.Add(this.btnİleriAnaliz);
            this.tPageAnaliz.Controls.Add(this.btnGeriAnaliz);
            this.tPageAnaliz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tPageAnaliz.Location = new System.Drawing.Point(4, 25);
            this.tPageAnaliz.Name = "tPageAnaliz";
            this.tPageAnaliz.Padding = new System.Windows.Forms.Padding(3);
            this.tPageAnaliz.Size = new System.Drawing.Size(1272, 691);
            this.tPageAnaliz.TabIndex = 1;
            this.tPageAnaliz.Text = "Analiz Sonuçları";
            // 
            // listViewAnaliz
            // 
            this.listViewAnaliz.HideSelection = false;
            this.listViewAnaliz.Location = new System.Drawing.Point(56, 40);
            this.listViewAnaliz.Name = "listViewAnaliz";
            this.listViewAnaliz.Size = new System.Drawing.Size(1130, 342);
            this.listViewAnaliz.TabIndex = 3;
            this.listViewAnaliz.UseCompatibleStateImageBehavior = false;
            this.listViewAnaliz.View = System.Windows.Forms.View.List;
            // 
            // btnTemizleAnaliz
            // 
            this.btnTemizleAnaliz.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTemizleAnaliz.Location = new System.Drawing.Point(375, 520);
            this.btnTemizleAnaliz.Name = "btnTemizleAnaliz";
            this.btnTemizleAnaliz.Size = new System.Drawing.Size(517, 100);
            this.btnTemizleAnaliz.TabIndex = 2;
            this.btnTemizleAnaliz.Text = "TEMİZLE";
            this.btnTemizleAnaliz.UseVisualStyleBackColor = true;
            this.btnTemizleAnaliz.Click += new System.EventHandler(this.btnTemizleAnaliz_Click);
            // 
            // btnİleriAnaliz
            // 
            this.btnİleriAnaliz.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnİleriAnaliz.Location = new System.Drawing.Point(930, 520);
            this.btnİleriAnaliz.Name = "btnİleriAnaliz";
            this.btnİleriAnaliz.Size = new System.Drawing.Size(300, 100);
            this.btnİleriAnaliz.TabIndex = 1;
            this.btnİleriAnaliz.Text = ">İLERİ";
            this.btnİleriAnaliz.UseVisualStyleBackColor = true;
            this.btnİleriAnaliz.Click += new System.EventHandler(this.btnİleriAnaliz_Click);
            // 
            // btnGeriAnaliz
            // 
            this.btnGeriAnaliz.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGeriAnaliz.Location = new System.Drawing.Point(30, 520);
            this.btnGeriAnaliz.Name = "btnGeriAnaliz";
            this.btnGeriAnaliz.Size = new System.Drawing.Size(300, 100);
            this.btnGeriAnaliz.TabIndex = 0;
            this.btnGeriAnaliz.Text = "<GERİ";
            this.btnGeriAnaliz.UseVisualStyleBackColor = true;
            this.btnGeriAnaliz.Click += new System.EventHandler(this.btnGeriAnaliz_Click);
            // 
            // tPageCizdir
            // 
            this.tPageCizdir.BackColor = System.Drawing.Color.Teal;
            this.tPageCizdir.Controls.Add(this.pBoxCizim);
            this.tPageCizdir.Controls.Add(this.btnTemizleSekil);
            this.tPageCizdir.Controls.Add(this.btnGitAnaEkran);
            this.tPageCizdir.Controls.Add(this.btnGeriCizdir);
            this.tPageCizdir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tPageCizdir.Location = new System.Drawing.Point(4, 25);
            this.tPageCizdir.Name = "tPageCizdir";
            this.tPageCizdir.Padding = new System.Windows.Forms.Padding(3);
            this.tPageCizdir.Size = new System.Drawing.Size(1272, 691);
            this.tPageCizdir.TabIndex = 2;
            this.tPageCizdir.Text = "Şekil Çizdir";
            // 
            // pBoxCizim
            // 
            this.pBoxCizim.BackColor = System.Drawing.Color.White;
            this.pBoxCizim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxCizim.BackgroundImage")));
            this.pBoxCizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxCizim.Location = new System.Drawing.Point(30, 39);
            this.pBoxCizim.Name = "pBoxCizim";
            this.pBoxCizim.Size = new System.Drawing.Size(1200, 466);
            this.pBoxCizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCizim.TabIndex = 3;
            this.pBoxCizim.TabStop = false;
            // 
            // btnTemizleSekil
            // 
            this.btnTemizleSekil.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTemizleSekil.Location = new System.Drawing.Point(370, 520);
            this.btnTemizleSekil.Name = "btnTemizleSekil";
            this.btnTemizleSekil.Size = new System.Drawing.Size(524, 100);
            this.btnTemizleSekil.TabIndex = 2;
            this.btnTemizleSekil.Text = "ŞEKLİ TEMİZLE";
            this.btnTemizleSekil.UseVisualStyleBackColor = true;
            this.btnTemizleSekil.Click += new System.EventHandler(this.btnTemizleSekil_Click);
            // 
            // btnGitAnaEkran
            // 
            this.btnGitAnaEkran.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGitAnaEkran.Location = new System.Drawing.Point(930, 520);
            this.btnGitAnaEkran.Name = "btnGitAnaEkran";
            this.btnGitAnaEkran.Size = new System.Drawing.Size(300, 100);
            this.btnGitAnaEkran.TabIndex = 1;
            this.btnGitAnaEkran.Text = "ANA EKRAN";
            this.btnGitAnaEkran.UseVisualStyleBackColor = true;
            this.btnGitAnaEkran.Click += new System.EventHandler(this.btnGitAnaEkran_Click);
            // 
            // btnGeriCizdir
            // 
            this.btnGeriCizdir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGeriCizdir.Location = new System.Drawing.Point(30, 520);
            this.btnGeriCizdir.Name = "btnGeriCizdir";
            this.btnGeriCizdir.Size = new System.Drawing.Size(300, 100);
            this.btnGeriCizdir.TabIndex = 0;
            this.btnGeriCizdir.Text = "<GERİ";
            this.btnGeriCizdir.UseVisualStyleBackColor = true;
            this.btnGeriCizdir.Click += new System.EventHandler(this.btnGeriCizdir_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.White;
            this.lblBilgilendirme.Location = new System.Drawing.Point(123, 374);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(1017, 22);
            this.lblBilgilendirme.TabIndex = 20;
            this.lblBilgilendirme.Text = "ŞEKİL ÇİZDİR SAYFASINDAKİ HER KARE 20 BİRİMDİR. HESAPLAMALARINIZI ONA GÖRE UYARLA" +
    "YABİLİRSİNİZ.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab1.ResumeLayout(false);
            this.tPageAnaEkran.ResumeLayout(false);
            this.tPageAnaEkran.PerformLayout();
            this.tPageAnaliz.ResumeLayout(false);
            this.tPageCizdir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCizim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tPageAnaEkran;
        private System.Windows.Forms.TabPage tPageAnaliz;
        private System.Windows.Forms.TabPage tPageCizdir;
        private System.Windows.Forms.Button btnİleriAnaEkran;
        private System.Windows.Forms.Button btnTemizleAnaEkran;
        private System.Windows.Forms.Button btnTemizleAnaliz;
        private System.Windows.Forms.Button btnİleriAnaliz;
        private System.Windows.Forms.Button btnGeriAnaliz;
        private System.Windows.Forms.Button btnGitAnaEkran;
        private System.Windows.Forms.Button btnGeriCizdir;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cbxAd;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.ComboBox cbxRenk;
        private System.Windows.Forms.TextBox tbxAci;
        private System.Windows.Forms.Label lblAci;
        private System.Windows.Forms.TextBox tbxCap;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.TextBox tbxKenar;
        private System.Windows.Forms.Label lblKenar;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox tbxBoy;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox tbxEn;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Button btnCizdir;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListView listViewAnaliz;
        private System.Windows.Forms.Button btnTemizleSekil;
        private System.Windows.Forms.PictureBox pBoxCizim;
        private System.Windows.Forms.Label lblBilgilendirme;
    }
}

