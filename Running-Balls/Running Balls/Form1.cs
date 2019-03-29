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
using System.Diagnostics;

namespace Running_Balls
{
    public partial class Form1 : Form
    {
        // Text Variable
        public static string endGame = "The Saint Killed the Witch!";
        //Stop watched used for the game
        public static Stopwatch  stopWatch = new Stopwatch();
        //Timer variable to stop game
        public static int stopTimeTimer = 45;
        public Form1()
        {
            InitializeComponent();
            //Adds main Screen
            MainScreen FS = new MainScreen();
            this.Controls.Add(FS);
            //Hides Cursor
            Cursor.Hide();
        }
        //Centers Screen
        private void Form1_Load(object sender, EventArgs e)
        {         
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
    }
}
