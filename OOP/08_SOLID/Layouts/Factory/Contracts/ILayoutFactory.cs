using System;
using System.Collections.Generic;
using System.Text;
using SOLIDLab.Layouts.Contracts;

namespace SOLIDLab.Layouts.Factory.Contracts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
