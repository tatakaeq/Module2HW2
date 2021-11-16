using System;
using Module2HW2.Services;

namespace Module2HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new StarterService();
            starter.Run();
        }
    }
}