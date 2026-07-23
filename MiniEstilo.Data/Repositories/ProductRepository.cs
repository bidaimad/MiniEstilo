using MiniEstilo.Data.Connection;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Models.Entities;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MiniEstilo.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public bool Add(Product product)
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string sql = @"
INSERT INTO mini_estilo.products
(
    barcode,
    code,
    name,
    category_id,
    brand_id,
    gender_id,
    age_group_id,
    purchase_price,
    selling_price,
    quantity,
    description,
    image_path,
    is_active
)
VALUES
(
    @barcode,
    @code,
    @name,
    @category_id,
    @brand_id,
    @gender_id,
    @age_group_id,
    @purchase_price,
    @selling_price,
    @quantity,
    @description,
    @image_path,
    TRUE
);";

                using var cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@code", product.ProductCode);
                cmd.Parameters.AddWithValue("@name", product.ProductName);
                cmd.Parameters.AddWithValue("@category_id", (object?)product.CategoryId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@brand_id", (object?)product.BrandId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@gender_id", (object?)product.GenderId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@age_group_id", (object?)product.AgeGroupId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@purchase_price", product.PurchasePrice);
                cmd.Parameters.AddWithValue("@selling_price", product.SellingPrice);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@image_path", (object?)product.ImagePath ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Update(Product product)
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string sql = @"
UPDATE mini_estilo.products
SET
    barcode=@barcode,
    code=@code,
    name=@name,
    category_id=@category_id,
    brand_id=@brand_id,
    gender_id=@gender_id,
    age_group_id=@age_group_id,
    purchase_price=@purchase_price,
    selling_price=@selling_price,
    quantity=@quantity,
    description=@description,
    image_path=@image_path
WHERE id=@id;";

                using var cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@id", product.Id);
                cmd.Parameters.AddWithValue("@barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@code", product.ProductCode);
                cmd.Parameters.AddWithValue("@name", product.ProductName);
                cmd.Parameters.AddWithValue("@category_id", (object?)product.CategoryId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@brand_id", (object?)product.BrandId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@gender_id", (object?)product.GenderId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@age_group_id", (object?)product.AgeGroupId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@purchase_price", product.PurchasePrice);
                cmd.Parameters.AddWithValue("@selling_price", product.SellingPrice);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@image_path", (object?)product.ImagePath ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string sql = "DELETE FROM mini_estilo.products WHERE id=@id";

                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public Product? GetById(int id)
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string sql = @"
SELECT
    id,
    barcode,
    code,
    name,
    category_id,
    brand_id,
    gender_id,
    age_group_id,
    purchase_price,
    selling_price,
    quantity,
    description,
    image_path
FROM mini_estilo.products
WHERE id = @id;";

                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Product
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Barcode = reader["barcode"]?.ToString() ?? "",
                        ProductCode = reader["code"]?.ToString() ?? "",
                        ProductName = reader["name"]?.ToString() ?? "",

                        CategoryId = reader["category_id"] == DBNull.Value ? null : Convert.ToInt32(reader["category_id"]),
                        BrandId = reader["brand_id"] == DBNull.Value ? null : Convert.ToInt32(reader["brand_id"]),
                        GenderId = reader["gender_id"] == DBNull.Value ? null : Convert.ToInt32(reader["gender_id"]),
                        AgeGroupId = reader["age_group_id"] == DBNull.Value ? null : Convert.ToInt32(reader["age_group_id"]),

                        PurchasePrice = Convert.ToDecimal(reader["purchase_price"]),
                        SellingPrice = Convert.ToDecimal(reader["selling_price"]),
                        Quantity = Convert.ToInt32(reader["quantity"]),

                        Description = reader["description"]?.ToString() ?? "",
                        ImagePath = reader["image_path"] == DBNull.Value ? null : reader["image_path"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string sql = @"
SELECT
    id,
    barcode,
    code,
    name,
    category_id,
    brand_id,
    gender_id,
    age_group_id,
    purchase_price,
    selling_price,
    quantity,
    description,
    image_path
FROM mini_estilo.products
ORDER BY id DESC;";

                using var cmd = new NpgsqlCommand(sql, connection);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Barcode = reader["barcode"]?.ToString() ?? "",
                        ProductCode = reader["code"]?.ToString() ?? "",
                        ProductName = reader["name"]?.ToString() ?? "",
                        CategoryId = reader["category_id"] == DBNull.Value ? null : Convert.ToInt32(reader["category_id"]),
                        BrandId = reader["brand_id"] == DBNull.Value ? null : Convert.ToInt32(reader["brand_id"]),
                        GenderId = reader["gender_id"] == DBNull.Value ? null : Convert.ToInt32(reader["gender_id"]),
                        AgeGroupId = reader["age_group_id"] == DBNull.Value ? null : Convert.ToInt32(reader["age_group_id"]),
                        PurchasePrice = Convert.ToDecimal(reader["purchase_price"]),
                        SellingPrice = Convert.ToDecimal(reader["selling_price"]),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Description = reader["description"]?.ToString() ?? "",
                        ImagePath = reader["image_path"] == DBNull.Value ? null : reader["image_path"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return products;
        }
        
        public List<Product> Search(string keyword)
        {
            List<Product> products = new List<Product>();

            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string sql = @"
SELECT
    id,
    barcode,
    code,
    name,
    category_id,
    brand_id,
    gender_id,
    age_group_id,
    purchase_price,
    selling_price,
    quantity,
    description,
    image_path
FROM mini_estilo.products
WHERE
    barcode ILIKE @keyword
    OR code ILIKE @keyword
    OR name ILIKE @keyword
ORDER BY id DESC;";

                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Barcode = reader["barcode"]?.ToString() ?? "",
                        ProductCode = reader["code"]?.ToString() ?? "",
                        ProductName = reader["name"]?.ToString() ?? "",
                        CategoryId = reader["category_id"] == DBNull.Value ? null : Convert.ToInt32(reader["category_id"]),
                        BrandId = reader["brand_id"] == DBNull.Value ? null : Convert.ToInt32(reader["brand_id"]),
                        GenderId = reader["gender_id"] == DBNull.Value ? null : Convert.ToInt32(reader["gender_id"]),
                        AgeGroupId = reader["age_group_id"] == DBNull.Value ? null : Convert.ToInt32(reader["age_group_id"]),
                        PurchasePrice = Convert.ToDecimal(reader["purchase_price"]),
                        SellingPrice = Convert.ToDecimal(reader["selling_price"]),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Description = reader["description"]?.ToString() ?? "",
                        ImagePath = reader["image_path"] == DBNull.Value ? null : reader["image_path"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return products;
        }
    }
}