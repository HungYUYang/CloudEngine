using System.IO;
using CloudCore;
namespace Task.WriteTxt
{
    public class WriteTxtFileHandler:IWriteTxtFileHandler
    {
        ITask task;
        public WriteTxtFileHandler(ITask task)
        {
            try {
                this.task = task;
            }
            catch {
                throw;
            }
        }
        public void WriteTxt()
        {
            string TxtPath = task.hashtable["TxtPath"].ToString();
            string TxtName = task.hashtable["TxtName"].ToString();
            TxtPath= TxtPath + TxtName+".txt";
            File.WriteAllText(TxtPath, task.hashtable["Describle"].ToString());
        }
    }
}
