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

namespace labCrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Crypter crypter;
        String alphabet;

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "testing tags in git";

            int rbLanguageIndex = getRadioButtonIndex(groupBox2);
            if (rbLanguageIndex == 1)//rus
            {
                alphabet = Alphabet.RusAll;
            }
            else alphabet = Alphabet.EnglishAll;

            try
            {
                crypter = new SimpleCrypter(new Ceasar(alphabet));
                String text = tbInputText.Text;
                String key = numericUpDown1.Value.ToString();

                int rbMethodIndex = getRadioButtonIndex(groupBox1);
                if (rbMethodIndex == 1)//crypt
                {
                    String cryptText = crypter.getCrypt(text, key);
                    tbOutputText.Text = cryptText;
                }
                else//decrypt
                {
                    String decryptText = crypter.getDecrypt(text, key);
                    tbOutputText.Text = decryptText;
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
            openFileDialog1.InitialDirectory = "c:\\";
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
                            String line = sr.ReadLine();
                            tbInputText.Text = line;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
