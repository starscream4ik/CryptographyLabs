using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using labCrypto.View;

namespace labCrypto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btLab1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void btLab2_Click(object sender, EventArgs e)
        {
            new TritemiusForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GammaForm().ShowDialog();
        }


        private void btLab4_Click(object sender, EventArgs e)
        {
            DESform desForm = new DESform();
            desForm.ShowDialog();
        }

    }
}
