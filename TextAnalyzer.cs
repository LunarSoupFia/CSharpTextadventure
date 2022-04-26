﻿using System;
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

        private static OptionIdentifier getOptionIdentifierByKeyword(string keyword)
        {
            switch (keyword)
            {
                case "fight":
                    return OptionIdentifier.FIGHT;
                case "flee":
                case "flieh":
                    return OptionIdentifier.FLEE;
                case "heal":
                    return OptionIdentifier.HEAL;
                case "öffne":
                    return OptionIdentifier.OPEN;
                case "drücke":
                    return OptionIdentifier.PRESS;
                default:
                    return OptionIdentifier.NULL;
            }
        }
    }
}