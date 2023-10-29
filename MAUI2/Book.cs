using System;
using System.Collections.Generic;
namespace MAUI2
{
    public class Book : Good
    {
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
    }
}
