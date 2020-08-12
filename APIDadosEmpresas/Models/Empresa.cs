using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosEmpresas.Models
{
    public class Empresa
    {
        public Empresa()
        {
            Fornecedores = new Collection<Fornecedor>();
        }
        [Key]
        public int EmpresaId { get; set; }

        public string UF { get; set; }
        public int CNPJ { get; set; }
        public string NomeFantasia { get; set; }

        public ICollection<Fornecedor> Fornecedores { get; set; }
    }
}
