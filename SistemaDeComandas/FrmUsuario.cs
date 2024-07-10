using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeComandas
{
    public partial class FrmUsuario : Form
    {
        private bool ehNovoUsuario;

        public FrmUsuario()
        {
            InitializeComponent();
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Load(object sender, EventArgs e)
        {
            CriarUsuario();
            //AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                //buscar o usuario pelo ID
                var usuario = banco
                    .Usuarios
                        .First(usuario =>
                            usuario.Id == 1);

                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;

                banco.SaveChanges();
            }
            

        }

        private void CriarUsuario()
        {
            if (txtNome.TextButton == string.Empty)
            {
                MessageBox.Show("Preencha seu nome");
                return;
            }

            if (txtEmail.TextButton == string.Empty)
            {
                MessageBox.Show("Preencha seu email");
                return;
            }

            if (txtSenha.TextButton == string.Empty)
            {
                MessageBox.Show("Preencha sua senha");
                return;
            }



            using (var banco = new ComandaContexto())
            {
                //criar o objeto usuario
                var novoUsuario = new Usuario();
                novoUsuario.Nome = txtNome.Text;
                novoUsuario.Email = txtEmail.Text;
                novoUsuario.Senha = txtSenha.Text;

                //adiciona esse objeto no contexto do banco
                banco.Usuarios.Add(novoUsuario);

                //Salva as alterações (INSERT INTO Usuarios (Id, nome, email, values[]
                banco.SaveChanges();

            }
        }

        private void txtSenha_Load(object sender, EventArgs e)
        {

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovoUsuario)
                CriarUsuario();
            else
                AtualizarUsuario();

    
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = true;

            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
