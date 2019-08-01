using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab_Some_Balls__Dodge_Some_Balls
{

    public partial class Balls : Form
    {

        
        Graphics g; // declare the graphics object

        int x3 = 475, y3 = 250 ;
        //Declare the rectangles to display the spaceship and planets in
        Rectangle area, area1, area2, area3, area4, area5, area6, area7;
        Random Circle = new Random();
        //hi2
        int x = 475;
        int y = Circle.Next(5, 50);// starting position of Red Circle

        private void TmrBalls_Tick(object sender, EventArgs e)
        {
            area1.X -= 5;// move the area(Red_Circle) across the panel
            area2.X -= 5  ; //  move the area(Blue_Circle) across the panel
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            g.DrawImage(White_Circle, area);
            //use the DrawImage method to draw the planet on the panel
            g.DrawImage(Red_Circle, area1);
            //use the DrawImage method to draw the planet on the panel
            g.DrawImage(Blue_Circle, area2);
            g.DrawImage(Red_Circle, area3);
            g.DrawImage(Red_Circle, area4);
            g.DrawImage(Blue_Circle, area5);
            g.DrawImage(Red_Circle, area6);
            g.DrawImage(Red_Circle, area7);
        }

        int x2 = 23, y2 = 150; //starting position of Blue Circle
        //Load our two images from the bin\debug folder
        Image White_Circle = Image.FromFile(Application.StartupPath + @"\White_Circle.png");
        Image Red_Circle = Image.FromFile(Application.StartupPath + @"\Red_Circle.png");
        Image Blue_Circle = Image.FromFile(Application.StartupPath + @"/Blue_Circle.png");


        public Balls()
        {
            InitializeComponent();
            area = new Rectangle(x2, y2, 30, 30);//spaceship's rectangle	
            area1 = new Rectangle(x, y, 20, 20); //planet1's rectangle
            area2 = new Rectangle(x3, y3, 20, 20); //Blue Circle's rectangle
            area3 = new Rectangle(x, y = Random, 20, 20);// 
            area4 = new Rectangle(x + 210, y, 40, 40);// 
            area5 = new Rectangle(x + 280, y, 40, 40);// 
            area6 = new Rectangle(x + 350, y, 40, 40);//
            area7 = new Rectangle(x + 420, y, 40, 40);// 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Press up to go up, press down to go down. Grab the blue balls, Dodge the red balls...Grab some balls, dodge some balls.");
       
        }

    }
}
