using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10
{
    public partial class FormAddResources : Form
    {
        public FormAddResources()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.mario2;
            imgimage3.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.mario1;
        }
    }
}
