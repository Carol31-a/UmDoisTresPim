
class Program
{

    static void Main()
    {
        Console.WriteLine("=== Silvio Santos e o Desafio do 'Pim' ===");
        Console.WriteLine("Os números de 1 a 40 serão exibidos. Múltiplos de 4 viram 'pim'!\n");
 

        ExibirSequencia(1, 40);
 
        Console.WriteLine("\n=== Fim do Desafio ===");
    }
 
    static void ExibirSequencia(int inicio, int fim)
    {
        for (int i = inicio; i <= fim; i++)
        {
     
            string valor = VerificarPim(i);

            if (valor == "pim")
                Console.ForegroundColor = ConsoleColor.Magenta;
            else
                Console.ResetColor();
 
            Console.Write(valor.PadRight(4));
 
            if (i % 4 == 0)
                Console.WriteLine();
        }
        Console.ResetColor();
    }
 
    static string VerificarPim(int numero)
    {
        return (numero % 4 == 0) ? "pim" : numero.ToString();
    }
}
