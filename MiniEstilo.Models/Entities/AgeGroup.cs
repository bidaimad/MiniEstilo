namespace MiniEstilo.Models.Entities
{
    public class AgeGroup
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string AgeGroupName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
