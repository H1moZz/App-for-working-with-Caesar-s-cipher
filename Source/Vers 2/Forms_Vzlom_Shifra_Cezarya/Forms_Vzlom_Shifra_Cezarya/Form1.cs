using Lib_Vzlom_Cesarya;
using System;
using System.Windows.Forms;

namespace Forms_Vzlom_Shifra_Cezarya
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Cezar.LoadDictionary();
        }
        private void взломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(this);
            form.Show();
        }

        private void Coding_Click(object sender, EventArgs e)
        {
            if (Kluch.TextLength == 0)
            {
                MessageBox.Show("Поле \"Ключ\" не может быть пустым", "Ошибка!");
            }
            else if (Convert.ToByte(Kluch.Text) > 33)
            {
                MessageBox.Show("Поле \"Ключ\" не должно превышать размер Русского алфавита (33)", "Ошибка!");
            }
            else if (Ishodnoe.TextLength == 0)
            {
                MessageBox.Show("Поле исходного текста пустое", "Ошибка!");
            }
            else
            {
                Zashifrovannoe.Text = Cezar.Coding(Ishodnoe.Text, Convert.ToByte(Kluch.Text));
            }
        }

        private void Decoding_Click(object sender, EventArgs e)
        {
            if (Kluch.TextLength == 0)
            {
                MessageBox.Show("Поле \"Ключ\" не может быть пустым", "Ошибка!");
            }
            else if (Convert.ToByte(Kluch.Text) > 33)
            {
                MessageBox.Show("Поле \"Ключ\" не должно превышать размер Русского алфавита (33)", "Ошибка!");
            }
            else if (Zashifrovannoe.TextLength == 0)
            {
                MessageBox.Show("Поле зашифрованного текста пустое", "Ошибка!");
            }
            else
            {
                Ishodnoe.Text = Cezar.Decoding(Zashifrovannoe.Text, Convert.ToByte(Kluch.Text));
            }
        }

        private void ИсходныйТекстОткрыть_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Открытие";
            openFile.ShowDialog();
            if (openFile.FileName != "")
            {
                Ishodnoe.Text = System.IO.File.ReadAllText(openFile.FileName);
            }
        }

        private void ЗашифрованныйТекстОткрыть_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Открытие";
            openFile.ShowDialog();
            if (openFile.FileName != "")
            {
                Zashifrovannoe.Text = System.IO.File.ReadAllText(openFile.FileName);
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
                System.IO.File.WriteAllText(saveFile.FileName, Ishodnoe.Text);
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
                System.IO.File.WriteAllText(saveFile.FileName, Zashifrovannoe.Text);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Kluch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
