namespace MiniEstilo.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Barcode { get; set; } = string.Empty;

        public string ProductCode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        public int? CategoryId { get; set; }

        public int? BrandId { get; set; }

        public int? GenderId { get; set; }

        public int? AgeGroupId { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SellingPrice { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; } = string.Empty;

        public string? ImagePath { get; set; }
    }
}