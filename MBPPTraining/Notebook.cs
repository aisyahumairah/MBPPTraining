using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPPTraining
{
    class Notebook : Book
    {
        public override void Dispose()
        {
            Console.WriteLine("Tear");
            Console.WriteLine("Recycle");
        }
    }
}
