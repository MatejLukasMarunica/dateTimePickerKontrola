using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePickerkontrola
{
    public partial class Form1 : Form
    {
        DateTime datum, vrijeme;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePickerVrijeme_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonrezervacija_Click(object sender, EventArgs e)
        {
            datum = dateTimePickerDatum.Value;
            vrijeme = dateTimePickerVrijeme.Value;
            richTextBox1.Clear();
            richTextBox1.AppendText("Vaš datum leta je: " + Environment.NewLine + datum.ToShortDateString() + Environment.NewLine);
            richTextBox1.AppendText("Vaše vrijeme posalka je: " + Environment.NewLine + vrijeme.ToShortTimeString());
        }
    }
}
