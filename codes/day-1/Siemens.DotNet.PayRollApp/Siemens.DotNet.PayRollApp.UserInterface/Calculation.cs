﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.DotNet.PayRollApp.UserInterface
{
    internal class Calculation
    {
        public void Add(int x, int y) => Console.WriteLine(x + y);
        public void Add(int x, int y, int z) => Console.WriteLine(x + y + z);
        public void Add(int x, long y, int z) => Console.WriteLine(x + y + z);
        public void Add(int x, int y, long z) => Console.WriteLine(x + y + z);
    }
}
