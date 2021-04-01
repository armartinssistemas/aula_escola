using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projeto_escola
{
    public partial class frmusuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (escolaEntities1 conexao = new escolaEntities1())
                {
                    carregaGrid(conexao);
                }
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (escolaEntities1 conexao = new escolaEntities1())
            {
                usuarios u = new usuarios();
                u.nome = txtNome.Text;
                u.login = txtUsuario.Text;
                u.senha = txtSenha.Text;

                //Salvar objeto em memória
                conexao.usuarios.Add(u);

                //Salvar no disco
                conexao.SaveChanges();

                //Mostrar dados no grid
                carregaGrid(conexao);
            }
        }

        private void carregaGrid(escolaEntities1 conexao)
        {
            List<usuarios> dados = conexao.usuarios.ToList();
            gridUsuarios.DataSource = dados;
            gridUsuarios.DataBind();
        }
    }
}