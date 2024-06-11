using Npgsql;
using PostgresConnectionExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_2024.Forms
{
    public partial class VerFuncionariosForm : Form
    {
        public VerFuncionariosForm()
        {
            InitializeComponent();
        }

        private void VerFuncionariosForm_Load(object sender, EventArgs e)
        {
            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                string query = "SELECT usename AS username, usecreatedb, usesuper, passwd FROM pg_user;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable usersTable = new DataTable();
                        adapter.Fill(usersTable);
                        dataGridViewUsers.DataSource = usersTable;
                    }
                }
            }
        }
    }
}
