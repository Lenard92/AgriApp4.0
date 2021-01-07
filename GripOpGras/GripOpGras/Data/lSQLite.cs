using System;
using System.Collections.Generic;
using System.Text;

namespace GripOpGras.Data
{
    public interface lSQlite
    {
        SQLiteConnection GetConnection();
    }
}
