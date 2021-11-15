using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudCore;
namespace Engine
{
    class Program
    {
        static void Main(string[] args)
        {

            Workflow wf = new Workflow();
            wf.hashtable.Add("dllpath", @"E:\C#\CloudEngine\Engine\Engine\bin\x64\DLL\");
            wf.hashtable.Add("SlnName", "Task.WriteTxt");
            wf.hashtable.Add("TaskName", "WriteTxt");
            wf.hashtable.Add("TxtPath", @"E:\C#\CloudEngine\Engine\Engine\bin\x64\DLL\");
            wf.hashtable.Add("Describle", DateTime.Now.Date.ToString());
            // TxtName測試重複key值用
            //wf.hashtable.Add("TxtName", "123");
            wf.Start();
            if (wf.hashtable.Contains("Error")) {
                Console.WriteLine("HashTable have error key: {0}", wf.hashtable["Error"].ToString());
            }else {
                Console.WriteLine("HashTable have not error key.");
            }
            Console.WriteLine("Enter any key to exit.");
            Console.ReadLine();

           
        }
    }
}
