using System.Security.Cryptography;

namespace KisiDefteriOnline6
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler;

        public Form1()
        {
            InitializeComponent();
            kisiler = OrnekVeriler();
            KisileriListele();
        }

        private void KisileriListele()
        {
            lstKisiler.Items.Clear();

            foreach (Kisi kisi in kisiler)
                lstKisiler.Items.Add(kisi);
        }

        private List<Kisi> OrnekVeriler()
        {
            return new List<Kisi>()
            {
                new Kisi() { Ad = "Ali", Soyad = "Yýlmaz" },
                new Kisi() { Ad = "Can", Soyad = "Öztürk" },
                new Kisi() { Ad = "Cem", Soyad = "Þahin" },
                new Kisi() { Ad = "Ece", Soyad = "Doðan" }
            };
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve soyad zorunlu!");
                return;
            }

            Kisi k = new Kisi() { Ad = ad, Soyad = soyad };
            kisiler.Add(k);
            KisileriListele();
            lstKisiler.SelectedItem = k;
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                MessageBox.Show("Silinmesini istediðiniz kiþiyi seçiniz.");
                return;
            }

            Kisi k = (Kisi)lstKisiler.SelectedItem;
            kisiler.Remove(k);
            KisileriListele();
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (sid < 1) return;
            SeciliyiTasi(sid - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (sid == -1 || sid == lstKisiler.Items.Count - 1) return;
            SeciliyiTasi(sid + 1);
        }

        private void SeciliyiTasi(int yeniIndeks)
        {
            Kisi k = (Kisi)lstKisiler.SelectedItem!;
            kisiler.Remove(k);
            kisiler.Insert(yeniIndeks, k);
            KisileriListele();
            lstKisiler.SelectedItem = k;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                MessageBox.Show("Düzenlenmesini istediðiniz kiþiyi seçiniz.");
                return;
            }

            Kisi k = (Kisi)lstKisiler.SelectedItem;
            DuzenleForm frmDuzenle = new DuzenleForm(k);
            frmDuzenle.ShowDialog();
            KisileriListele();
            lstKisiler.SelectedItem = k;
        }
    }
}