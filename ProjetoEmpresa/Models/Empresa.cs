using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Models
{
    public class Empresa
    {
        public Empresa()
        {

        }
        public int EmpresaId { get; set; }

        public string UF { get; set; }
        public int CNPJ { get; set; }
        public string NomeFantasia { get; set; }
    }
}
