using BD2_2024.Forms;
using System;
using System.Windows.Forms;

namespace BD2_2024
{
    public partial class Login : Form
    {

        private void showMessageBox(String txt, String title = "Atenção!")
        {
            MessageBox.Show(txt,title);
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var txtUsuario = txtBoxLoginUsuario.Text;
            var txtSenha = txtBoxLoginSenha.Text;

            if (String.IsNullOrEmpty(txtUsuario))
            {
                showMessageBox("Preencha todos os campos.");
            }
            else if (String.IsNullOrEmpty(txtSenha))
            {
                showMessageBox("Preencha todos os campos.");
            }
            else
            {
                this.Hide();

                Form mainForm = new MainForm();
                mainForm.Show();
            }

        }

     

    }
 
}
