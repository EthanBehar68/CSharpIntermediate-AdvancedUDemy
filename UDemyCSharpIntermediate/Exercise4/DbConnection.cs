using System;
using System.Collections.Generic;
using System.Text;

namespace UDemyCSharpIntermediate
{
    abstract class DbConnection
    {
        private readonly string _connectionString;
        protected TimeSpan _timeout = TimeSpan.FromSeconds(60);

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Cannot create a DbConnection with a null or empty connection.");
            }

            this._connectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
