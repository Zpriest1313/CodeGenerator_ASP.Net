using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Collections;
using System.Timers;
using System.Threading;
namespace Csharp{
  class Program{
    static void Main(string[] args){
      
    }

    
  }
  class Todo{
    public string Description{get;set;}
    public int EstimatedHours{get;set;}
    public Status Status{get;set;}
  }
  enum Status{
    NotStarted,
    InProgress,
    OnHold,
    Completed
  }

 public class Car{
    public string VIN{get;set;}
    public string Make{get;set;}
    public string Model{get;set;}
    public decimal StickerPrice { get; set; }
    public int Year{get;set;}
    

    
   
    public static void myMethod(){
      Console.WriteLine("this is static method");
      
  }
  
  
    
}
}