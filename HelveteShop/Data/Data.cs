using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public static class Data
    {
        private static DataBase dataBase = null;

        public static DataBase GetDataBase()
        {
            if (dataBase == null)
            {
                CreateDataBase();
            }

            return dataBase;
        }

        private static void CreateDataBase()
        {
            dataBase = new DataBase(new Factory());
        }

    }
}
