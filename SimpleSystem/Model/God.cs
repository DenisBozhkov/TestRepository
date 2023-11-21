using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class God : BaseModel
    {
        public string Name { get; set; }
        public string Mythology { get; set; }
        public int ChildrenCount { get; set; }
        public bool IsImmortal { get; set; }
        public God(Guid id, string name, string mythology, int childrenCount, bool isImmortal)
        {
            Id = id;
            Name = name;
            Mythology = mythology;
            ChildrenCount = childrenCount;
            IsImmortal = isImmortal;
        }
        public God(string name, string myhtology, int childrenCount, bool isImmortal)
            : this(Guid.NewGuid(), name, myhtology, childrenCount, isImmortal) { }
        public override string ToString()
        {
            return string.Join("|@|", new object[] { Name, Mythology, ChildrenCount, IsImmortal });
        }
    }
}
