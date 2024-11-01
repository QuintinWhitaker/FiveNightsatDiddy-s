using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace FiveNightsatDiddy_s
{
    public partial class LostatDiddys : Form
    {
       // Global varibles
        int page = 1;
        Random randGen = new Random();
        SoundPlayer player = new SoundPlayer();

        public LostatDiddys()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tracks what page of the story the user is at

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check what page we are currntly on, and then flip to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 18;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }

            DisplayPage();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Check what page we are currntly on, and then flip to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 14;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 1;
            }


            DisplayPage();

        }




        public void DisplayPage()
        {
            
            switch (page)
            {
                // Text and Cases
                case 1:
                   // Inserts sounds
                    player = new SoundPlayer(Properties.Resources.Hello_SoundBible_com_1812488315);
                    player.Play();
                   // Insert images
                    storyImages.Image = Properties.Resources.Diddy_house;
                    outputLabel.Text = "Your car breaks down, but you come across a house. DO you enter the house?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 2:
                    storyImages.Image = Properties.Resources.Diddy_2;
                       outputLabel.Text = "Diddy offers you to come in. Do you?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 3:
                    player = new SoundPlayer(Properties.Resources.Loud_Bang_Osama_Bin_Laden_925764326);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "You freeze to death in the car. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "Diddy offers you a drink, do you take it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "He pulls out a gun and shoots you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "You feel dizzy. Do you lie in Diddy's bed?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    player = new SoundPlayer(Properties.Resources. TV_Static_Mike_Koenig_1287909192);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "Diddy asks if you are hungry?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "You wake up next to Diddy. He offers you breakfast. Do you take it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "You fall over and hit your head. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "Diddy offers you three options?";
                    option1Label.Text = "Pizza";
                    option2Label.Text = "Chicken";
                    option3Label.Text = "Watermelon";
                    break;
                case 11:
                    player = new SoundPlayer(Properties.Resources. Short_Beep_Tone_SoundBible_com_1937840853);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "Diddy shoots you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    storyImages.Image = Properties.Resources.Diddy_and_lebron;
                    outputLabel.Text = "Lebron James appears out of nowhere and asks if you want to play basketball with him and Diddy?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    int randomValue = randGen.Next(1, 101);

                    break;
                case 14:
                    player = new SoundPlayer(Properties.Resources. Loud_Bang_Osama_Bin_Laden_925764326);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "You get poisned. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    break;
                case 15:
                    storyImages.Image = Properties.Resources.Diddy_3;
                    outputLabel.Text = "After you eat Diddy asks if you want to go for a swim?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 16:
                    storyImages.Image = Properties.Resources.Diddy_3;
                    outputLabel.Text = "Diddy offers you a beverage?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    storyImages.Image = Properties.Resources.Diddy_and_lebron;
                    outputLabel.Text = "Lebron and Diddy take turns beating you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 18:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "Lebron jumps on you until you die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 19:
                    storyImages.Image = Properties.Resources.Diddy_3;
                    outputLabel.Text = "The pool was fill with baby oil, you drown. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    player = new SoundPlayer(Properties.Resources. TV_Static_Mike_Koenig_1287909192);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "Diddy kills you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = "You ask him to get get your drink. While he's gone you realize you can leave. Do you?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 22:
                    player = new SoundPlayer(Properties.Resources. Loud_Bang_Osama_Bin_Laden_925764326);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy_3;
                    outputLabel.Text = " Diddy gets mad, you die. Play again? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 23:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text = " You eascape and win! Play again? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 24:
                    storyImages.Image = Properties.Resources.Diddy_2;
                    outputLabel.Text =" The drink was poisened. You die. Play again ? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    player = new SoundPlayer(Properties.Resources. Loud_Bang_Osama_Bin_Laden_925764326);
                    player.Play();
                    storyImages.Image = Properties.Resources.Diddy;
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 10)
            {
                page = 15;
            }

            DisplayPage();
        }

       
    }
}
