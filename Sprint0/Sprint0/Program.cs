using System;

namespace Sprint0
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester test = new Tester();
            test.Test();

            Console.ReadLine();
        }
    }

    class Tester
    {
        public void Test()
        {
            Console.WriteLine("Flying Vehicle Tester......................................................");
            Console.WriteLine("\nAirplane.cs...............................................................");
        
            Airplane ap = new Airplane();
            Console.WriteLine(ap.About());

            Console.WriteLine("\nAirplaneTakeOffTests...............................................................");
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
            Console.WriteLine("\nCall ap.FlyUp(40000) Fly up another 40,000ft should work");
            ap.FlyUp(40000);    //Fly up tp 41,000 ft should work
            Console.WriteLine(ap.About());
      
            //Land
            Console.WriteLine("\nFly Down.................................................................");
            Console.WriteLine("Call ap.FlyDown(50000) Fly Down 50,000 ft");
            ap.FlyDown(50000);   
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyDown(ap.CurrentAltitude) this should land");
            ap.FlyDown(ap.CurrentAltitude); 
            Console.WriteLine(ap.About());

            Console.WriteLine("\nToy plane tests.................................................................");

            ToyPlane tp = new ToyPlane();
            Console.WriteLine(tp.About());

            Console.WriteLine("\nToyPlane TakeOffTests...............................................................");
            Console.WriteLine("\nCall tp.TakeOff():"); //engine not started and not wound, wont take off
            Console.WriteLine(tp.TakeOff());

            Console.WriteLine("\nCall tp.WindUp():"); //engine not started, wont take off
            tp.WindUp();
            Console.WriteLine(tp.TakeOff());

            Console.WriteLine("\nCall tp.StartEngine():"); //will take off
            tp.StartEngine();
            Console.WriteLine(tp.TakeOff());


            //Fly up
            Console.WriteLine("\nFly up Tests...................................................................");
            Console.WriteLine("Call tp.FlyUp() fly to 10ft default");
            tp.FlyUp();
            Console.WriteLine(tp.About());
            Console.WriteLine("\nCall tp.FlyUp(44) Fly up to 54ft:");
            tp.FlyUp(44);    
            Console.WriteLine(tp.About());
            Console.WriteLine("\nCall ap.FlyUp(40) Fly up another 40ft should work");
            tp.FlyUp(40);    
            Console.WriteLine(tp.About());

            //Land
            Console.WriteLine("\nFly Down.................................................................");
            Console.WriteLine("Call tp.FlyDown(60) Fly Down 60 ft");
            tp.FlyDown(60);   
            Console.WriteLine(tp.About());
            Console.WriteLine("\nCall tp.FlyDown(tp.CurrentAltitude) this should land");
            tp.FlyDown(tp.CurrentAltitude); 
            Console.WriteLine(tp.About());
        }
    }
    
}
