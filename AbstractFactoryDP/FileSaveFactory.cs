﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class FileSaveFactory : IFileSaveFactory
    {
        public IFileSave SaveFile()
        {
            return new FileSave();
        }
    }
}
