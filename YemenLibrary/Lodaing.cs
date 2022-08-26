using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemenLibrary
{
    public partial class Lodaing : Form
    {
        private int _ticks;
        public Lodaing()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 20) {
                this.Close();
                Home f = new Home();
                this.Hide();
                f.Show();
            }

        }
    }
}
