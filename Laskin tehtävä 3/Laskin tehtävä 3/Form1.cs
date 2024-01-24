namespace Laskin_tehtävä_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float luku1, luku2, tulos;
            string merkki;
            luku1 = float.Parse(LukuYksiTB.Text);
            luku2 = float.Parse(LukuKaksiTB.Text);
            merkki = LaskutoimitusCB.Text;
            switch (merkki)
            {
                case "+":
                    tulos = luku1 + luku2;
                    break;
                case "-":
                    tulos = luku1 - luku2;
                    break;
                case "*":
                    tulos = luku1 + luku2;
                    break;
                case "/":
                    tulos = luku1 / luku2;
                    break;
                default:
                    tulos = 0;
                    break;
            }
            VastausLB.Text = Convert.ToString(tulos);
            VastausLB.Visible = true;

        }

        private void LukuYksiTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}