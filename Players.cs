using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mahjongg
{
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Mahjongg(this, p1.Text, p2.Text, p3.Text, p4.Text).Show();
            Hide();
        }
    }
}
