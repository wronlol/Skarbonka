using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Skarbonka.Modele
{
    public static class DbContext
    {
        static LiteDatabase _instance;

        public static void Init(string fileNme)
        {
            _instance = new LiteDatabase(fileNme);
        }

        public static LiteDatabase GetInstance()
        {
            return _instance;
        }
    }
}
