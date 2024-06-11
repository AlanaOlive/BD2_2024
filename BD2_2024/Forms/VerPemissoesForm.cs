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
    public partial class VerPemissoesForm : Form
    {
        public VerPemissoesForm()
        {
            InitializeComponent();
        }


        private void DisplayPermissionsInGrid(List<string> permissions)
        {
            // Configurar as colunas do DataGridView
            dataGridViewPermissions.ColumnCount = 2;
            dataGridViewPermissions.Columns[0].Name = "Tabela";
            dataGridViewPermissions.Columns[1].Name = "Permissão";

            // Adicionar as permissões ao DataGridView
            foreach (var permission in permissions)
            {
                var parts = permission.Split(new char[] { '-' }, 2);
                if (parts.Length == 2)
                {
                    dataGridViewPermissions.Rows.Add(parts[0].Trim(), parts[1].Trim());
                }
            }
        }

        private void VerPemissoesForm_Load(object sender, EventArgs e)
        {
            var permissions = DatabasePostgresConnection.GetInstance().GetNativeUserPermissions();
            DisplayPermissionsInGrid(permissions);
        }
    }

}
