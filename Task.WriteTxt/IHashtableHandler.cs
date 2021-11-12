using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.WriteTxt
{
    public interface IHashtableHandler
    {
        void WritToHashtable(string key, string value);
    }
}
