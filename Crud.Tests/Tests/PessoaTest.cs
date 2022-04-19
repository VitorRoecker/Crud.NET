using Core.Entidade;
using Crud.Infra.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xunit;

namespace Crud.Tests.Tests
{
    public class PessoaTest
    {
        [Fact]
        [Description("O método deve retornar uma exception quando o nome for nulo ou vazio")]
        public void Pessoa_ShouldThrowException_WhenHaveEmptyOrNullName()
        {
            var pessoa = new Pessoa();

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Nome inválido", exp.Message);
        }

        [Fact]
        [Description("O método deve retornar uma exception quando a idade for igual a Zero")]
        public void Pessoa_ShouldThrowException_WhenHaveAIdadeLessThenZero()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Claudio",
                DocumentoFederal = "98765555376"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Idade inválida", exp.Message);
        }

        [Fact]
        [Description("O método deve retornar uma exception quando o tamanho do documento federal for menor que 11")]
        public void Pessoa_ShouldThrowException_WhenDocumentoFederalIsLessThenEleven()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Claudio",
                Idade = 33,
                DocumentoFederal = "98756555542"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Documento federal inválido", exp.Message);
        }

        [Fact]
        [Description("O método deve verificar se retorna uma lista de pessoas")]
        public void Pessoa_ShouldReturn_IfHasAnything()
        {
            var pessoas = PessoasMock._pessoas;

            Assert.True(pessoas.Any());
        }

        [Fact]
        [Description("O método deve verificar se insere uma pessoa")]
        public void Pessoa_ShouldInsert_InsideTheList()
        {
            var pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa() { Nome = "Vitor", DocumentoFederal = "07787942967", Idade = 20 });

            Assert.True(pessoas.Any());
        }

        [Fact]
        [Description("O método deve retornar uma pessoa pelo documento federal")]
        public void Pessoa_ShouldGetPessoa_ByDocumentoFederal()
        {
            var pessoa = PessoasMock._pessoas.Where(x => Validacoes.DeixaNumeros(x.DocumentoFederal) == Validacoes.DeixaNumeros("010.255.002-61"));

            Assert.NotNull(pessoa);
        }
        
        [Fact]
        [Description("O método deve retornar uma pessoa pelo documento federal")]
        public void Pessoa_ShouldDeletePessoaFromList_ByDocumentoFederal()
        {

            var pessoas = PessoasMock._pessoas;
            var pessoa = PessoasMock._pessoas.Where(x => Validacoes.DeixaNumeros(x.DocumentoFederal) == Validacoes.DeixaNumeros("010.255.002-61")).FirstOrDefault();

            pessoas.Remove(pessoa);

            var pessoa2 = PessoasMock._pessoas.Where(x => Validacoes.DeixaNumeros(x.DocumentoFederal) == Validacoes.DeixaNumeros("010.255.002-61")).FirstOrDefault();


            Assert.Null(pessoa2);
        }
    }
}
