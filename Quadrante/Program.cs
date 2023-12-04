using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrante {
    class Program {
        static void Main(string[] args) {

            int x, y, quadrante;

            Console.WriteLine("Digite os valores das coordenadas X e Y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            
            while (x != 0 && y != 0) {
                quadrante = 0;

                if (x > 0 && y > 0) {
                    quadrante = 1;
                }
                else if (x > 0 && y < 0) {
                    quadrante = 4;
                }
                else if (x < 0 && y < 0) {
                    quadrante = 3;
                }
                else if (x < 0 && y > 0) {
                    quadrante = 2;
                }
                Console.WriteLine("QUADRANTE Q" + quadrante);
                Console.WriteLine("Digite os valores das coordenadas X e Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }
        }
    }
}
