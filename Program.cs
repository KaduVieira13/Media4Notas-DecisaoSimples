using System;

namespace Media4Notas_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal p1, p2, p3, p4, media;
            bool p1Valida, p2Valida, p3Valida, p4Valida;



            Console.WriteLine("--- Média Aluno ---\n");

            Console.Write("Digite a nota da prova 1: ");
            p1Valida = Decimal.TryParse(Console.ReadLine(), out p1);

            Console.Write("Digite a nota da prova 2: ");
            p2Valida = Decimal.TryParse(Console.ReadLine(), out p2);

            Console.Write("Digite a nota da prova 3: ");
            p3Valida = Decimal.TryParse(Console.ReadLine(), out p3);

            Console.Write("Digite a nota da prova 4: ");
            p4Valida = Decimal.TryParse(Console.ReadLine(), out p4);


            if (!p1Valida || !p2Valida || !p3Valida || !p4Valida)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite apenas numeros.");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            if (p1 < 0 || p1 > 10
             || p2 < 0 || p2 > 10
             || p3 < 0 || p3 > 10
             || p4 < 0 || p4 > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Favor digitar notas entre 0 a 10.");
                Console.ResetColor();
                Environment.Exit(-1);
            }





            media = ((p1 + p2 + p3 + p4) / 4);


            if (media < 5)
            {
                Console.WriteLine($"Sua nota final foi {media}, você foi reprovado.");
            }

            else if (media <= 6)
            {
                Console.WriteLine($"Sua nota final foi {media}, você está em recuperação.");
            }

            else
            {
                Console.WriteLine($"Sua nota final foi {media}, você  foi aprovado.");
            }









        }
    }
}
