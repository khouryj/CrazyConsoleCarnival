using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class HorseyRaces : CarnivalGame
    {
        public override string getName()
        {
            return "Horsey Races";
        }

        public override void play()
        {
            float odds1 = 0;
            float odds2 = 0;
            float odds3 = 0;

            int race = 1;

            int h1 = 0;
            int h2 = 0;
            int h3 = 0;

            int Money = 1000;
            while (Money > 0)
            {
                clear();
                showTitle("Horsey Races");
                writeLine("|a0$" + Money);
                writeLine("|c01 [Horse 1], 2 [Horse 2], 3 [Horse 3], Q [Quit]");
                writeLine("|e0Odds of winning:\n|20Horse1: " + odds1 + "|40 Horse2: " + odds2 + "|b0 Horse3: " + odds3);

                write("Select a horse to bet on: ");

                string choice = getOption("1", "2", "3", "q");
                if (choice == "q")
                {
                    clear();
                    break;
                }

                write("How much to bet? $");
                int Bet = Convert.ToInt32(getInput());
                if (Bet > Money)
                {
                    writeLine("Cheater!");
                    break;
                }

                Money -= Bet;
                

                string RaceTrack1 = "-_-_-_-_-$-_";
                string RaceTrack = "-_-_-_-_-$-_";
                string RaceTrack2 = "-_-_-_-_-$-_";
                string RaceTrack3 = "-_-_-_-_-$-_";

                Random Moves = new Random();

                int H1 = 0, H2 = 0, H3 = 0;

                int Max = 0;
                while (Max < 10)
                {
                    clear();

                    for (int i = 1; i <= 3; i++)
                    {
                        if (i == 1)
                        {
                            RaceTrack1 = RaceTrack;
                            H1 += Moves.Next(0, 3) + 1;
                            RaceTrack1 = RaceTrack1.Insert(H1, "1");

                        }
                        if (i == 2)
                        {
                            RaceTrack2 = RaceTrack;
                            H2 += Moves.Next(0, 3) + 1;
                            RaceTrack2 = RaceTrack2.Insert(H2, "2");
                        }
                        if (i == 2)
                        {
                            RaceTrack3 = RaceTrack;
                            H3 += Moves.Next(0, 3) + 1;
                            RaceTrack3 = RaceTrack3.Insert(H3, "3");
                        }
                    }

                    Max = Math.Max(H1, Math.Max(H2, H3));
                    writeOut(RaceTrack1 + "\n" + RaceTrack2 + "\n" + RaceTrack3);
                    wait(3);
                }

                string winner = "";

                if (Max == H1)
                {
                    winner = "1";
                    h1++;
                    if (H2 == Math.Max(H2,H3))
                    {
                        h2 += 2;
                        h3 += 3;
                    }
                    else
                    {
                        h2 += 3;
                        h3 += 2;
                    }
                }
                if (Max == H2)
                {
                    winner = "2";
                    h2++;
                    if (H1 == Math.Max(H1, H3))
                    {
                        h1 += 2;
                        h3 += 3;
                    }
                    else
                    {
                        h1 += 3;
                        h3 += 2;
                    }
                }
                if (Max == H3)
                {
                    winner = "3";
                    h3++;
                    if (H2 == Math.Max(H2, H1))
                    {
                        h2 += 2;
                        h1 += 3;
                    }
                    else
                    {
                        h2 += 3;
                        h1 += 2;
                    }
                }
                odds1 = (100 * ((float)race / h1))/1.15f;
                odds2 = (100 * ((float)race / h2))/1.15f;
                odds3 = (100 * ((float)race / h3))/1.15f;

                writeLine("|e0Odds of winning:\n|20Horse1: " + odds1 + "|40 Horse2: " + odds2 + "|b0 Horse3: " + odds3);


                if (choice == winner)
                {
                    writeLine("|20Y O U  W I N !");
                    if (choice == "1")
                    {
                        if (odds1 == Math.Min(odds1, Math.Min(odds2, odds3)))
                            Money += Bet * 4;
                        if (odds1 == Math.Min(odds1, Math.Max(odds2, odds3)))
                            Money += Bet * 3;
                        if (odds1 == Math.Max(odds1, Math.Max(odds2, odds3)))
                            Money += Bet * 2;
                    }
                    if (choice == "2")
                    {
                        if (odds2 == Math.Min(odds2, Math.Min(odds1, odds3)))
                            Money += Bet * 4;
                        if (odds2 == Math.Min(odds2, Math.Max(odds1, odds3)))
                            Money += Bet * 3;
                        if (odds2 == Math.Max(odds2, Math.Max(odds1, odds3)))
                            Money += Bet * 2;
                    }
                    if (choice == "3")
                    {
                        if (odds3 == Math.Min(odds3, Math.Min(odds2, odds1)))
                            Money += Bet * 4;
                        if (odds3 == Math.Min(odds3, Math.Max(odds2, odds1)))
                            Money += Bet * 3;
                        if (odds3 == Math.Max(odds3, Math.Max(odds2, odds1)))
                            Money += Bet * 2;
                    }
                }
                else
                    write("|40Y O U  L O S E !");

                wait(3);
                clear();
                race++;
            }
        }
    }
}
