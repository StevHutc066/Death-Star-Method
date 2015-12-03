using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Death_Star_Method
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            DeathStar(55, 55, 400);
        }

        /// <summary>
        /// Draws a death star.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="pixels"></param>
        public void DeathStar(float x, float y, float pixels)
        {
            // creates a scale to scale the death star properly when using inputted pixel size
            float scale = pixels / 400;

            // creates a red pen for drawing the death star
            Pen deathPen = new Pen(Color.Red);

            // draws a circle for the Death Star
            g.DrawArc(deathPen, x, y, (400 * scale), (400 * scale), 273, 354);

            // draws the hole opening in the Death Star
            g.DrawLine(deathPen, ((x + ( 190 * scale))), y, ((x +(190 * scale))), (y + (20 * scale)));
            g.DrawLine(deathPen, (x + ( 190 * scale)), ((y + (20 * scale))), ((x + (210 * scale))), ((y + (20 * scale))));
            g.DrawLine(deathPen, ((x + (210 * scale))), y, ((x + (210 * scale))), (y + (20 * scale)));
        }
    }
}
