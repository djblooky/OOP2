using System;

namespace Sprint0
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester test = new Tester();
            test.Test();
        }
    }

    class Tester
    {
        public void Test()
        {
            Console.WriteLine("Flying Vehicle Tester......................................................");
            Console.WriteLine("\nAirlplane.cs...............................................................");
        
            Airplane ap = new Airplane();
            Console.WriteLine(ap.About());

            Console.WriteLine("\nAireplaneTakeOffTests...............................................................");
            Console.WriteLine("\nCall ap.TakeOff():");
            Console.WriteLine(ap.TakeOff());  
                                      
            Console.WriteLine("\nCall ap.StartEngine():");
            ap.StartEngine();
            Console.WriteLine(ap.TakeOff()); 

            //Fly up
            Console.WriteLine("\nFly up Tests...................................................................");
            Console.WriteLine("Call ap.FlyUp() fly to 1,000ft default");
            ap.FlyUp();    
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Fly up to 45,000ft:");
            ap.FlyUp(44000);    //Fly up tp 45,000 ft shouldn't work
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Fly up another 40,000ft shouldn't work");
            ap.FlyUp(40000);    //Fly up tp 41,000 ft shouldn't work
            Console.WriteLine(ap.About());
      
            //Land
            Console.WriteLine("\nFly Down.................................................................");
            Console.WriteLine("Call ap.FlyDown(50000) Fly Down 50,000 ft");
            ap.FlyDown(50000);   //Land by floying down 50,000 ft = Crash and shouldn't work
            Console.WriteLine(ap.About());
            Console.WriteLine("Call ap.FlyDown(ap.CurrentAltitude) this should land");
            ap.FlyDown(ap.CurrentAltitude); //Land by flying down current altitiute
            Console.WriteLine(ap.About());
        }
    }
    }
}
