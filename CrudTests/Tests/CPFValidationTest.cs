using Core.Entidade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace CrudTests.Tests
{
    public class CPFValidationTest
    {
        [Fact]
        [Description("O método deve retornar uma exception quando o documento federal for invalido")]
        public void Pessoa_ShouldThrowException_WhenHaveADocumentoFederalIsInvalid()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Claudio",
                Idade = 33,
                DocumentoFederal = "18273458934"
            };

            var exp = Assert.ThrowsException<Exception>(() => pessoa.Validate());

            Assert.Equals(exp.Message, "Documento federal inválido");
        }
    }
}
