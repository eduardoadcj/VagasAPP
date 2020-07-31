using System;
using System.Collections.Generic;
using System.Text;

namespace VagasAPP.Database {
    public interface IDatabasePath {
        string GetPath(string databaseName);
    }
}
