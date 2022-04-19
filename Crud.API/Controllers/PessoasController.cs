using Core.Entidade;
using Crud.Infra.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Crud.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        [HttpGet]
        public List<Pessoa> GetAll()
        {
            return PessoasMock._pessoas;
        }

        [HttpGet("{documento}")]
        public Pessoa GetByDocumento(string documento)
        {
            return PessoasMock._pessoas.Where(x => Validacoes.DeixaNumeros(x.DocumentoFederal) == Validacoes.DeixaNumeros(documento)).FirstOrDefault();
        }

        [HttpPost]
        public void Post(Pessoa request)
        {
            PessoasMock._pessoas.Add(new Pessoa
            {
                Nome = request.Nome,
                Idade = request.Idade,
                DocumentoFederal = request.DocumentoFederal
            });
        }

        [HttpDelete("{documento}")]
        public void Delete(string documento)
        {
            var pessoa = PessoasMock._pessoas.Where(x => Validacoes.DeixaNumeros(x.DocumentoFederal) == Validacoes.DeixaNumeros(documento)).FirstOrDefault();

            PessoasMock._pessoas.Remove(pessoa);
        }
    }
}
