using math.Domain.Models;
using System.Collections.Generic;

namespace math.Helper
{
    public class OperationModelToVm
    {
        public static List<string> OperationsToArrayString(List<Operation> operations)
        {
            var viewOperations = new List<string>();

            foreach (var operation in operations)
                viewOperations.Add($"[{operation.ID}] {operation.Name}");

            return viewOperations;
        }
    }
}
