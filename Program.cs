using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ler as medidas do triângulo X e armazenar em um array
            double[] medidasX = LerMedidasTriangulo("X");

            // Ler as medidas do triângulo Y e armazenar em um array
            double[] medidasY = LerMedidasTriangulo("Y");

            // Calcular a área do triângulo X
            double areaX = CalcularAreaTriangulo(medidasX);

            // Calcular a área do triângulo Y
            double areaY = CalcularAreaTriangulo(medidasY);

            // Exibir a área do triângulo X formatada com 4 casas decimais
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            // Exibir a área do triângulo Y formatada com 4 casas decimais
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Verificar qual triângulo tem a maior área e exibir no console
            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            }
            else
            {
                Console.WriteLine("Maior Área: Y");
            }
        }

        // Método para ler as medidas de um triângulo
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            // Criar um array para armazenar as medidas (3 medidas)
            double[] medidas = new double[3];

            // Solicitar ao usuário que digite as medidas do triângulo especificado
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");

            // Ler as 3 medidas do console e armazenar no array
            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Retornar o array com as medidas
            return medidas;
        }

        // Método para calcular a área de um triângulo
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            // Extrair as medidas do array
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            // Calcular o semiperímetro
            double p = (a + b + c) / 2.0;

            // Calcular a área usando a fórmula de Heron
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Retornar o valor da área
            return area;
        }
    }
}
