using System.Collections;

namespace CloudCore
{
    public abstract class Task:ITask
    {
        public Task()
        {
            this._hashtable = new Hashtable();
        }
        Hashtable _hashtable;

        public abstract void Run();

        public Hashtable hashtable {
            get {
                return _hashtable;
            }
            set {
                if (_hashtable == null) {
                    _hashtable = value;
                }
            }
        }

        public void HashtableKeyHaveExists(string key)
        {
           
            _hashtable.Add("Error", "The key[" + key + "] have exists");
        }

    }
}
