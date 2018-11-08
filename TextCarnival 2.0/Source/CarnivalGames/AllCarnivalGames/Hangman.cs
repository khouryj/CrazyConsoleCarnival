using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Hangman : CarnivalGame
    {
        int tries = 5;
        String word = "";
        String word1 = "";
        String letters = "";
        int words = 1;
        String[] phrases = new String[] { "the big gay", "switch", "nofriendo", "no u", "tank zos", "dulan claymold", "car crash compilation", "jason", "the xylophone experience", "logan paul", "jake paul", "deji", "awkward dwarves", "mystical pixel", "pajama party", "ivory tower", "klu klux krab"};
        Random rnd = new Random();

        public Hangman() : base()
        {

        }

        public override string getName()
        {
            return "Hangman";
        }

        public override void play()
        {
            clear();
            showTitle("Welcome to Hangman!!!!!!");

            writeOut("I'm just going to assume you already know what hangman is and how to play");
            dramaticPause(3);

            
            word = phrases[rnd.Next(0, phrases.Length - 1)];
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    words++;
                }
            }

            clear();
            foreach (char c in word)
            {
                if (c == ' ')
                {
                    word1 += " ";
                }
                else
                {
                    word1 += "-";
                }
            }

            while (word1 != word && tries != 0)
            {
                update();
            }

            if (!word1.Contains("-") && tries != 0)
            {
                writeOut("Congrats! You have won! The phrase was " + word + ". Thanks for playing.");
                dramaticPause(3);
                clear();
            }
            else if (tries == 0)
            {
                writeOut("Sorry, but you have lost this time. The phrase was " + word + ". Thanks for playing.");
                dramaticPause(3);
                clear();
            }
        }

        public void update()
        {
            writeLine("Tries: " + tries);
            writeLine("\n" + word1 + "  " + "Words: " + words + "\n\n" + letters);
            writeLine("[guess phrase] or [guess letter]");
            String input = getOption("guess phrase", "guess letter");
            if (input == "guess letter")
            {
                write("\nEnter a letter (that hasn't been used): ");
                input = getInput();
                letters += input;
                if (word.Contains(input))
                {
                    char[] h = word1.ToCharArray();
                    String temp = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i].ToString() == input && h[i] == '-')
                        {
                            h[i] = input.ToCharArray()[0];
                            temp += input;
                        }
                        else
                        {
                            temp += h[i];
                        }
                        word1 = temp;
                    }
                }
                else
                {
                    tries--;
                }
            }
            else
            {
                write("\nGuess the phrase: ");
                input = getInput();

                if (input == word)
                {
                    word1 = input;
                }
                else
                {
                    tries--;
                }
            }
            clear();
        }
    }
}
