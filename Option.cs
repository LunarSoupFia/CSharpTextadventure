using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    public class Option
    {
        private string optionIdentifier;

        public string OptionIdentifier
        {
            get { return optionIdentifier; }
            set { optionIdentifier = value; }
        }
        private string optionText;

        public string OptionText
        {
            get { return optionText; }
            set { optionText = value; }
        }
        private string[] nextScene;

        public string[] NextScene
        {
            get { return nextScene; }
            set { nextScene = value; }
        }

    }
}
