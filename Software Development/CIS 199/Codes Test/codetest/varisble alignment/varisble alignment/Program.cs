using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varisble_alignment
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("{0, 5}", 4);
            WriteLine("{0, 5}", 5);
            WriteLine("{0, -8}{1, 8}", "lee", "mike");
        }
    }
}
