using System;

namespace Public_library
{
    internal class SQLiteConnection
    {
        private string dpPath;

        public SQLiteConnection(string dpPath)
        {
            this.dpPath = dpPath;
        }

        internal void CreateTable<T>()
        {
            throw new NotImplementedException();
        }

        internal object Delete(Tbl_Books item)
        {
            throw new NotImplementedException();
        }

        internal void Insert(Tbl_Books tbl)
        {
            throw new NotImplementedException();
        }
    }
}