// March 27, 2019 Nicholas Levesque. A simple game Program demonstarting the uses of Class based objects
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Running_Balls
{
    public partial class helpScreen : UserControl
    {
        public helpScreen()
        {
            InitializeComponent();
            //Help Text
            helpLabel.Text =  "Hello, welcome to Witch v Saint! Assuiming your new, the movement " +
            "for The Saint, it is the right joystick and press the blue button next to it for invincblity. " +
            "For the Witch, it is the left joystick, press the blue button next to it to shoot a black ball. " +
            "The objective of this game is for the Witch to catch the Saint, you have 30 seconds until the Saint will escape. " +
            "YOU ONLY HAVE 3 CHARGES ON YOUR ABLITYS, use them well. Happy hunting!(Or Being Hunted!";
        }
        //Sends to Main Screen
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen Sc = new MainScreen();
            f.Controls.Add(Sc);
            Sc.Focus();
            this.Dispose();
        }
        //Centers Screen
        private void helpScreen_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
    }
}
