using System;
using System.Collections.Generic;
using System.Text;

namespace Engine09CollectionHierarchy.Interfaces
{
    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        IReadOnlyCollection<T> Used { get; }
    }
}
