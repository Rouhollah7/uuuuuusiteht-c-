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
            string teksti = File.ReadAllText(@"C:\\Users\\rouhollahtajik\\source\\repos\\Windows-\\teht 14.text");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\rouhollahtajik\\source\\repos\\Windows-\\teht 14.text");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}