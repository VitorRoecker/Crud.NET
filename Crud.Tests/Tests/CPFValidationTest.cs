using Core.Entidade;
using Crud.Infra.Helpers;
using System;
using System.ComponentModel;
using Xunit;

namespace Crud.Tests.Tests
{
    public class CPFValidationTest
    {
        [Fact]
        [Description("O método deve retornar uma exception quando o documento federal for invalido")]
        public void Pessoa_ShouldThrowException_WhenHaveAInvalidDocumentoFederal()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Claudio",
                Idade = 33,
                DocumentoFederal = "18273458934"
            };

            var isValid = Validacoes.ValidaCpf(pessoa.DocumentoFederal);

            Assert.False(isValid);
        }
    }
}
