using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KI.WinForms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void rootToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rootCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RootCAfrm ca = new RootCAfrm();
            ca.ShowDialog();
        }

        private void intermediateCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntermediateCAfrm afrm = new IntermediateCAfrm();
            afrm.ShowDialog();
        }

        private void generateEndEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateEndfrm afrm = new GenerateEndfrm();
            afrm.ShowDialog();
        }

        private void signFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignForm afrm = new SignForm();
            afrm.ShowDialog();
        }

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifyForm afrm = new VerifyForm();
            afrm.ShowDialog();
        }
    }
}
