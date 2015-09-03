using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace baiyLogin
{
    class Json
    {
        public string encode(Object ob)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(ob);
        }

    }
}
