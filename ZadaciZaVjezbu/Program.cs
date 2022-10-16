using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbuGabrielMatosevic20211211
{
    class KlasaC
    {
        public int Zbroj(int[] Brojevi)
        {
            return Brojevi.Sum();
        }
        public double Prosjek(int[] Brojevi)
        {
            return Brojevi.Average();
        }
    }
    class KlasaB
    {
        public string BezPrvogIZadnjeg(string Recenica)
        {
            return Recenica.Substring(1, Recenica.Length - 2);
        }
    }
    class Sort
    {
        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public void QuickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
    }
    class Search
    {
        public int BinarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] == x)
                    return m;
                if (arr[m] < x)
                    l = m + 1;
                else
                    r = m - 1;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Biranje = 0;
            do
            {
                Console.Write("Birajte program od 1 do 5, 0 za exit:");
                Biranje = Convert.ToInt32(Console.ReadLine());
                switch (Biranje)
                {
                    case 1:
                        KlasaC ObjektC = new KlasaC();
                        int[] Brojevi = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Birajte broj " + (i + 1) + ":");
                            Brojevi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int zbroj = ObjektC.Zbroj(Brojevi);
                        double prosjek = ObjektC.Prosjek(Brojevi);
                        Console.WriteLine("Zbroj = " + zbroj + "\nProsjek = " + prosjek);
                        break;
                    case 2:
                        KlasaB ObjektB = new KlasaB();
                        Console.Write("Upisite recenicu sa vise od 2 znaka:");
                        string Recenica = Console.ReadLine();
                        Console.WriteLine((Recenica.Length <= 2) ? "Recenica nije veca od dva znaka" : "Recenica je " + ObjektB.BezPrvogIZadnjeg(Recenica));
                        break;
                    case 3:
                        Sort ObjektSortAscending = new Sort();
                        Console.Write("Koliko ima niz elemenata:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int[] arrAsc = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Elemenat broj " + (i + 1) + ":");
                            arrAsc[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        ObjektSortAscending.QuickSort(arrAsc, 1, arrAsc.Length - 2);
                        Console.Write("Sortirani niz:");
                        for (int i = 0; i < arrAsc.Length; i++)
                        {
                            Console.Write(arrAsc[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Sort ObjektSortDescending = new Sort();
                        Console.Write("Koliko ima niz elemenata:");
                        int m = Convert.ToInt32(Console.ReadLine());
                        int[] arrDesc = new int[m];
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write("Elemenat broj " + (i + 1) + ":");
                            arrDesc[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        ObjektSortDescending.QuickSort(arrDesc, 0, arrDesc.Length - 1);
                        Console.Write("Sortirani niz:");
                        arrDesc = arrDesc.OrderByDescending(c => c).ToArray();
                        for (int i = 0; i < arrDesc.Length; i++)
                        {
                            Console.Write(arrDesc[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Search ObjektSearch = new Search();
                        int[] arrSearch = new int[100];
                        int neparnibroj = 1;
                        for (int i = 0; i < 100; i++)
                        {
                            arrSearch[i] = neparnibroj;
                            neparnibroj += 2;
                        }
                        Console.WriteLine("Index broja 75 je:" + ObjektSearch.BinarySearch(arrSearch, 75));
                        break;
                }
            } while (Biranje != 0);
        }
    }
}