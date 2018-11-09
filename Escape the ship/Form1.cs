/// created by : Andrew Langford
/// date       : November 8th, 2018
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Escape_the_ship
{

    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;
        // special items to collect;
        bool item = false;
        bool p = false;
        bool win;

        SoundPlayer nextScene = new SoundPlayer(Properties.Resources.blip);
        SoundPlayer itemPlayer = new SoundPlayer(Properties.Resources.itemSound);
        SoundPlayer start = new SoundPlayer(Properties.Resources.Boxing_Bell_Start_Round_SoundBible_com_1691615580);

        public Form1()
        {
            start.PlaySync();

            InitializeComponent();
            //display initial message and options
            outputLabel.Text = "You wake up tied to examination table in a strange room. \nDo you try to break free?";
            redLabel.Text = "Yes";
            blueLabel.Text = "No";
            greenlabel.Visible = false;
            yellowlabel.Visible = false;
            greenButtonLabel.Visible = false;
            yellowButtonLabel.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene <= 25)
                {
                    nextScene.Play();
                }
                if (scene == 0)
                {
                    Random randGen = new Random();
                    int outcome = randGen.Next(1, 101);
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;

                    if (outcome < 90)
                    {
                        scene = 4;
                    }
                    else
                    {
                        scene = 5;
                    }
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 6;
                    item = true;
                }
                else if (scene == 6)
                {
                    Random randGen = new Random();
                    int outcome = randGen.Next(1, 101);

                    if (outcome < 60)
                    {
                        scene = 10;
                    }
                    else
                    {
                        scene = 12;
                    }
                }
                else if (scene == 7)
                {
                    Random randGen = new Random();
                    int outcome = randGen.Next(1, 101);

                    if (outcome < 90)
                    {
                        scene = 12;
                    }
                    else
                    {
                        scene = 9;
                    }
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 22)
                {
                    if (p == false)
                    {
                        if (p == true)
                        {
                            scene = 17;
                        }
                        else
                        {
                            scene = 15;
                        }
                    }
                    else
                    {
                        scene = 17;
                    }
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 14)
                {
                    scene = 13;
                }
                else if (scene == 26)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    Random randGen = new Random();
                    int outcome = randGen.Next(1, 101);
                    if (outcome < 50)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 19;
                    }

                }
                else if (scene == 13)
                {
                    scene = 23;
                }
                else if (scene == 21)
                {
                    scene = 13;
                }
                else if (scene == 23)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 13;
                    p = true;
                }
                else if (scene == 25)
                {
                    scene = 13;
                }

                else if (scene == 2 || scene == 3 || scene == 5 || scene == 9 || scene == 10 || scene == 15 || scene == 18 || scene == 19 || scene == 27)
                {
                    scene = 26;
                }
                else if (scene == 20)
                {
                    scene = 26;
                    win = true;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene <= 25)
                {
                    nextScene.Play();
                }
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 9;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 13)
                {
                    scene = 21;
                }
                else if (scene == 17)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {

                    scene = 13;

                }
                else if (scene == 23)

                {
                    scene = 25;
                }
                else if (scene == 99)
                {
                    this.Close();
                }
                else if (scene == 26)
                {
                    this.Close();
                }

            }
            else if (e.KeyCode == Keys.Space) //green button press 
            {
                if (scene <= 25)
                {
                    nextScene.Play();
                }
                if (scene == 13)
                {
                    if (p == true)
                    {
                        scene = 16;
                    }
                    else
                    {
                        Random randGen = new Random();
                        int outcome = randGen.Next(1, 101);

                        if (outcome <= 60 && outcome > 20)
                        {
                            scene = 14;
                        }
                        else if (outcome > 60)
                        {
                            scene = 15;
                        }
                        else
                        {
                            scene = 27;
                        }
                    }
                }
                else if (scene == 17)
                {
                    Random randGen = new Random();
                    int outcome = randGen.Next(1, 101);

                    if (outcome < 50)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 18;
                    }
                }
            }

            else if (e.KeyCode == Keys.N) //yellow button press 
            {
                if (scene <= 25)
                {
                    nextScene.Play();
                }
                if (scene == 13)
                {
                    itemPlayer.Play();
                    scene = 22;
                }
            }
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You wake up tied to examination table in a strange room. \nDo you try to break free?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    item = false;
                    p = false;
                    win = false;
                    start.Play();
                    break;
                case 1:
                    outputLabel.Text = "Are you sure you want to wait?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;

                    break;
                case 2:
                    outputLabel.Text = "By the time you decide to change your mind, an Alien walks into the room, notices your awake and probes you. Game over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 3:
                    outputLabel.Text = "You wait patiently until an Alien walks into the room, notices you're awake and probes you. Game Over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 4:
                    outputLabel.Text = "You manage to break free! You start leaving the room, but as you leave you notice a strange item. Do you grab it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                case 5:
                    outputLabel.Text = "You struggle to break free, but have no energy left. An alien walks into the room, presses a button on the console and everything goes black. Game Over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "You grab the object! You look out in to the corridor and can hear noises coming from the left.";
                    redLabel.Text = "Turn Right";
                    blueLabel.Text = "Turn Left";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    item = true;
                    break;
                case 7:
                    outputLabel.Text = "You look out in to the corridor and can hear noises coming from the left.";
                    redLabel.Text = "Turn Right";
                    blueLabel.Text = "Turn Left";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                case 9:
                    outputLabel.Text = "You turn left and start walking until you bump straight into the alien. He shoots his phaser at you, but forgets to set it to stun, Game Over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 10:
                    outputLabel.Text = "You took to long grabbing the item. The alien catches up to you and shoots you with his phaser. Game Over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "You reach the end of the corridor and you see a door with red illuminated symbols above it.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 11:
                    outputLabel.Text = " The alien catches up to you and shoots you with his phaser. Game Over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 13:
                    outputLabel.Text = "What do you do?";
                    redLabel.Text = "Look around";
                    greenlabel.Text = "Push on the door \nas hard as you can.";
                    blueLabel.Text = "Cry for help.";
                    greenlabel.Visible = true;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = true;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    if (item == true)
                    {
                        yellowButtonLabel.Visible = true;
                        yellowlabel.Text = "Unlock the door";
                        yellowlabel.Visible = true;
                    }
                    break;
                case 15:
                    outputLabel.Text = "You fall 10,000 feet to your death. Game Over.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 14:
                    outputLabel.Text = "You push as hard as you can on the door but it doesn't budge. Maybe you could try again?";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 16:
                    outputLabel.Text = "You manage to break open the door! You look out and see absolutely nothing, it seems you are on a flying ship. Do you jump out?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                case 17:


                    outputLabel.Text = "You jump out of the ship. When do you pull your shoot?";
                    redLabel.Text = "1000 ft";
                    blueLabel.Text = "2500 ft";
                    greenlabel.Text = "5000 ft";
                    greenlabel.Visible = true;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = true;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                case 18:
                    outputLabel.Text = "You pulled your shoot to early and your parachute cannot catch the wind. You fall to your death. Game Over!";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 19:
                    outputLabel.Text = "You didn't pull your shoot at the right time! You hit the ground to hard and die. Game Over!";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 20:
                    outputLabel.Text = "You pull your shoot and land safety. Congratulations, You Win!";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 21:
                    outputLabel.Text = "But nobody came.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 22:
                    outputLabel.Text = "The strange object glows a bright green and the door unlocks and opens. You look out and see absolutely nothing, it seems you are on a flying ship. Do you jump out?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                case 23:
                    outputLabel.Text = "You notice a bench next to the door, under the bench you see a parachute. Do you put it on?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                case 24:
                    outputLabel.Text = "You put on the parachute!";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 25:
                    outputLabel.Text = "You don't put on the parachute!";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 27:
                    outputLabel.Text = "You trip and knock yourself out on the door handle. Game Over";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;
                    break;
                case 26:
                    outputLabel.Text = "Do you want to play agian";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenlabel.Visible = false;
                    yellowlabel.Visible = false;
                    greenButtonLabel.Visible = false;
                    yellowButtonLabel.Visible = false;
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    break;
                default:
                    break;
            }
        }
        // view controls for using a keyboard
        private void controlsOpenLabel_Click(object sender, EventArgs e)
        {
            controlsCloseLabel.Visible = true;
            controlsOpenLabel.Visible = false;
            controlsImage.Visible = true;
        }

        private void controlsCloseLabel_Click(object sender, EventArgs e)
        {
            controlsCloseLabel.Visible = false;
            controlsOpenLabel.Visible = true;
            controlsImage.Visible = false;
        }
    }
}