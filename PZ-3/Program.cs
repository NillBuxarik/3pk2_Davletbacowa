using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BynaryTree tree = new BynaryTree(6);

            //BynaryTree.GetTreeData(tree.Root);
            Console.Write("Среднее значение:");
            BynaryTree.AverageArif(tree.Root);
            Console.WriteLine("Положительные числа " + BynaryTree.CountPlus(tree.Root));
            Console.WriteLine("Отрицательные числа " + BynaryTree.CountMinus(tree.Root));

            Console.Write("Введите число для поиска: ");
            int sverka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество вхождений вашего числа: " + BynaryTree.Countsverka(tree.Root, sverka));
            Console.ReadKey();
        }
    }
}
