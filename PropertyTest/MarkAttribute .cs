using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    /// <summary>
    /// 学习属性编程
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class MarkAttribute:Attribute
    {
        public MarkAttribute(string FiledName, string Description)
        {
            this.FiledName = FiledName;
            this.Description = Description;
        }

        private string _FiledName;
        public string FiledName
        {
            get { return _FiledName; }
            set { _FiledName = value; }
        }
        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
