using System;
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
        Story story;
        string[] labelOptionList = new string[] {"","","","","",""};
        string[] defaultOptionList = new string[] { "", "", "", "", "", "" };
        public Form1()
        {
            InitializeComponent();
            story = new Story();
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
                option1.Text = defaultOptionList[0];
                option2.Text = defaultOptionList[1];
                option3.Text = defaultOptionList[2];
                option4.Text = defaultOptionList[3];
                option5.Text = defaultOptionList[4];
                option6.Text = defaultOptionList[5];
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
                option1.Text = labelOptionList[0];
                option2.Text = labelOptionList[1];
                option3.Text = labelOptionList[2];
                option4.Text = labelOptionList[3];
                option5.Text = labelOptionList[4];
                option6.Text = labelOptionList[5];
            } else {
                option1.Text = defaultOptionList[0];
                option2.Text = defaultOptionList[1];
                option3.Text = defaultOptionList[2];
                option4.Text = defaultOptionList[3];
                option5.Text = defaultOptionList[4];
                option6.Text = defaultOptionList[5];
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
                    if (chosenOption.Visibility == VisibilityCondition.ONCE)
                    {
                        chosenOption.Visibility = VisibilityCondition.INACTIVE_ONCE;
                    }
                    
                    if (story.CurrentScene.BackgroundImage != null)
                    {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                        Image backImage = (Image)resources.GetObject(story.CurrentScene.BackgroundImage);
                        if (backImage != null)
                        {
                            BackgroundImage = backImage;
                        }
                    } 
                    story.questLog.QuestLogDescription = "";
                    foreach (Quest quest in story.questLog.Quests)
                    {
                        if (quest.QuestStatus != 0)
                        {
                            story.questLog.QuestLogDescription = story.questLog.QuestLogDescription + quest.QuestName + nl + quest.QuestDescription + nl + nl;
                        }
                        else if (quest.QuestStatus != 1)
                        {
                            story.questLog.QuestLogDescription = story.questLog.QuestLogDescription + quest.QuestName + " ERLEDIGT!"+ nl + nl;
                        }
                    }
                    questBox.Text = story.questLog.QuestLogDescription;
                }
                else
                {
                    MessageBox.Show("invalid command");
                }
                inputbox.Text = "Eingabe";
            }
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

        private void action1_Click(object sender, EventArgs e)
        {
            inputbox.Text = action1.Text;
        }

        private void action2_Click(object sender, EventArgs e)
        {
            inputbox.Text = action2.Text;
        }

        private void action3_Click(object sender, EventArgs e)
        {
            inputbox.Text = action3.Text;
        }

        private void action4_Click(object sender, EventArgs e)
        {
            inputbox.Text = action4.Text;
        }

        private void action5_Click(object sender, EventArgs e)
        {
            inputbox.Text = action5.Text;
        }

        private void action6_Click(object sender, EventArgs e)
        {
            inputbox.Text = action6.Text;
        }

        private void action7_Click(object sender, EventArgs e)
        {
            inputbox.Text = action7.Text;
        }

        private void action8_Click(object sender, EventArgs e)
        {
            inputbox.Text = action8.Text;
        }
        
        private void action9_Click(object sender, EventArgs e)
        {
            inputbox.Text = action9.Text;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            inputbox.Text += " " + option1.Text;
        }

        private void option2_Click(object sender, EventArgs e)
        {
            inputbox.Text += " " + option2.Text;
        }

        private void option3_Click(object sender, EventArgs e)
        {
            inputbox.Text += " " + option3.Text;
        }

        private void option4_Click(object sender, EventArgs e)
        {
            inputbox.Text += " " + option4.Text;
        }

        private void option5_Click(object sender, EventArgs e)
        {
            inputbox.Text += " " + option5.Text;
        }

        private void option6_Click(object sender, EventArgs e)
        {
            inputbox.Text += " " + option6.Text;
        }
    }
}
