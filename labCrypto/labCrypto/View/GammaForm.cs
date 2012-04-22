using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using cryptoAlg;

namespace labCrypto.View
{
    public partial class GammaForm : Form
    {
        Crypter crypter = new SimpleCrypter(new Gamma(Alphabet.All));
        
        public GammaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String key = numericUpDown1.Value.ToString();
            int lineCount = richTextBox1.Lines.Length;
            try
            {
                for (int i = 0; i < lineCount; i++)
                {
                    Alphabet.symbolsExistsInAlphabet(richTextBox1.Lines[i]);
                }

                int radioButtonIndex = getRadioButtonIndex(groupBox2);
                richTextBox2.Clear();
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
            richTextBox1.Clear();
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
