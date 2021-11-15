using CloudCore;
namespace Task.WriteTxt
{
    public class HashtableHandler: IHashtableHandler
    {
        ITask task;
        public HashtableHandler(ITask task)
        {
            try {
                this.task = task;
            }
            catch {
                throw;
            }
        }
        public void WritToHashtable(string key,string value)
        {
            if (!task.hashtable.Contains(key)) {
                task.hashtable.Add(key, value);
            }else {
                task.HashtableKeyHaveExists(key);
            }
        }
    }
}
