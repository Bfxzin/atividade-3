using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome da pessoa:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o sexo da pessoa (M/F):");
        char sexo = char.Parse(Console.ReadLine());

        if (sexo == 'M' || sexo == 'm')
        {
            Console.WriteLine("Ilmo Sr. " + nome);
        }
        else if (sexo == 'F' || sexo == 'f')
        {
            Console.WriteLine("Ilma Sra. " + nome);
        }
        else
        {
            Console.WriteLine("Sexo inválido");
        }
    }
}
//atividade 3//