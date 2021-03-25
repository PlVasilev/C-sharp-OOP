using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Rectangle
    {
        public string Id { get; set; }
        public Point TopLeft { get; set; }
        public Point BotRight { get; set; }

        public Rectangle(string id, Point topLeft,Point botRight)
        {
            Id = id;
            TopLeft = topLeft;
            BotRight = botRight;
        }        
    }
}
