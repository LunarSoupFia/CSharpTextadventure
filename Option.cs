using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    public class Option
    {
        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        private OptionIdentifier _identifier;
       
        public OptionIdentifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }
        private string _optionText;

        public string OptionText
        {
            get { return _optionText; }
            set { _optionText = value; }
        }
        private string[] _nextScene;

        public string[] NextScene
        {
            get { return _nextScene; }
            set { _nextScene = value; }
        }

        private Item _requiredItem;

        public Item RequiredItem
        {
            get { return _requiredItem; }
            set { _requiredItem = value; }
        }

        private VisibilityCondition _visibility;
        public VisibilityCondition Visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }

        private string[] _allowedFor;

        public string[] AllowedFor
        {
            get { return _allowedFor; }
            set { _allowedFor = value; }
        }

        private string _neededQuest;

        public string NeededQuest
        {
            get { return _neededQuest; }
            set { _neededQuest = value; }
        }

        public Option(OptionIdentifier Identifier, string OptionText, string[] NextScene)
        {
            this.Identifier = Identifier;
            this.OptionText = OptionText;
            this.NextScene = NextScene;
            this.Visibility = VisibilityCondition.ALWAYS;
        }

        public Option(OptionIdentifier Identifier, string OptionText, string[] NextScene, string[] AllowedFor)
        {
            this.Identifier = Identifier;
            this.OptionText = OptionText;
            this.NextScene = NextScene;
            this.AllowedFor = AllowedFor;
            this.Visibility = VisibilityCondition.ALWAYS;
        }

        public Option(OptionIdentifier Identifier, string OptionText, string[] NextScene, string[] AllowedFor, VisibilityCondition Visibility)
        {
            this.Identifier = Identifier;
            this.OptionText = OptionText;
            this.NextScene = NextScene;
            this.AllowedFor = AllowedFor;
            this.Visibility = Visibility;
        }

        public Option(OptionIdentifier Identifier, string OptionText, string[] NextScene, string[] AllowedFor, string NeededQuest)
        {
            this.Identifier = Identifier;
            this.OptionText = OptionText;
            this.NextScene = NextScene;
            this.AllowedFor = AllowedFor;
            this.Visibility = VisibilityCondition.ALWAYS;
            this.NeededQuest = NeededQuest;
        }

        public Option(OptionIdentifier Identifier, string OptionText, string[] NextScene, string[] AllowedFor, VisibilityCondition Visibility, string NeededQuest)
        {
            this.Identifier = Identifier;
            this.OptionText = OptionText;
            this.NextScene = NextScene;
            this.AllowedFor = AllowedFor;
            this.Visibility = Visibility;
            this.NeededQuest = NeededQuest;
        }
    }
}
