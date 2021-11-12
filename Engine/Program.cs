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
            wf.hashtable.Add("TxtName", "123");
            wf.hashtable.Add("Describle", DateTime.Now.Date.ToString());
            
            wf.Start();
            Console.ReadLine();
        }
    }
}
