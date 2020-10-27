using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }

        private void BtnDisplayForm_Click(object sender, EventArgs e)
        {
            // Create an instance/object of the MessageForm Class
            MessageForm myOtherForm = new MessageForm();

            // Display the form
            //myOtherForm.CenterToParent();
            myOtherForm.ShowDialog();
        }
    }
}
