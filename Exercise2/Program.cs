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
        public void SelectionSortArray()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int tf = i - 1; tf >= 0; tf--)
                {
                    if (Attar[tf] > attar[tf + 1])
                    {
                        int temp;
                        temp = attar[tf];
                        attar[tf] = attar[tf + 1];
                        attar[tf + 1] = temp;
                    }
                }
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                Console.Write("\nMasukkan elemen array: ");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                while ((item != attar[mid]) && (lowerbound <= upperbound))
                {
                    if (item > attar[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++
                }
            }
        }
    }
}