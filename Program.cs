namespace class_0317_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test std1, std2;

            std1 = new Test();
            std2 = new Test();

            std1.mid = 78;
            std1.SetFinal(72);

            std2.SetGrade(68, 84);

            Console.WriteLine(std1.GetAvg().ToString());
            Console.WriteLine(std2.GetAvg().ToString());
        }
    }
}
