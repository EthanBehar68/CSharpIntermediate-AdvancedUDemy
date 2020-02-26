using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateUDemy
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening a Oracle Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing a Oracle Connection");
        }
    }
}
