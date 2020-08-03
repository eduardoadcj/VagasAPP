using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using VagasAPP.Model;

namespace VagasAPP.Database {
    public class SqliteRepository<T> where T : new(){

        protected SQLiteConnection con;

        public SqliteRepository() {
            con = Connection.Get();
            con.CreateTable<T>();
            
        }

        public int Add(T obj) {
            return con.Insert(obj);
        }

        public void Delete(T obj) {
            con.Delete(obj);
        }

        public void Update(T obj) {
            con.Update(obj);
        }

        public List<T> ListAll() {
            return con.Table<T>().ToList();
        }

        public T GetById(int id) {
            return con.Get<T>(id);
        }

    }
}
