using System;

namespace _7.Hotels
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Я так поняла, эта задача связана с WCF, с которым я не работала.
             Но вообще я бы делала это через sql, запросом
             select h.name from hotels h
             where h.id in ( ids_array )
             

            8.
            Нельзя гарантировать вставку в таблицу до получения ответа от сервиса, а к сервису нельзя обратиться, пока вставка в таблицу не гарантирована. Логическое противоречие.

            Если же это задание про то, как гарантировать вставку в таблицу, то можно делать так:
                1 вариант:

            void AddMeMoney(decimal maneyManeyManey)  {
                var conn = new PgSqlConnection(str);
                conn.Open();
                var command = new PgSqlCommand() {
                    Connection = conn
                };
                PgSqlTransaction myTrans;
                myTrans = conn.BeginTransaction();
                command.Transaction = myTrans;
                try
                {
                    command.CommandText = $"INSERT INTO mytable Values({maneyManeyManey}) where id = {_currentUser.Id}";
                    command.ExecuteNonQuery();
                    if (!IBankOfTheMafia.HeHasMoney())
                        throw new InvalidOperationException("No money!");
                    myTrans.Commit();
                }
                catch(Exception e)
                {
                    myTrans.Rollback();
                    throw;
                }
                finally
                {
                    pgConnection.Close();
                }
         
            }

                2 вариант:
                    Подойдет, если оба сервиса работают с одной бд. Вынести логику проверки + вставки данных в хранимку, и так же через commit/rollback разрешить ситуацию

             */
        }
    }
}
