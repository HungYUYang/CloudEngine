using System.Collections;

namespace CloudCore
{
    public interface ITask
    {
        Hashtable hashtable { get; }
        void Run();
        void HashtableKeyHaveExists(string key);
    }
}
