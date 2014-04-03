using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestHandler requestHandler;
            var cliente = new Client() { Name = "Smill", LastName="Vásquez"};
            var request = new Request() { Client = cliente, Level = Level.Easy};
            var tecnico = new TechnicalSupport() { Name="Gerald"};
            var manager = new ITManager() { Name = "Miguel"};
            requestHandler = tecnico;
            tecnico.AddToRequestHandler(manager);
            requestHandler.SendToRequestHandler(request);

            Console.ReadKey();
        }
    }
}
