using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İddaatahminprgrm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void eB_Button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();

            frm5.Show();
        }

        private void eB_Button2_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();

            frm6.Show();
        }

        private void eB_Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
