using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star_formatiive
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Pen drawpen = new Pen(Color.Black, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen drawpen = new Pen(Color.Black, 1);
            DrawStar(drawpen, 40, 50, 25);
        }
        private void DrawStar(Pen drawpen, float x, float y, float size)
        {
            Graphics FormGraphics = this.CreateGraphics();

            float sizemultiplier = size / 140;

            FormGraphics.DrawLine(drawpen, sizemultiplier* 110 + x, sizemultiplier * 9 + y, sizemultiplier * 84 + x, sizemultiplier * 84 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 110 + x, sizemultiplier * 9 + y, sizemultiplier * 133 + x, sizemultiplier * 83 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 8 + x, sizemultiplier * 84 + y, sizemultiplier * 84 + x, sizemultiplier * 84 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 47 + x, sizemultiplier * 203 + y, sizemultiplier * 70 + x, sizemultiplier * 129 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 8 + x, sizemultiplier * 84 + y, sizemultiplier * 70 + x, sizemultiplier * 129 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 47 + x, sizemultiplier * 203 + y, sizemultiplier * 109 + x, sizemultiplier * 158 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 173 + x, sizemultiplier * 203 + y, sizemultiplier * 109 + x, sizemultiplier * 158 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 173 + x, sizemultiplier * 203 + y, sizemultiplier * 148 + x, sizemultiplier * 129 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 211 + x, sizemultiplier * 84 + y, sizemultiplier * 148 + x, sizemultiplier * 129 + y);
            FormGraphics.DrawLine(drawpen, sizemultiplier * 211 + x, sizemultiplier * 84 + y, sizemultiplier * 133 + x, sizemultiplier * 83 + y);
        }
        
}
}
