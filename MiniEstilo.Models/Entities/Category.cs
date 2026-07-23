namespace MiniEstilo.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int? ParentId { get; set; }

        public bool IsActive { get; set; } = true;
    }
}