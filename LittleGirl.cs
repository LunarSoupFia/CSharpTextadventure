using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    class LittleGirl
    {
        /*
        Gehe zu: Wald.  Waldrand
        Ein kleines Mädchen sitzt alleine vor dem Waldrand.

        Gehe zu: Mädchen.
        Du gehst auf das Mädchen zu, sie blickt dich mit traurigen Augen an.

        Frage: was ist los?  Warum allein? Warum traurig?
        Sie beginnt zu weinen.

        Drücke: Mädchen.
        Sie beruhigt sich und erzählt dir: Ich habe im Wald, beim Beeren sammeln,
        meinen Umhang vergessen, doch es wird bald dunkel und ich traue mich nicht ihn zurück zu holen.

        Frage nach: Umhang.
        Als du das Mädchen nach seinem Umhang fragst, erzählt es dir stolz:
        Ich hab ihn letztes Jahr von meiner Tante bekommen, der hat wunderschöne Bommel.

        Frage nach: Tante.
        Meine Tante lebt am Rande vom Dorf. Sie ist Schneiderin und kümmert sich ab und zu auch um den alten Mann der in iherer Nähe wohnt.

        Frage nach: altem Mann.
        Der alte Mann ist echt nett. Manchmal ein bisschen mufflig, aber wenn mann ihn nach seinen Abenteuern fragt,
        erzählt er einem immer total spannende Geschichten.
        
        Nach das kleine Mädchen dir das erzählt hat, blickt es dich abwartend an.

        Gehe zu: Wald.
        Nachdem du einige Schritte in den Wald hinein gegangen bist, siehst du links von dir hohe Eichen,
        rechts einen kleinen Bach, der weiter geradeaus hin zu Sträuchern und Büschen fließt.

        Gehe zu: Büschen, geradeaus, kleinem Bach
        Du kommst zu den Stäuchern und Büschen, von denen einige noch über und über mit Beeren behangen sind,
        doch an anderen siehst du, das welche gepflückt wurden.

        Suche ?
        Als du dich in der Nähe der Beerenbüsche umsiehst und etwas suchst, findest du tatsächlich einen rosaroten kleinen Umhang, mit beigefarbenen Bommeln.

        Gehe zu: Waldrand
        Du bringt den Umhang dem kleinen Mädchen zurück.
        Freudestahlend schaut sie dich an und ruft: Dankeschön.
        Vielen lieben Dank. 
        Wenn ich das meiner Tante erzähle, wird sie dir sicher auch dankbar sein.

        Gehe zu: Tante.
        Guten Abend, ich habe schon gehört was du liebevoller Weiße für meine kleine Nichte getan hast. 
        Zum Dank möchte ich dir diese Reisetasche geben, ich hatte sie für einen anderen Abenteuer hergestellt, doch dieser hat sie nie abgeholt.

        Questbelohnung: Reisetasche.
        (Du hast nun ein größeres Inventar. + 3 Plätze)


        - Gehe zu: Eichen
        Hinter einer der Eichen tritt eine wunderschöne Frau hervor. 
        Sie blickt dich an und fragt, was tust du hier?

         */

        private static string nl = Environment.NewLine;
        private static Scene[] _scenes = {
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "Du gehst auf das Mädchen zu.", new string[]{"LITTLE_GIRL2"}, new string[]{"Mädchen", "ihr", "weiter"}),
                new Option(OptionIdentifier.GO, "", new string[]{"DORF1"}, new string[]{"Dorf"})
            },"LITTLE_GIRL1","Ein kleines Mädchen sitzt, ein Stück vor dir, alleine vor dem Waldrand. Neben ihr auf dem Boden steht ein Korb voller süßer Beeren.",
                "$forest"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Sie beginnt zu weinen.", new string[]{"LITTLE_GIRL3"}, new string[]{"Wohlbefinden", "allein", "traurig", "los"}),
                new Option(OptionIdentifier.ASK, "Ich heiße Marie.", new string[]{"LITTLE_GIRL2"}, new string[]{"Name", "heißt", "nennt"}),
                new Option(OptionIdentifier.GO, "Ungerührt von ihrem Leid gehst du zurück ins Dorf", new string[]{"DORF1"}, new string[]{"Dorf"})
            },"LITTLE_GIRL2","Sie blickt dich mit traurigen Augen an."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.PRESS, "Sie beruhigt sich und erzählt dir:" + nl + "Ich habe im Wald, beim Beeren sammeln, meinen Umhang vergessen, doch es wird bald dunkel und ich traue mich nicht ihn zurück zu holen.", new string[]{"LITTLE_GIRL4"}, new string[]{"Mädchen", "Sie", "Marie"}),
                new Option(OptionIdentifier.GO, "Ungerührt von ihrem Leid gehst du zurück ins Dorf.", new string[]{"DORF1"}, new string[]{"Dorf"})
            },"LITTLE_GIRL3",""),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Als du das Mädchen nach seinem Umhang fragst, erzählt es dir stolz: Ich hab ihn letztes Jahr von meiner Tante bekommen, der hat wunderschöne Bommel. Dann wird ihr Blick betrübt und sie meint: Doch nun ist er weg.", new string[]{"LITTLE_GIRL4a"}, new string[]{"Umhang"}),
                new Option(OptionIdentifier.GO, "Du beschließt ihr zu helfen, und ihren Umhang zu suchen.", new string[]{"LITTLE_GIRL5"}, new string[]{"Waldrand", "Wald"})
            },"LITTLE_GIRL4",""),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Meine Tante und ich *schnüff* leben am Rande vom Dorf. Sie ist Schneiderin und kümmert sich ab und zu auch um den alten Mann der in ihrer Nähe wohnt. Sie hat mir den Umhang geschenkt.", new string[]{"LITTLE_GIRL4b"}, new string[]{"Tante", "Familie"}),
                new Option(OptionIdentifier.GO, "Du beschließt ihr zu helfen, und ihren Umhang zu suchen.", new string[]{"LITTLE_GIRL5"}, new string[]{"Waldrand", "Wald"})
            },"LITTLE_GIRL4a",""),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Der alte Mann ist echt nett. Manchmal ein bisschen mufflig, aber wenn man ihn nach seinen Abenteuern fragt, erzählt er einem immer total spannende Geschichten. Nachdem sie dir dies erzählt hat blickt sie dich abwartend an.", new string[]{"LITTLE_GIRL4"}, new string[]{"Mann", "alter", "alt", "Opa", "Greis"}),
                new Option(OptionIdentifier.GO, "Du beschließt ihr zu helfen, und ihren Umhang zu suchen.", new string[]{"LITTLE_GIRL5"}, new string[]{"Waldrand", "Wald"})
            },"LITTLE_GIRL4b",""),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL6"}, new string[]{"Sträucher", "Büsche"}),
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL6"}, new string[]{"Bach"}),
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL_DRYAD1"}, new string[]{"links", "Eichen", "Eiche"}),
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL6"}, new string[]{"rechts"}),
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL6"}, new string[]{"geradeaus"}),
                new Option(OptionIdentifier.SEARCH, "Du schaust dich um und suchst, doch irgendwie scheinst du noch nicht am richtigem Ort zu sein. ", new string[]{"LITTLE_GIRL5"}, new string[]{"Umhang"})
            },"LITTLE_GIRL5","Nachdem du einige Schritte in den Wald hinein gegangen bist, siehst du links von dir hohe Eichen, rechts einen kleinen Bach, der weiter geradeaus hin zu Sträuchern und Büschen fließt."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.SEARCH, "", new string[]{"LITTLE_GIRL7"}, new string[]{"Umhang", "Sträucher", "Beeren", "Büschen", "Spuren", "leeren"})
            },"LITTLE_GIRL6","Du kommst zu den Stäuchern und Büschen, von denen einige noch über und über mit Beeren behangen sind, doch an anderen siehst du, das welche gepflückt wurden."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL8"}, new string[]{"Waldrand", "Marie", "Mädchen"}),
            },"LITTLE_GIRL7","Als du dich in der Nähe der Beerenbüsche umsiehst und etwas suchst, findest du tatsächlich einen rosaroten kleinen Umhang, mit beigefarbenen Bommeln."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL9"}, new string[]{"Tante"}),
                new Option(OptionIdentifier.GO, "", new string[]{"DORF1"}, new string[]{"Dorf"}),
            },"LITTLE_GIRL8","Du bringt den Umhang dem kleinen Mädchen zurück. Freudestahlend schaut sie dich an und ruft: Dankeschön. Vielen lieben Dank. Wenn ich das meiner Tante erzähle, wird sie dir sicher auch dankbar sein."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "", new string[]{"DORF1"}, new string[]{"Dorf"}),
            },"LITTLE_GIRL9","Guten Abend, ich habe schon gehört was du liebevollerweise für meine kleine Nichte getan hast. Zum Dank möchte ich dir diese Reisetasche geben, ich hatte sie im letzten Jahr für einen anderen Abenteurer hergestellt, doch dieser hat sie nie abgeholt."),
            new Scene(new Option[]{
                new Option(OptionIdentifier.ASK, "Die schöne Frau blickt dich verwundert an: Ich weiß nicht, aber manchmal sammeln die Menschen Früchte am kleinen Bach im Wald. Sucht doch dort.", new string[]{"LITTLE_GIRL_DRYAD2"}, new string[]{"Mädchen", "Marie", "Umhang", "Dorf"}),
                new Option(OptionIdentifier.ASK, "Hier würde der Dryadenquest beginnen. Aber den gibt es noch nicht, also ab in den Wald", new string[]{"LITTLE_GIRL5"}, new string[]{"bist", "Name"})
            },"LITTLE_GIRL_DRYAD1","Hinter einer der Eichen tritt eine wunderschöne Frau des Wald hervor. Sie blickt dich an und fragt, was tust du hier?", "$dryad"),
            new Scene(new Option[]{
                new Option(OptionIdentifier.GO, "", new string[]{"LITTLE_GIRL6"}, new string[]{"Beeren"}),
                new Option(OptionIdentifier.ASK, "Hier würde der Dryadenquest beginnen. Aber den gibt es noch nicht, also ab in den Wald", new string[]{"LITTLE_GIRL5"}, new string[]{ "Name", "bist"})
            },"LITTLE_GIRL_DRYAD2",""),

        };
        public static Scene[] getScenes()
        {
            return _scenes;
        }
    }   

}
