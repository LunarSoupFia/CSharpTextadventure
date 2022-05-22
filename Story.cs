using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Story
    { 
        Scene[] scenes = new Scene[] { };
        public QuestLog questLog = new QuestLog("","", new Quest[]
        {
            new Quest("SCHATZ", "Der uralte Schatz","Findet den Schatz des anktiken Volk.","END_SUCCESS","", 0.1 ),
            new Quest("TEMPLE", "Der antike Tempel", "Ihr habt herausgefunden wie man zum Tempel des antiken Volk kommt.", "TRAP1","", 0.0),
            new Quest("UMHANG", "Umhang Finden","Helft dem kleinen Mädchen ihren Umhang wieder zu finden.","LITTLE_GIRL8","", 0.0),
            new Quest("LOST.BOY", "Der verlorene Junge", "Findet den verloren Jungen Timmy, und bringt ihn zu seiner Mutter","DORF_QUEST1_END","",0.0),
            new Quest("TORNADO", "Das brennende Getränk","Stellt euch in der Taverne dem Dorftornado, und überlebt.","TORNADO_SUCCESS","Dorftornado™", 0.0)
        });

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
