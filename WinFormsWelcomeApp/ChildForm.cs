using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWelcomeApp
{
    public partial class ChildForm : Form
    {
        Form form;
        public ChildForm()
        {
            InitializeComponent();
        }

        public ChildForm(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.BackColor = Color.Red;
        }
    }
}
