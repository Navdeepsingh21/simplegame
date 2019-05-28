using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplegame
{
    public partial class Form1 : Form
    {
        Class1 g1 = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            g1.load();
            btn_load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
        }

        private void Btn_spin_Click(object sender, EventArgs e)
        {
            g1.spin();
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            g1.shoot();
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
        }

        private void Btn_shootaway_Click(object sender, EventArgs e)
        {
            g1.shootaway();
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
        }
    }
}
