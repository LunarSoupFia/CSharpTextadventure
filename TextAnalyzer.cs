using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Textadventure;

namespace Textadventure
{
    internal class TextAnalyzer
    {
        public static Option GetOption(Scene currentScene, string input)
        {
            input = input.ToLower();
            string[] split = input.Split(' ');
            string keyword = split[0];
            OptionIdentifier identifier = getOptionIdentifierByKeyword(keyword);
            Option[] validOptions = currentScene.getOptionsByIdentifier(identifier);
            foreach (Option option in validOptions)
            {
                if(option.AllowedFor == null || option.AllowedFor.Length == 0)
                {
                    return option;
                }
                foreach (string allowed in option.AllowedFor)
                {
                    for (int i = 1; i < split.Length; i++)
                    {
                        if (split[i] == allowed.ToLower())
                        {
                            return option;
                        }
                    }
                }
            }
            
            return null;
        }

        public static OptionIdentifier getOptionIdentifierByKeyword(string keyword)
        {
            switch (keyword)
            {
                case "höre":
                    return OptionIdentifier.LISTEN;
                case "fight":
                case "besiege":
                case "bekämpfe":
                case "schlage":
                    return OptionIdentifier.FIGHT;
                case "flee":
                case "flieh":
                case "fliehe":
                    return OptionIdentifier.FLEE;
                case "heal":
                case "heile":
                    return OptionIdentifier.HEAL;
                case "öffne":
                    return OptionIdentifier.OPEN;
                case "gehe":
                case "laufe":
                    return OptionIdentifier.GO;
                case "frage":
                    return OptionIdentifier.ASK;
                case "drücke":
                    return OptionIdentifier.PRESS;
                case "suche":
                case "schau":
                    return OptionIdentifier.LOOK;
                default:
                    return OptionIdentifier.NULL;
            }
        }
    }
}
