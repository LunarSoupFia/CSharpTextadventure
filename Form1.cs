﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textadventure
{
    public partial class Form1 : Form
    {
        TestStory story;
        string[] labelOptionList = new string[] {"","","","","",""};
        string[] defaultOptionList = new string[] { "gehe zu", "benutze", "frage nach", "fliehe", "bekämpfe", "drücke" };
        public Form1()
        {
            InitializeComponent();
            story = new TestStory();
            outputBox.Text = story.CurrentScene.SceneDescription;
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void questBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if (inputbox.Text == "" || inputbox.Text == "Eingabe")
            {
                action1.Text = defaultOptionList[0];
                action2.Text = defaultOptionList[1];
                action3.Text = defaultOptionList[2];
                action4.Text = defaultOptionList[3];
                action5.Text = defaultOptionList[4];
                action6.Text = defaultOptionList[5];
                return;
            }
            int optionCounter = 0;
            string[] input = inputbox.Text.Split(" ");
            if (input.Length > 0)
            {
                foreach (Option option in story.CurrentScene.Options)
                {

                    if (option.Identifier == TextAnalyzer.getOptionIdentifierByKeyword(input[0])
                       && option.AllowedFor != null && option.AllowedFor.Length > 0)
                    {
                        labelOptionList[optionCounter] = option.AllowedFor[0];
                        optionCounter++;
                    }
                    
                }
            }
            if (optionCounter > 0)
            {
                for (int i = optionCounter; i < labelOptionList.Length; i++)
                {
                    labelOptionList[i] = "";
                }
                action1.Text = labelOptionList[0];
                action2.Text = labelOptionList[1];
                action3.Text = labelOptionList[2];
                action4.Text = labelOptionList[3];
                action5.Text = labelOptionList[4];
                action6.Text = labelOptionList[5];
            } else {
                action1.Text = defaultOptionList[0];
                action2.Text = defaultOptionList[1];
                action3.Text = defaultOptionList[2];
                action4.Text = defaultOptionList[3];
                action5.Text = defaultOptionList[4];
                action6.Text = defaultOptionList[5];
            }
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Option chosenOption = TextAnalyzer.GetOption(story.CurrentScene, inputbox.Text);
                if (chosenOption != null)
                {
                    int random = 0;
                    if (chosenOption.NextScene.Length > 1)
                    {
                        random = Convert.ToInt32(new Random().Next(chosenOption.NextScene.Length));
                    }
                    string nl = Environment.NewLine;
                    story.CurrentScene = story.getSceneByIdentifier(chosenOption.NextScene[random]);
                    string[] split = chosenOption.OptionText.Split('#');
                    if (split.Length > 1)
                    {
                        outputBox.Text = split[random] + nl + nl + story.CurrentScene.SceneDescription;
                    } else {
                        outputBox.Text = split[0] + nl + nl + story.CurrentScene.SceneDescription;
                    }

                }
                else
                {
                    MessageBox.Show("invalid command");
                }
                inputbox.Text = "Eingabe";
            }
        }

        
        private void action1_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = action1.Text;
            } else { inputbox.Text += " " + action1.Text; }
        }

        private void action2_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = action2.Text;
            } else { inputbox.Text += " " + action2.Text; }
        }

        private void action3_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = action3.Text;
            } else { inputbox.Text += " " + action3.Text; }
        }

        private void action4_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = action4.Text;
            } else { inputbox.Text += " " + action4.Text; }
        }

        private void action5_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = action5.Text;
            } else { inputbox.Text += " " + action5.Text; }
        }

        private void action6_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = action6.Text;
            }
            else { inputbox.Text += " " + action6.Text; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (inputbox.Text == "Eingabe")
            {
                inputbox.Text = "";
            }
        }
    }
}
