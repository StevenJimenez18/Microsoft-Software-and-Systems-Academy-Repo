using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
namespace Module11Demo
{
    class DynamicClass : IDisposable
    {
        private dynamic word, doc;

        //Destructor - non deterministic
         ~DynamicClass()
        {
            word = null;
            doc = null;
            Console.WriteLine("Disposed in destructor!");
            
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            doc = null;
            word = null;
            Console.WriteLine("Objects Disposed!");
        }

        public void InvokeWord()
        {
            try
            {
                word = new Application { Visible = false };

                doc = word.Documents.Add();
                doc.Activate();
                var currentLocation = word.ActiveDocument.Range(word.ActiveDocument.Content.End - 1);
                currentLocation.InsertAfter("Hello there. \n");
                currentLocation.InsertAfter("General Kenobi.");
                currentLocation.Save();
                currentLocation.Close();
                Console.WriteLine("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
