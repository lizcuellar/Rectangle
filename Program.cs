using System;

namespace InClass3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double perimetro = 0;
            double lado1, lado2, lado3;

            Console.WriteLine("2. CALCULO DE PERÍMETRO");
            Console.WriteLine();
            Console.WriteLine("El programa calcula el perímetro de tres figuras geométricas");
            Console.WriteLine("Escoja una figura");

            Console.WriteLine("Cuadrado   --> 1");
            Console.WriteLine("Rectángulo --> 2");
            Console.WriteLine("Triángulo  --> 3");
            Console.Write("Opcion: ");
            entrada = Console.ReadLine();

            if(entrada == "1")
            {
                Console.WriteLine("Digite lado de cuadrado: ");
                lado1 = double.Parse(Console.ReadLine());
                perimetro = PerimeterShape(lado1);
                
            }
            else if (entrada == "2")
            {
                Console.WriteLine("Digite lado 1 de rectángulo: ");
                lado1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite lado 2 de rectángulo: ");
                lado2 = double.Parse(Console.ReadLine());
                perimetro = PerimeterShape(lado1, lado2);
            }
            else if (entrada =="3")
            {
                Console.WriteLine("Digite lado 1 de triángulo: ");
                lado1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite lado 2 de triángulo: ");
                lado2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite lado 3 de triángulo: ");
                lado3 = double.Parse(Console.ReadLine());

                perimetro = PerimeterShape(lado1, lado2, lado3);
            }
            else
            {
                Console.WriteLine("Usted no ha elegido ninguna opción");
            }
            Console.WriteLine();
            Console.WriteLine("El perímetro de la figura seleccionada es: " + perimetro);
            Console.WriteLine("Presione ENTER para finalizar");
            Console.ReadLine();
        }


        public static double PerimeterShape(double lado)
        {
            // cuacrado
            return lado * 4;
        }

        public static double PerimeterShape(double lado1, double lado2)
        {
            //rectángulo
            return (lado1 * 2) + (lado2 * 2);
        }

        public static double PerimeterShape(double lado1, double lado2, double lado3)
        {
            //triangulo
            return (lado1 + lado2 + lado3);
        }


    }
}
