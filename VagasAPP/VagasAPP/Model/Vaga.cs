using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace VagasAPP.Model {
    
    [Table("vaga")]
    public class Vaga {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        
        public string Nome { get; set; }
        public short Vagas { get; set; }
        public string Cidade { get; set; }
        public double Salario { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }

}
