using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Story
    {
        Scene[] scenes=new Scene[] { };
        
        private Scene _currentScene;
        public Scene CurrentScene
        {
            get { return _currentScene; } 
            set { _currentScene = value; }
        }
        public Story()
        {
            scenes = scenes
                .Concat(Village.getScenes())
                .Concat(Temple.getScenes())
                .Concat(OrcBattle.getScenes("DORF1", "TRAP1"))
                .Concat(LittleGirl.getScenes())
                .Concat(VillageQuest1.getScenes())
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
