using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class TestStory
    {
        Scene[] scenes=new Scene[] { };
        
        private Scene _currentScene;
        public Scene CurrentScene
        {
            get { return _currentScene; } 
            set { _currentScene = value; }
        }
        public TestStory()
        {
            scenes = scenes
                .Concat(TestVillage.getScenes())
                .Concat(TestTrap.getScenes())
                .Concat(TestBattle.getScenes("DORF1", "TRAP1"))
                .ToArray();
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
