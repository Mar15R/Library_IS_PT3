using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Library_IS.Lib
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public  bool IsSuccess => ErrorMessage==null;
        public string InnerExceptionMessage { get; set; }
    }
}