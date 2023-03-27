using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Part2
{
    public abstract class Drawing : iPen, iPencil
    {
        public bool color;
        public abstract string WhichStyle();
        public virtual void HowLong() { }
    }

    public interface iPen
    {
        
    }

    public interface iPencil
    {
        
    }

    public class Sketching: Drawing, iPencil, iPen
    {
        public override string WhichStyle() { return WhichStyle(); }
        public override void HowLong() { }
    }

    public class Coloring : Drawing, iPencil, iPen
    {
        public override string WhichStyle() { return WhichStyle(); }
        public override void HowLong() { }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Coloring coloring = new Coloring();
            Sketching sketching = new Sketching();

            StartDrawing(coloring);
            StartDrawing(sketching);
        }

        static void StartDrawing(object obj)
        {
            if(obj is Coloring)
            {
                Coloring coloring = (Coloring)obj;
                coloring.HowLong();
                coloring.WhichStyle();
            }
            else if(obj is Sketching)
            {
                Sketching sketching = (Sketching)obj;
                sketching.HowLong();
                sketching.WhichStyle();
            }
        }
    }
}
