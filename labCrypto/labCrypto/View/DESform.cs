using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cryptoAlg;

namespace labCrypto
{
    public partial class DESform : Form
    {
        private Crypter crypter = new SimpleCrypter(new DESalgo(Alphabet.All));
        
        public DESform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(richTextBox1.Text);
            String key = txtKey.Text + ";" + txtIV.Text;
            int lineCount = richTextBox1.Lines.Length;
            try
            {
                for (int i = 0; i < lineCount; i++)
                {
                    Alphabet.symbolsExistsInAlphabet(richTextBox1.Lines[i]);
                }
                richTextBox2.Text = crypter.getCrypt(richTextBox1.Text, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! " + ex.Message); 
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String key = txtKey.Text + ";" + txtIV.Text;
            //int lineCount = richTextBox1.Lines.Length;
            try
            {
                richTextBox2.Text = crypter.getDecrypt(richTextBox1.Text, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! " + ex.Message);
            }
        }
    }
}
