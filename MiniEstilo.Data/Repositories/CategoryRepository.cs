using MiniEstilo.Data.Connection;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Models.Entities;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MiniEstilo.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private string GenerateCategoryCode(NpgsqlConnection connection)
        {
            string sql = @"
        SELECT code
        FROM mini_estilo.categories
        ORDER BY id DESC
        LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, connection);

            object? result = cmd.ExecuteScalar();

            if (result == null)
                return "MC00001";

            string lastCode = result.ToString()!;

            int number = int.Parse(lastCode.Substring(2));

            number++;

            return "MC" + number.ToString("D5");
        }
        public bool Add(Category category)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                INSERT INTO mini_estilo.categories
                (
                    code,
                    name,
                    description,
                    parent_id,
                    is_active
                )
                VALUES
                (
                    @code,
                    @name,
                    @description,
                    @parent_id,
                    @is_active
                );";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@code", GenerateCategoryCode(connection));
            cmd.Parameters.AddWithValue("@name", category.CategoryName);
            cmd.Parameters.AddWithValue("@description", category.Description);
            cmd.Parameters.AddWithValue("@parent_id", (object?)category.ParentId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@is_active", category.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(Category category)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE mini_estilo.categories
                SET
                    code = @code,
                    name = @name,
                    description = @description,
                    parent_id = @parent_id,
                    is_active = @is_active
                WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", category.Id);
            cmd.Parameters.AddWithValue("@code", category.Code);
            cmd.Parameters.AddWithValue("@name", category.CategoryName);
            cmd.Parameters.AddWithValue("@description", category.Description);
            cmd.Parameters.AddWithValue("@parent_id", (object?)category.ParentId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@is_active", category.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(int id)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
        DELETE FROM mini_estilo.categories
        WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        
        }

        public Category? GetById(int id)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
        SELECT
            id,
            code,
            name,
            description,
            parent_id,
            is_active
        FROM mini_estilo.categories
        WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Category
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Code = reader.GetString(reader.GetOrdinal("code")),
                    CategoryName = reader.GetString(reader.GetOrdinal("name")),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("description")),
                    ParentId = reader.IsDBNull(reader.GetOrdinal("parent_id"))
                        ? null
                        : reader.GetInt32(reader.GetOrdinal("parent_id")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                };
            }

            return null;
        
        }

        public List<Category> GetAll()
        {
            var categories = new List<Category>();

            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
        SELECT
            id,
            code,
            name,
            description,
            parent_id,
            is_active
        FROM mini_estilo.categories
        ORDER BY name;";

            using var cmd = new NpgsqlCommand(sql, connection);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categories.Add(new Category
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Code = reader.GetString(reader.GetOrdinal("code")),
                    CategoryName = reader.GetString(reader.GetOrdinal("name")),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("description")),
                    ParentId = reader.IsDBNull(reader.GetOrdinal("parent_id"))
                        ? null
                        : reader.GetInt32(reader.GetOrdinal("parent_id")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                });
            }

            return categories;
        
    }
    }
}