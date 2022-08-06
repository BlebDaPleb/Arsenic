using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ezOverLay;

namespace Arsenic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var enemypen = new Pen(Color.Red, 3);
            Graphics graphics = e.Graphics;
            graphics.DrawLine(enemypen, Width / 2, Height, Width / 2, Height / 2);
            graphics.DrawLine(enemypen, 0, 0, Width / 2, Height / 2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 234234
            ez ez = new ez();
            ez.SetInvi(this);
            ez.DoStuff("Counter-Strike: Global Offensive - Direct3D 9", this);
            // ez.StartLoop(10, "Counter-Strike: Global Offensive - Direct3D 9", this);
        }
    }
}
