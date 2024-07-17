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

        private void CarregarUsuarios()
        {
            using (var Banco = new ComandaContexto())
            {
                //consulta todos os usuarios na tabela usuarios (select * from usuarios)
                var usuarios = Banco.Usuarios.ToList();

                dgvUsuario.DataSource = null;
                //dados da tabela usuarios serao exibidos no grid
                dgvUsuario.DataSource = usuarios;

            }
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
                            usuario.Id == int.Parse(txtId.TextButton));

                // SELECT *FROM usuarios
                // WHERE id = 234

                // atualizar as propriedades
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;

                //salvar as alterações
                // UPDATE usuarios SET
                // Nome = 'Kaua <- (txtNome.Textbutton)',
                // Emial = 'kaua@hotmail.gov'
                // WHERE id 
                banco.SaveChanges();

                MessageBox.Show("Usuário atualizado com sucesso!");
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
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;

                //adiciona esse objeto no contexto do banco
                banco.Usuarios.Add(novoUsuario);

                //Salva as alterações (INSERT INTO Usuarios (Id, nome, email, senha, values[]
                banco.SaveChanges();

            }
            MessageBox.Show("Usuário cadastrado com sucesso.");
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


            LimparCampos();
            DesabilitarCampos();
            CarregarUsuarios();

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // informa que está cadastrando um novo usuario
            ehNovoUsuario = true;
            //limpa os campos da tela
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
            // chama o metodo que habilita os campos para a digitação
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verificar se a linha foi verificada
            if (e.RowIndex >= 0)
            {
                // obter a linha
                var linha = dgvUsuario.Rows[e.RowIndex];

                // popular os campos da tela de acordo com a tela
                txtId.TextButton = linha.Cells["Id"].Value.ToString();
                txtNome.TextButton = linha.Cells["Nome"].Value.ToString();
                txtEmail.TextButton = linha.Cells["Email"].Value.ToString();
                txtSenha.TextButton = linha.Cells["Senha"].Value.ToString();


            }
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            ehNovoUsuario = false;
            habilitarCampos();
        }
    }
}
