﻿using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik2.Repository
{
    public class SingletonDB
    {
        private static Database1Entities db = null;

        private SingletonDB() { }

        public static Database1Entities GetInstance()
        {
            if (db == null) db = new Database1Entities();
            return db;
        }
    }
}