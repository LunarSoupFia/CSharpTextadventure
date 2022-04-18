using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Story
    {
        Scene[] scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.FIGHT, "Kämpfen", new string[]{"END_SUCCESS", "END_FAIL"}),
                new Option(OptionIdentifier.FLEE, "Fliehen", new string[]{"END_FAIL"}),
                new Option(OptionIdentifier.HEAL, "Heilen", new string[]{"T1", "END_FAIL"})
            }, "T1","Testszene Kampf"),
            new Scene(new Option[]{}, "END_FAIL","Alle sterben"),
            new Scene(new Option[]{}, "END_SUCCESS","Und dann lebten sie glücklich und zufrieden.")
        };
        private Scene _currentScene;
        public Scene CurrentScene
        {
            get { return _currentScene; } 
            set { _currentScene = value; }
        }
        public Story()
        {
            CurrentScene = scenes[0];
        }
        
        //Diese Methode ermittelt eine Szene anhand ihres Identifiers
        internal Scene getSceneByIdentifier(string identifier)
        {
            foreach (Scene scene in this.scenes)
            {
                if (scene.SceneIdentifier == identifier)
                {
                    return scene;
                }
            }
            return null;
        }
    }
}
