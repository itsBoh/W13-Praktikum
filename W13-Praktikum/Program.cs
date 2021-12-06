using System;

namespace W13_Praktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Data = new string[999, 6];
            int hitung = 0;
            while (true)
            {
                ConsoleKey print = 0;
                ConsoleKey ulang = 0;
                Console.Write("Berapa Data = ");
                int berapa = Convert.ToInt32(Console.ReadLine());
                int printberapa = 0;
                printberapa = printberapa + berapa;
                int cek1 = 0;
                for (int i = hitung; i < printberapa; i++)
                {
                    Console.WriteLine($"data ke-{i + 1}");
                    while (true)
                    {
                        Console.Write("NIM            : ");
                        Data[i, 0] = Console.ReadLine();
                        if (i != 0)
                        {
                            if (Data[i, 0] == Data[i - 1, 0])
                            {
                                Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                                cek1 = 1;
                            }
                            else
                            {
                                cek1 = 0;
                            }
                        }
                        if (cek1 != 1)
                            break;
                    }
                    Console.Write("NAMA           : ");
                    Data[i, 1] = Console.ReadLine();
                    Console.Write("JENIS KELAMIN  : ");
                    Data[i, 2] = Console.ReadLine();
                    Console.Write("TAHUN MASUK    : ");
                    Data[i, 3] = Console.ReadLine();
                    Console.Write("PROGRAM STUDI  : ");
                    Data[i, 4] = Console.ReadLine();
                    Console.Write("KELAS          : ");
                    Data[i, 5] = Console.ReadLine();
                }
                hitung = berapa - 1;
                while (print != ConsoleKey.Y && print != ConsoleKey.N)
                {
                    Console.Write("PRINT HASIL ? (y/n) . . . ");
                    print = Console.ReadKey().Key;
                }
                if (print == ConsoleKey.Y)
                {
                    Console.WriteLine("\nNO NIM NAMA                JENIS KELAMIN TAHUN MASUK PROGRAM STUDI KELAS");
                    for (int i = 0; i < printberapa; i++)
                    {
                        string formatString = String.Format("{0,-3} {1,-4} {2,-20} {3,-14} {4,-12} {5,-14} {6,-6)", (i + 1), Data[i,0], Data[i,1], Data[i,2], Data[i,3], Data[i,4], Data[i,5]);
                        Console.WriteLine(formatString);
                    }
                }
                while (ulang != ConsoleKey.Y && ulang != ConsoleKey.N)
                {
                    Console.Write("TAMBAH DATA ? (y/n) . . . ");
                    ulang = Console.ReadKey().Key;
                }
                if (ulang == ConsoleKey.N)
                {
                    break;
                }
            }
        }
    }
}
