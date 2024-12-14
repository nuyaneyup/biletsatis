namespace sinemabiletsatısı
{
    public partial class frmBiletSatis : Form
    {
        public frmBiletSatis()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, bilet, su, toplam;
            su = int.Parse(txtSu.Text);
            bilet = int.Parse(txtBilet.Text);
            cay = int.Parse(txtCay.Text);
            misir = int.Parse(txtMisir.Text);
            toplam = su * 1 + bilet * 8 + cay * 2 + misir * 4;
            lblTopla.Text = toplam.ToString();
            kasatutar = toplam + kasatutar;
            lblKasa.Text = kasatutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSu.Text = "";
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtMisir.Focus();
            kasatutar = 0;
            lblKasa.Text = kasatutar.ToString();
        }
    }
}
