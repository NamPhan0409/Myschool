using System;

namespace Myschool
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("1","123");
            Console.WriteLine("{0},{1}", st.ID, st.FullName);
        }
    }
}
