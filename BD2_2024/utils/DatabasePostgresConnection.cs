using System;
using System.Collections.Generic;
using Npgsql;

namespace PostgresConnectionExample
{
    public sealed class DatabasePostgresConnection
    {
        private static DatabasePostgresConnection _instance = null;
        private static readonly object _lock = new object();
        private NpgsqlConnection _connection;
        private string _connectionString;

        private DatabasePostgresConnection(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new NpgsqlConnection(_connectionString);
            _connection.Open();
        }

        public static DatabasePostgresConnection GetInstance(string connectionString = null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    if (connectionString == null)
                    {
                        throw new InvalidOperationException("A conexão ainda não foi inicializada.");
                    }
                    _instance = new DatabasePostgresConnection(connectionString);
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
            {
                _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public List<string> GetNativeUserPermissions()
        {
            var permissions = new List<string>();

            string query = @"
                SELECT
                    grantee,
                    table_catalog,
                    table_schema,
                    table_name,
                    privilege_type
                FROM
                    information_schema.role_table_grants
                WHERE
                    grantee = CURRENT_USER;";

            using (var command = new NpgsqlCommand(query, _connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string permission = $"{reader.GetString(0)}:{reader.GetString(1)}.{reader.GetString(2)}.{reader.GetString(3)} - {reader.GetString(4)}";
                        permissions.Add(permission);
                    }
                }
            }

            return permissions;
        }

        public bool HasInsertPermissionOnVendas()
        {
            string query = "SELECT has_table_privilege(CURRENT_USER, 'tb_vendas', 'INSERT');";

            using (var command = new NpgsqlCommand(query, _connection))
            {
                return (bool)command.ExecuteScalar();
            }
        }

        public bool HasSelectPermissionOnFuncionarios()
        {
            string query = "SELECT has_table_privilege(CURRENT_USER, 'tb_funcionarios', 'SELECT');";

            using (var command = new NpgsqlCommand(query, _connection))
            {
                return (bool)command.ExecuteScalar();
            }
        }

    }
}
