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
        TestStory story;

        public Form1()
        {
            InitializeComponent();
            story = new TestStory();
            textBox1.Text = story.CurrentScene.SceneDescription;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Option chosenOption = TextAnalyzer.GetOption(story.CurrentScene, inputbox.Text);
                if (chosenOption != null)
                {
                    story.CurrentScene = story.getSceneByIdentifier(chosenOption.NextScene[0]);
                    textBox1.Text = story.CurrentScene.SceneDescription;
                }
                else
                {
                    MessageBox.Show("invalid command");
                }
            }
        }

        private void action3_Click(object sender, EventArgs e)
        {

        }

        private void action1_Click(object sender, EventArgs e)
        {
            inputbox.Text = action1.Text;
        }

        private void action2_Click(object sender, EventArgs e)
        {
            inputbox.Text = action2.Text;
        }

        private void action3_Click_1(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
