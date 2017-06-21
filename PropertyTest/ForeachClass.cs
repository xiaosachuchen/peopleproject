using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    class ForeachClass
    {
        public static void ForeachClassProperties<T>(T model,string type)
        {
            Type t = model.GetType();
            PropertyInfo[] PropertyList = t.GetProperties();
            List<string> keys = new List<string>();
            List<object> values = new List<object>();
            foreach (PropertyInfo item in PropertyList)
            {
                string name = item.Name;
                object value = item.GetValue(model, null);
                object[] Attribute = item.GetCustomAttributes(typeof(MarkAttribute), false);
                if (Attribute.Count() == 0)
                {
                    keys.Add("@" + name);
                    if (value is string)
                    {
                        values.Add((string)value);
                    }
                    else if (value is int)
                    {
                        values.Add(value);
                    }
                }
            }
            switch (type)
            {
                case "update":
                    
                    break;
                case "insert":
                    break;
            }
            Console.WriteLine(string.Format("insert into {0} ({1}) values ({2})",t.Name, string.Join(",", keys.ToArray()).Replace("@",""), string.Join(",", keys.ToArray())));
        }
    }
}
