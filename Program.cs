namespace prov_3_repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SkrivUt(PlusEtt(3));
            SkrivUt(PlusEtt(2));
            SkrivUt(PlusEtt(1));
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
