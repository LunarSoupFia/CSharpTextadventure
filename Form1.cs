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
        Story testStory;

        public Form1()
        {
            InitializeComponent();
            testStory = new Story();
            textBox1.Text = testStory.CurrentScene.SceneDescription;
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
                Option chosenOption = null;
                switch (textBox2.Text)
                {
                    case "fight":
                        chosenOption = testStory.CurrentScene.getOptionByIdentifier(OptionIdentifier.FIGHT);
                        break;
                    case "flee":
                        chosenOption = testStory.CurrentScene.getOptionByIdentifier(OptionIdentifier.FLEE);
                        break;
                    case "heal":
                        chosenOption = testStory.CurrentScene.getOptionByIdentifier(OptionIdentifier.HEAL);
                        break;
                    default:
                        break;
                }
                if (chosenOption != null)
                {
                    testStory.CurrentScene = testStory.getSceneByIdentifier(chosenOption.NextScene[0]);
                    textBox1.Text = testStory.CurrentScene.SceneDescription;
                }
            }
        }
    }
}
