﻿// March 27, 2019 Nicholas Levesque. A simple game Program demonstarting the uses of Class based objects
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
    public partial class EndGame : UserControl
    {
        public EndGame()
        {        
            InitializeComponent();
            //Determines what it will write
            if (Form1.stopWatch.Elapsed.Seconds < Form1.stopTimeTimer)
            {
                endScreenLabel.Text = "Oh No! The Witch Killed The Saint!";
                timerLabel.Text = "You lasted " + Convert.ToString(Form1.stopWatch.Elapsed.Seconds) + " Seconds";
            }
            if (Form1.stopWatch.Elapsed.Seconds == Form1.stopTimeTimer)
            {
                endScreenLabel.Text = "The Saint Escaped the witch!";
                timerLabel.Text = "You escaped!";
            }
        }
        //Centers Screen
        private void EndGame_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }
        //Exit Button
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form1.stopWatch.Reset();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen Sc = new MainScreen();
            f.Controls.Add(Sc);
            Sc.Focus();
        }
    }
}
