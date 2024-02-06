namespace teht_19
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
        }
        

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            label9.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 307 v‰litunteisin \n";
            label9.Text += "9:00 - 14:30 joka p‰iv‰ maanantaista torstaisin ja perjantaisin \n";
            label9.Text += "9.00 - 12.30 \n\n Keudan oppilaskunnan kahvilasta saa l‰mpimien \n";
            label9.Text += "juomien lis‰ksi virvokkeita sek‰ pient‰ putavaa ja makeisia\n";
            label9.Text += "tervetuloa tutustumaan!\n";
            label9.Font = new Font("Arial", 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KoriPL.Visible= false;
            JuomaPL.Visible= false;
            RuoatPL.Visible= false;
            HerkutPL.Visible= false;
            Meist‰PL.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KoriPL.Visible = false;
            JuomaPL.Visible = false;
            RuoatPL.Visible = true;
            HerkutPL.Visible = false;
            Meist‰PL.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KoriPL.Visible = false;
            JuomaPL.Visible = true;
            RuoatPL.Visible = false;
            HerkutPL.Visible = false;
            Meist‰PL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KoriPL.Visible = false;
            JuomaPL.Visible = false;
            RuoatPL.Visible = false;
            HerkutPL.Visible = true;
            Meist‰PL.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            KoriPL.Visible = true;
            JuomaPL.Visible = false;
            RuoatPL.Visible = false;
            HerkutPL.Visible = false;
            Meist‰PL.Visible = false;
        }
    }
}