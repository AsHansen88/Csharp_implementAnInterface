using System.Diagnostics.Contracts;

public class Program
{
    public static void Main(string[] args)
    {
        Sinatra sinatra = new Sinatra();
        Console.WriteLine($"Tonight featuring {sinatra.GetName()}"); // 1) Use getName
        

        
        sinatra.Talk();
        // 2) Uncomment this
        sinatra.Sing();
        
        ISinger s = new Sinatra(); // 3) Assign New Sinatra instead of null
        Console.WriteLine($"The singer is {s.GetName()}");
        s.Sing();

    }

    interface ISinger
    {
        String GetName();
        void Sing();

    }

    class Sinatra : ISinger// implement the interface
    {
        // Provide the interface implementation

        public void Talk()
        {

            Console.WriteLine("Good evening Las Vegas");
        }

        public string GetName(){
            Console.WriteLine();

            return "Anders";
        }

        public void Sing(){
            Console.WriteLine("Fly with me");
        }

        string ISinger.GetName()
        {
            throw new NotImplementedException();
        }
    }
}