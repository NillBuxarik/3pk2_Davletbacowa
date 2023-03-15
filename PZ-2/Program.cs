using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] M = new bool[4, 4]
            {
              {false, true, false, true}, // матрица смежности графа G4
              {true, false, false, false},
              {true, true, false, true},
              {false, true, false, false}
            };
            Graph graph = new Graph(4, M);
            graph.Depth(1);


    }
}
}
