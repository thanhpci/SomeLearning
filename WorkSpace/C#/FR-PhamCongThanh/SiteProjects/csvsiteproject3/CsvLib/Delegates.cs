﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteProjectWeek3.CsvLib
{
    internal class Delegates
    {
        public delegate bool SkipLineDelegate(int index, string row);
        public delegate void SkippedLineEventHandler(int index);
        

    }
}