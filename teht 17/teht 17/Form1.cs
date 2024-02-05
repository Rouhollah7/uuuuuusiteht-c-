using System.IO;
namespace teht_17
{
    public partial class NotepadForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public NotepadForm()
        {
            InitializeComponent();
        }
        private void UusiTiedosto() 
        {
            try 
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text)) 
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");

                }
                else
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Nimetön";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void TallennaTiedosto() 
        {
            try 
            {   
                if (!string.IsNullOrEmpty(TekstiTB.Text)) 
                {
                    saveFileDialog= new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt|Rikas Tekstiformaatti (*.rtf) | *.rtf"; 
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                    {
                        File.WriteAllText(saveFileDialog.FileName , TekstiTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        private void AvaaTiedosto() 
        {
            try 
            {
                openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog()==DialogResult.OK) 
                {
                    TekstiTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa! " + ex);
            }
        }
    
        private void NotepadForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    TallennaTiedosto();

                }
                else 
                {
                    this.Close();
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa! " + ex);
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if(fontDialog.ShowDialog() == DialogResult.OK) 
                {
                    TekstiTB.Font = fontDialog.Font;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe; " + ex);
            }
        }
       
    }
}