using SqliteORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlLiteWebAPI.Models
{
    public class DataAccess<T>
    {

        public DataAccess()
        {
            DbConnection.Initialise("data source=App_Data/db.sqlite3");
        }

        public T Get()
        {
            
            using (TableAdapter<T> adapter = TableAdapter<T>.Open())
            {
                // Create
                //adapter.CreateUpdate(1, "Hello world!");

                // Read
               T value = adapter.Select().First();
                return (T)Convert.ChangeType(value, typeof(T));

                //// Update
                //row.Test = "Cheese";
                //adapter.CreateUpdate(row);

                //// Delete
                //adapter.Delete(row1);
            }

            //return value;
        }

    }

    [Serializable]
    public abstract class TableBase<T>
    {
        protected TableBase()
        {

            DbConnection.Initialise("data source=App_Data/db.sqlite3");
        }

        public static void Delete(params object[] args)
        {
            using (TableAdapter<T> adapter = TableAdapter<T>.Open(new object[0]))
            {
                adapter.Delete(args);
            }
        }

        public static void Do(Action<TableAdapter<T>> action)
        {
            using (TableAdapter<T> adapter = TableAdapter<T>.Open(new object[0]))
            {
                action(adapter);
            }
        }

        public static TReturn Get<TReturn>(Func<TableAdapter<T>, TReturn> action)
        where TReturn : class
        {
            TReturn tReturn;
            using (TableAdapter<T> adapter = TableAdapter<T>.Open(new object[0]))
            {
                tReturn = action(adapter);
            }
            return tReturn;
        }

        public static T Read(params object[] args)
        {
            T t;
            using (TableAdapter<T> adapter = TableAdapter<T>.Open(new object[0]))
            {
                t = adapter.Read(args);
            }
            return t;
        }

        public virtual void Save()
        {
            using (TableAdapter<T> adapter = TableAdapter<T>.Open(new object[0]))
            {
                adapter.CreateUpdate(new object[] { this });
            }
        }
    }
}