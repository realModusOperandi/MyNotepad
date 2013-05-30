using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class DocumentWindow : Form
    {
        public DocumentWindow()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Can't just open a new form because that document would close when this one does.
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
    }
}
