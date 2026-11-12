namespace prov_3_repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkrivUt(3);
            SkrivUt(14);
            SkrivUt(24);
            Console.WriteLine();
            
            Console.WriteLine(PlusEtt(3));
            Console.WriteLine(PlusEtt(2));
            Console.WriteLine(PlusEtt(1));
        }


        static void SkrivUt(int tal)
        {
            Console.WriteLine(tal);
        }

        static int PlusEtt(int tal)
        {
            return tal + 1;
        }
    }
}
