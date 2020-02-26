using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateUDemy
{
    class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening a Sql Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing a Sql Connection");
        }
    }
}
