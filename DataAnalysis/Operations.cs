using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAnalysis
{
    abstract public class Operations
    {
        public Operations()
        {

        }

        abstract public void Initialization();
        abstract public void Do();
    }
}
