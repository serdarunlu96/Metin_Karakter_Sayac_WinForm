namespace Metin_Karakter_Sayac_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            string mtn = txtMetin.Text;

            lblToplamKarakterSayisi.Text = mtn.Length.ToString();

            string[] ayraclar = { " ", "\r\n", "\t", "\n" };

            string[] kelimeler = mtn.Split(ayraclar,
                StringSplitOptions.RemoveEmptyEntries);

            lblKelimeSayisi.Text = kelimeler.Length.ToString();

            string enUzunKelime = "";

            foreach (string k in kelimeler)
            {
                if (k.Length > enUzunKelime.Length)
                {
                    enUzunKelime = k;
                }
            }
            lblEnUzun.Text = $"{enUzunKelime} ({enUzunKelime.Length})";
        }
    }
}