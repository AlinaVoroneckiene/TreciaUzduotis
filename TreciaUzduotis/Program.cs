namespace TreciaUzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students stud = new Students("Alina", 19, 60);
            //Console.WriteLine(stud.Weight);
            //stud.PrintBasicInfo();

            BoyToys toy1 = new BoyToys(2, 10, "Bear", 15, "Teddy", 12.99);
            toy1.PrintToScreen();

            if(!toy1.IsExpensive())
            {
                Console.WriteLine("This is a rather cheap toy.");
            }
            else
            {
                Console.WriteLine($"You are ready to spend {toy1.Price} on your son`s toy... This is rather an expensive bear.");
            }
            

        }
    }
}