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
                new Option(OptionIdentifier.FIGHT, "Du verfehlst.#Du triffst den Ork, doch dieser kämpft unbeirrt weiter.", new string[]{"BATTLE_FAIL1", "BATTLE_HIT1"}, new string[]{"Ork", "Monster"}),
                new Option(OptionIdentifier.FLEE, "Du fliehst dorthin wo du hergekommen bist", new string[]{"#START#"})
            }, "BATTLE_START","Auf deinem Weg greift dich plötzlich ein Ork an."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "Du gehst einen Schritt zurück und der Ork kommt aus seiner Balance#Die Keule trifft dich und du stirbst", new string[]{"BATTLE_HIT1", "BATTLE_DEATH"}, new string[]{"Zurück", "Deckung"}),
                new Option(OptionIdentifier.FLEE, "Du fliehst dorthin wo du hergekommen bist", new string[]{"#START#"})
            }, "BATTLE_FAIL1","Wütend attackiert dich der Ork und schwingt seine Keule um dich zu erschlagen."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.FIGHT, "Du besiegst den Ork und gehst weiter.#Du schlägst den Ork und verfehlst. Nun holt er mit der Keule aus und droht dich zu zerquetschen.#Du triffst den Ork, doch dieser kämpft unbeirrt weiter.", new string[]{"#END#", "BATTLE_FAIL1", "BATTLE_HIT1"}, new string[]{"Ork", "Monster"}),
                new Option(OptionIdentifier.FLEE, "Du fliehst dorthin wo du hergekommen bist", new string[]{"#START#"})
            }, "BATTLE_HIT1","Jetzt ist die Gelegenheit da, der Ork ist angeschlagen."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "", new string[]{"#START#"})
            }, "BATTLE_DEATH","Der Ork erschlägt dich und plündert deine Überreste. Tippe: Gehe zum Start um neu anzufangen.")
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
