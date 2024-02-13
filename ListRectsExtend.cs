using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sem_Lab1UDP
{
    public static class ListRectsExtend
    {
        public static void AddIfNoIntersects(this List<Rectangle> rectangles,Rectangle rectangleToAdd)
        {
            foreach(var rect in rectangles)
            {
                if (rectangleToAdd.IntersectsWith(rect))
                {
                    return;
                }
            }

            rectangles.Add(rectangleToAdd);
        }
    }
}
