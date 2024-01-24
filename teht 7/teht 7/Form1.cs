using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.LinkLabel;

namespace teht_7
{
    public partial class KustannusForm : Form
    {
        public KustannusForm()
        {
            InitializeComponent();
        }
        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutuset, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutuset = Convert.ToDouble(VakuutuksetTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            energia = Convert.ToDouble(PolttoNesteTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            kustannukset = (laina + nesteet + vakuutuset + pesut + huollot + renkaat + energia + muut) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }

        private void ToDouble(string text)
        {
            throw new NotImplementedException();
        }
    }
}