using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using SQLite;
using System.Threading.Tasks;

namespace GripOpGras.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
