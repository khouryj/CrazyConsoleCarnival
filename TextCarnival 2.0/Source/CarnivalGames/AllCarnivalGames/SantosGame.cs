using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class SantosGame : CarnivalGame
    {
        public SantosGame() : base()
        {

        }

        public override string getName()
        {
            return "Write A Rom-Com";
        }

        public override void play()
        {
            //Shows the green title text
            clear();
            showTitle("Welcome to MadLibs: Rom-Com Edition!");

            writeLine("Time to write your own story.");
            dramaticPause(3);
            writeLine("");

            writeOut("NOTE: play full screen for the best experience. Or don't, if you want the\nformatting to be garbage.");
            dramaticPause(3);
            writeLine("");

            writeOut("I need 14 words from you to finish the story--I'll ask them for you now, one by one.");
            dramaticPause(1);
            writeLine("");

            writeOut("Name (your own, or a friend's, if you would rather subject them to the \nhappenings of the cheesy plot line): ");
            String name = getInput();
            writeLine("");

            writeOut("A friend's name: ");
            String fName = getInput();
            writeLine("");

            writeOut("A nice, generic boy name: ");
            String boyName = getInput();
            writeLine("");

            writeOut("And a nice, equally generic girl name: ");
            String girlName = getInput();
            writeLine("");

            writeOut("Two verbs ending in -ing: ");
            String ing1 = getInput();
            String ing2 = getInput();
            writeLine("");

            writeOut("A verb ending in -ed: ");
            String ed1 = getInput();
            writeLine("");

            writeOut("A noun: ");
            String noun = getInput();
            writeLine("");

            writeOut("Two adjectives: ");
            String adj1 = getInput();
            String adj2 = getInput();
            writeLine("");

            writeOut("Two exclamations: ");
            String exc = getInput();
            String exc2 = getInput();
            writeLine("");

            writeOut("A plural noun: ");
            String pluNoun = getInput();
            writeLine("");

            writeOut("Finally, a plural body part: ");
            String bodyPart = getInput();
            writeLine("");

            // Transition
            writeLine("Wonderful. Time for your final product :)");
            clear();
            dramaticPause(3);
            writeLine("");

            writeOut(name + " wasn't like other girls.");
            dramaticPause(2);
            writeLine("");

            writeOut("Most high schoolers didn't care about their grades--");
            dramaticPause(2);
            writeOut(name + " absolutely lost her mind for academics.");
            dramaticPause(2);
            writeLine("");

            writeOut("Most high schoolers went to football games and parties--");
            dramaticPause(2);
            writeOut(name + " found comfort in " + ing1 + " in the peace and comfort of \nher own home.");
            dramaticPause(2);
            writeLine("");

            writeOut("And most high schoolers had a guy or girl to call their own, their " + noun + "ipoo--");
            dramaticPause(2);
            writeOut(name + " was extremely, extremely single.");
            dramaticPause(2);
            writeLine("");

            writeOut("But you can imagine that changed nice and quick.");
            dramaticPause(2);
            writeLine("");

            writeOut("Most predictably, " + name + " was just " + ing2 + " in the library one " + adj1 +
                " Tuesday afternoon. " + "She always did this with the most extreme focus.\nSuddenly, "
                + "to her great surprise, the second bell for class was already ringing. '" + exc
                + "!' She yelled.\n'1:00 already???' She picked up all her " + pluNoun + " and bolted out the "
                + "door, rounding corners like a Tokyo drifter.\nBut alas, she wasn't slick enough to "
                + "avoid bumping " + bodyPart + " with the most popular guy in school.");

            dramaticPause(8);
            writeLine("");

            writeOut("'" + exc2 + "!' " + name + " yelled as she tumbled to the floor with her " + pluNoun + ". ");
            writeOut(fName + ", an absolute unit of a high school quarterback, stood tall and unaffected over her.");

            dramaticPause(4);
            writeLine("");

            writeOut("'Are you okay??' " + fName + " gasped, reaching for " + name + "'s hand.");

            dramaticPause(4);
            writeLine("");

            writeOut("'YEAH LOL' she replied, very apparently not okay. She grabbed his hand "
                + "\nreluctantly and pulled herself to her feet.");

            dramaticPause(4);
            writeLine("");

            writeOut("'Where were you running from so quickly?' " + fName + " questioned. "
                + "\n'You looked like me on the field during the final seconds of a tie game ahahahah :)'");

            dramaticPause(4);
            writeLine("");

            writeOut(name + " " + ed1 + ". She composed herself to reply. 'The library of "
                + "course because I'm \nsuch a quirky cutie and can't even bear to go to lunch "
                + "because it reeks of high school stereotype, yuck.'");

            dramaticPause(5);
            writeLine("");

            writeOut("'Oh right,' " + fName + " replied casually. 'Say, you're a " + adj2 +
                " nerd right? \nWhile I've got you here, think you could help me with something?'");

            dramaticPause(3);
            writeLine("");

            writeOut(fName + " proceeded with a whole oration about how he's failing calculus or something and "
                + "his dad is really mad and he \nneeds to pass the class to stay quarterback "
                + "and it'll ruin him if he can't play football anymore blah blah. \n" + name
                + ", convinced our boy is a big fat jerk jock, is reluctant. And he's all like "
                + "please I\ncan't live without football so she asks what she gets in return "
                + "and he says he'll get her into some \nmassive party she secretly wants to go "
                + "to or he'll be her prom date or something.");

            dramaticPause(13);
            writeLine("");

            writeOut("'Yeah alright, '" + name + " replies. 'How's tomorrow after school?'");

            dramaticPause(3);
            writeLine("");

            writeOut("Just really fantastic he probably says. They part ways.");

            dramaticPause(3);
            writeLine("");

            writeOut("At this point I really wanna go to bed so let's cut to the hot chase. "
                + name + " and " + fName + " get together at " + name + "'s house, \n"
                + "coincidentally when she 'has the free.' They're on this calculus grind "
                + "and all of a sudden " + fName + "\nleans back like boy I'm BURNT let me "
                + "make some casual leading statements so you ask me about personal things.\n"
                + name + " asks personal things and she's all like wow my cat died when I "
                + "was 8 too and it made me really sad too.\nSuddenly " + name + " realizes "
                + "he's kinda soft and insecure and " + fName + " suddenly has this safe "
                + "space to be emotionally\nvulnerable and supported and they kiss a little bit.");

            dramaticPause(15);
            writeLine("");

            writeOut("20 years later " + name + " and " + fName + " are married and living "
                + "in a beautiful, Tuscan-style four-bedroom with their two kids, "
                + boyName + " and " + girlName + ". \nThey like to have Taco Tuesdays, "
                + "go cycling, and host annual Super Bowl parties with some killer "
                + "bean dip. They plan on retiring at 65\nand moving into a quaint "
                + "cottage in Myrtle Beach.");

            writeLine("");

            writeOut("Type anything to quit and never see this atrocity again.");
            getInput();
            clear();
        }
    }
}

