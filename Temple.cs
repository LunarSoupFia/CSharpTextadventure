using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal static class Temple
    {
        private static string nl = Environment.NewLine;
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
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "Während deine Leiche mit den Ruinen des antiken Volk verschmilzt, steigt dein Geist zu einer höheren Ebene auf, wo dir eine Stimme etwas sagt:", new string[]{"END_THANKS"}, new string[]{"Ende", "Schluss"})
            }, "END_FAILURE","Eine gewaltige Explosion erschüttert den Raum und du siehst wie die Mauern einstürzen. Offenbar bleibt dieses Geheimnis auf ewig verborgen." + nl + "Tippe 'Gehe zu Ende', um dein Abenteuer zu beenden."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.FLEE, "Aus Angst vor möglichen Flüchen, die auf diesem Schatz liegen könnten, fliehst du aus dem Tempel.", new string []{"END_THANKS"}),
                new Option(OptionIdentifier.GO, "Du weist die Schätze ab, und erkennst dass es größere Reichtümer gibt, als einen Haufen Gold", new string[]{ "END_THANKS" }, new string[]{"Dorf"}),
                new Option(OptionIdentifier.USE, "Du nimmst das Gold an dich, und siehst wie eine gewichtete Platte unter dem Schatz hochfährt. Die Schatzkammer beginnt zu erzittern doch bevor du von den Trümmern erschlagen werden kannst stürmst du mit soviel Gold wie du tragen kannst aus dem Tempel", new string[]{"END_GOLDEN"}, new string[]{"Schatz", "Gold"})
            }, "END_SUCCESS","Das Tor öffnet sich und du siehst vor dir die Reichtümer der uralten Zivilisation welche diesen Tempel gebaut hat."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Als ihr die Fremden fragt wer sie seien entgegnen diese mit lautem Gelächter dann sagen beide gleichzeitig:" + nl + nl + "Heheheha, Wir sind nur Reisende auf dem Weg nach Hause. Ihr widerum, seid ein erfolgreicher Abenteurer, der es geschafft hat den Gefahren auf seinem Weg zu trotzen, und großes zu vollbringen, und dafür habt ihr unseren größten Respekt" + nl + "Bevor die mysteriösen Männer verschwinden, drehen sie sich noch ein mal zu euch:", new string[]{"END_THANKS"}, new string[]{"Name","wer"}),
                new Option(OptionIdentifier.GO, "Du läufst unbeirrt weiter, die Männer sollen dich nicht aufhalten.", new string[]{"END_THANKS"}, new string[]{"weiter"})
            }, "END_GOLDEN", "Mit dem Schatz des antiken Volk in deinen Taschen machst ihr euch auf, neue Abenteuer zu erleben. Auf eurem Heimweg begegnen euch zwei in goldene Tücher gekleidete Männ, Ihre Weisheit lässt sich sofort erkennen.", "$this.backgroundImage"),
            new Scene(new Option[]{
            }, "END_THANKS", "Euer Abenteuer endet hier, welchen Weg auch immer ihr eingeschlagen habt oder noch einschlagen werdet. Wir danken euch fürs Spielen und hoffen es hat euch gefallen!", "$this.backgroundImage")
        };
        public static Scene[] getScenes()
        {
            return _scenes;
        }
    }
}
