using System;
namespace sort_data
{ 
    class program
    {
        //Deklarasi data int dengan ukuran 728
        private int[] a = new int[728];

        //Deklarasi variabel int untuk menyimpan banyaknya data 
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            //Menentukan banyaknya data yang disimpan
            while (true)
            {
                Console.Write("Masukkan banyaknya data pada int");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 728)
                    break;
                else
                    Console.WriteLine("\nData dapat memiliki maksimal 728 elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("==============================================================");
            Console.WriteLine(" Masukkan jumlah elemen data ");
            Console.WriteLine("==============================================================");

            //pengguna memasukkan elemen int pada data
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampil tampilan data yang terstruktur
            Console.WriteLine("");
            Console.WriteLine("==================================================");
            Console.WriteLine(" Elemen Data Yang Terstruktur");
            Console.WriteLine("==================================================");
            for (int mk = 0; mk < n; mk++)
            {
                Console.WriteLine(a[mk]);
            }
            Console.WriteLine("");
        }
        public void sort_data()
        {
            for (int i = 1; i < n; i++) // For n -1 passes
            {
                // Pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the sort data class
            Programm myList = new Program();

            // Pemanggilan Fungsi untuk menerima elemen data
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan data
            myList.BubbleSortArray();
            //Pemanggilan fungsi untuk menampilkan data yang tersusun
            myList.display();
            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}






