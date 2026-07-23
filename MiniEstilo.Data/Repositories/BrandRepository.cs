using MiniEstilo.Data.Connection;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Models.Entities;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MiniEstilo.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private string GenerateBrandCode(NpgsqlConnection connection)
        {
            string sql = @"
                SELECT code
                FROM mini_estilo.brands
                ORDER BY id DESC
                LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, connection);

            object? result = cmd.ExecuteScalar();

            if (result == null)
                return "MB00001";

            string lastCode = result.ToString()!;

            int number = int.Parse(lastCode.Substring(2));

            number++;

            return "MB" + number.ToString("D5");
        }

        public bool Add(Brand brand)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                INSERT INTO mini_estilo.brands
                (
                    code,
                    name,
                    description,
                    is_active
                )
                VALUES
                (
                    @code,
                    @name,
                    @description,
                    @is_active
                );";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@code", GenerateBrandCode(connection));
            cmd.Parameters.AddWithValue("@name", brand.BrandName);
            cmd.Parameters.AddWithValue("@description", brand.Description);
            cmd.Parameters.AddWithValue("@is_active", brand.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(Brand brand)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE mini_estilo.brands
                SET
                    code = @code,
                    name = @name,
                    description = @description,
                    is_active = @is_active
                WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", brand.Id);
            cmd.Parameters.AddWithValue("@code", brand.Code);
            cmd.Parameters.AddWithValue("@name", brand.BrandName);
            cmd.Parameters.AddWithValue("@description", brand.Description);
            cmd.Parameters.AddWithValue("@is_active", brand.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Delete(int id)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = "DELETE FROM mini_estilo.brands WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public Brand? GetById(int id)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    id,
                    code,
                    name,
                    description,
                    is_active
                FROM mini_estilo.brands
                WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Brand
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Code = reader.GetString(reader.GetOrdinal("code")),
                    BrandName = reader.GetString(reader.GetOrdinal("name")),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("description")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                };
            }

            return null;
        }

        public List<Brand> GetAll()
        {
            List<Brand> brands = new List<Brand>();

            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    id,
                    code,
                    name,
                    description,
                    is_active
                FROM mini_estilo.brands
                ORDER BY name;";

            using var cmd = new NpgsqlCommand(sql, connection);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                brands.Add(new Brand
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Code = reader.GetString(reader.GetOrdinal("code")),
                    BrandName = reader.GetString(reader.GetOrdinal("name")),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("description")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                });
            }

            return brands;
        }
    }
}
