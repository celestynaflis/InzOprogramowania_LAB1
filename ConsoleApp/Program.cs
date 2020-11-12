using System;
using UtilityLibraries;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prezentacja
{
    class Program
    {
        /// <system>
        /// Uruchamianie serwera
        /// </system>
        static void Main(string[] args)
        {
            /// <system>
            /// Wywołanie metody uruchamiającej serwer
            /// </system>
            MyTcpServer.Server();
        }

    }
}


