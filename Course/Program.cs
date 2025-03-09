using System;
using System.Globalization;




namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            Double preco1 = 2100.0;
            Double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0} cujo preco é  {1} ", produto1, preco1);

            Console.Write("Registro:");
            Console.WriteLine("{0} anos de idade, código {1} e gênero: {2} ", idade, codigo, genero);

            Console.WriteLine($" medida com oito casas decimais:{media.ToString("F8")} ");
            Console.WriteLine($" Arredondado: {media.ToString("F3")} ");
            Console.WriteLine($" Separador decimal invariant culture: {media.ToString("F3", CultureInfo.InvariantCulture)}");




        }

    }

}

