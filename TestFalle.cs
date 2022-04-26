using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class TestFalle
    {
        Scene[] scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"T2"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "T1","Nach langer Suche im Tempel des schrecklichen Todes stehst du endlich vor der Kammer der unendlichen Schmerzen in der ein großer Schatz verborgen sein soll. Drei Symbole sind an der Tür zu sehen, ein Mond, eine Sonne und ein Stern."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"T3"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "T2","Noch lebst du, doch wie geht es weiter?"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"T4"}, new string[]{"Sonne"})
            }, "T3","Der Schweiß steht dir auf der Stirn bei dem Gedanken mit dieser uralten Falle herum zu spielen"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"T5"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "T4","Schon hörst du wie das Gemäuer rumpelt und erzittert."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_SUCCESS"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "T5","Sicher, das du das tun willst? Nur noch ein Symbol scheint dich vom Schatz zu trennen."),
            new Scene(new Option[]{new Option(OptionIdentifier.FLEE, "Flieh", new string[]{"T1"}) }, "END_FAILURE","Eine gewaltige Explosion erschüttert den Raum und du siehst wie die Mauern einstürzen. Offenbar bleibt dieses Geheimnis auf ewig verborgen. Tippe Flieh um zum Eingang zu kommen."),
            new Scene(new Option[]{}, "END_SUCCESS","Das Tor öffnet sich und du siehst vor dir die Reichtümer der uralten Zivilisation welche diesen Tempel gebaut hat.")
        };
        private Scene _currentScene;
        public Scene CurrentScene
        {
            get { return _currentScene; } 
            set { _currentScene = value; }
        }
        public TestFalle()
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
