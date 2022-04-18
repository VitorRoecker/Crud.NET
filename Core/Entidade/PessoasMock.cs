using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidade
{
    public class PessoasMock
    {
        public static List<Pessoa> _pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "Matheusin", Idade = 20, DocumentoFederal = "112.214.731-74" },
            new Pessoa { Nome = "João", Idade = 19, DocumentoFederal = "010.255.002-61" }
        };
    }
}
