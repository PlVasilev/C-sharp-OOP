using System;
using System.Collections.Generic;
using System.Text;

namespace ExFroggy
{
   public class Lake
   {
       private List<Stone> stones;

       public Lake()
       {
           stones = new List<Stone>();
       }

       public void AddStone(Stone stone)
       {
            stones.Add(stone);
       }

       public List<Stone> Jump()
       {
            List<Stone> result = new List<Stone>();

           for (int i = 0; i < stones.Count; i+=2)
           {
               result.Add(stones[i]);
           }

           if (stones.Count % 2 == 0) 
           {
               for (int i = stones.Count - 1; i >= 0; i-=2)
               {
                   result.Add(stones[i]);
               }
           }
           else
           {
               for (int i = stones.Count - 2; i >= 0; i -= 2)
               {
                   result.Add(stones[i]);
               }

            }

           return result;
       }
   }
}
