using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CommandMenu
    {
       public abstract class ICommand
        {
          public  Invoker Execute, Undo, Redo;
        }

       public class Paste : ICommand
        {
            public Paste(Document doc)
            {
                Execute = delegate { Execute.Log(); doc.Paste(); };
                Undo = delegate { Undo.Log(); doc.Restore(); };
                Redo = delegate { Redo.Log(); doc.Paste(); };
            }
        }

        public class Print : ICommand
        {
            public Print(Document doc)
            {
                Execute = delegate { Execute.Log(); doc.Print(); };
                Undo = delegate { Undo.Log(); Console.WriteLine("This action cannot be Undone"); };
                Redo = delegate { Redo.Log(); doc.Print(); };
            }
        }

        
    }

    public class Document
    {
        string name, oldPage, page;
       public static string clipBoard;

        public Document(string name)
        {
            this.name = name;
        }

        public void Paste()
        {
            oldPage = page;
            page += clipBoard + "\n";
        }
        public void Restore()
        {
            page = oldPage;
        }
        public void Print()
        {
            Console.WriteLine("File " + name + " at " + DateTime.Now.ToString());
            Console.WriteLine(page);
        }
    }
}
