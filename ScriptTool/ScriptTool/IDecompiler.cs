﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptTool
{
    interface IDecompiler
    {
        string ReadString(byte[] rom, int address, int endAddress, bool basicMode);
    }
}
