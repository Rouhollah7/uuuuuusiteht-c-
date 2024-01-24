namespace Harjoitus_6_salasana
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void VirheviestiLB_Click(object sender, EventArgs e)
        {

        }

        private void SalasanaPanel_Paint(object sender, PaintEventArgs e)
        {
            if (KayttajaTB.Text == "Ruhi" && SalasanaTB.Text == "M1naRuh")
            {
                SalasanaPanel.Visible= false;
                SalasanaOikeinPanel.Visible= true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheviestiLB.Text = true;
            }

        }
    }
}