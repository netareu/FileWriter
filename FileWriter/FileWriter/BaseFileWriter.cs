using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter
{
    public abstract class BaseFileWriter
    {
        protected string _path { get; set; }
        public virtual void WriteLine(string line)
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                writer.WriteLine(line);
            }
        }
    }
}
