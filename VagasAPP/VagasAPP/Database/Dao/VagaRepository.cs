using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VagasAPP.Model;

namespace VagasAPP.Database.Dao {
    public class VagaRepository : SqliteRepository<Vaga>{
    
        public VagaRepository() : base() {

        }

        public List<Vaga> Search(string query) {
            return con.Query<Vaga>(query).ToList();
        }

        public List<Vaga> SearchNome(string nome) {
            return con.Table<Vaga>()
                .Where(vaga => vaga.Nome.Contains(nome)).ToList();
        }

    }
}
