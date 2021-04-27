using System;
using System.Reflection;
using System.Runtime.Loader;

namespace ALCPrinter
{
    public class Printer
    {
        public static void PrintALC()
        {
            Console.WriteLine(AssemblyLoadContext.GetLoadContext(Assembly.GetExecutingAssembly()));
        }
    }
}
