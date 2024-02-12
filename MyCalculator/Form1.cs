namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textboxHasil.Select();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "0";
        }

        private void koma_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear();  }
            textboxHasil.Text = textboxHasil.Text + ",";
        }

        private void satu_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear();  }
            textboxHasil.Text = textboxHasil.Text + "1";
        }

        private void dua_Click(object sender, EventArgs e)
        {
           if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
           textboxHasil.Text = textboxHasil.Text + "2";
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "3";
        }

        private void empat_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "4";
        }

        private void lima_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear();  }
            textboxHasil.Text = textboxHasil.Text + "5";
        }

        private void enam_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "6";
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "7";
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "8";
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text == "0") { textboxHasil.Clear(); }
            textboxHasil.Text = textboxHasil.Text + "9";
        }

        private void hapus_semua_Click(object sender, EventArgs e)
        {
            textboxHasil.Text = "0";
            textboxSimpan.Clear();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            textboxHasil.Text = "0";
            textboxSimpan.Text = "";
        }

        double angka, hasilHitung;
        int hitung;

        private void samadengan_Click(object sender, EventArgs e)
        {
            switch (hitung)
            {
                //kondisi menghitung hasil operator penjumlahan
                case 1:
                    hasilHitung = angka + Convert.ToDouble(textboxHasil.Text);
                    textboxSimpan.Text = textboxSimpan.Text + textboxHasil.Text + "=";
                    textboxHasil.Text = hasilHitung.ToString();
                    break;
                //kondisi menghitung hasil operator pengurangan
                case 2:
                    hasilHitung = angka - Convert.ToDouble(textboxHasil.Text);
                    textboxSimpan.Text = textboxSimpan.Text + textboxHasil.Text + "=";
                    textboxHasil.Text = hasilHitung.ToString();
                    break;
                //kondisi menghitung hasil operator perkalian
                case 3:
                    hasilHitung = angka * Convert.ToDouble(textboxHasil.Text);
                    textboxSimpan.Text = textboxSimpan.Text + textboxHasil.Text + "=";
                    textboxHasil.Text = hasilHitung.ToString();
                    break;
                //kondisi menghitung hasil operator pembagian
                case 4:
                    hasilHitung = angka / Convert.ToDouble(textboxHasil.Text);
                    textboxSimpan.Text = textboxSimpan.Text + textboxHasil.Text + "=";
                    textboxHasil.Text = hasilHitung.ToString();
                    break;
            }
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text != "")
            {
                angka = Convert.ToDouble(textboxHasil.Text); //konversi karakter ke desimal
                textboxSimpan.Text = textboxHasil.Text + "-";
                textboxHasil.Clear();
                hitung = 2;
            }
        }

        private void kali_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text != "")
            {
                angka = Convert.ToDouble(textboxHasil.Text); //konversi karakter ke desimal
                textboxSimpan.Text = textboxHasil.Text + "x";
                textboxHasil.Clear();
                hitung = 3;
            }
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text != "")
            {
                angka = Convert.ToDouble(textboxHasil.Text); //konversi karakter ke desimal
                textboxSimpan.Text = textboxHasil.Text + ":";
                textboxHasil.Clear();
                hitung = 4;
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (textboxHasil.Text != "")
            {              
                angka = Convert.ToDouble(textboxHasil.Text); //konversi karakter ke desimal
                textboxSimpan.Text = textboxHasil.Text + "+";
                textboxHasil.Clear();
                hitung = 1;
            }
        }
    }
}