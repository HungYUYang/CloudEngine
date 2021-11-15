using System;
using System.Collections;
using System.Reflection;


namespace CloudCore
{
    public class Workflow
    {
        public Workflow()
        {
            this.hashtable = new Hashtable();
        }
        public Hashtable hashtable { get; set; }
        public void Start()
        {
            string dllpath = hashtable["dllpath"].ToString();
            string SlnName = hashtable["SlnName"].ToString();
            string TaskName = hashtable["TaskName"].ToString();

            Assembly oa = Assembly.LoadFile(dllpath + SlnName + ".dll");
            Type t = oa.GetType(SlnName + "." + TaskName);
            var task = (Task)Activator.CreateInstance(t);
            foreach(DictionaryEntry item in hashtable) {
                task.hashtable.Add(item.Key, item.Value);
            }
            task.Run();

            if (task.hashtable.Contains("Error")) {
                hashtable.Add("Error", task.hashtable["Error"].ToString());
            }

        }
    }
}
