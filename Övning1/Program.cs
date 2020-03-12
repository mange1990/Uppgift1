using System;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkomna till programmets huvudmeny. Navigera i huvudmenyen genom att ange en siffra");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Räkna ut pris för ett helt sällskap");
            Console.WriteLine("3. Skriv ut någonting tio gånger");
            Console.WriteLine("4. Skriv ut tredje ordet i en mening");

            bool quit = false;

            while (!quit)
            {
                int choice;

                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0:
                        quit = true;
                        break;
                    case 1:
                        ungdom_pensionär();
                        break;
                    case 2:
                        räkna_ut_pris();
                        break;
                    case 3:
                        skriv_ut_text_tio_gånger();
                        break;
                    case 4:
                        skriv_ut_tredje_ordet();
                        break;
                    default:
                        Console.WriteLine("Felaktig input! Ange 0 eller 1");
                        break;
                }
            }
        }

        private static void skriv_ut_tredje_ordet()
        {
            
        }

        private static void skriv_ut_text_tio_gånger()
        {
            Console.WriteLine("Ange en godtycklig text");
            string text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "." + text + ", ");
            }
        }

        private static void räkna_ut_pris()
        {
            Console.WriteLine("Ange antal personer: ");
            int antal_personer = 0;
            int.TryParse(Console.ReadLine(), out antal_personer);

            int pris = 0;
            for (int i = 1; i <= antal_personer; i++)
            {
                Console.WriteLine("Ange ålder på person nummer " + i );
                int ålder;
                int.TryParse(Console.ReadLine(), out ålder);

                if (ålder < 20)
                {
                    pris += 80;
                }
                else if (ålder > 64)
                {
                    pris += 90;
                }
                else
                {
                    pris += 120;
                }
            }
            Console.WriteLine("Antal personer: " + antal_personer);
            Console.WriteLine("Totalkostnad för hela sällskapet: " + pris);
        }

        private static void ungdom_pensionär()
        {
            int ålder;
            Console.WriteLine("Ange din ålder");
            int.TryParse(Console.ReadLine(), out ålder);
            if (ålder < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }else if (ålder > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }
    }
}
