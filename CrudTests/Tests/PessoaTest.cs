using Core.Entidade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Xunit;

namespace CrudTests
{
    [TestClass]
    public class PessoaTest
    {
        [Fact]
        [Description("O método deve retornar uma exception quando o nome for nulo ou vazio")]
        public void Pessoa_ShouldThrowException_WhenHaveEmptyOrNullName()
        {
            var pessoa = new Pessoa();

            var exp = Assert.ThrowsException<Exception>(() => pessoa.Validate());

            Assert.Equals(exp.Message, "Nome inválido");
        }

        [Fact]
        [Description("O método deve retornar uma exception quando a idade for menor que Zero")]
        public void Pessoa_ShouldThrowException_WhenHaveAIdadeLessThenZero()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Claudio",
                DocumentoFederal = "07787942967"
            };

            var exp = Assert.ThrowsException<Exception>(() => pessoa.Validate());

            Assert.Equals(exp.Message, "Idade inválida");
        }

        [Fact]
        [Description("O método deve retornar uma exception quando o tamanho do documento federal for menor que 11")]
        public void Pessoa_ShouldThrowException_WhenDocumentoFederalIsLessThenEleven()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Claudio",
                Idade = 33,
                DocumentoFederal = "07787942967"
            };

            var exp = Assert.ThrowsException<Exception>(() => pessoa.Validate());

            Assert.Equals(exp.Message, "Documento federal inválido");
        }

        [Fact]
        [Description("O método deve verificar se retorna uma lista de pessoas")]
        public void Pessoa_ShouldReturn_IfHasAnything()
        {
            var pessoas = PessoasMock._pessoas;

            Assert.IsTrue(pessoas.Any());
        }
    }
}
