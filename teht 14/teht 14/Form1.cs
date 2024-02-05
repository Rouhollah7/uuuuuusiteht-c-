namespace teht_14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void talennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"c:\\Users\\rouhollah.tajik\\source\\repos\\windowsForm\\teht 14\\paivakirja.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("c:\\Users\\rouhollah.tajik\\source\\repos\\windowsForm\\teht 14\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}