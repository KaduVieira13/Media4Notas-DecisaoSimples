using System;

namespace Media4Notas_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal p1, p2, p3, p4, media;
           
            

            

            Console.WriteLine("--- Média Aluno ---");

            Console.Write("digite a nota da prova 1: ");
            p1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("digite a nota da prova 2: ");
            p2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("digite a nota da prova 3: ");
            p3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("digite a nota da prova 4: ");
            p4 = Convert.ToDecimal(Console.ReadLine());

              media = ((p1+p2+p3+p4) / 4);
              

            if (media < 5)
            {
             Console.WriteLine($"Sua nota final foi {media}, você foi reprovado.");
            }
            
           else if  (media <= 6)
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
