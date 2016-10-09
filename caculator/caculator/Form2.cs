using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //it cancels the close form2 window
        private void messag(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("if you want to close this just uncheck the tickbox");
            e.Cancel = true;
        }
    }
}
