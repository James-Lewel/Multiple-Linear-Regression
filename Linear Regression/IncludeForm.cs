using System;
using System.Windows.Forms;

namespace Linear_Regression
{
    public partial class IncludeForm : Form
    {
        public IncludeForm(string data)
        {
            InitializeComponent();

            label.Text += "\n\n" + data;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
