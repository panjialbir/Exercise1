using System;

namespace Exercise1
{
    class program
    {//deklarasi array dengan int ukuran 27
        private int[] panji = new int[27];
        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;
        //funsi atau method untuk menerima masukan
        public void read()
        {//menerima angka menentukan banyaknya dta yang diterima array
            while (true)
            { Console.Write("Masukkan Elemen Pada Array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 27)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 27 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("=====================");
            Console.WriteLine("Masukkan Elemen Array");
            Console.WriteLine("=====================");

            //memasukkan elemen pada aray
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                panji[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {//menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("Elemen Array Yang Telah Tersusun");
            Console.WriteLine("================================");

            for (int MA = 0; MA < n; MA++)
            {
                Console.WriteLine(panji[MA]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {//rumus penyusunan array
                for (int MA = 0; MA < n - i; MA++)
                {
                    if (panji[MA] < panji[MA + 1])
                    {
                        int temp;
                        temp = panji[MA];
                        panji[MA] = panji[MA + 1];
                        panji[MA + 1] = temp;
                  }
                }
            }
        }
        static void Main(String[] Args)
        {
            //pembuatan objek program kelas array
            program myList = new program();
            //pemanggilan fungsi utk menerima panggilan array
            myList.read();
            //pemanggilan fungsi utk mengurutkan array
            myList.BubbleSortArray();
            //pemanggilan fungsi utk menampilkan array
            myList.display();
            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}