using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using EOMOD.Settings;
using EOMOD.Models;

namespace EOMOD.Controllers
{
    class GradeStudents
    {
        private ConnectionODBC CursorDB = new ConnectionODBC();

        public DataTable FindAll()
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT categoria, grado, codigog FROM Tgrado");
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }
    }
}
