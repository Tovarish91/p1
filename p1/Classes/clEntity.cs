﻿using p1.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1.Classes
{
    internal class clEntity
    {
        public static Entities Context { get; } = new Entities();
    }
}