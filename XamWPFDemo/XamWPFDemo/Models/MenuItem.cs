using System;
using System.Collections.Generic;
using System.Text;

namespace XamWPFDemo.Models
{
    public class MenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
