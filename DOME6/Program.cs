using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;
using Crunchy.Lunch;

namespace DOME
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DOMElement_GrammarDefinition.GenerateDOM(CmdUtilities.CreateConfiguration<DOMESettings>(args));
            }
            catch (DOMESyntaxException ex)
            {
                Console.WriteLine("A syntax error occured:");
                Console.WriteLine(ex.GetMessage());
            }
        }
    }
}