using System;
using System.Security.AccessControl;


namespace CasaCambio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            Passos do Sistema;
            
            [1] Solicitar a cotação das moedas em dolar
            [2] Solicitar o par de moedas para conversão
            [3] Solicitar o valor para conversão
            [4] Converter o valor para dolar
            [5] Converter de dolar para a moeda destino
            [6] Mostrar resultado para o cliente

            */

            // Variáveis das Moedas

            decimal dolar = 1;
            decimal real;
            decimal euro;
            decimal iene;

            // Variável de Opção

            char moeda;

            // Variável de quantidade 

            decimal quant;

            // Configurações do Programa

            Console.WriteLine("Informe os valores das moedas em relação ao Dolar: ");

            Console.Write("\n[Euro]: ");
            euro = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n[Real]: ");
            real = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n[Iene]: ");
            iene = Convert.ToDecimal(Console.ReadLine());

            // Inicio do Programa 

            Console.Clear();
            Console.Write(

                "\nInforme a Moeda de Destino: ",
                "\n",
                "[R]-Real [D]-Dolar [E]-Euro [I]-Iene"

                );
            moeda = Convert.ToChar(Console.ReadLine());

            Console.Write("Informe a Quantidade Para Conversão: ");
            quant = Convert.ToDecimal(Console.ReadLine());

            if (moeda == 'R')
            {
                // Variável de Conversão
                decimal convert_real = real * quant;
                decimal convert_euro = dolar / euro;
                decimal convert_iene = iene * quant;

                Console.WriteLine("\n------------------------------------1");
                Console.WriteLine("| O VALOR DA CONVERSÃO É DE: " + convert_real.ToString("N2") + "$ |");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("\n------------------------------------");
                Console.WriteLine("| O VALOR DA CONVERSÃO É DE: " + convert_euro.ToString("N2") + "€ |");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("\n------------------------------------");
                Console.WriteLine("| O VALOR DA CONVERSÃO É DE: " + convert_iene.ToString("N2") + "¥ |");
                Console.WriteLine("------------------------------------");
            }
            
        }
    }
}
