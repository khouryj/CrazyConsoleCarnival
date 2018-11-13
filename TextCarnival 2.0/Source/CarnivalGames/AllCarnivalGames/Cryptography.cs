using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Cryptography : CarnivalGame
    {
        public override string getName()
        {
            return "Cryptography";
        }

        public override void play()
        {
            clear();
            showTitle("|40Cryptography Game");

            writeOut("TH15 W1LL B3 @ TR1(KY G@M3 F0R 5UR3!");
            wait(5);
            writeOut("Ok, not that tricky. Your goal is to guess the number\nthat the letters in the word have shifted.");
            wait(5);
            writeOut("But that's not your main goal, you have to type out the word.\nFinding the number of times the letters shift will just lead\nyou to the answer.");
            wait(6);
            writeLine("|c0\nEXAMPLE: 'Hello' shifted 1 letter would then give you 'Ifmmp' or 'Gdkkn'\ndepending on which way the letters shift.\nTo be even more clear, 'Hello' should've been\nthe word typed as the answer.\n|f0");
            wait(6);

            string Alph = "abcdefghijklmnopqrstuvwxyz";
            string BigAlph = Alph.ToUpper();

            string[] Words = new string[] {"Fart", "robertsonsuckseggs",
                "AdvancedDataStructures", "Spaz",
                "Hello", "Cryptography",
                "example", "Easton",
                "poop", "Clippy",
                "Tanczos"};
            string[] phrases = new string[] {"The quick brown fox jumps over the lazy dog.", "Bloomsburg Coding Competition",
                "Computer Science", "Advanced Data Structures", "This game is by far the best in the class", "You suck at this",
                "Andrew Spaziani is a God"};

            int round = 1;
            while (true)
            {
                clear();
                writeLine("|c0round " + round);
                Random rand = new Random();
                Random Value = new Random();
                int Val = Value.Next();
                string Original = "";
                string Answer = "";

                if (round < 10)
                {
                    Original = Words[rand.Next() % Words.Length];
                    foreach (char c in Original)
                    {
                        if (Alph.Contains(c.ToString()))
                            Answer += Alph.Substring((Alph.IndexOf(c) + Val) % 26, 1);
                        else if (BigAlph.Contains(c.ToString()))
                            Answer += BigAlph.Substring((BigAlph.IndexOf(c) + Val) % 26, 1);
                        else Answer += c.ToString();
                    }
                }
                else
                {
                    Original = phrases[rand.Next() % phrases.Length];
                    foreach (char c in Original)
                    {
                        if (Alph.Contains(c.ToString()))
                            Answer += Alph.Substring((Alph.IndexOf(c) + Val) % 26, 1);
                        else if (BigAlph.Contains(c.ToString()))
                            Answer += BigAlph.Substring((BigAlph.IndexOf(c) + Val) % 26, 1);
                        else Answer += c.ToString();
                    }
                }

                writeOut("\n\nYour encrypted word is: " + Answer);
                string input = getInput();

                if (input != Original.ToLower())
                {
                    writeOut("You suck worse than Sabeen's code (pretty darn sucky)");
                    wait(5);
                    writeOut("Just kidding, Sabeen has decent code, but you still suck like absolute trash");
                    wait(3);
                    writeLine("|c0The correct word was: |a0" + Original);
                    wait(5);
                    clear();
                    break;
                }
                else
                {
                    writeLine("|a0Nice job!");
                    wait(2);
                }
                round++;
            }
        }
    }
}
