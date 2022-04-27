using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal static class TestVillage
    {
        private static string nl = Environment.NewLine;
        private static Scene[] _scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst im Dorf nach dem Schatz des antiken Volk. Man informiert dich über einen Greis, welcher am Stadtrand lebt und der dir helfen könnte.", new string[]{"DORF1"}, new string[]{"Schatz"}),
                new Option(OptionIdentifier.ASK, "Du fragst einen Passanten nach Informationen über das Dorf. Der Passant stellt sich als ein Fremdenführer heraus, welcher dir beginnt von der Stadt zu erzählen:" + nl + "Dieses Dorf ist bereits hunderte von Jahren alt und ist bis heute bekannt für seine Braukunst und Kultur", new string[]{"DORF_GUIDE1"}, new string[]{"Dorf"}),
                new Option(OptionIdentifier.GO, "Du besuchst den alten Mann am Rand der Stadt.", new string[]{"DORF_OLD_MAN1"}, new string[]{"Mann", "Greis", "alter", "altem", "alten"})
            }, "DORF1","Du befindest dich im kleinen Dorf und stehst auf einem großen Platz."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst nach der Braukunst des Dorfs, der Fremdenführer erzählt dir von der Taverne, in der auch gebraut wird, und führt dich dorthin.", new string[]{"DORF_TAVERNE1"}, new string[]{"Braukunst", "Taverne", "Brauerei"}),
                new Option(OptionIdentifier.NULL, "Der Fremdenführer schaut dich verdutzt an aber kann auf deine Aktion keine passende Reaktion finden außer zu gehen.", new string[]{"DORF1"}),
                new Option(OptionIdentifier.ASK, "Du fragst nach einer Quelle für Waffen, aber der Fremdenführer informiert dich, dass das Dorf keinen Schmied hat, da dieser aktuell auf Reisen ist.", new string[]{"DORF_GUIDE1"}, new string[]{"Waffen", "Schmied"})
            }, "DORF_GUIDE1","Der Fremdenführer schaut dich wartend an:" + nl + "Gibt es sonst noch etwas, womit ich helfen kann?"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst den Wirt nach dem Schatz der Antiken. Er zuckt kurz zusammen bevor er sich über den Thresen beugt und dich zu ihm zieht:" + nl + "Du hast Mumm Kumpel, einfach in eine Taverne zu gehen und nach dem Schatz zu fragen. Willst du etwa gleich sterben?" + nl + "Er zeigt dir einen Weg zu einem alten Tempel, in dem der Schatz sein soll.", new string[]{"BATTLE_START", "TRAP1"}, new string[]{"Schatz"}) 
            }, "DORF_TAVERNE1","Du betrittst eine Taverne, in der das Leben pulsiert. An vielen Tischen lassen sich Gruppen von Trinkliebhabern und Glückspielfreunden sehen. Du setzt dich an den Thresen, wo dich der Wirt begrüßt:" + nl + "Na, was darf es sein?"),
            new Scene(new Option[]{}, "END_SUCCESS","Das Tor öffnet sich und du siehst vor dir die Reichtümer der uralten Zivilisation welche diesen Tempel gebaut hat.")
        };
        public static Scene[] getScenes()
        {
            return _scenes;
        }
    }
}
