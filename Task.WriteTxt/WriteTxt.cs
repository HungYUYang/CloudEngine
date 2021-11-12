using System;
using System.Collections;
using System.Linq;
using System.Text;
using CloudCore;

namespace Task.WriteTxt
{
    public class WriteTxt: CloudCore.Task
    {
        public override void Run()
        {
            var _HashtableHandler = GetHashtableHandler();
            var _WriteTxtFileHandler = GetWriteTxtFileHandler();
            _WriteTxtFileHandler.WriteTxt();
        }

        public virtual IHashtableHandler GetHashtableHandler()
        {
            return new HashtableHandler(this);
        }

        public virtual IWriteTxtFileHandler GetWriteTxtFileHandler()
        {
            return new WriteTxtFileHandler(this);
        }
    }

}
