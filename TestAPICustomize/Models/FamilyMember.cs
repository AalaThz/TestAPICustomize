namespace TestAPICustomize.Models
{
    public class FamilyMember
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public int FamilyMemberTypeId { get; set; }
    }
}
