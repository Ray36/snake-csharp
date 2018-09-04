using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_csharp
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
       
        
        public void Draw()
        {

            Console.SetCursorPosition(p.x, p.y);
            Console.Write(p.sym);
        }
    }
}
