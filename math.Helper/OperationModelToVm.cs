using math.Domain.Models;
using math.Domain.ViewModels;
using System.Collections.Generic;

namespace math.Helper
{
    public class OperationModelToVm
    {
        public List<string> OperationsToArrayString(List<Operation> operations)
        {
            var viewOperations = new List<string>();

            foreach (var operation in operations)
                viewOperations.Add($"[{operation.ID}] {operation.Name}");

            return viewOperations;
        }

        public List<OperationVM> OperationsToOperationVM(List<Operation> operations)
        {
            var viewOperations = new List<OperationVM>();

            foreach (var operation in operations)
                viewOperations.Add(OperationToOperationVM(operation));

            return viewOperations;
        }

        public OperationVM OperationToOperationVM(Operation operation)
        {
            return new OperationVM
            {
                ID = operation.ID,
                OperationName = operation.Name,
                OperationURL = $"http://localhost/math/api/operation?id={operation.ID}"
            };
        }
    }
}
