namespace prov_3_repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SkrivUt(PlusEtt(3));
            SkrivUt(PlusEtt(2));
            SkrivUt(PlusEtt(1));
            for (int i = 0; i <= 5; i++)
            {
                SkrivUt(i);
            }

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
