using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class TestBattle
    {
        private static Scene[] _scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.FIGHT, "Du besiegst den Ork und gehst weiter", new string[]{"#END#"}, new string[]{"Ork", "Monster"}),
                new Option(OptionIdentifier.FLEE, "Du fliehst dorthin wo du hergekommen bist", new string[]{"#START#"})
            }, "BATTLE_START","Auf deinem Weg greift dich plötzlich ein Ork an.")
            
        };
        public static Scene[] getScenes(string startScene, string endScene)
        {
            foreach (Scene scene in _scenes)
            {
                foreach(Option option in scene.Options)
                {
                    for (int i = 0; i < option.NextScene.Length; i++)
                    {
                        if (option.NextScene[i] == "#START#")
                        {
                            option.NextScene[i] = startScene;
                        }
                        else if (option.NextScene[i] == "#END#")
                        {
                            option.NextScene[i] = endScene;
                        }
                    }
                }
            }
            return _scenes;
        }
    }
}
