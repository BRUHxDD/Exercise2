using System();

namespace Exercise2
{
    class Program
    {
        int[] attar = new int[33];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Masukkan jumlah elemen array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (attar[n] <= 33))
                    break;
                else
                    Console.WriteLine("\nArray maksimum 33 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                attar[i] = Int32.Parse(s1);
            }
        }
    }
}