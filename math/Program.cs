using System;
using System.Collections.Generic;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            var operacoes = GetOperacoes();
            Console.WriteLine("Operações disponíveis: ");
            operacoes.ForEach(o => Console.WriteLine(o)); 
            Console.WriteLine();

            Console.WriteLine("Digite o ID operação que você deseja realizar:");
            Console.ReadKey();
        }
        public static List<string> GetOperacoes()
        {
            var IdsOperacoes = new List<Operation>();
            IdsOperacoes.Add(new Operation { ID = 1, Name = "Soma" });
            IdsOperacoes.Add(new Operation { ID = 2, Name = "Subtracao" });
            IdsOperacoes.Add(new Operation { ID = 3, Name = "Multiplicacao" });
            IdsOperacoes.Add(new Operation { ID = 4, Name = "Divisao" });
            
            return OperationsToArrayString(IdsOperacoes);
        }

        public static List<string> OperationsToArrayString(List<Operation> operations)
        {
            var viewOperations = new List<string>();

            foreach (var operation in operations)
                viewOperations.Add($"[{operation.ID}] {operation.Name}");

            return viewOperations;
        }
    }



    public class Operation
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
