using System.Collections.Generic;

namespace CV22.Models.Decanat
{
    internal class Group
    {
        public string Name { get; set; }
        public IList<Student> Students { get;set; }
    }
}
