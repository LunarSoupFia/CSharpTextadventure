using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class VillageQuest1
    {
        private static string nl = Environment.NewLine;
        
        private static Scene[] _scenes = {
            new Scene(new Option[]
            {   new Option(OptionIdentifier.ASK, "Du fragst die Frau nach ihrem Kind, sie beginnt dir von ihm zu erzählen" + nl + "Mein Sohn ist ein echter Rabauke, aber er verschwindet manchmal für Stunden, ohne dass ich weiß wo er hin geht." + nl + "Bitte findet ihn so schnell wie möglich!", new string[]{"DORF_QUEST1_SUCHE"}, new string[]{"Kind", "Aufenthaltsort", "Wo", "Sohn"}),
                new Option(OptionIdentifier.ASK, "Du bietest der Mutter deine Hilfe an. Sie bedankt sich und gibt dir eine Info zu ihrem Sohn:" + nl + "Er versteckt sich bestimmt hier im Dorf", new string[]{"DORF_QUEST1_SUCHE"}, new string[]{"Hilfe", "Helfen", "anbieten", "Unterstützung"}),
                new Option(OptionIdentifier.GO, "Die Anliegen der Frau sind für dich zum jetzigen Zeitpunkt nicht von Bedeutung und du entfernst dich von ihr.", new string[]{"DORF1"}, new string[]{"weg", "Dorf", "zurück", "Dorfplatz"})
            
            }, "DORF_QUEST1", "Als ihr euch der Frau nähert schaut sie euch sorgenvoll an und bittet euch um Hilfe:" + nl + "Bitte, ihr seid doch ein Abenteurer, mein Sohn Timmy ist verschwunden und ich kann ihn nicht finden!", "$villageQuest1", new string[]{"LOST.BOY"}),
            new Scene(new Option[]
            {   new Option(OptionIdentifier.SEARCH, "Als du hinter den Fässern schaust, findest du den vermissten Jungen. Du bringst ihn zu seiner Mutter. #Als du hinter den Fässern schaust, findest du einige Ratten, die ein Bankett mit Tee und diversen Gerichten halten. Die Ratten sind von deinem Verhalten empört und bitten dich höflich zu gehen.", new string[]{"DORF_QUEST1_END", "DORF_QUEST1_SUCHE"}, new string[]{"Fässer", "Fässern", "Fass", "Rumpern"}, VisibilityCondition.ALWAYS),
                new Option(OptionIdentifier.OPEN, "Als du in die Fässer schaust, siehst du den vermissten Jungen. Nachdem du ihn aus einem nassen Fass ziehst bringst du den Jungen zu seiner Mutter. #Als du in die Fässer schaust, siehst du nur Wein, Obst und Gemüse.", new string[]{"DORF_QUEST1_END", "DORF_QUEST1_SUCHE"}, new string[]{"Fässer", "Fässern", "Fass", "Rumpern"}, VisibilityCondition.ALWAYS),
                new Option(OptionIdentifier.SEARCH, "Als du dich in der Schmiede umschaust, findest du den vermissten Jungen, welcher mit den Hämmern und Zangen spielt. Nachdem du ihm die Schmiedewerkzeuge abgenommen hast bringst du den Jungen zu seiner Mutter. #Als du dich in der Schmiede umschaust, findest du einige Vögel, welche sich im Innendach der Schmiede ein Nest gebaut haben. Sie scheinen kein Problem darzustellen.", new string[]{"DORF_QUEST1_END", "DORF_QUEST1_SUCHE" }, new string[]{"Schmied", "Schmiede", "metallene", "Metall", "Klänge"}, VisibilityCondition.ALWAYS)
            
            }, "DORF_QUEST1_SUCHE", "Du suchst im Dorf nach dem Kind. Hinter den Fässern hörst du ein Rumpern. In der Schmiede hörst du einige metallene Klänge, die nicht vom Schmied kommen können."),
            new Scene(new Option[]
            {   new Option(OptionIdentifier.GO, "Du bedankst dich für das Angebot und nimmst am Essen teil. Als du ein von der Bäckerin selbstgebackenes Brot aufschneidest, fällt dir der Wandteppich auf, auf dem ein Tempel mit einigen Symbolen gestickt ist. nach kurzem Nachfragen erzählt dir die Frau, dass es sich um einen uraltes Familienerbstück handelt, dessen Bedeutung sie nicht kennt. Am unteren Rand sind 5 Symbole angedeutet, von denen das erste und dritte komplett verblasst sind. Die erkennbaren Symbole sind:"
                                                + nl + "ein Mond, ein Stern und ein weiterer Mond." + nl + "Am nächsten Morgen hast du dir die Symbole gut eingeprägt.", new string[]{"DORF1"}, new string[]{"Haus", "Bäckerei", "Bäckerhaus", "Mutter", "Frau", "Bäckerin"}),
                new Option(OptionIdentifier.GO, "Du lehnst dankend ab, du hättest leider noch einiges zu tun", new string[]{"DORF1"}, new string[]{ "Dorf", "weg", "zurück", "Dorfplatz"})
            }, "DORF_QUEST1_END", "Du bringst der Mutter ihr Kind. Voller Erleichterung bedankt sie sich bei dir, und lädt dich zum Essen bei ihr im Bäckerhaus ein.")
        };
        public static Scene[] getScenes()
        {
            return _scenes;
        }
    }
}
