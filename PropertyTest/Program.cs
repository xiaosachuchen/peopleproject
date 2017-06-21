using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    class Program
    {
        public class AddressInfo
        {
            public int Id { get; set; }
            public string userName { get; set; }
            public string userTel { get; set; }
            public string Addressdetail { get; set; }
            public int isMoren { get; set; }
            [Mark("notuse", "ignore")]
            public object notuse { get; set; }
            public AddressInfo()
            {
                Id = 1;
                userName = "陈卧龙";
                userTel = "1813707015*";
                Addressdetail = "江苏省苏州市工业园区国际科技园";
                isMoren = 1;
            }
        }
        static void Main(string[] args)
        {
            AddressInfo model = new AddressInfo();
            ForeachClass.ForeachClassProperties<AddressInfo>(model,"update");
            Console.ReadLine();
        }
    }
}
