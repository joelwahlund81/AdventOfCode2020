using System;
using System.Collections.Generic;
using System.Text;

namespace day3
{
    public enum Direction
    {
        Horizontal,
        Vertical
    }

   public static class Hill
    {
        public static int GoDown(string[] hillLines)
        {
            int currentPositionX = 0, treesEncountered = 0;

            bool goHorizontal = true;

            for (int i = 0; i < hillLines.Length; i++)
            {
                if (goHorizontal)
                {
                    currentPositionX += 3;
                    // koll att inte X hamnar utanför
                    // .. då indentener vi bara på nästa rad

                }
                else
                {
                    if (currentPositionX == hillLines[i].Length)
                    {
                        currentPositionX = 0;
                    }

                    if (hillLines[i][currentPositionX] == "#".ToCharArray()[0])
                    {
                        treesEncountered += 1;
                    }
                }
               
                goHorizontal = !goHorizontal;
            }

            return treesEncountered;
        }
    }
}
