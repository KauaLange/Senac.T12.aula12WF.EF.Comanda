using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
            CriarUsuarioAdmin();
        }

        private void CriarUsuarioAdmin()
        {
            // acessa o banco de dados
            using (var banco = new ComandaContexto())
            {   
                //cria um novo usuario
                var novoUsuario = new Usuario();
                novoUsuario.Nome = "Admin";
                novoUsuario.Email = "admin@comanda.com";
                novoUsuario.Senha = "123";
                // banco, adicione na coleção Usuarios, um novo usuario
                banco.Usuarios.Add(novoUsuario);

                // confirma a adição
                banco.SaveChanges();
            }
        }

        void CriarBancoDeDados()
        {
            using (var banco = new ComandaContexto())
            {

                banco.Database.Migrate();
            }

        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            // crio o form de cardapio e exibo para o humano        
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           new FrmUsuario().ShowDialog();
        }
    }
}
