
class Calculadora
{
    static void Main()
    {
        CalcularEstoqueMedio();
        CalcularIdade();
        ConverterDolarReal();

    }

    //Faça um programa para calcular o estoque médio de uma peça, sendo que estoque médio = (quantidade_minima + quantidade_maxima) / 2. 
    
    static void CalcularEstoqueMedio()
    {
        Console.Write("Informe a quantidade mínima: ");
        double quantMin = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a quantidade máxima: ");
        double quantMax = Convert.ToDouble(Console.ReadLine());

        double estqMed = (quantMin + quantMax) / 2;

        Console.WriteLine("O estoque médio é: " + estqMed);
    }

    // Faça um algoritmoo que leia a idade de uma pessoa expressa em anos e escreva a idade dessa pessoa expressa apenas em dias. 

    static void CalcularIdade()
    {
        Console.Write("informe sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 0 || idade >= 100)
        {
            Console.Write("informe uma idade válida: ");
            int idadeValida = Convert.ToInt32(Console.ReadLine());
            int repeticoes = idadeValida;
            int resultado = repeticoes * 365;
            Console.WriteLine(resultado);
        }
        else
        {
            int repeticoes = idade;
            int resultado = repeticoes * 365;
            Console.WriteLine(resultado);
        }


       // Faça um programa que converta dolares em reais.

    }

    static void ConverterDolarReal()
    {
        Console.Write("informe um valor em dolar(es): ");
        double dolar = Convert.ToDouble(Console.ReadLine());
        
        double real = 5.55;
        double resultado = dolar * real;
    
        Console.WriteLine($"{dolar} dólares é igual a {resultado} reais");

    }


}
