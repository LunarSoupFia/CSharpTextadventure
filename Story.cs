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
            new Quest("testQ", "TestQuest","Dies ist eine Test-Quest","TRAP1","", 0.1),
            new Quest("Schatz","Finde den Schatz des anktiken Volk","END_THANKS","", 0.0 ),
            new Quest("Umhang Finden","Hilf dem kleinen Mädchen ihren Umhang wieder zu finden.","LITTLE_GIRL_DRYAD2","", 0.0),
            new Quest("Dorftornado","Stelle dich dem Dorftornado in der Taverne","TORNADO_DEATH","", 0.0)



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
