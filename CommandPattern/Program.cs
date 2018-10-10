using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Greeting");
            CommandMenu.Paste paste = new CommandMenu.Paste(doc);
            CommandMenu.Print print = new CommandMenu.Print(doc);

            Document.clipBoard = "Hello, Everyone";
            paste.Execute();
            print.Execute();
            Document.clipBoard = "How you all are doing????";
            paste.Execute();
            print.Execute();
            paste.Undo();
            print.Execute();
            paste.Redo();
            print.Execute();

            print.Redo();
            print.Undo();

            Console.ReadLine();
            Console.WriteLine("Total Commands executed " + paste.Execute.Count());
            Console.ReadLine();

        }
    }
}
