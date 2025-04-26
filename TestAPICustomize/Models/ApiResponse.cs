namespace TestAPICustomize.Models
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<FamilyMember> Data { get; set; }
    }
}
