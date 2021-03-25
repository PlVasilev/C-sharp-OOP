using System;
using System.Collections.Generic;
using System.Text;

namespace Engine09CollectionHierarchy.Interfaces
{
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        T Remove();
    }
}
