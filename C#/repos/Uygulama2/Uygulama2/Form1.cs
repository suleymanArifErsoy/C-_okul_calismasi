using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Niye Bastın Mal Deyneği");
        }

        private void btnTıkla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aferin Reis ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
