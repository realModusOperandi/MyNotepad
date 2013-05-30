using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class DocumentWindow : Form
    {
        String currentFilePath = "";
        public DocumentWindow()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Can't just open a new form because that document would close when this one does.
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            currentFilePath = of.FileName;
            //Console.WriteLine(currentFilePath);
            if (!currentFilePath.Equals(""))
            {
                StreamReader fileReader = new StreamReader(currentFilePath);
                mainTextBox.Text = fileReader.ReadToEnd();
                fileReader.Close();
            }
        }
    }
}
