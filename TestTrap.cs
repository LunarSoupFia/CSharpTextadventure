using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal static class TestTrap
    {
        private static Scene[] _scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"TRAP2"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"}),
                new Option(OptionIdentifier.GO, "Du gehst zurück zum Dorfplatz", new string[]{"DORF1", "BATTLE_START"}, new string[]{"Dorf", "zurück"})
            }, "TRAP1","Nach langer Suche im Tempel des schrecklichen Todes stehst du endlich vor der Kammer der unendlichen Schmerzen in der ein großer Schatz verborgen sein soll. Drei Symbole sind an der Tür zu sehen, ein Mond, eine Sonne und ein Stern.",
                "$ancientTemple"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"TRAP3"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "TRAP2","Noch lebst du, doch wie geht es weiter?"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"TRAP4"}, new string[]{"Sonne"})
            }, "TRAP3","Der Schweiß steht dir auf der Stirn bei dem Gedanken mit dieser uralten Falle herum zu spielen"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"TRAP5"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "TRAP4","Schon hörst du wie das Gemäuer rumpelt und erzittert."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_SUCCESS"}, new string[]{"Mond"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Stern"}),
                new Option(OptionIdentifier.PRESS, "Drücke", new string[]{"END_FAILURE"}, new string[]{"Sonne"})
            }, "TRAP5","Sicher, das du das tun willst? Nur noch ein Symbol scheint dich vom Schatz zu trennen."),
            new Scene(new Option[]{new Option(OptionIdentifier.FLEE, "Flieh", new string[]{ "TRAP1" }) }, "END_FAILURE","Eine gewaltige Explosion erschüttert den Raum und du siehst wie die Mauern einstürzen. Offenbar bleibt dieses Geheimnis auf ewig verborgen. Tippe Flieh um zum Eingang zu kommen."),
            new Scene(new Option[]{}, "END_SUCCESS","Das Tor öffnet sich und du siehst vor dir die Reichtümer der uralten Zivilisation welche diesen Tempel gebaut hat.")
        };
        public static Scene[] getScenes()
        {
            return _scenes;
        }
    }
}
