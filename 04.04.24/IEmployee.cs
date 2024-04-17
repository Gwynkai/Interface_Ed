using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04._04._24.Classes;

namespace _04._04._24
{
    public interface IEmployee
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Post {  get; set; }

        public bool Appeared { get; set; }

        public void AppearanceCheck();
    }
}
