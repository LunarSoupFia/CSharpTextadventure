using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal static class Village
    {
        private static string nl = Environment.NewLine;
        private static Scene[] _scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst im Dorf nach dem Schatz des antiken Volk. Man informiert dich über einen Greis, welcher am Dorfrand lebt und der dir helfen könnte.", new string[]{"DORF1"}, new string[]{"Schatz"}),
                new Option(OptionIdentifier.ASK, "Du fragst einen Passanten nach Informationen über das Dorf. Der Passant stellt sich als ein Fremdenführer heraus, welcher dir beginnt von diesem Dorf zu erzählen:" + nl + "Dieses Dorf ist bereits hunderte von Jahren alt und ist bis heute bekannt für seine Braukunst und Kultur", new string[]{"DORF_GUIDE1"}, new string[]{"Dorf"}),
                new Option(OptionIdentifier.GO, "Du besuchst den alten Mann am Rand des Dorfs.", new string[]{"DORF_OLD_MAN1"}, new string[]{"Greis", "Mann", "alter", "altem", "alten"}),
                new Option(OptionIdentifier.GO, "Entschlossen brichts du in die nähere Umgebung des Dorfes auf.", new string[]{"LITTLE_GIRL1"}, new string[]{"Wald", "Waldrand", "Westen"}),
                new Option(OptionIdentifier.GO, "Du brichst auf zum Tempel der unendlichen Qualen.", new string[]{"TRAP1", "BATTLE_START"}, new string[]{"Tempel", "Temple", "Berg"}, "TEMPLE_0.1"),
                new Option(OptionIdentifier.GO, "Du gehst zu der besorgt aussehenden Frau", new string[]{"DORF_QUEST1"}, new string[]{"Frau","Dame"})
            }, "DORF1","Du befindest dich in einem kleinen Dorf und stehst auf dem großen Platz, auf dem eine besorgte Frau steht. Ein Fremdenführer nimmt Fragen an. Das Dorf liegt am Fuße eines hohen Berges und im Westen wird es von einem grünen und ruhigen Wald umschlossen. Du bist hier, da du Geschichten von einem großem Schatz gehört hast - doch noch weißt du nicht wo du suchen sollst. "
                ,"$village", new string[]{"SCHATZ"}),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst den alten Mann nach dem Schatz des antiken Volk. Er beginnt dir von seinen früheren Abenteuern zu erzählen:", new string[]{"DORF_OLD_MAN_ADVENTURES1"}, new string[]{"Tempel", "Schatz", "Volk"}),
                new Option(OptionIdentifier.ASK, "Du fragst den alten Mann nach seinen früheren Abenteuern. Mit einem Leuchten in seinen Augen beginnt er zu erzählen:", new string[]{"DORF_OLD_MAN_ADVENTURES1"}, new string[]{"Mann", "Greis", "alter", "altem", "alten", "Abenteuer", }),
                new Option(OptionIdentifier.GO, "Du gehst zurück zum Dorfplatz", new string[]{"DORF1", "BATTLE_START"}, new string[]{"Dorf", "zurück"})
            }, "DORF_OLD_MAN1", "Als du dich dem alten Haus am Dorfrand näherst winkt dir ein alter Mann zu. Du erkennst den alten Mann als jemand, der schon viel erlebt hat. Er begrüßt dich:" + nl + "Hallo mein Kind, was kann ich für dich tun?",
                "$oldManHouse"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst den alten Mann was diese Geschichte mit dem Tempel des antiken Volk zu tun hat. Er versichert dir, dass es sich lohnen wird, ihm zuzuhören.", new string[]{"DORF_OLD_MAN_ADVENTURES2"}, new string[]{"Tempel", "Schatz", "Volk"}),
                new Option(OptionIdentifier.LISTEN, "Du hörst dem alten Mann zu, was er noch zu sagen hat.", new string[]{"DORF_OLD_MAN_ADVENTURES2"}),
                new Option(OptionIdentifier.GO, "Du wendest dich dem alten Mann wortlos ab. Er schaut dir traurig hinterher...", new string[]{"DORF1"}, new string[]{"weg", "zurück", "Dorf"})
            }, "DORF_OLD_MAN_ADVENTURES1", "Als ich noch etwas jünger war, etwas jünger als du, damals als es noch viele Abenteurer gab, ging ich oft mit meinem kleinen Bruder raus aus dem Dorf und in den Wald, wo wir so taten als wären wir große Abenteurer." + nl + "Der alte Mann macht eine kurze Pause."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst den alten Mann wie man diesen Tempel nun findet. Zuerst zurückhaltend, gibt er dir doch eine Antwort:" + nl + "Mein Bruder und ich fanden den Tempel beim Blauberg. Aber pass auf dich auf, es gibt Fallen im Tempel.", new string[]{"TRAP1", "BATTLE_START"}, new string[]{"Tempel", "Schatz", "Volk"}),
                new Option(OptionIdentifier.LISTEN, "Du hörst dem alten Mann zu, was er noch zu sagen hat. ", new string[]{"DORF_OLD_MAN_ADVENTURES3"}),
                new Option(OptionIdentifier.GO, "Du wendest dich dem alten Mann wortlos ab. Er schaut dir traurig hinterher...", new string[]{"DORF1"}, new string[]{"weg", "zurück", "Dorf"})
            }, "DORF_OLD_MAN_ADVENTURES2", "Es war in diesen Wäldern, wo wir einen kleinen Weg durch die Berge fanden, der unser beider Leben auf ewig verändern sollte. Wir fanden einen kleinen Tempel zwischen den Felswänden. Ich wollte nicht hinein, es wirkte mir zu unsicher, aber Lukas bestand darauf, dass wir es uns ansehen sollten.",null, new string[]{"TEMPLE" }),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst den alten Mann wie man diesen Tempel nun  findet. Zuerst zurückhaltend, gibt er dir doch eine Antwort:" + nl + "Mein Bruder und ich fanden den Tempel beim Blauberg. Aber pass auf dich auf, es gibt Fallen im Tempel.", new string[]{"TRAP1", "BATTLE_START"}, new string[]{"Tempel", "Schatz", "Volk"}),
                new Option(OptionIdentifier.GO, "Du bedankst dich bei dem alten Mann, dass er seine Geschichte mit dir geteilt hat. Er gibt dir noch einen Rat bevor du aufbrichst:" + nl + "Das erste Symbol ist ein Stern", new string[]{"DORF1"}, new string[]{"weg", "zurück", "Dorf"})
            }, "DORF_OLD_MAN_ADVENTURES3", "Ich stand etwas weiter weg als es passierte. Er drückte auf eine Schaltfläche, ich erinnere mich es war ein Sonnensymbol, und plötzlich läuchtete der gesamte Raum auf und blendete mich." + nl + "Als ich wieder sehen konnte war mein Bruder verschwunden.", "$ancientTemple"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst nach der Braukunst des Dorfs, der Fremdenführer erzählt dir von der Taverne, in der auch gebraut wird, und führt dich dorthin.", new string[]{"DORF_TAVERNE1"}, new string[]{"Braukunst", "Taverne", "Brauerei"}),
                new Option(OptionIdentifier.NULL, "Der Fremdenführer schaut dich verdutzt an aber kann auf deine Aktion keine passende Reaktion finden außer zu gehen.", new string[]{"DORF1"}),
                new Option(OptionIdentifier.GO, "Du entfernst dich vom Fremdenführer um dich alleine umzusehen.", new string[]{"DORF1"}, new string[]{"Dorfplatz", "Dorf" }),
                new Option(OptionIdentifier.ASK, "Du fragst nach einer Quelle für Waffen, aber der Fremdenführer informiert dich, dass das Dorf keinen Schmied hat, da dieser aktuell auf Reisen ist.", new string[]{"DORF_GUIDE1"}, new string[]{"Waffen", "Schmied"})
            }, "DORF_GUIDE1","Der Fremdenführer schaut dich wartend an:" + nl + "Gibt es sonst noch etwas, womit ich helfen kann?", "$village"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Du fragst den Tavernenwirt nach einem Getränk", new string[]{"DORF_TAVERNE_DRINK"}, new string[]{"Getränk", "Alkohol", "Drink", "Bier"}),
                new Option(OptionIdentifier.ASK, "Du fragst den Tavernenwirt nach dem Glückspielangebot. Er bietet dir an bei dem neuesten Spiel im Sortiment mitzuspielen, welches er den Roten Schurken nennt.", new string[]{"ROTER_SCHURKE_START"}, new string[]{"Glückspiel"}),
                new Option(OptionIdentifier.ASK, "Du fragst am Glückspieltisch, ob du eine Runde Roter Schurke mitspielen darfst. #Der Tisch lehnt ab, die Spieler möchten alleine spielen. #Der Tisch lässt dich mitspielen.", new string[]{"DORF_TAVERNE1", "ROTER_SCHURKE_START"}, new string[]{"Roter", "Schurke"}),
                new Option(OptionIdentifier.ASK, "Du fragst den Wirt nach dem Schatz der Antiken. Er zuckt kurz zusammen bevor er sich über den Thresen beugt und dich zu ihm zieht:" + nl + "Du hast Mumm Kumpel, einfach in eine Taverne zu gehen und nach dem Schatz zu fragen. Willst du etwa gleich sterben?" + nl + "Er zeigt dir einen Weg zu einem alten Tempel, in dem der Schatz sein soll.", new string[]{"BATTLE_START", "TRAP1"}, new string[]{"Schatz"}) 
            }, "DORF_TAVERNE1","Du betrittst eine Taverne, in der das Leben pulsiert. An vielen Tischen lassen sich Gruppen von Trinkliebhabern und Glückspielfreunden sehen. Du setzt dich an den Thresen, wo dich der Wirt begrüßt:" + nl + "Na, was darf es sein?",
               "$tavern"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Der Dorftornado ist ein Getränk, das nur die stärksten und mächtigsten Helden des Dorfes jemals getrunken und überlebt haben. Wenn du dich dich traust, den Dorftornado zu trinken, benutze den Zündler.", new string[]{"DORF_TAVERNE_DRINK" }, new string[]{"Dorftornado"}),
                new Option(OptionIdentifier.USE, "Als du den Zünder einschaltest, sprudelt eine grüne Flüssigkeit durch die Gläsernen Zylinder. In der gesamten Taverne hörst du den Ruf: ZÜNDE DEN TORNADO! Der Wirt befiehlt dir die an der Maschine befestigte, mit grünem Trunk gefüllte Flasche zu packen und in einer Drehbewegung hebst du sie an deinen Mund. Die brodelnde Flüssigkeit beginnt deinen Körper von innen nach außen, von außen nach innen, von oben nach unten, von unten nach oben, von links nach rechts und von rechts nach links zu verbrennen. Das letzte was du siehst ist ein grünes Feuer in deinen Augen.#Als du den Zünder einschaltest, sprudelt eine grüne Flüssigkeit durch die Gläsernen Zylinder. In der gesamten Taverne hörst du den Ruf: ZÜNDE DEN TORNADO! Der Wirt befiehlt dir die an der Maschine befestigte, mit grünem Trunk gefüllte Flasche zu packen und in einer Drehbewegung hebst du sie an deinen Mund. Das mystische Getränk scheint deine Sinne sowohl zu stärken als auch zu benebeln. Die Taverne verschwimmt vor deinen Augen, und ein Mann mit goldenem Haar und goldener Aura erscheint. Er spricht kein Wort, aber hinter ihm siehst du eine glühende Sonne mit 5 Zacken.#Als du den Zünder einschaltest, sprudelt eine grüne Flüssigkeit durch die Gläsernen Zylinder. In der gesamten Taverne hörst du den Ruf: ZÜNDE DEN TORNADO! Der Wirt befiehlt dir die an der Maschine befestigte, mit grünem Trunk gefüllte Flasche zu packen und in einer Drehbewegung hebst du sie an deinen Mund. Das mystische Getränk scheint deine Sinne sowohl zu stärken als auch zu benebeln. Die Taverne verschwimmt vor deinen Augen, und ein Mann mit goldenem Haar und goldener Aura erscheint. Er spricht kein Wort, aber hinter ihm siehst du eine glühende Sonne mit 5 Zacken.", new string[]{"TORNADO_DEATH","TORNADO_SUCCESS","TORNADO_SUCCESS"}, new string[]{"Zündler"})
            }, "DORF_TAVERNE_DRINK", "Hallo Fremder, sind sie neu im Dorf. Hast du Lust unsere Dorfspezialität den Dorftornado auszuprobieren?",null,new string[]{"TORNADO"}),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "Du beendest dein Abenteuer, deine Seele brennt noch immer in einer grünen Flamme, doch kannst du eine Stimme vernehmen:", new string[]{"END_THANKS"}, new string[]{"Ende"})
            },"TORNADO_DEATH","you died" + nl + nl + "Du verlierst 69 Seelen." + nl + nl + "Du bist schon fast wie ein Phoenix, ein brennendes Vieh mit kleinem Gehirn. Nur steigst du nicht aus der Asche auf."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "Du gehst zurück zum Dorfplatz, die Nacht ist eingebrochen, weshalb du vor der Stadt ein Lager aufbaust." + nl + "Am nächsten Morgen gehst du zurück ins Dorf", new string[]{"DORF1"}, new string[]{"Dorf"}),
                new Option(OptionIdentifier.GO, "Du nächtigst in einem der Zimmer des Wirts." + nl + "Am nächsten Morgen verlässt du das Wirtshaus und gehst auf den Dorfplatz", new string[]{"DORF1"}, new string[]{"Schlafplatz"})
            }, "TORNADO_SUCCESS", "Als du wieder aufwachst steht vor dir der Wirt, er kürt dich zum neuen Meister des Tornado und gibt dir 1 Flasche des Dorftornados.")
        };
        public static Scene[] getScenes()
        {
            return _scenes;
        }
    }
}
