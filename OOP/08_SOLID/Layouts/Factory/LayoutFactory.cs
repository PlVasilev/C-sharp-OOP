using System;
using System.Collections.Generic;
using System.Text;
using SOLIDLab.Layouts.Contracts;
using SOLIDLab.Layouts.Factory.Contracts;

namespace SOLIDLab.Layouts.Factory
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default: throw new ArgumentException("Invalid Layout type!");
            }
        }
    }
}
