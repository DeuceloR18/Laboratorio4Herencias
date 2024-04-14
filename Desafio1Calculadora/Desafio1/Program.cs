using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());
            Calculadora_cientifica calc = new Calculadora_cientifica("CASIO", "FX-83GTX");
            Console.WriteLine("RESULTADO SUMA:");
            double total = calc.Sumar(num1, num2);
            Console.WriteLine(total);

            Console.WriteLine("RESULTADO RESTA:");
            double diferencia = calc.Restar(num1, num2);
            Console.WriteLine(diferencia);

            Console.WriteLine("RESULTADO MULTIPLICACION:");
            double producto = calc.Multiplicar(num1, num2);
            Console.WriteLine(producto);

            Console.WriteLine("RESULTADO DIVICION:");
            double division = calc.Dividir(num1, num2);
            Console.WriteLine(division);



            CalculadoraCientifica cientifica = new CalculadoraCientifica("Casio", "FX-83GTX");
            Console.WriteLine("RESULTADO RAIZ CUADRADA:");
            double raiz = cientifica.Raíz(num1);
            Console.WriteLine(raiz);

            Console.WriteLine("RESULTADO POTENCIA:");
            double potencia = cientifica.Potencia(num1, num2);
            Console.WriteLine(potencia);

            Console.WriteLine("RESULTADO MODULO:");
            double modulo = cientifica.Modulo(num1, num2);
            Console.WriteLine(modulo);

            Console.WriteLine("RESULTADO LOGARITMO:");
            double log = cientifica.Logaritmo(num1, num2);
            Console.WriteLine(log);

            Console.ReadLine();

        }
    }

    public class Calculadora_cientifica
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora_cientifica(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }

    public class CalculadoraCientifica : Calculadora_cientifica
    {

        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        public double Raíz(double num1)
        {
            return Math.Sqrt(num1);
        }
        public double Modulo(double n1, double num2)
        {
            return n1 % num2;
        }
        public double Logaritmo(double num1, double num2)
        {
            return Math.Log(num1, num2);
        }
    }
}
