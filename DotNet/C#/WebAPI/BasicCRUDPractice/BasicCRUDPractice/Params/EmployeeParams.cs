using System.Diagnostics.CodeAnalysis;

namespace BasicCRUDPractice.Params
{
    public class EmployeeParams : PaginationParams
    {
        [AllowNull]
        public string? SearchText { get; set; }
    }
}
