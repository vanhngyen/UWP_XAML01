using System;

namespace UWPSQLiteDemo
{
    internal class Net
    {
        internal class SQLiteConnection
        {
            public SQLiteConnection(Net.Platform.WinRT.SQLitePlatformWinRT sQLitePlatformWinRT, string path)
            {
            }

            internal object Insert(Customer customer)
            {
                throw new NotImplementedException();
            }

            internal object Table<T>()
            {
                throw new NotImplementedException();
            }

            internal void CreateTable<T>()
            {
                throw new NotImplementedException();
            }
        }

        internal class Platform
        {
            internal class WinRT
            {
                internal class SQLitePlatformWinRT
                {
                    public SQLitePlatformWinRT()
                    {
                    }
                }
            }
        }
    }
}