using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosEmpresas.Models
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            
        }

        [Key]
        public int FornecedorId { get; set; }

        public int CPFCNPJ { get; set; }        
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Telefone { get; set; }
        public string RG { get; set; }
        public DateTime DataNasc { get; set; }

        

        public Empresa Empresas { get; set; }
        public int EmpresaId { get; set; }

    }
}
