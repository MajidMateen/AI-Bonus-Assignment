using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       
        public Random _random;
        bool down = false;
        public Form1()
        {
            InitializeComponent();
           timer1.Start();

         


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(pictureBox3.Location.X - 10, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y);

            

            if (pictureBox2.Location.X < 10)
            {
                pictureBox2.Location = new Point(1000, pictureBox2.Location.Y);
            }
            if (pictureBox3.Location.X < 10)
            {
                pictureBox3.Location = new Point(1000, pictureBox3.Location.Y);
            }
            if (pictureBox4.Location.X < 10)
            {
                pictureBox4.Location = new Point(1000, pictureBox4.Location.Y);
            }

            


            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Jump();
            }
            else if (down == true)
            {

                pictureBox5.Location = new Point(pictureBox5.Location.X, 250);
                down = false;
            }

            else if (pictureBox5.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Jump();
            }
            else if (down == true)
            {

                pictureBox5.Location = new Point(pictureBox5.Location.X, 250);
                down = false;
            }

            else if(pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                Jump();
                down = false;
            }
            else if (down == true)
            {

                pictureBox5.Location = new Point(pictureBox5.Location.X, 250);
                down = false;
            }
            
        }
 
        public void Jump()
        {
            pictureBox5.Location = new Point(pictureBox5.Location.X,pictureBox5.Location.Y-150);
            down = true;
        }
        

    }
}
