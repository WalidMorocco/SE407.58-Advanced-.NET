using System;
using BlockBuster;

namespace BlockBusterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = BlockBusterBasicFunctions.GetAllMovies();
            var oh = new OutputHelper();
            oh.WriteToCSV(b);
        }
    }
}
