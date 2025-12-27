namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKisiIslemleri kisiIslemleri = new FrmKisiIslemleri();
            kisiIslemleri.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void k›TAPLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKisiler kisiler = new FrmKisiler();
            kisiler.Show();
        }

        private void k›TAPVERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void k›ﬁ››ﬁLEMLER›ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KitapIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapIslemleri kitapIslemleri = new FrmKitapIslemleri();
            kitapIslemleri.Show();
        }

        private void tESL›METToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslimEt teslimet = new FrmTeslimEt();
            teslimet.Show();
        }

        private void tESL›MALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslimAlma teslimAlma = new FrmTeslimAlma();
            teslimAlma.Show();
        }

        private void k›TAPLARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKitaplar kitaplar = new FrmKitaplar();
            kitaplar.Show();
        }
    }
}
