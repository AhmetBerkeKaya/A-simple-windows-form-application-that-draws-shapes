using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevNesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tPageAnaEkran_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Notify icon'u çağırma işlemi
            notifyIcon1.BalloonTipText = "İstediğiniz şekli seçin çizelim!!";
            notifyIcon1.BalloonTipTitle = "Programa Hoşgeldiniz!!";
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(1000);
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void ListeyeEkle()
        {
            // Kullanıcıdan bilgileri al ve tanımla 
            int id = Convert.ToInt32(tbxId.Text);
            string adi = cbxAd.SelectedItem.ToString();
            Sekil.ERenk renk = (Sekil.ERenk)Enum.Parse(typeof(Sekil.ERenk), cbxRenk.SelectedItem.ToString());

            // Seçili şekile göre işlem yap
            string seciliSekil = cbxAd.SelectedItem.ToString();
            if (seciliSekil == "Dikdörtgen")
            {
                // Dikdörtgen sınıfından al
                double en = Convert.ToDouble(tbxEn.Text);
                double boy = Convert.ToDouble(tbxBoy.Text);
                // Nesne oluştur
                Dikdortgen dikdortgen = new Dikdortgen(id, adi, renk, en, boy);
                ListViewItem item = new ListViewItem(dikdortgen.BilgiYazdir());
                listViewAnaliz.Items.Add(item);
            }
            else if (seciliSekil == "Daire")
            {
                // Daire sınıfından al
                double cap = Convert.ToDouble(tbxCap.Text);
                double aci = Convert.ToDouble(tbxAci.Text);
                Daire daire = new Daire(id, adi, renk, cap, aci);
                ListViewItem item = new ListViewItem(daire.BilgiYazdir());
                listViewAnaliz.Items.Add(item);
            }
            else if (seciliSekil == "Eşkenar Üçgen")
            {
                // Üçgen sınıfından al
                double kenar = Convert.ToDouble(tbxKenar.Text);
                EskenarUcgen ucgen = new EskenarUcgen(id, adi, renk, kenar);
                ListViewItem item = new ListViewItem(ucgen.BilgiYazdir());
                listViewAnaliz.Items.Add(item);
            }   
        }
        private bool IsInputValid()
        {
            // CheckBox'ların seçili olup olmadığını kontrol etme
            if (string.IsNullOrWhiteSpace(tbxId.Text) ||
                cbxAd.SelectedItem == null ||
                cbxRenk.SelectedItem == null)
            {
                return false;
            }

            // Id'nin sayı olup olmadığını kontrol etme
            if (!int.TryParse(tbxId.Text, out _))
            {
                MessageBox.Show("Id alanına sayı girmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Seçili şekilin boş olup olmadığını kontrol etme
            string seciliSekil = cbxAd.SelectedItem.ToString();
            switch (seciliSekil)
            {
                case "Dikdörtgen":
                    return !string.IsNullOrWhiteSpace(tbxEn.Text) && !string.IsNullOrWhiteSpace(tbxBoy.Text);

                case "Daire":
                    return !string.IsNullOrWhiteSpace(tbxCap.Text) && !string.IsNullOrWhiteSpace(tbxAci.Text);

                case "Eşkenar Üçgen":
                    return !string.IsNullOrWhiteSpace(tbxKenar.Text);

                default:
                    return false;
            }
        }

        private void btnİleriAnaEkran_Click(object sender, EventArgs e)
        {
            // Mevcut seçili tab'in index'ini al
            int currentIndex = tab1.SelectedIndex;

            // Bir sonraki tab'in index'ini belirle
            int nextIndex = (currentIndex + 1);

            // Bir sonraki tab'i seç
            tab1.SelectedIndex = nextIndex;
        }

        private void btnGeriAnaliz_Click(object sender, EventArgs e)
        {
            // Mevcut seçili tab'in index'ini al
            int currentIndex = tab1.SelectedIndex;

            // Bir önceki tab'in index'ini belirle
            int backIndex = currentIndex - 1;

            // Bir önceki tab i seç
            tab1.SelectedIndex = backIndex;
        }

        private void btnİleriAnaliz_Click(object sender, EventArgs e)
        {
            // Mevcut seçili tab'in index'ini al
            int currentIndex = tab1.SelectedIndex;

            // Bir sonraki tab'in index'ini belirle
            int nextIndex = (currentIndex + 1);

            // Bir sonraki tab'i seç
            tab1.SelectedIndex = nextIndex;
        }

        private void btnGeriCizdir_Click(object sender, EventArgs e)
        {
            // Mevcut seçili tab'in index'ini al
            int currentIndex = tab1.SelectedIndex;

            // Bir önceki tab'in index'ini belirle
            int backIndex = currentIndex - 1;

            // Bir önceki tab i seç
            tab1.SelectedIndex = backIndex;
        }

        private void btnGitAnaEkran_Click(object sender, EventArgs e)
        {
            // Mevcut seçili tab'in index'ini al
            int currentIndex = tab1.SelectedIndex;

            // İki önceki tab'in index'ini belirle
            int backIndex = currentIndex - 2;

            // İki önceki tab i seç
            tab1.SelectedIndex = backIndex;
        }

        private void cbxAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'ta seçili olan öge
            string seciliSekil = cbxAd.SelectedItem.ToString();

            // Tüm textboxları gizle
            lblBoy.Visible = false;
            lblEn.Visible = false;
            tbxEn.Visible = false;             
            tbxBoy.Visible = false;
            lblCap.Visible = false;
            lblAci.Visible = false;           
            tbxCap.Visible = false;
            tbxAci.Visible = false;
            lblKenar.Visible = false;
            tbxKenar.Visible = false;

            // Seçili şekle göre bilgi istenecek
            if (seciliSekil == "Dikdörtgen")
            {
                lblBoy.Visible = true;
                lblEn.Visible = true;
                tbxEn.Visible = true;             // Görünürlüğü Aç
                tbxBoy.Visible = true;
            }
            else if(seciliSekil == "Daire")
            {
                lblCap.Visible = true;
                lblAci.Visible = true;            // Görünürlüğü Aç
                tbxCap.Visible = true;
                tbxAci.Visible = true;
            }
            else if(seciliSekil == "Eşkenar Üçgen")
            {
                lblKenar.Visible = true;
                tbxKenar.Visible = true;          // Görünürlüğü Aç
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                ListeyeEkle();
            }
            else
            {
                // Boş alanlar için uyarı
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizleAnaEkran_Click(object sender, EventArgs e)
        {
            // Form üzerindeki bütün kontrol elemanlarını döngü ile kontrol et
            foreach (Control control in tab1.SelectedTab.Controls)
            {
                // Eğer kontrol bir ComboBox ise
                if (control is ComboBox)
                {
                    
                }
                // Eğer kontrol bir TextBox ise
                else if (control is TextBox)
                {
                    // TextBox'ın içeriğini temizle
                    ((TextBox)control).Clear();
                }
            }
        }

        private void btnCizdir_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                // PictureBox'a bir Bitmap oluşturun
                Bitmap bitmap = new Bitmap(pBoxCizim.Width, pBoxCizim.Height);

                // Graphics nesnesini Bitmap üzerine alın
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    string seciliSekil = cbxAd.SelectedItem.ToString();
                    string seciliRenk = cbxRenk.SelectedItem.ToString();
                    Color renk = Color.Black; // Varsayılan renk

                    // Renk seçimi
                    switch (seciliRenk.ToLower())
                    {
                        case "kirmizi":
                            renk = Color.Red;
                            break;
                        case "mavi":
                            renk = Color.Blue;
                            break;
                        case "yesil":
                            renk = Color.Green;
                            break;
                        case "sari":
                            renk = Color.Yellow;
                            break;
                        case "siyah":
                            renk = Color.Black;
                            break;
                        default:
                            break;
                    }

                    using (Pen pen = new Pen(renk))
                    using (SolidBrush brush = new SolidBrush(renk)) // Yeni bir SolidBrush eklenmiştir
                    {
                        switch (seciliSekil)
                        {
                            case "Dikdörtgen":
                                // Dikdörtgen çizimi ve içini doldur
                                double en = Convert.ToDouble(tbxEn.Text);
                                double boy = Convert.ToDouble(tbxBoy.Text);
                                g.DrawRectangle(pen, 20, 20, (float)en, (float)boy);
                                // Çizilen şekillerin içini dolduran ifade isteğe bağlı kullanılabilir
                                //g.FillRectangle(brush, 10, 10, (float)en, (float)boy);
                                break;
                            case "Daire":
                                // Daire çizimi ve içini doldur
                                double cap = Convert.ToDouble(tbxCap.Text);
                                double aci = Convert.ToDouble(tbxAci.Text);
                                float startAngle = 0; // Başlangıç açısı
                                float sweepAngle = (float)aci; // Açı değeri

                                g.DrawPie(pen, 20, 20, (float)cap, (float)cap, startAngle, sweepAngle);
                                // Çizilen şekillerin içini dolduran ifade isteğe bağlı kullanılabilir
                                //g.FillPie(brush, 20, 20, (float)cap, (float)cap, startAngle, sweepAngle);
                                break;
                            case "Eşkenar Üçgen":
                                // Üçgen çizimi ve içini doldur
                                double kenar = Convert.ToDouble(tbxKenar.Text);
                                PointF[] points =
                                {
                        new PointF(20 + (float)(kenar / 2), 20),
                        new PointF(20, 20  + (float)kenar),
                        new PointF(20 + (float)kenar, 20 + (float)kenar)
                    };
                                g.DrawPolygon(pen, points);
                                // Çizilen şekillerin içini dolduran ifade isteğe bağlı kullanılabilir
                                //g.FillPolygon(brush, points);
                                break;
                            default:
                                break;
                        }
                    }
                }

                // PictureBox'a Bitmap'i ata
                pBoxCizim.Image = bitmap;
            }
            else
            {
                // Boş alanlar için uyarı
                MessageBox.Show("Lütfen tüm çizim bilgilerini doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        // Listview temizleme
        private void btnTemizleAnaliz_Click(object sender, EventArgs e)
        {
            listViewAnaliz.Clear();
        }
        // PictureBox temizleme
        private void btnTemizleSekil_Click(object sender, EventArgs e)
        {
            pBoxCizim.Image = null;
        }
    }
}
