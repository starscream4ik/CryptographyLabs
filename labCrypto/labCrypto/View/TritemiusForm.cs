using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cryptoAlg;
using System.IO;

namespace labCrypto.View
{
    public partial class TritemiusForm : Form 
    {
        Crypter crypter = new CeasarCrypter(new Tritemius(Alphabet.All));
        
        public TritemiusForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Crypter crypter = new CeasarCrypter(new Tritemius(Alphabet.EnglishAll));
            String key = "120";
            int length = Alphabet.EnglishAll.IndexOf('w');
            String crypted = crypter.getCrypt("wwwwww", key);
            String decrypted = crypter.getDecrypt(crypted, key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(groupBox2.
            int keySelectorIndex = getRadioButtonIndex(groupBox1);
            String key;
            if (keySelectorIndex == 0)
                key = numericUpDown1.Value.ToString() + ";" + numericUpDown2.Value.ToString();
            else if (keySelectorIndex == 1)
                key = numericUpDown3.Value.ToString() + ";" + numericUpDown4.Value.ToString() + ";" + numericUpDown5.Value.ToString();
            else
                key = textBox3.Text;


            int radioButtonIndex = getRadioButtonIndex(groupBox2);
            if (radioButtonIndex == 0) //crypt
            {
                foreach (String line in richTextBox1.Lines)
                {
                    String cryptedLine = crypter.getCrypt(line, key);
                    richTextBox2.AppendText(cryptedLine + "\n");
                }
            }
            else
            {
                foreach (String line in richTextBox1.Lines)
                {
                    String cryptedLine = crypter.getDecrypt(line, key);
                    richTextBox2.AppendText(cryptedLine + "\n");
                }
            }
            int lineCount = richTextBox1.Lines.Length;
            try
            {
                for (int i = 0; i < lineCount; i++)
                {
                    Alphabet.symbolsExistsInAlphabet(richTextBox1.Lines[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getRadioButtonIndex(GroupBox group)
        {
            int index = 0;
            foreach (Control control in group.Controls)
            {
                if (((RadioButton)control).Checked)
                {
                    index = control.TabIndex;
                    break;
                }

            }
            return index;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader sr = new StreamReader(myStream);
                            String line = String.Empty;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (Alphabet.symbolsExistsInAlphabet(line))
                                    richTextBox1.AppendText(line + "\n");
                            }
                            sr.Close();
                            //tbInputText.Text = line;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void saveTextToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            saveFileDialog1.InitialDirectory = "d:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamWriter sw = new StreamWriter(myStream);
                            foreach (String line in richTextBox2.Lines)
                            {
                                sw.WriteLine(line);
                            }

                            sw.Flush();
                            sw.Close();
                            //tbInputText.Text = line;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
