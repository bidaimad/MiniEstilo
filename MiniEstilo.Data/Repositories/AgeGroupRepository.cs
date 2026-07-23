using MiniEstilo.Data.Connection;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Models.Entities;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MiniEstilo.Data.Repositories
{
    public class AgeGroupRepository : IAgeGroupRepository
    {
        private string GenerateAgeGroupCode(NpgsqlConnection connection)
        {
            string sql = @"
                SELECT code
                FROM mini_estilo.age_groups
                ORDER BY id DESC
                LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, connection);

            object? result = cmd.ExecuteScalar();

            if (result == null)
                return "AG00001";

            string lastCode = result.ToString()!;

            int number = int.Parse(lastCode.Substring(2));

            number++;

            return "AG" + number.ToString("D5");
        }

        public bool Add(AgeGroup ageGroup)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                INSERT INTO mini_estilo.age_groups
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

            cmd.Parameters.AddWithValue("@code", GenerateAgeGroupCode(connection));
            cmd.Parameters.AddWithValue("@name", ageGroup.AgeGroupName);
            cmd.Parameters.AddWithValue("@description", ageGroup.Description);
            cmd.Parameters.AddWithValue("@is_active", ageGroup.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(AgeGroup ageGroup)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE mini_estilo.age_groups
                SET
                    code=@code,
                    name=@name,
                    description=@description,
                    is_active=@is_active
                WHERE id=@id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", ageGroup.Id);
            cmd.Parameters.AddWithValue("@code", ageGroup.Code);
            cmd.Parameters.AddWithValue("@name", ageGroup.AgeGroupName);
            cmd.Parameters.AddWithValue("@description", ageGroup.Description);
            cmd.Parameters.AddWithValue("@is_active", ageGroup.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Delete(int id)
        {
            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = "DELETE FROM mini_estilo.age_groups WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public AgeGroup? GetById(int id)
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
                FROM mini_estilo.age_groups
                WHERE id = @id;";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new AgeGroup
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Code = reader.GetString(reader.GetOrdinal("code")),
                    AgeGroupName = reader.GetString(reader.GetOrdinal("name")),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("description")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                };
            }

            return null;
        }

        public List<AgeGroup> GetAll()
        {
            List<AgeGroup> ageGroups = new List<AgeGroup>();

            using var connection = DatabaseConnection.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    id,
                    code,
                    name,
                    description,
                    is_active
                FROM mini_estilo.age_groups
                ORDER BY name;";

            using var cmd = new NpgsqlCommand(sql, connection);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ageGroups.Add(new AgeGroup
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Code = reader.GetString(reader.GetOrdinal("code")),
                    AgeGroupName = reader.GetString(reader.GetOrdinal("name")),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("description")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                });
            }

            return ageGroups;
        }
    }
}