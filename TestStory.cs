using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class TestStory
    {
        Scene[] scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.OPEN, "Öffnen", new string[]{"END_SUCCESS"}, new string[]{"Tor","Schloss","Tür"})
            }, "T1","Testszene Tor öffnen"),
            new Scene(new Option[]{}, "END_SUCCESS","Das Tör öffnet sich")
        };
        private Scene _currentScene;
        public Scene CurrentScene
        {
            get { return _currentScene; } 
            set { _currentScene = value; }
        }
        public TestStory()
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
