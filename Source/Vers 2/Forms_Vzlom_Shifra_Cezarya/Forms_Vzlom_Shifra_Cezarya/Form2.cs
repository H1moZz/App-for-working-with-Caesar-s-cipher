using System;
using System.Windows.Forms;
using Lib_Vzlom_Cesarya;

namespace Forms_Vzlom_Shifra_Cezarya
{
    
    public partial class Form2 : Form
    {
        Form FORM1;
        public Form2(Form form1)
        { 
            InitializeComponent();
            FORM1 = form1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FORM1.Show();
        }

        private void Hack_Click(object sender, EventArgs e)
        {
            if (Shifr.TextLength == 0)
            {
                MessageBox.Show("Поле для взлома пустое, заполните его!","Ошибка!");
            }
            else
            {
                try
                {
                    if (Shifr.Text.Length >= 600)
                        Results.Text = Cezar.Vzlom_Shifra_Chastotnim(Shifr.Text);
                    else
                    {
                        Results.Text = Cezar.Alphabet_Attack(Shifr.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ИсходныйТекстСохранить_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Сохранение";
            saveFile.DefaultExt = "txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                System.IO.File.WriteAllText(saveFile.FileName, Results.Text);
            }
        }

        private void ЗашифрованныйТекстСохранить_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Сохранение";
            saveFile.DefaultExt = "txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                System.IO.File.WriteAllText(saveFile.FileName, Shifr.Text);
            }
        }

        private void ВернутьсяНаГлавную_Click(object sender, EventArgs e)
        {
            this.Close();
            FORM1.Show();
        }

        private void ЗашифрованныйТекстОткрыть_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Открытие";
            openFile.ShowDialog();
            if (openFile.FileName != "")
            {
                Shifr.Text = System.IO.File.ReadAllText(openFile.FileName);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
