internal class Program
{
    private static void Main(string[] args)
    {
        int dias, ano1, ano2;

        Console.WriteLine("Digite o primeiro ano: ");
        ano1 = int.Parse(Console.ReadLine());

        ano2 = ano1 - 1;

        while (ano1 > ano2) { 
        Console.WriteLine("Digite o segundo ano: ");
        ano2 = int.Parse(Console.ReadLine());
        }

        dias = (ano2 - ano1 + 1)*365;
        for (int i = ano1; i <= ano2; i++)
        {
            if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
            {
                dias += 1;
            }
        }
        Console.WriteLine("O total de dias é: " + dias);
    }
}