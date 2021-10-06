using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoetzGarage_Invoice
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
            Main obj = new Main();
            timer1.Stop();
            obj.Show();
            this.Hide();
        }
    }
}
