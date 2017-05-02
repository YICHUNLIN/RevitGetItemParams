using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetItemParams
{
    // 自己定義的 parameter，原生的Parameter太複雜，我只需要名字跟內容
    public  class CusParameter
    {
        private string _defName = "";
        private string _value = "";
      //  private string _id = "";

        // constructor
        public CusParameter(string defName, string value)
        {
            _defName = defName;
            _value = value;
          ///  _id = id;
        }

        // defName getter
        public string DefName
        {
            get
            {
                return _defName;
            }
        }

        // value getter
        public string Value
        {
            get
            {
                return _value;
            }
        }
    }
}
