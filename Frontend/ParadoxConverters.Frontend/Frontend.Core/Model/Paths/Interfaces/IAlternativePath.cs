﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Core.Model.Paths.Interfaces
{
    public interface IAlternativePath
    {
        string Path { get; set; }
        bool Exists { get; }
    }
}