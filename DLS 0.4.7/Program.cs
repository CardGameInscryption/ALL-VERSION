using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DLS_0._4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Clear();

            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......2.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|—————————| |---------| |         | |         |");
            Console.WriteLine("|        1| | ___     | |         | |         |");
            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
            Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
            Console.WriteLine("|—————————| |---------| |         | |         |");
            Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
            Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|—————————| |---------| |         | |         |");
            Console.WriteLine("|        1| | ___     | |         | |         |");
            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
            Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
            Console.WriteLine("|—————————| |---------| |         | |         |");
            Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            Thread.Sleep(750);
            Console.Clear();

            while (true)
            {

                Thread.Sleep(250);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                Console.WriteLine(@"——————————— |   (*)   | ——————————— ———————————");
                Console.WriteLine(@"|..Пень...| |   | |   | |..Пень...| |         |");
                Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                Console.WriteLine(@"|         | | -|---|- | |         | |         |");
                Console.WriteLine(@"| |\_  /| | |  |   |  | | |\_  /| | |         |");
                Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                Console.WriteLine(@"| |_____\ | |  \   /  | | |_____\ | |         |");
                Console.WriteLine(@"|---------| |   \ /   | |---------| |         |");
                Console.WriteLine(@"|.......2.| ----------- |.......2.| |         |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ| |         | |         | |          |");
                Console.WriteLine(@"|—————————| | _______ | |         | |          |");
                Console.WriteLine(@"|        1| ||       || |         | |          |");
                Console.WriteLine(@"| |\---/| | ||  /-\  || |         | |          |");
                Console.WriteLine(@"| | -_- | | | \ \_/ / | |         | |          |");
                Console.WriteLine(@"|  \_^_/  | |  \   /  | |         | |          |");
                Console.WriteLine(@"|—————————| |   \_/   | |         | |          |");
                Console.WriteLine(@"|.1.....3.| |         | |         | |          |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(250);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                Console.WriteLine(@"|..Пень...| |   (*)   | |..Пень...| |         |");
                Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                Console.WriteLine(@"| |\_  /| | | -|---|- | | |\_  /| | |         |");
                Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                Console.WriteLine(@"| |_____\ | |  |   |  | | |_____\ | |         |");
                Console.WriteLine(@"|---------| |  |   |  | |---------| |         |");
                Console.WriteLine(@"|.......2.| |  \   /  | |.......3.| |         |");
                Console.WriteLine(@"——————————— |   \ /   | ——————————— ——————————— ");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ| ——————————— |         | |         |");
                Console.WriteLine(@"|---------| |         | |         | |         |");
                Console.WriteLine(@"|        1| | _______ | |         | |         |");
                Console.WriteLine(@"| |\---/| | ||       || |         | |         |");
                Console.WriteLine(@"| | -_- | | ||  /-\  || |         | |         |");
                Console.WriteLine(@"|  \_^_/  | | \ \_/ / | |         | |         |");
                Console.WriteLine(@"|—————————| |  \   /  | |         | |         |");
                Console.WriteLine(@"|.1.....3.| |   \_/   | |         | |         |");
                Console.WriteLine(@"——————————— |         | ——————————— ———————————");
                Console.WriteLine(@"            ———————————");

                Thread.Sleep(250);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                Console.WriteLine("|---------| |—————————| |---------| |         |");
                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                Console.WriteLine("|---------| |—————————| |---------| |         |");
                Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                Console.WriteLine("|—————————| |---------| |         | |         |");
                Console.WriteLine("|        1| | ___     | |         | |         |");
                Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                Console.WriteLine("|—————————| |---------| |         | |         |");
                Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                break;
            }

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|   / \   | |         |");
            Console.WriteLine(@"|  0   0  | |         |");
            Console.WriteLine(@"|   \ /   | |  C...C  |");
            Console.WriteLine(@"|   / \   | | ( . . ) |");
            Console.WriteLine(@"|   \ /   | |  \   /  |");
            Console.WriteLine(@"|   / \   | |   `o`   |");
            Console.WriteLine(@"|  0   0  | |         |");
            Console.WriteLine(@"|   \ /   | |         |");
            Console.WriteLine(@"——————————— ———————————");

            Thread.Sleep(250);
            Console.WriteLine("1) Своя карта.");

            Thread.Sleep(250);
            Console.WriteLine("2) Белка.");

            int Karta_ne_iz_ryk = int.Parse(Console.ReadLine());

            Console.Clear();

            if (Karta_ne_iz_ryk == 1)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|        1| | ___     | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Console.WriteLine(@"———————————  ———————————  ———————————");
                    Console.WriteLine(@"|...ВОЛК..|  |...Жаба..|  |.ГАДЮКА..|");
                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                    Console.WriteLine(@"||\_____/2|  |    00  1|  |        2|");
                    Console.WriteLine(@"||)     (||  |   (--)  |  |  ___   /|");
                    Console.WriteLine(@"| \ o o / |  |  ( || ) |  | ('')\_//|");
                    Console.WriteLine(@"|  \_0_/  |  |  ^^~~^^ |  |  ^  \_/ |");
                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                    Console.WriteLine(@"|.3.....2.|  |.1.....2.|  |.1..X..1.|");
                    Console.WriteLine(@"———————————  ———————————  ———————————");

                    Thread.Sleep(250);
                    Console.WriteLine("1) Волк");

                    Thread.Sleep(250);
                    Console.WriteLine("2) Жаба");

                    Thread.Sleep(250);
                    Console.WriteLine("3) Гадюка");

                    int vibor_karti_iz_ryk2 = int.Parse(Console.ReadLine());

                    if (vibor_karti_iz_ryk2 != 2)
                    {
                        Console.Write("***** - ");
                        {
                            string te = "Этой карте нужно больше жертв.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (vibor_karti_iz_ryk2 == 2)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                            Console.WriteLine("|---------| |—————————| |---------| |         |");
                            Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                            Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |—————————| |---------| |         |");
                            Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|—————————| |---------| |         | |         |");
                            Console.WriteLine("|        1| | ___     | |         | |         |");
                            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                            Console.WriteLine(@"| | -_- | | ||_____\_ | |    3    | |    4    |");
                            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                            Console.WriteLine("|—————————| |---------| |         | |         |");
                            Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Выбери место.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                            }
                            int mesto_karti2 = int.Parse(Console.ReadLine());

                            Console.Clear();

                            if (mesto_karti2 < 2)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|—————————| |---------| |         | |         |");
                                Console.WriteLine("|        1| | ___     | |         | |         |");
                                Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                                Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                                Console.WriteLine("|—————————| |---------| |         | |         |");
                                Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Это место занято. Выбери другое.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                            }
                            else if (mesto_karti2 == 3)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |...Жаба..| |         |");
                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                Console.WriteLine("|        1| | ___     | |    00  1| |         |");
                                Console.WriteLine(@"| |\---/| | ||___\_   | |   (--)  | |         |");
                                Console.WriteLine(@"| | -_- | | ||_____\_ | |  ( || ) | |         |");
                                Console.WriteLine(@"|  \_^_/  | ||_______\| |  ^^~~^^ | |         |");
                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                Console.WriteLine("|.1.....3.| |.......4.| |.1.....2.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                    Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                                    Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |...Жаба..| |         |");
                                    Console.WriteLine("|—————————| |---------| |---------| |         |");
                                    Console.WriteLine("|        1| | ___     | |    00  1| |         |");
                                    Console.WriteLine(@"| |\---/| | ||___\_   | |   (--)  | |         |");
                                    Console.WriteLine(@"| | -_- | | ||_____\_ | |  ( || ) | |         |");
                                    Console.WriteLine(@"|  \_^_/  | ||_______\| |  ^^~~^^ | |         |");
                                    Console.WriteLine("|—————————| |---------| |---------| |         |");
                                    Console.WriteLine("|.1.....3.| |.......4.| |.1.....2.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");


                                    while (true)
                                    {
                                        Console.WriteLine("Что бы начать атаку нажми на Tab");
                                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                                        if (keyinfo.Key == ConsoleKey.Tab)
                                        {
                                            while (true)
                                            {

                                                Console.Clear();
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                                                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                                                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                                Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |...Жаба..| |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|        1| | ___     | |    00  1| |         |");
                                                Console.WriteLine(@"| |\---/| | ||___\_   | |   (--)  | |         |");
                                                Console.WriteLine(@"| | -_- | | ||_____\_ | |  ( || ) | |         |");
                                                Console.WriteLine(@"|  \_^_/  | ||_______\| |  ^^~~^^ | |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|.1.....3.| |.......4.| |.1.....2.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                                Thread.Sleep(250);
                                                Console.Clear();

                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|         | |ВОЛЧЁНОК.| |..Пень...| |         |");
                                                Console.WriteLine("| _______ | |—————————| |---------| |         |");
                                                Console.WriteLine(@"||       || | |\___/|2| |         | |         |");
                                                Console.WriteLine(@"||  /-\  || | |)o o(| | | |\_  /| | |         |");
                                                Console.WriteLine(@"| \ \_/ / | |  \_0_/  | | |  \/ | | |         |");
                                                Console.WriteLine(@"|  \   /  | |         | | |_____\ | |         |");
                                                Console.WriteLine(@"|   \_/   | |—————————| |---------| |         |");
                                                Console.WriteLine("|         | |.1..$..1.| |.......3.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"——————————— |.КАМЕНЬ..| |...Жаба..| |         |");
                                                Console.WriteLine(@"|   / \   | |---------| |---------| |         |");
                                                Console.WriteLine(@"|  /   \  | | ___     | |    00  1| |         |");
                                                Console.WriteLine(@"|  |   |  | ||___\_   | |   (--)  | |         |");
                                                Console.WriteLine(@"|  |   |  | ||_____\_ | |  ( || ) | |         |");
                                                Console.WriteLine(@"|  |   |  | ||_______\| |  ^^~~^^ | |         |");
                                                Console.WriteLine(@"| -|___|- | |---------| |---------| |         |");
                                                Console.WriteLine(@"|   | |   | |.......5.| |.1.....2.| |         |");
                                                Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   (*)   |");
                                                Console.WriteLine(@"-----------");

                                                Thread.Sleep(250);
                                                Console.Clear();

                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|         | ——————————— ——————————— ———————————");
                                                Console.WriteLine("| _______ | |ВОЛЧЁНОК.| |..Пень...| |         |");
                                                Console.WriteLine("||       || |—————————| |---------| |         |");
                                                Console.WriteLine(@"||  /-\  || | |\___/|2| |         | |         |");
                                                Console.WriteLine(@"| \ \_/ / | | |)o o(| | | |\_  /| | |         |");
                                                Console.WriteLine(@"|  \   /  | |  \_0_/  | | |  \/ | | |         |");
                                                Console.WriteLine(@"|   \_/   | |         | | |_____\ | |         |");
                                                Console.WriteLine("|         | |—————————| |---------| |         |");
                                                Console.WriteLine("——————————— |.1..$..1.| |.......3.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|  /   \  | |.КАМЕНЬ..| |...Жаба..| |         |");
                                                Console.WriteLine(@"|  |   |  | |---------| |---------| |         |");
                                                Console.WriteLine(@"|  |   |  | | ___     | |    00  1| |         |");
                                                Console.WriteLine(@"|  |   |  | ||___\_   | |   (--)  | |         |");
                                                Console.WriteLine(@"| -|___|- | ||_____\_ | |  ( || ) | |         |");
                                                Console.WriteLine(@"|   | |   | ||_______\| |  ^^~~^^ | |         |");
                                                Console.WriteLine(@"|   | |   | |---------| |---------| |         |");
                                                Console.WriteLine(@"|   (*)   | |.......5.| |.1.....2.| |         |");
                                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                                Thread.Sleep(250);
                                                Console.Clear();

                                                Console.Clear();
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                                                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                                                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                                Console.WriteLine("|.......1.| |.1..$..1.| |.......3.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |...Жаба..| |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|        1| | ___     | |    00  1| |         |");
                                                Console.WriteLine(@"| |\---/| | ||___\_   | |   (--)  | |         |");
                                                Console.WriteLine(@"| | -_- | | ||_____\_ | |  ( || ) | |         |");
                                                Console.WriteLine(@"|  \_^_/  | ||_______\| |  ^^~~^^ | |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|.1.....3.| |.......4.| |.1.....2.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                                Thread.Sleep(250);
                                                Console.Clear();

                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|..Пень...| |   |-|   | |..Пень...| |         |");
                                                Console.WriteLine("|---------| |   | |   | |---------| |         |");
                                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                                Console.WriteLine(@"| |\_  /| | |   | |   | | |\_  /| | |         |");
                                                Console.WriteLine(@"| |  \/ | | |   | |   | | |  \/ | | |         |");
                                                Console.WriteLine(@"| |_____\ | |   | |   | | |_____\ | |         |");
                                                Console.WriteLine("|---------| |   | |   | |---------| |         |");
                                                Console.WriteLine("|.......1.| |   |-|   | |.......3.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |...Жаба..| |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|        1| | ___     | |    00  1| |         |");
                                                Console.WriteLine(@"| |\---/| | ||___\_   | |   (--)  | |         |");
                                                Console.WriteLine(@"| | -_- | | ||_____\_ | |  ( || ) | |         |");
                                                Console.WriteLine(@"|  \_^_/  | ||_______\| |  ^^~~^^ | |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|.1.....3.| |.......4.| |.1.....2.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                                Thread.Sleep(200);
                                                Console.Celar();

                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|..Пень...| |...ВОЛК..| |..Пень...| |         |");
                                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                                Console.WriteLine(@"|         | ||\_____/2| |         | |         |");
                                                Console.WriteLine(@"| |\_  /| | ||)     (|| | |\_  /| | |         |");
                                                Console.WriteLine(@"| |  \/ | | | \ o o / | | |  \/ | | |         |");
                                                Console.WriteLine(@"| |_____\ | |  \_0_/  | | |_____\ | |         |");
                                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                                Console.WriteLine("|.......1.| |.3.....2.| |.......3.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |...Жаба..| |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|        1| | ___     | |    00  1| |         |");
                                                Console.WriteLine(@"| |\---/| | ||___\_   | |   (--)  | |         |");
                                                Console.WriteLine(@"| | -_- | | ||_____\_ | |  ( || ) | |         |");
                                                Console.WriteLine(@"|  \_^_/  | ||_______\| |  ^^~~^^ | |         |");
                                                Console.WriteLine("|—————————| |---------| |---------| |         |");
                                                Console.WriteLine("|.1.....3.| |.......4.| |.1.....2.| |         |");
                                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                                break;
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                            else if (mesto_karti2 == 4)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |—————————| |---------| |         |");
                                Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |...Жаба..|");
                                Console.WriteLine("|—————————| |---------| |         | |---------|");
                                Console.WriteLine("|        1| | ___     | |         | |    00  1|");
                                Console.WriteLine(@"| |\---/| | ||___\_   | |         | |   (--)  |");
                                Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |  ( || ) |");
                                Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |  ^^~~^^ |");
                                Console.WriteLine("|—————————| |---------| |         | |---------|");
                                Console.WriteLine("|.1.....3.| |.......4.| |         | |.1.....2.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            else if (Karta_ne_iz_ryk == 2)
            {
                Console.Clear();
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                Console.WriteLine("|---------| |—————————| |---------| |         |");
                Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                Console.WriteLine("|---------| |—————————| |---------| |         |");
                Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                Console.WriteLine("|—————————| |---------| |         | |         |");
                Console.WriteLine("|        1| | ___     | |         | |         |");
                Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                Console.WriteLine("|—————————| |---------| |         | |         |");
                Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Console.WriteLine(@"———————————  ———————————  ———————————");
                Console.WriteLine(@"|..БЕЛКА..|  |...Жаба..|  |.ГАДЮКА..|");
                Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                Console.WriteLine(@"| _  (\_  |  |    00  1|  |        2|");
                Console.WriteLine(@"|( \  ( '>|  |   (--)  |  |  ___   /|");
                Console.WriteLine(@"| ) \/_)= |  |  ( || ) |  | ('')\_//|");
                Console.WriteLine(@"|(_(__)_  |  |  ^^~~^^ |  |  ^  \_/ |");
                Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                Console.WriteLine(@"|.0.....1.|  |.1.....2.|  |.1..X..1.|");
                Console.WriteLine(@"———————————  ———————————  ———————————");

                Thread.Sleep(250);
                Console.WriteLine("1) Белка");

                Thread.Sleep(250);
                Console.WriteLine("2) Жаба");

                Thread.Sleep(250);
                Console.WriteLine("3) Гадюка");

                int vibor_karti_iz_ryk2 = int.Parse(Console.ReadLine());

                if (vibor_karti_iz_ryk2 == 3)
                {
                    Console.Write("***** - ");
                    {
                        string te = "Этой карте нужно больше жертв.";
                        int ab = 100;

                        foreach (char c in te)
                        {
                            Console.Write(c);
                            Thread.Sleep(ab);
                        }
                        Console.WriteLine();
                    }
                }
                else if (vibor_karti_iz_ryk2 == 1)
                {

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|        1| | ___     | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||_____\_ | |    3    | |    4    |");
                    Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Console.Write("***** - ");
                    {
                        string fraza = "Выбери место.";
                        int vrema = 100;
                        foreach (char c in fraza)
                        {
                            Console.Write(c);
                            Thread.Sleep(vrema);
                        }
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    }
                    int mesto_karti2 = int.Parse(Console.ReadLine());

                    Console.Clear();

                    if (mesto_karti2 == 2 || mesto_karti2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                        Console.WriteLine("|---------| |—————————| |---------| |         |");
                        Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                        Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                        Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                        Console.WriteLine("|---------| |—————————| |---------| |         |");
                        Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                        Console.WriteLine("|—————————| |---------| |         | |         |");
                        Console.WriteLine("|        1| | ___     | |         | |         |");
                        Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                        Console.WriteLine(@"| | -_- | | ||_____\_ | |    3    | |    4    |");
                        Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                        Console.WriteLine("|—————————| |---------| |         | |         |");
                        Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Console.Write("***** - ");
                        {
                            string fraza = "Это место занято. Выбери другое.";
                            int vrema = 100;
                            foreach (char c in fraza)
                            {
                                Console.Write(c);
                                Thread.Sleep(vrema);
                            }
                            Console.WriteLine();
                            Thread.Sleep(1000);
                        }
                    }
                    else if (mesto_karti2 == 3)
                    {

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |..МЫШКА..|");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |---------|");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   ,_,   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | | /-) (-\ |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |/-_\_/_-\|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | |    ^    |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |---------|");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |.2.....1.|");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                        Console.WriteLine("|---------| |—————————| |---------| |         |");
                        Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                        Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                        Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                        Console.WriteLine("|---------| |—————————| |---------| |         |");
                        Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |..БЕЛКА..| |         |");
                        Console.WriteLine("|—————————| |---------| |—————————| |         |");
                        Console.WriteLine(@"|        1| | ___     | | _  (\_  | |         |");
                        Console.WriteLine(@"| |\---/| | ||___\_   | |( \  ( '>| |         |");
                        Console.WriteLine(@"| | -_- | | ||_____\_ | | ) \/_)= | |         |");
                        Console.WriteLine(@"|  \_^_/  | ||_______\| |(_(__)_  | |         |");
                        Console.WriteLine("|—————————| |---------| |—————————| |         |");
                        Console.WriteLine("|.1.....3.| |.......4.| |.0.....1.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");



                    }
                }
            }
            break;
        }
                                    else
                                    {
                                        Console.Write("***** - ");
                                        {
                                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                                            int ab = 100;

                                            foreach (char c in te)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(ab);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
            */

            /*
             Console.Clear();

                            if (mesto_carti_iz_ryk == 1)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|---------| |---------| |         | |         |");
                                Console.WriteLine(@"|        1| | ___     | |         | |         |");
                                Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                                Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                                Console.WriteLine("|---------| |---------| |         | |         |");
                                Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                while (true)
                                {
                                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");

                                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                                    if (keyinfo.Key == ConsoleKey.Tab)
                                    {
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine("|---------| |---------| |         | |         |");
                                            Console.WriteLine(@"|        1| | ___     | |         | |         |");
                                            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                                            Console.WriteLine("|---------| |---------| |         | |         |");
                                            Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |         | |..Пень...| |         |");
                                            Console.WriteLine("| _______ | |         | |---------| |         |");
                                            Console.WriteLine("||       || |         | |         | |         |");
                                            Console.WriteLine(@"||  /-\  || |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| \ \_/ / | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"|  \   /  | |         | | |_____\ | |         |");
                                            Console.WriteLine(@"|   \_/   | |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"——————————— |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine(@"|   / \   | |---------| |         | |         |");
                                            Console.WriteLine(@"|  /   \  | | ___     | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||_______\| |         | |         |");
                                            Console.WriteLine(@"| -|___|- | |---------| |         | |         |");
                                            Console.WriteLine(@"|   | |   | |.......5.| |         | |         |");
                                            Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   (*)   |");
                                            Console.WriteLine(@"-----------");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | ——————————— ——————————— ———————————");
                                            Console.WriteLine("| _______ | |         | |..Пень...| |         |");
                                            Console.WriteLine("||       || |         | |---------| |         |");
                                            Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                                            Console.WriteLine(@"| \ \_/ / | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"|  \   /  | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"|   \_/   | |         | | |_____\ | |         |");
                                            Console.WriteLine("|         | |         | |---------| |         |");
                                            Console.WriteLine("——————————— |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|  /   \  | |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine(@"|  |   |  | |---------| |         | |         |");
                                            Console.WriteLine(@"|  |   |  | | ___     | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"| -|___|- | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|   | |   | ||_______\| |         | |         |");
                                            Console.WriteLine(@"|   | |   | |---------| |         | |         |");
                                            Console.WriteLine(@"|   (*)   | |.......5.| |         | |         |");
                                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......2.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine("|—————————| |---------| |         | |         |");
                                            Console.WriteLine("|        1| | ___     | |         | |         |");
                                            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                                            Console.WriteLine("|—————————| |---------| |         | |         |");
                                            Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            break;
                                        }
                                    }
                                }      
                            }
                            else if (mesto_carti_iz_ryk == 3)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |---------| |---------| |         |");
                                Console.WriteLine(@"|         | | ___     | |        1| |         |");
                                Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                                Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                                Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                                Console.WriteLine("|         | |---------| |---------| |         |");
                                Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                while (true)
                                {
                                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                                    if (keyinfo.Key == ConsoleKey.Tab)
                                    {
                                        while (true)
                                        {
                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                                            Console.WriteLine("|         | |---------| |—————————| |         |");
                                            Console.WriteLine("|         | | ___     | |        1| |         |");
                                            Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                                            Console.WriteLine("|         | |---------| |—————————| |         |");
                                            Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|..Пень...| |         | |         | |          |");
                                            Console.WriteLine(@"|---------| |         | | _______ | |          |");
                                            Console.WriteLine(@"|         | |         | ||       || |          |");
                                            Console.WriteLine(@"| |\_  /| | |         | ||  /-\  || |          |");
                                            Console.WriteLine(@"| |  \/ | | |         | | \ \_/ / | |          |");
                                            Console.WriteLine(@"| |_____\ | |         | |  \   /  | |          |");
                                            Console.WriteLine(@"|---------| |         | |   \_/   | |          |");
                                            Console.WriteLine(@"|.......3.| |         | |         | |          |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| ——————————— |         |");
                                            Console.WriteLine(@"|         | |---------| |   / \   | |         |");
                                            Console.WriteLine(@"|         | | ___     | |  /   \  | |         |");
                                            Console.WriteLine(@"|         | ||___\_   | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |  |   |  | |         |");
                                            Console.WriteLine(@"|         | |---------| | -|___|- | |         |");
                                            Console.WriteLine(@"|         | |.......5.| |   | |   | |         |");
                                            Console.WriteLine(@"----------- ----------- |   | |   | ———————————");
                                            Console.WriteLine(@"                        |   (*)   |");
                                            Console.WriteLine(@"                        -----------");


                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("----------- ----------- |         | ———————————");
                                            Console.WriteLine(@"|..Пень...| |         | | _______ | |          |");
                                            Console.WriteLine(@"|---------| |         | ||       || |          |");
                                            Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                                            Console.WriteLine(@"| |\_  /| | |         | | \ \_/ / | |          |");
                                            Console.WriteLine(@"| |  \/ | | |         | |  \   /  | |          |");
                                            Console.WriteLine(@"| |_____\ | |         | |   \_/   | |          |");
                                            Console.WriteLine(@"|---------| |         | |         | |          |");
                                            Console.WriteLine("|.......3.| |         | ——————————— |          |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"----------- ——————————— |   / \   | ———————————");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |  /   \  | |         |");
                                            Console.WriteLine(@"|         | |---------| |  |   |  | |         |");
                                            Console.WriteLine(@"|         | | ___     | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||___\_   | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | | -|___|- | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |   | |   | |         |");
                                            Console.WriteLine(@"|         | |---------| |   | |   | |         |");
                                            Console.WriteLine(@"|         | |.......5.| |   (*)   | |         |");
                                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......2.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                                            Console.WriteLine("|         | |---------| |—————————| |         |");
                                            Console.WriteLine("|         | | ___     | |        1| |         |");
                                            Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                                            Console.WriteLine("|         | |---------| |—————————| |         |");
                                            Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("***** - ");
                                        {
                                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                                            int ab = 100;

                                            foreach (char c in te)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(ab);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                            else if (mesto_carti_iz_ryk == 4)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |---------| |         | |---------|");
                                Console.WriteLine(@"|         | | ___     | |         | |        1|");
                                Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                                Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                                Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                                Console.WriteLine("|         | |---------| |         | |---------|");
                                Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                while (true)
                                {
                                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                                    if (keyinfo.Key == ConsoleKey.Tab)
                                    {
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                                            Console.WriteLine("|         | |---------| |         | |—————————|");
                                            Console.WriteLine("|         | | ___     | |         | |        1|");
                                            Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                                            Console.WriteLine("|         | |---------| |         | |—————————|");
                                            Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine(@"|         | |---------| |         | |   / \   |");
                                            Console.WriteLine(@"|         | | ___     | |         | |  /   \  |");
                                            Console.WriteLine(@"|         | ||___\_   | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |  |   |  |");
                                            Console.WriteLine(@"|         | |---------| |         | | -|___|- |");
                                            Console.WriteLine(@"|         | |.......5.| |         | |   | |   |");
                                            Console.WriteLine(@"——————————— ----------- ----------- |   | |   |");
                                            Console.WriteLine(@"                                    |   (*)   |");
                                            Console.WriteLine(@"                                    -----------");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"----------- ----------- ——————————— |   / \   |");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |  /   \  |");
                                            Console.WriteLine(@"|         | |---------| |         | |  |   |  |");
                                            Console.WriteLine(@"|         | | ___     | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||___\_   | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | | -|___|- |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |   | |   |");
                                            Console.WriteLine(@"|         | |---------| |         | |   | |   |");
                                            Console.WriteLine(@"|         | |.......5.| |         | |   (*)   |");
                                            Console.WriteLine(@"----------- ----------- ——————————— ———————————");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                                            Console.WriteLine("|         | |---------| |         | |—————————|");
                                            Console.WriteLine("|         | | ___     | |         | |        1|");
                                            Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                                            Console.WriteLine("|         | |---------| |         | |—————————|");
                                            Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("***** - ");
                                        {
                                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                                            int ab = 100;

                                            foreach (char c in te)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(ab);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                        if (vibor_karti_iz_ryk == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                            Console.WriteLine(@"|    1    | ||_____\_ | |    3    | |    4    |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Выбери место.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                            }

                            int mesto_carti_iz_ryk = int.Parse(Console.ReadLine());

                            Console.Clear();

                            if (mesto_carti_iz_ryk == 1)
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|...Жаба..| |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|---------| |---------| |         | |         |");
                                    Console.WriteLine(@"|    00  1| | ___     | |         | |         |");
                                    Console.WriteLine(@"|   (--)  | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|  ( || ) | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|  ^^~~^^ | ||_______\| |         | |         |");
                                    Console.WriteLine("|---------| |---------| |         | |         |");
                                    Console.WriteLine("|.1.....2.| |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                                    if (keyinfo.Key == ConsoleKey.Tab)
                                    {
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|...Жаба..| |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine("|---------| |---------| |         | |         |");
                                            Console.WriteLine(@"|    00  1| | ___     | |         | |         |");
                                            Console.WriteLine(@"|   (--)  | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"|  ( || ) | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|  ^^~~^^ | ||_______\| |         | |         |");
                                            Console.WriteLine("|---------| |---------| |         | |         |");
                                            Console.WriteLine("|.1.....2.| |.......5.| |         | |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |         | |..Пень...| |         |");
                                            Console.WriteLine("| _______ | |         | |---------| |         |");
                                            Console.WriteLine("||       || |         | |         | |         |");
                                            Console.WriteLine(@"||  /-\  || |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| \ \_/ / | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"|  \   /  | |         | | |_____\ | |         |");
                                            Console.WriteLine(@"|   \_/   | |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"——————————— |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine(@"|   / \   | |---------| |         | |         |");
                                            Console.WriteLine(@"|  /   \  | | ___     | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||_______\| |         | |         |");
                                            Console.WriteLine(@"| -|___|- | |---------| |         | |         |");
                                            Console.WriteLine(@"|   | |   | |.......5.| |         | |         |");
                                            Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   (*)   |");
                                            Console.WriteLine(@"-----------");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | ——————————— ——————————— ———————————");
                                            Console.WriteLine("| _______ | |         | |..Пень...| |         |");
                                            Console.WriteLine("||       || |         | |---------| |         |");
                                            Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                                            Console.WriteLine(@"| \ \_/ / | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"|  \   /  | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"|   \_/   | |         | | |_____\ | |         |");
                                            Console.WriteLine("|         | |         | |---------| |         |");
                                            Console.WriteLine("——————————— |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|  /   \  | |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine(@"|  |   |  | |---------| |         | |         |");
                                            Console.WriteLine(@"|  |   |  | | ___     | |         | |         |");
                                            Console.WriteLine(@"|  |   |  | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"| -|___|- | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|   | |   | ||_______\| |         | |         |");
                                            Console.WriteLine(@"|   | |   | |---------| |         | |         |");
                                            Console.WriteLine(@"|   (*)   | |.......5.| |         | |         |");
                                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......2.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|...Жаба..| |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine("|---------| |---------| |         | |         |");
                                            Console.WriteLine(@"|    00  1| | ___     | |         | |         |");
                                            Console.WriteLine(@"|   (--)  | ||___\_   | |         | |         |");
                                            Console.WriteLine(@"|  ( || ) | ||_____\_ | |         | |         |");
                                            Console.WriteLine(@"|  ^^~~^^ | ||_______\| |         | |         |");
                                            Console.WriteLine("|---------| |---------| |         | |         |");
                                            Console.WriteLine("|.1.....2.| |.......5.| |         | |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("***** - ");
                                        {
                                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                                            int ab = 100;

                                            foreach (char c in te)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(ab);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                            else if (mesto_carti_iz_ryk == 3)
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |...Жаба..| |         |");
                                    Console.WriteLine("|         | |---------| |---------| |         |");
                                    Console.WriteLine(@"|         | | ___     | |    00  1| |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |   (--)  | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |  ( || ) | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |  ^^~~^^ | |         |");
                                    Console.WriteLine("|         | |---------| |---------| |         |");
                                    Console.WriteLine("|         | |.......5.| |.1.....2.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                                    if (keyinfo.Key == ConsoleKey.Tab)
                                    {
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |...Жаба..| |         |");
                                            Console.WriteLine("|         | |---------| |---------| |         |");
                                            Console.WriteLine(@"|         | | ___     | |    00  1| |         |");
                                            Console.WriteLine(@"|         | ||___\_   | |   (--)  | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | |  ( || ) | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |  ^^~~^^ | |         |");
                                            Console.WriteLine("|         | |---------| |---------| |         |");
                                            Console.WriteLine("|         | |.......5.| |.1.....2.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|..Пень...| |         | |         | |          |");
                                            Console.WriteLine(@"|---------| |         | | _______ | |          |");
                                            Console.WriteLine(@"|         | |         | ||       || |          |");
                                            Console.WriteLine(@"| |\_  /| | |         | ||  /-\  || |          |");
                                            Console.WriteLine(@"| |  \/ | | |         | | \ \_/ / | |          |");
                                            Console.WriteLine(@"| |_____\ | |         | |  \   /  | |          |");
                                            Console.WriteLine(@"|---------| |         | |   \_/   | |          |");
                                            Console.WriteLine(@"|.......3.| |         | |         | |          |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| ——————————— |         |");
                                            Console.WriteLine(@"|         | |---------| |   / \   | |         |");
                                            Console.WriteLine(@"|         | | ___     | |  /   \  | |         |");
                                            Console.WriteLine(@"|         | ||___\_   | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |  |   |  | |         |");
                                            Console.WriteLine(@"|         | |---------| | -|___|- | |         |");
                                            Console.WriteLine(@"|         | |.......5.| |   | |   | |         |");
                                            Console.WriteLine(@"----------- ----------- |   | |   | ———————————");
                                            Console.WriteLine(@"                        |   (*)   |");
                                            Console.WriteLine(@"                        -----------");


                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("----------- ----------- |         | ———————————");
                                            Console.WriteLine(@"|..Пень...| |         | | _______ | |          |");
                                            Console.WriteLine(@"|---------| |         | ||       || |          |");
                                            Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                                            Console.WriteLine(@"| |\_  /| | |         | | \ \_/ / | |          |");
                                            Console.WriteLine(@"| |  \/ | | |         | |  \   /  | |          |");
                                            Console.WriteLine(@"| |_____\ | |         | |   \_/   | |          |");
                                            Console.WriteLine(@"|---------| |         | |         | |          |");
                                            Console.WriteLine("|.......3.| |         | ——————————— |          |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"----------- ——————————— |   / \   | ———————————");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |  /   \  | |         |");
                                            Console.WriteLine(@"|         | |---------| |  |   |  | |         |");
                                            Console.WriteLine(@"|         | | ___     | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||___\_   | |  |   |  | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | | -|___|- | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |   | |   | |         |");
                                            Console.WriteLine(@"|         | |---------| |   | |   | |         |");
                                            Console.WriteLine(@"|         | |.......5.| |   (*)   | |         |");
                                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......2.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |...Жаба..| |         |");
                                            Console.WriteLine("|         | |---------| |---------| |         |");
                                            Console.WriteLine(@"|         | | ___     | |    00  1| |         |");
                                            Console.WriteLine(@"|         | ||___\_   | |   (--)  | |         |");
                                            Console.WriteLine(@"|         | ||_____\_ | |  ( || ) | |         |");
                                            Console.WriteLine(@"|         | ||_______\| |  ^^~~^^ | |         |");
                                            Console.WriteLine("|         | |---------| |---------| |         |");
                                            Console.WriteLine("|         | |.......5.| |.1.....2.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("***** - ");
                                        {
                                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                                            int ab = 100;

                                            foreach (char c in te)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(ab);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                            else if (mesto_carti_iz_ryk == 4)
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |...Жаба..|");
                                    Console.WriteLine("|         | |---------| |         | |---------|");
                                    Console.WriteLine(@"|         | | ___     | |         | |    00  1|");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |   (--)  |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |  ( || ) |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |  ^^~~^^ |");
                                    Console.WriteLine("|         | |---------| |         | |---------|");
                                    Console.WriteLine("|         | |.......5.| |         | |.1.....2.|");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                                    if (keyinfo.Key == ConsoleKey.Tab)
                                    {
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |...Жаба..|");
                                            Console.WriteLine("|         | |---------| |         | |---------|");
                                            Console.WriteLine(@"|         | | ___     | |         | |    00  1|");
                                            Console.WriteLine(@"|         | ||___\_   | |         | |   (--)  |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | |  ( || ) |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |  ^^~~^^ |");
                                            Console.WriteLine("|         | |---------| |         | |---------|");
                                            Console.WriteLine("|         | |.......5.| |         | |.1.....2.|");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                            Thread.Sleep(250);
                                            Console.Clear();

                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |         |");
                                            Console.WriteLine(@"|         | |---------| |         | |   / \   |");
                                            Console.WriteLine(@"|         | | ___     | |         | |  /   \  |");
                                            Console.WriteLine(@"|         | ||___\_   | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |  |   |  |");
                                            Console.WriteLine(@"|         | |---------| |         | | -|___|- |");
                                            Console.WriteLine(@"|         | |.......5.| |         | |   | |   |");
                                            Console.WriteLine(@"——————————— ----------- ----------- |   | |   |");
                                            Console.WriteLine(@"                                    |   (*)   |");
                                            Console.WriteLine(@"                                    -----------");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"----------- ----------- ——————————— |   / \   |");
                                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |  /   \  |");
                                            Console.WriteLine(@"|         | |---------| |         | |  |   |  |");
                                            Console.WriteLine(@"|         | | ___     | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||___\_   | |         | |  |   |  |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | | -|___|- |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |   | |   |");
                                            Console.WriteLine(@"|         | |---------| |         | |   | |   |");
                                            Console.WriteLine(@"|         | |.......5.| |         | |   (*)   |");
                                            Console.WriteLine(@"----------- ----------- ——————————— ———————————");

                                            Thread.Sleep(250);

                                            Console.Clear();
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|         | |         | |         | |         |");
                                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                            Console.WriteLine("|---------| |         | |---------| |         |");
                                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |...Жаба..|");
                                            Console.WriteLine("|         | |---------| |         | |---------|");
                                            Console.WriteLine(@"|         | | ___     | |         | |    00  1|");
                                            Console.WriteLine(@"|         | ||___\_   | |         | |   (--)  |");
                                            Console.WriteLine(@"|         | ||_____\_ | |         | |  ( || ) |");
                                            Console.WriteLine(@"|         | ||_______\| |         | |  ^^~~^^ |");
                                            Console.WriteLine("|         | |---------| |         | |---------|");
                                            Console.WriteLine("|         | |.......5.| |         | |.1.....2.|");
                                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("***** - ");
                                        {
                                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                                            int ab = 100;

                                            foreach (char c in te)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(ab);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                    }

            */

            /*
            if (vibor_karti == 1)
                {
                    void aa()
                    {
                        int vibor_karti_iz_ryk = int.Parse(Console.ReadLine());

                        if (vibor_karti_iz_ryk == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                            Console.WriteLine(@"|    1    | ||_____\_ | |    3    | |    4    |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Выбери место.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                            }

                            int mesto_carti_iz_ryk = int.Parse(Console.ReadLine());

                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string te = "Ты попал в засаду по среди бездорожья.";
                                int ad = 100;
                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ad);
                                }
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.Clear();
                            }


                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Теперь ты можешь видеть мою предстоящую атаку.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            while (true)
                            {
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine(@"|         | | ___     | |         | |         |");
                                Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("|         | |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.WriteLine(@"———————————  ———————————  ———————————  ———————————");
                                Console.WriteLine(@"|..БЕЛКА..|  |ГОРНОСТАЙ|  |...Жаба..|  |.ГАДЮКА..|");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"| _  (\_  |  |        1|  |    00  1|  |        2|");
                                Console.WriteLine(@"|( \  ( '>|  | |\---/| |  |   (--)  |  |  ___   /|");
                                Console.WriteLine(@"| ) \/_)= |  | | -_- | |  |  ( || ) |  | ('')\_//|");
                                Console.WriteLine(@"|(_(__)_  |  |  \_^_/  |  |  ^^~~^^ |  |  ^  \_/ |");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"|.0.....1.|  |.1.....3.|  |.1.....2.|  |.1..X..1.|");
                                Console.WriteLine(@"———————————  ———————————  ———————————  ———————————");

                                Thread.Sleep(500);
                                Console.WriteLine("1) Белка.");

                                Thread.Sleep(500);
                                Console.WriteLine("2) Горностай.");

                                Thread.Sleep(500);
                                Console.WriteLine("3) Жаба.");

                                Thread.Sleep(500);
                                Console.WriteLine("4) Гадюка.");

                                Thread.Sleep(500);

                                int vibor_Karti_iz_colodi_na_rycah = int.Parse(Console.ReadLine());

                                if (vibor_Karti_iz_colodi_na_rycah == 1)
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    if (vibor_Karti_iz_colodi_na_rycah > 1)
                                    {
                                        Random text3 = new Random();
                                        int fraza3 = text3.Next(1, 3);

                                        if (fraza3 == 1)
                                        {
                                            Thread.Sleep(500);
                                            Console.Write("***** - ");
                                            {
                                                string text = "Этой карте нужно больше крови.";
                                                int a = 100;

                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(a);
                                                }
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }
                                        }
                                        else if (fraza3 == 2)
                                        {
                                            Thread.Sleep(500);
                                            Console.Write("***** - ");
                                            {
                                                string text = "Этим пока ходить нельзя, но вот белка бесплатная.";
                                                int a = 100;

                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(a);
                                                }
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }

                                        }
                                        else if (fraza3 == 3)
                                        {
                                            Thread.Sleep(500);
                                            Console.Write("***** - ");
                                            {
                                                string text = "Не... Но ты можешь пойти Белкой.";
                                                int a = 100;

                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(a);
                                                }
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }
                                        }
                                    }
                                }
                            }
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|    1    | ||___\_   | |    3    | |    4    |");
                            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Положи карту.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                            }

                            int carta_nomer1 = int.Parse(Console.ReadLine());

                            Console.Clear();

                            if (carta_nomer1 == 1)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..БЕЛКА..| |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|—————————| |---------| |         | |         |");
                                Console.WriteLine(@"| _  (\_  | | ___     | |         | |         |");
                                Console.WriteLine(@"|( \  ( '>| ||___\_   | |         | |         |");
                                Console.WriteLine(@"| ) \/_)= | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|(_(__)_  | ||_______\| |         | |         |");
                                Console.WriteLine("|—————————| |---------| |         | |         |");
                                Console.WriteLine("|.0.....1.| |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери жертву.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                                int carta_zertvi = int.Parse(Console.ReadLine());

                                if (carta_zertvi == 1)
                                {
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|\.БЕЛКА./| |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine(@"|—\—————/—| |---------| |         | |         |");
                                    Console.WriteLine(@"|  \  (/_ | | ___     | |         | |         |");
                                    Console.WriteLine(@"|(  \ / '>| ||___\_   | |         | |         |");
                                    Console.WriteLine(@"| ) //\)= | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|(_/__)\  | ||_______\| |         | |         |");
                                    Console.WriteLine(@"|—/—————\—| |---------| |         | |         |");
                                    Console.WriteLine(@"|/0.....1\| |.......5.| |         | |         |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                }

                                Console.Clear();

                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine(@"|         | | ___     | |         | |         |");
                                Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("|         | |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.WriteLine(@"———————————  ———————————  ———————————");
                                Console.WriteLine(@"|ГОРНОСТАЙ|  |...Жаба..|  |.ГАДЮКА..|");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"|        1|  |    00  1|  |        2|");
                                Console.WriteLine(@"| |\---/| |  |   (--)  |  |  ___   /|");
                                Console.WriteLine(@"| | -_- | |  |  ( || ) |  | ('')\_//|");
                                Console.WriteLine(@"|  \_^_/  |  |  ^^~~^^ |  |  ^  \_/ |");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"|.1.....3.|  |.1.....2.|  |.1..X..1.|");
                                Console.WriteLine(@"———————————  ———————————  ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери карту.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }

                                Thread.Sleep(500);
                                Console.WriteLine("1) Горностай.");

                                Thread.Sleep(500);
                                Console.WriteLine("2) Жаба.");

                                Thread.Sleep(500);
                                Console.WriteLine("3) Гадюка.");

                                void aaa()
                                {
                                    aa();
                                }
                                aaa();

                            }
                            if (carta_nomer1 == 3)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |..БЕЛКА..| |         |");
                                Console.WriteLine("|         | |---------| |—————————| |         |");
                                Console.WriteLine(@"|         | | ___     | | _  (\_  | |         |");
                                Console.WriteLine(@"|         | ||___\_   | |( \  ( '>| |         |");
                                Console.WriteLine(@"|         | ||_____\_ | | ) \/_)= | |         |");
                                Console.WriteLine(@"|         | ||_______\| |(_(__)_  | |         |");
                                Console.WriteLine("|         | |---------| |—————————| |         |");
                                Console.WriteLine("|         | |.......5.| |.0.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери жертву.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                                int carta_zertvi = int.Parse(Console.ReadLine());

                                if (carta_zertvi == 3)
                                {
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |\.БЕЛКА./| |         |");
                                    Console.WriteLine(@"|         | |---------| |—\—————/—| |         |");
                                    Console.WriteLine(@"|         | | ___     | |  \  (/_ | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |(  \ / '>| |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | | ) //\)= | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |(_/__)\  | |         |");
                                    Console.WriteLine(@"|         | |---------| |—/—————\—| |         |");
                                    Console.WriteLine(@"|         | |.......5.| |/0.....1\| |         |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine(@"———————————  ———————————  ———————————");
                                    Console.WriteLine(@"|ГОРНОСТАЙ|  |...Жаба..|  |.ГАДЮКА..|");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|        1|  |    00  1|  |        2|");
                                    Console.WriteLine(@"| |\---/| |  |   (--)  |  |  ___   /|");
                                    Console.WriteLine(@"| | -_- | |  |  ( || ) |  | ('')\_//|");
                                    Console.WriteLine(@"|  \_^_/  |  |  ^^~~^^ |  |  ^  \_/ |");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|.1.....3.|  |.1.....2.|  |.1..X..1.|");
                                    Console.WriteLine(@"———————————  ———————————  ———————————");

                                    Console.Write("***** - ");
                                    {
                                        string fraza = "Выбери карту.";
                                        int vrema = 100;
                                        foreach (char c in fraza)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(vrema);
                                        }
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                    }

                                    Thread.Sleep(500);
                                    Console.WriteLine("1) Горностай.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("2) Жаба.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("3) Гадюка.");

                                    void aaa()
                                    {
                                        aa();
                                    }
                                    aaa();
                                }
                            }
                            if (carta_nomer1 == 4)
                            {
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |..БЕЛКА..|");
                                Console.WriteLine("|         | |---------| |         | |—————————|");
                                Console.WriteLine(@"|         | | ___     | |         | | _  (\_  |");
                                Console.WriteLine(@"|         | ||___\_   | |         | |( \  ( '>|");
                                Console.WriteLine(@"|         | ||_____\_ | |         | | ) \/_)= |");
                                Console.WriteLine(@"|         | ||_______\| |         | |(_(__)_  |");
                                Console.WriteLine("|         | |---------| |         | |—————————|");
                                Console.WriteLine("|         | |.......5.| |         | |.0.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери жертву.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                                int carta_zertvi = int.Parse(Console.ReadLine());

                                if (carta_zertvi == 4)
                                {
                                    Console.Clear();

                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |\.БЕЛКА./|");
                                    Console.WriteLine(@"|         | |---------| |         | |—\—————/—|");
                                    Console.WriteLine(@"|         | | ___     | |         | |  \  (/_ |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |(  \ / '>|");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | | ) //\)= |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |(_/__)\  |");
                                    Console.WriteLine(@"|         | |---------| |         | |—/—————\—|");
                                    Console.WriteLine(@"|         | |.......5.| |         | |/0.....1\|");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine(@"———————————  ———————————  ———————————");
                                    Console.WriteLine(@"|ГОРНОСТАЙ|  |...Жаба..|  |.ГАДЮКА..|");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|        1|  |    00  1|  |        2|");
                                    Console.WriteLine(@"| |\---/| |  |   (--)  |  |  ___   /|");
                                    Console.WriteLine(@"| | -_- | |  |  ( || ) |  | ('')\_//|");
                                    Console.WriteLine(@"|  \_^_/  |  |  ^^~~^^ |  |  ^  \_/ |");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|.1.....3.|  |.1.....2.|  |.1..X..1.|");
                                    Console.WriteLine(@"———————————  ———————————  ———————————");

                                    Console.Write("***** - ");
                                    {
                                        string fraza = "Выбери карту.";
                                        int vrema = 100;
                                        foreach (char c in fraza)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(vrema);
                                        }
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                    }

                                    Thread.Sleep(500);
                                    Console.WriteLine("1) Горностай.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("2) Жаба.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("3) Гадюка.");

                                    void aaa()
                                    {
                                        aa();
                                    }
                                    aaa();
                                }
                            }
                        
                        if (vibor_karti == 2)
                        {
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string te = "Ты попал в засаду по среди бездорожья.";
                                int ad = 100;
                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ad);
                                }
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.Clear();
                            }


                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Теперь ты можешь видеть мою предстоящую атаку.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            while (true)
                            {
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine(@"|         | | ___     | |         | |         |");
                                Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("|         | |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.WriteLine(@"———————————  ———————————  ———————————  ———————————");
                                Console.WriteLine(@"|..БЕЛКА..|  |ГОРНОСТАЙ|  |...Жаба..|  |..КОШКА..|");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"| _  (\_  |  |        1|  |    00  1|  | \    /\2|");
                                Console.WriteLine(@"|( \  ( '>|  | |\---/| |  |   (--)  |  |  )  ( ')|");
                                Console.WriteLine(@"| ) \/_)= |  | | -_- | |  |  ( || ) |  | (  /  ) |");
                                Console.WriteLine(@"|(_(__)_  |  |  \_^_/  |  |  ^^~~^^ |  |  \(__)| |");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"|.0.....1.|  |.1.....3.|  |.1.....2.|  |.0..%..1.|");
                                Console.WriteLine(@"———————————  ———————————  ———————————  ———————————");

                                Thread.Sleep(500);
                                Console.WriteLine("1) Белка.");

                                Thread.Sleep(500);
                                Console.WriteLine("2) Горностай.");

                                Thread.Sleep(500);
                                Console.WriteLine("3) Жаба.");

                                Thread.Sleep(500);
                                Console.WriteLine("4) Кошка.");

                                Thread.Sleep(500);

                                int vibor_Karti_iz_colodi_na_rycah = int.Parse(Console.ReadLine());

                                if (vibor_Karti_iz_colodi_na_rycah == 1)
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    if (vibor_Karti_iz_colodi_na_rycah > 1)
                                    {
                                        Random text3 = new Random();
                                        int fraza3 = text3.Next(1, 3);

                                        if (fraza3 == 1)
                                        {
                                            Thread.Sleep(500);
                                            Console.Write("***** - ");
                                            {
                                                string text = "Этой карте нужно больше крови.";
                                                int a = 100;

                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(a);
                                                }
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }
                                        }
                                        else if (fraza3 == 2)
                                        {
                                            Thread.Sleep(500);
                                            Console.Write("***** - ");
                                            {
                                                string text = "Этим пока ходить нельзя, но вот белка бесплатная.";
                                                int a = 100;

                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(a);
                                                }
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }

                                        }
                                        else if (fraza3 == 3)
                                        {
                                            Thread.Sleep(500);
                                            Console.Write("***** - ");
                                            {
                                                string text = "Не... Но ты можешь пойти Белкой.";
                                                int a = 100;

                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(a);
                                                }
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }
                                        }
                                    }
                                }
                            }

                            void bb()
                            {
                                int vibor_karti_iz_ryk = int.Parse(Console.ReadLine());

                                if (vibor_karti_iz_ryk == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|    1    | ||_____\_ | |    3    | |    4    |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.Write("***** - ");
                                    {
                                        string fraza = "Выбери место.";
                                        int vrema = 100;
                                        foreach (char c in fraza)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(vrema);
                                        }
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                    }

                                    int mesto_carti_iz_ryk = int.Parse(Console.ReadLine());

                                    Console.Clear();

                                    if (mesto_carti_iz_ryk == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|         | |         | |         | |         |");
                                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                                        Console.WriteLine("|---------| |---------| |         | |         |");
                                        Console.WriteLine(@"|        1| | ___     | |         | |         |");
                                        Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                                        Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                                        Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                                        Console.WriteLine("|---------| |---------| |         | |         |");
                                        Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    }
                                    else if (mesto_carti_iz_ryk == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|         | |         | |         | |         |");
                                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                                        Console.WriteLine("|         | |---------| |---------| |         |");
                                        Console.WriteLine(@"|         | | ___     | |        1| |         |");
                                        Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                                        Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                                        Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                                        Console.WriteLine("|         | |---------| |---------| |         |");
                                        Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    }
                                    else if (mesto_carti_iz_ryk == 4)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|         | |         | |         | |         |");
                                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                                        Console.WriteLine("|         | |---------| |         | |---------|");
                                        Console.WriteLine(@"|         | | ___     | |         | |        1|");
                                        Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                                        Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                                        Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                                        Console.WriteLine("|         | |---------| |         | |---------|");
                                        Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    }
                                }
                                if (vibor_karti_iz_ryk == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|    1    | ||_____\_ | |    3    | |    4    |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.Write("***** - ");
                                    {
                                        string fraza = "Выбери место.";
                                        int vrema = 100;
                                        foreach (char c in fraza)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(vrema);
                                        }
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                    }

                                    int mesto_carti_iz_ryk = int.Parse(Console.ReadLine());

                                    Console.Clear();

                                    if (mesto_carti_iz_ryk == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|         | |         | |         | |         |");
                                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|...Жаба..| |.КАМЕНЬ..| |         | |         |");
                                        Console.WriteLine("|---------| |---------| |         | |         |");
                                        Console.WriteLine(@"|    00  1| | ___     | |         | |         |");
                                        Console.WriteLine(@"|   (--)  | ||___\_   | |         | |         |");
                                        Console.WriteLine(@"|  ( || ) | ||_____\_ | |         | |         |");
                                        Console.WriteLine(@"|  ^^~~^^ | ||_______\| |         | |         |");
                                        Console.WriteLine("|---------| |---------| |         | |         |");
                                        Console.WriteLine("|.1.....2.| |.......5.| |         | |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    }
                                    else if (mesto_carti_iz_ryk == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|         | |         | |         | |         |");
                                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|         | |.КАМЕНЬ..| |...Жаба..| |         |");
                                        Console.WriteLine("|         | |---------| |---------| |         |");
                                        Console.WriteLine(@"|         | | ___     | |    00  1| |         |");
                                        Console.WriteLine(@"|         | ||___\_   | |   (--)  | |         |");
                                        Console.WriteLine(@"|         | ||_____\_ | |  ( || ) | |         |");
                                        Console.WriteLine(@"|         | ||_______\| |  ^^~~^^ | |         |");
                                        Console.WriteLine("|         | |---------| |---------| |         |");
                                        Console.WriteLine("|         | |.......5.| |.1.....2.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    }
                                    else if (mesto_carti_iz_ryk == 4)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|         | |         | |         | |         |");
                                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                        Console.WriteLine("|---------| |         | |---------| |         |");
                                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                        Console.WriteLine("|         | |.КАМЕНЬ..| |         | |...Жаба..|");
                                        Console.WriteLine("|         | |---------| |         | |---------|");
                                        Console.WriteLine(@"|         | | ___     | |         | |    00  1|");
                                        Console.WriteLine(@"|         | ||___\_   | |         | |   (--)  |");
                                        Console.WriteLine(@"|         | ||_____\_ | |         | |  ( || ) |");
                                        Console.WriteLine(@"|         | ||_______\| |         | |  ^^~~^^ |");
                                        Console.WriteLine("|         | |---------| |         | |---------|");
                                        Console.WriteLine("|         | |.......5.| |         | |.1.....2.|");
                                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    }
                                }
                            }

                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine(@"|         | | ___     | |         | |         |");
                            Console.WriteLine(@"|    1    | ||___\_   | |    3    | |    4    |");
                            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|         | ||_______\| |         | |         |");
                            Console.WriteLine("|         | |---------| |         | |         |");
                            Console.WriteLine("|         | |.......5.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Console.Write("***** - ");
                            {
                                string fraza = "Положи карту.";
                                int vrema = 100;
                                foreach (char c in fraza)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(vrema);
                                }
                                Console.WriteLine();
                                Thread.Sleep(1000);
                            }

                            int carta_nomer1 = int.Parse(Console.ReadLine());

                            Console.Clear();

                            if (carta_nomer1 == 1)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..БЕЛКА..| |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|—————————| |---------| |         | |         |");
                                Console.WriteLine(@"| _  (\_  | | ___     | |         | |         |");
                                Console.WriteLine(@"|( \  ( '>| ||___\_   | |         | |         |");
                                Console.WriteLine(@"| ) \/_)= | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|(_(__)_  | ||_______\| |         | |         |");
                                Console.WriteLine("|—————————| |---------| |         | |         |");
                                Console.WriteLine("|.0.....1.| |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери жертву.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                                int carta_zertvi = int.Parse(Console.ReadLine());

                                if (carta_zertvi == 1)
                                {
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|\.БЕЛКА./| |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine(@"|—\—————/—| |---------| |         | |         |");
                                    Console.WriteLine(@"|  \  (/_ | | ___     | |         | |         |");
                                    Console.WriteLine(@"|(  \ / '>| ||___\_   | |         | |         |");
                                    Console.WriteLine(@"| ) //\)= | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|(_/__)\  | ||_______\| |         | |         |");
                                    Console.WriteLine(@"|—/—————\—| |---------| |         | |         |");
                                    Console.WriteLine(@"|/0.....1\| |.......5.| |         | |         |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                }

                                Console.Clear();

                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine(@"|         | | ___     | |         | |         |");
                                Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("|         | |.......5.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.WriteLine(@"———————————  ———————————  ———————————");
                                Console.WriteLine(@"|ГОРНОСТАЙ|  |...Жаба..|  |..КОШКА..|");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"|        1|  |    00  1|  | \    /\2|");
                                Console.WriteLine(@"| |\---/| |  |   (--)  |  |  )  ( ')|");
                                Console.WriteLine(@"| | -_- | |  |  ( || ) |  | (  /  ) |");
                                Console.WriteLine(@"|  \_^_/  |  |  ^^~~^^ |  |  \(__)| |");
                                Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                Console.WriteLine(@"|.1.....3.|  |.1.....2.|  |.0..%..1.|");
                                Console.WriteLine(@"———————————  ———————————  ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери карту.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }

                                Thread.Sleep(500);
                                Console.WriteLine("1) Горностай.");

                                Thread.Sleep(500);
                                Console.WriteLine("2) Жаба.");

                                Thread.Sleep(500);
                                Console.WriteLine("3) Кошка.");

                                void bbb()
                                {
                                    bb();
                                }
                                bbb();

                            }
                            if (carta_nomer1 == 3)
                            {
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |..БЕЛКА..| |         |");
                                Console.WriteLine("|         | |---------| |—————————| |         |");
                                Console.WriteLine(@"|         | | ___     | | _  (\_  | |         |");
                                Console.WriteLine(@"|         | ||___\_   | |( \  ( '>| |         |");
                                Console.WriteLine(@"|         | ||_____\_ | | ) \/_)= | |         |");
                                Console.WriteLine(@"|         | ||_______\| |(_(__)_  | |         |");
                                Console.WriteLine("|         | |---------| |—————————| |         |");
                                Console.WriteLine("|         | |.......5.| |.0.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери жертву.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                                int carta_zertvi = int.Parse(Console.ReadLine());

                                if (carta_zertvi == 3)
                                {
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |\.БЕЛКА./| |         |");
                                    Console.WriteLine(@"|         | |---------| |—\—————/—| |         |");
                                    Console.WriteLine(@"|         | | ___     | |  \  (/_ | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |(  \ / '>| |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | | ) //\)= | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |(_/__)\  | |         |");
                                    Console.WriteLine(@"|         | |---------| |—/—————\—| |         |");
                                    Console.WriteLine(@"|         | |.......5.| |/0.....1\| |         |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine(@"———————————  ———————————  ———————————");
                                    Console.WriteLine(@"|ГОРНОСТАЙ|  |...Жаба..|  |..КОШКА..|");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|        1|  |    00  1|  | \    /\2|");
                                    Console.WriteLine(@"| |\---/| |  |   (--)  |  |  )  ( ')|");
                                    Console.WriteLine(@"| | -_- | |  |  ( || ) |  | (  /  ) |");
                                    Console.WriteLine(@"|  \_^_/  |  |  ^^~~^^ |  |  \(__)| |");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|.1.....3.|  |.1.....2.|  |.0..%..1.|");
                                    Console.WriteLine(@"———————————  ———————————  ———————————");

                                    Console.Write("***** - ");
                                    {
                                        string fraza = "Выбери карту.";
                                        int vrema = 100;
                                        foreach (char c in fraza)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(vrema);
                                        }
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                    }

                                    Thread.Sleep(500);
                                    Console.WriteLine("1) Горностай.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("2) Жаба.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("3) Кошка.");

                                    void bbb()
                                    {
                                        bb();
                                    }
                                    bbb();
                                }
                            }
                            if (carta_nomer1 == 4)
                            {
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                Console.WriteLine("|---------| |         | |---------| |         |");
                                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |..БЕЛКА..|");
                                Console.WriteLine("|         | |---------| |         | |—————————|");
                                Console.WriteLine(@"|         | | ___     | |         | | _  (\_  |");
                                Console.WriteLine(@"|         | ||___\_   | |         | |( \  ( '>|");
                                Console.WriteLine(@"|         | ||_____\_ | |         | | ) \/_)= |");
                                Console.WriteLine(@"|         | ||_______\| |         | |(_(__)_  |");
                                Console.WriteLine("|         | |---------| |         | |—————————|");
                                Console.WriteLine("|         | |.......5.| |         | |.0.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Console.Write("***** - ");
                                {
                                    string fraza = "Выбери жертву.";
                                    int vrema = 100;
                                    foreach (char c in fraza)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(vrema);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                }
                                int carta_zertvi = int.Parse(Console.ReadLine());

                                if (carta_zertvi == 4)
                                {
                                    Console.Clear();

                                    Console.Clear();
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |\.БЕЛКА./|");
                                    Console.WriteLine(@"|         | |---------| |         | |—\—————/—|");
                                    Console.WriteLine(@"|         | | ___     | |         | |  \  (/_ |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |(  \ / '>|");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | | ) //\)= |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |(_/__)\  |");
                                    Console.WriteLine(@"|         | |---------| |         | |—/—————\—|");
                                    Console.WriteLine(@"|         | |.......5.| |         | |/0.....1\|");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|         | |         | |         | |         |");
                                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                                    Console.WriteLine("|---------| |         | |---------| |         |");
                                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine(@"|         | | ___     | |         | |         |");
                                    Console.WriteLine(@"|         | ||___\_   | |         | |         |");
                                    Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                                    Console.WriteLine(@"|         | ||_______\| |         | |         |");
                                    Console.WriteLine("|         | |---------| |         | |         |");
                                    Console.WriteLine("|         | |.......5.| |         | |         |");
                                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                    Console.WriteLine(@"———————————  ———————————  ———————————");
                                    Console.WriteLine(@"|ГОРНОСТАЙ|  |...Жаба..|  |..КОШКА..|");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|        1|  |    00  1|  | \    /\2|");
                                    Console.WriteLine(@"| |\---/| |  |   (--)  |  |  )  ( ')|");
                                    Console.WriteLine(@"| | -_- | |  |  ( || ) |  | (  /  ) |");
                                    Console.WriteLine(@"|  \_^_/  |  |  ^^~~^^ |  |  \(__)| |");
                                    Console.WriteLine(@"|—————————|  |—————————|  |—————————|");
                                    Console.WriteLine(@"|.1.....3.|  |.1.....2.|  |.0..%..1.|");
                                    Console.WriteLine(@"———————————  ———————————  ———————————");

                                    Console.Write("***** - ");
                                    {
                                        string fraza = "Выбери карту.";
                                        int vrema = 100;
                                        foreach (char c in fraza)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(vrema);
                                        }
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                    }

                                    Thread.Sleep(500);
                                    Console.WriteLine("1) Горностай.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("2) Жаба.");

                                    Thread.Sleep(500);
                                    Console.WriteLine("3) Кошка.");

                                    void bbb()
                                    {
                                        bb();
                                    }
                                    bbb();
                                }
                            }
                        }
                    }
            */

            int Leavel3_Gagyka_ili_kosha = int.Parse(Console.ReadLine());

            if (Leavel3_Gagyka_ili_kosha == 1)
            {
                void a()
                {
                    bitva1();
                }
                a();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|..БЕЛКА..| |ГОРНОСТАЙ| |...Жаба..| |.ГАДЮКА..|");
                Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"| _  (\_  | |        1| |    00  1| |        2|");
                Console.WriteLine(@"|( \  ( '>| | |\---/| | |   (--)  | |  ___   /|");
                Console.WriteLine(@"| ) \/_)= | | | -_- | | |  ( || ) | | ('')\_//|");
                Console.WriteLine(@"|(_(__)_  | |  \_^_/  | |  ^^~~^^ | |  ^  \_/ |");
                Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"|.0.....1.| |.1.....3.| |.1.....2.| |.1..X..1.|");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            }
            else
            {
                void a()
                {
                    bitva1();
                }
                a();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|..БЕЛКА..| |ГОРНОСТАЙ| |...Жаба..| |..КОШКА..|");
                Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"| _  (\_  | |        1| |    00  1| | \    /\2|");
                Console.WriteLine(@"|( \  ( '>| | |\---/| | |   (--)  | |  )  ( ')|");
                Console.WriteLine(@"| ) \/_)= | | | -_- | | |  ( || ) | | (  /  ) |");
                Console.WriteLine(@"|(_(__)_  | |  \_^_/  | |  ^^~~^^ | |  \(__)| |");
                Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                Console.WriteLine(@"|.0.....1.| |.1.....3.| |.1.....2.| |.0..%..1.|");
                Console.WriteLine(@"——————————— ——————————— ——————————- ———————————");
            }
        }
    }
}
