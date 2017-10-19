using ControleEstoque.DAO;
using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace ControleEstoque.Controllers.Api
{
    [RoutePrefix("api/Produtos")]
    public class ProdutosController : ApiController
    {
        [HttpPost]
        [Route("Decrementa")]
        public Produto DecrementaQtd([FromBody] int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(Convert.ToInt32(id));
            produto.Quantidade--;
            dao.Atualiza(produto);

            return produto;
        }

        [HttpPost]
        [Route("Teste")]
        public String Teste()
        {
            return "Mensagem";
        }
    }
}
