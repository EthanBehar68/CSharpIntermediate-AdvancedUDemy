using System;

namespace CSharpIntermediateUDemy
{
    class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            if(connection == null)
            {
                throw new ArgumentNullException("Cannot create a DbCommand with a null connection.");
            }

            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentException("Cannot create a DbCommand with a null or empty instruction.");
            }

            this._connection = connection;
            this._instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();

            Run();

            _connection.CloseConnection();
        }

        private void Run()
        {
            Console.WriteLine("Running instructions \"{0}\" with a {1}.", _instruction, _connection.GetType().ToString());  
        }
    }
}
