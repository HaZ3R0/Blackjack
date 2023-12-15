using System;
using System.ComponentModel.Design;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!VÄLKOMMEN!");

            string menyval = "0";
            string vinnare = " Ingen vinnare än";

            while (menyval != "4") 
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1: Spela BlackJack");
                Console.WriteLine("2: Visa senaste vinnare");
                Console.WriteLine("3: Regler");
                Console.WriteLine("4: Avsluta Programmet");

                menyval = Console.ReadLine();

                switch (menyval)
                {
                    case "1":
                    {
                            Console.WriteLine("Du får nu två kort");
                            Random slump = new Random();
                            int spelare1 = slump.Next(1, 12);
                            int spelare2 = slump.Next(1, 12);
                            int spelare3 = 0;
                            int dator2 = slump.Next(1, 12);
                            int dator1 = slump.Next(1, 12);
                            int dator3 = 0;
                            int sumdator = (dator1 + dator2);
                            int sumspelare = (spelare1 + spelare2);
                            Console.WriteLine("Du har " + sumspelare + " poäng");
                            Console.WriteLine("Datorns ena kort är värt " + dator1 + " poäng ");
                            Console.WriteLine(" ");

                            if (sumspelare > 21)
                            {
                                Console.WriteLine("Du blev tjock");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                break;
                            }

                            else if (sumdator > 21)
                            {
                                Console.WriteLine("Datron blev tjock");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                break;
                            }
                            Console.WriteLine("Vill du ta ett nytt kort? (j för ja n för nej)");
                            string val = Console.ReadLine().ToLower();
                            Console.WriteLine(" ");

                            while (val == "j")
                            {
                                spelare3 += slump.Next(1, 12);
                                sumspelare = (sumspelare + spelare3);
                                Console.WriteLine("du fick " + spelare3 + " poäng");
                                Console.WriteLine("Din nya poäng är " + sumspelare);
                                Console.WriteLine("Datorns poäng är " + dator1);
                                Console.WriteLine(" ");

                                if (sumspelare > 21)
                                {
                                    Console.WriteLine("Datorn vann =( (Du blev tjock)");
                                    Console.WriteLine(" ");
                                    break;
                                }

                                Console.WriteLine("Vill du dra ett till kort j för ja n gör nej");
                                val = Console.ReadLine().ToLower();
                                Console.WriteLine(" ");
                            }
                            
                            while (val != "j")
                            {
                                while (sumdator < 18)
                                {
                                    Console.WriteLine("Datorn hade " + sumdator + " innan ny dragning");
                                    dator3 = slump.Next(1, 12);
                                    sumdator = (sumdator + dator3);
                                    Console.WriteLine("datorn fick " + dator3 + " poäng till");
                                    Console.WriteLine("datorn har nu " + sumdator + " poäng");
                                    Console.WriteLine(" ");

                                    if (sumdator > 21)
                                    {
                                        Console.WriteLine("Du har vunnit!");
                                        Console.WriteLine("Du hade " + sumspelare + " poäng");
                                        Console.WriteLine("Datorn hade " + sumdator + " poäng");
                                        Console.WriteLine("Datorn blev tjock");
                                        Console.WriteLine(" ");
                                        break;

                                    }
        
                                    else if (sumdator > sumspelare)
                                    {
                                        Console.WriteLine("Du förlorade =(");
                                        Console.WriteLine("Du hade " + sumspelare + " poäng");
                                        Console.WriteLine("Datorn hade " + sumdator + " poäng");
                                        Console.WriteLine(" ");
                                        break;
                                    }
                                }
                                if(sumdator < sumspelare)
                                {
                                    Console.WriteLine("Du vann");
                                    Console.WriteLine("Du hade " + sumspelare + " poäng");
                                    Console.WriteLine("Datorns poäng var " + sumdator);
                                    Console.WriteLine(" ");
                                    break;
                                }
                                else if (sumdator == sumspelare)
                                {
                                    Console.WriteLine("Du förlorade datorns poäng var " + sumdator);
                                    Console.WriteLine("Du hade " + sumspelare + " poäng");
                                    Console.WriteLine(" ");
                                    break;
                                }

                                Console.WriteLine("Skriv vem som vann (ditt namn eller datorn)");
                                vinnare = Console.ReadLine();
                                break;
                            }
                            break;
                    }
                    case "2":
                        {
                            Console.WriteLine("Senaste vinnaren var " + vinnare);
                            Console.WriteLine(" ");
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Ditt mål är tvinga datorn få mer än 21 poäng eller få mer poäng än datron." +
                                "Du får poäng genom att dra ett kort 1-11." +
                                "Om du får mer än 21 poäng förlorar du." +
                                "Både du och datorn får två kort i början bara att ett av datrons är gömda." +
                                "Där efter får du dra nya kort tills du är nöjd eller får över 21." +
                                "När du är klar drar datorn kort tills den har över 17 eller mer än 21");
                            Console.WriteLine(" ");
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Programet avslutas");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            break;
                        }
                }
            }
        }
    }
}