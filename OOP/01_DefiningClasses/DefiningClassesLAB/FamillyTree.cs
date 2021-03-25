using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class FamillyTree
    {
        public FamilyMember ThePeson { get; set; }
        public List<FamilyMember> Parents { get; set; } = new List<FamilyMember>();
        public List<FamilyMember> Cildren { get; set; } = new List<FamilyMember>();

        public FamillyTree(FamilyMember thePerson, FamilyMember parent, FamilyMember child)
        {
            ThePeson = thePerson;
            Parents.Add(parent);
            Cildren.Add(child);
        }
    }
}
