using CalculadoraClasses;

Console.WriteLine("Calculadora C#");
Calculadora calculadora = new Calculadora();

bool EstaNoPrograma = true;
while (EstaNoPrograma)
{
    Console.WriteLine("Digite 1 - Somar, 2 - Subtrair, 3 - Multiplicar, 4 - Dividir, 5 - Ver Historico, 6 - Sair");
    string Resposta = Console.ReadLine();
    switch (Resposta)
    {
        case "1":
            Console.WriteLine("Digite os numeros!");
            try
            {
                int valor1 = Convert.ToInt32(Console.ReadLine());
                int valor2 = Convert.ToInt32(Console.ReadLine());
                int valor3 = calculadora.Somar(valor1, valor2);
                calculadora.AdicionarNoHistorico(valor3);
                Console.WriteLine(valor3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Você não digitou um numero!");
            }
            break;
        case "2":
            Console.WriteLine("Digite os numeros!");
            try
            {
                int valor1 = Convert.ToInt32(Console.ReadLine());
                int valor2 = Convert.ToInt32(Console.ReadLine());
                int valor3 = calculadora.Subtrair(valor1, valor2);
                calculadora.AdicionarNoHistorico(valor3);
                Console.WriteLine(valor3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Você não digitou um numero!");
            }
            break;
        case "3":
            Console.WriteLine("Digite os numeros!");
            try
            {
                int valor1 = Convert.ToInt32(Console.ReadLine());
                int valor2 = Convert.ToInt32(Console.ReadLine());
                int valor3 = calculadora.Multiplicar(valor1, valor2);
                calculadora.AdicionarNoHistorico(valor3);
                Console.WriteLine(valor3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Você não digitou um numero!");
            }
            break;
        case "4":
            Console.WriteLine("Digite os numeros!");
            try
            {
                int valor1 = Convert.ToInt32(Console.ReadLine());
                int valor2 = Convert.ToInt32(Console.ReadLine());
                int valor3 = calculadora.Dividir(valor1, valor2);
                calculadora.AdicionarNoHistorico(valor3);
                Console.WriteLine(valor3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Você não digitou um numero!");
            }
            break;
        case "5":
            Console.WriteLine(calculadora.MostrarHistorico()[0]);
            Console.WriteLine(calculadora.MostrarHistorico()[1]);
            Console.WriteLine(calculadora.MostrarHistorico()[2]);
            break;
        case "6":
            EstaNoPrograma = false;
            break;
        default:
            Console.WriteLine("Caractere fora das opções");
            break;
    }
    Console.Clear();
}
