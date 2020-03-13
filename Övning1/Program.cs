using System;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool avsluta = false;
            do
            {
                Console.WriteLine("Välkomna till programmets huvudmeny. Navigera i huvudmenyen genom att ange en siffra");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Räkna ut pris för ett helt sällskap");
                Console.WriteLine("3. Skriv ut någonting tio gånger");
                Console.WriteLine("4. Skriv ut tredje ordet i en mening");
    
                string meny_val = Console.ReadLine();
                switch (meny_val)
                {
                    case "0":
                        avsluta = true;
                        break;
                    case "1":
                        ungdom_pensionär();
                        break;
                    case "2":
                        räkna_ut_pris();
                        break;
                    case "3":
                        skriv_ut_text_tio_gånger();
                        break;
                    case "4":
                        skriv_ut_tredje_ordet();
                        break;
                    default:
                        Console.WriteLine("Felaktig input! Ange 0 eller 1-4");
                        break;
                }
               
            } while (!avsluta);

        }

        private static void skriv_ut_tredje_ordet()
        {
            bool över_tre_ord = false;
            string tredje_ordet = "";
            while (! över_tre_ord)
            {
                Console.WriteLine("Amge em mening med minst tre ord");
                string mening = Console.ReadLine();

                string[] mening_arr = mening.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                if (mening_arr.Length >= 3)
                {
                    tredje_ordet = mening_arr[2];
                    över_tre_ord = true;
                }
            }
            Console.WriteLine("Tredje ordet är: " + tredje_ordet);
        }

        private static void skriv_ut_text_tio_gånger()
        {
            Console.WriteLine("Ange en godtycklig text");
            string text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "." + text + ", ");
            }
            Console.WriteLine();
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
                while (!int.TryParse(Console.ReadLine(), out ålder))
                {
                    Console.WriteLine("Ange en ålder");
                }

               
               if (ålder < 20 && ålder != 0)
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
