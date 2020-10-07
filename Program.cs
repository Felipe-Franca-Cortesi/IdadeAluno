using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Exemplo a ser seguido: dia/mês/ano \n");
            Console.Write("Informe sua data de nascimento: ");
            string dataNascimentoUsuario = Console.ReadLine();
            DateTime dataNascimento = Convert.ToDateTime(dataNascimentoUsuario);
            DateTime maiorIdade = dataNascimento.AddYears(18);
            Console.WriteLine($"Seu nascimento foi, {dataNascimento.ToLongDateString()}");
            Console.WriteLine($"Aniversário de 18 anos, {maiorIdade.ToLongDateString()}");

        }
    }
}
