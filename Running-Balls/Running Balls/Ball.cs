// March 27, 2019 Nicholas Levesque. A simple game Program demonstarting the uses of Class based objects
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Running_Balls
{
    class Ball
    {
        //Class Variables
        public int X, Y, size, speedY, speedX;
        public bool invicblity;
        //Charinfo
        public Ball(int _X, int _Y, int _size, int _speedX, int _speedY)
        {
            X = _X;
            Y = _Y;
            size = _size;
            speedY = _speedY;
            speedX = _speedX;          
        }
        //Used in Collsion
        public void Invicblity(bool _invicblity)
        {
            invicblity = _invicblity;
        }
        //Move Method
        public void Move()
        {
            Y -= speedY;
        }
        //Gathers the witches current postion
        public void WitchPostion (int _witchX, int _witchY)
        {
            X = _witchX;
            Y = _witchY;
        }
        //Collsion
        public bool Collsion(Witch MC, Saint MC2, UserControl uc,Ball ball1)
        {
            Rectangle rec1 = new Rectangle(MC2.X, MC2.Y, MC2.size, MC2.size);
            Rectangle rec2 = new Rectangle(ball1.X, ball1.Y, ball1.size, ball1.size);
            if (rec1.IntersectsWith(rec2) && invicblity == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
