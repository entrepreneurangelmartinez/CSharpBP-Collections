using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class MiClaseGenerica<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }
        public MiClaseGenerica()
        {

        }
        public MiClaseGenerica(T result, string message):this()
        {
            this.Result = result;
            this.Message = message;
        }

    }
}
