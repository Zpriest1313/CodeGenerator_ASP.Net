using System;
namespace Csharp{
    public class Boys : Person, ITalk{
        
        public override void HelloConsole()
        {    
            Console.WriteLine("hello this is boys group");
        }
       public void ISpeech(){
        Console.WriteLine("ITalk on Boys");
       }
        
    }
}