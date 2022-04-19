using Crud.Infra.Helpers;
using System;

namespace Core.Entidade
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public byte Idade { get; set; }
        public string DocumentoFederal { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome inválido");
            if (Idade <= 0)
                throw new Exception("Idade inválida");
            if (DocumentoFederal.Length != 11)
                throw new Exception("Docuemnto federal inválido");
            if (!Validacoes.ValidaCpf(DocumentoFederal))
                throw new Exception("Documento federal inválido");
        }
    }
}
