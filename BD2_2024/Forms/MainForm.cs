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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showMessageBox(String txt, String title = "Atenção!")
        {
            MessageBox.Show(txt, title);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool hasInsertPermission = DatabasePostgresConnection.GetInstance().HasInsertPermissionOnVendas();
            bool hasInsertPermissionVerFuncionarios = DatabasePostgresConnection.GetInstance().HasSelectPermissionOnFuncionarios();

            BtnNovaVenda.Enabled = hasInsertPermission;
            BtnFuncionario.Enabled = hasInsertPermissionVerFuncionarios;
        }


        private void btnVerPermissoes_Click(object sender, EventArgs e)
        {
            Form mainForm = new VerPemissoesForm();
            mainForm.Show();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            Form mainForm = new VerFuncionariosForm();
            mainForm.Show();
        }
    }
}
