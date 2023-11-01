using System;
using System.Collections;
using System.Text;

namespace myApp
{
    public static class Program{
        public static void Main(string[] args){
         
       /*  int a =5;
        int b= 5;
        int flag= a>b ? 1 : a<b ? -1: 0 ;
        Console.WriteLine(flag); */

        
       /*  string? fname=Console.ReadLine();
        string? lname =Console.ReadLine();
        Console.WriteLine($"{fname} {lname}"); */
        
        
       /*  var i =2;
        var j =2;
        var c = i/j;
        var d = i%j;
        var e = $"{c}.{d}";
        Console.WriteLine(e);
 */     
 
        /* string? switch_on=Console.ReadLine();
        switch (switch_on)
        {
            case "a":
                Console.WriteLine($"{switch_on}");
                break;
            case "b":
                Console.WriteLine($"{switch_on}");
                break;
            default:
            Console.WriteLine("unexpected");
            break;
        } */
        
        /* var x =1;
        var y =2;
        var z =3;
        var tupleN = (x,y,z);

        switch (tupleN)
        {
            case (1,2,3):
            //                Console.WriteLine($"case {(int)(x)} {(int)(y)} {(int)(z)}");
                Console.WriteLine("Correct");
                break;
            case (1,2,2):
                Console.WriteLine("Incorrect");
                break;
            default:
                Console.WriteLine("unexpected");
                break;
        } */
        
        
        /* int t = 1;
        float v= 1.2f;
        Console.WriteLine(t+v); */

       /*  Console.WriteLine("Please enter your name");
        string? inputName = Console.ReadLine();
        Console.WriteLine("Please enter your last name");
        string? inputLastName = Console.ReadLine();
        Console.WriteLine($"{inputName} {inputLastName}");
 */     
 
 
        /* 
        string person="testP1";
        string person2="testP2";
        string person3="testP3";
        ArrayList arrayList = new ArrayList();
        arrayList.Add(person);
        arrayList.Add(person2);
        arrayList.Add(person3);
        
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.RemoveAt(0);
        Console.WriteLine("-------------------");
        Console.WriteLine(arrayList[0]);
        Console.WriteLine("-------------------");
        Console.WriteLine(arrayList.Count);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }


        object?[] people = arrayList.ToArray();
        
        foreach (var item in people)
        {
            Console.WriteLine(item);
        }

 */     
        /* static string writeName(string name){
            return name;
        }
        
        Console.WriteLine(writeName("TestName")); */
       
       /*  Console.WriteLine("Please enter first number");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine(num+num2);   */
       
       
        /* Console.WriteLine("Please enter first number");
        string? num = Console.ReadLine();
        Console.WriteLine("Please enter second number");
        string? num2 = Console.ReadLine();
        
        Console.WriteLine(Convert.ToDouble(num)+Convert.ToDouble(num2));     */ 

        /* int i = 0;
        string s = "123";
        i =int.Parse(s);
        i = Convert.ToInt32(s);
        Console.WriteLine(i.GetType()); */


    
        /* Random rand = new Random();
        int rndNum= rand.Next(100);
        //Console.WriteLine(rndNum);
        while(true){
            int i=0;
            Console.WriteLine("Please enter a number");
            string? s= Console.ReadLine();
            i= Convert.ToInt32(s);
            if(rndNum==i){
                Console.WriteLine("WELL DONE, YOU GUESS THE RIGHT NUMBER");
                break;
            }
            else if(rndNum<i){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("Higher");
            }
        } */



        /* int number=99;
        Console.WriteLine($"number is :{number}");
        Add(ref number,5);
        Console.WriteLine($"number is :{number}");
        static int  Add(ref int i,int j) {
            i=40;
            return i + j;
        } */

        
       /*  string sentence ="My name is test sentence";
        var sentenceCloned = sentence.Clone();
        sentence = "Changed to see whether cloned sentence changes or not";
        Console.WriteLine(sentenceCloned.GetType());
        Console.WriteLine(sentenceCloned);
        //Test sentence is not change because it has new ref value 
        Console.WriteLine(sentence.IndexOf(" "));
        Console.WriteLine(sentence.LastIndexOf(" "));
        string subString = sentence.Substring(0,7);
         Console.WriteLine(subString);
        Console.WriteLine(sentence);
        //sentence=sentence.Replace(" ","");
        Console.WriteLine(sentence); 
        subString=sentence.Remove(10,4);
        Console.WriteLine(subString); */

        /* Customer person = new Customer{
           Id=1,
           Name="Thomas", //this provide by setters if person.Id used then getters is used
           City="Magnesia",
           LastName="Chandler" 
        } ;
        Console.WriteLine(person.Name);
        Console.WriteLine("------------");
        Console.WriteLine(person.City);
        
        PeopleList pList = new PeopleList();
        pList.Add(new Customer()); */

        LogManager logging = new LogManager(new FileLogger());
        logging.Add();

        ExtendedClass test= new ExtendedClass(212321321,23);
        test.Add();
        }

    }

        class TestClass{
            private int _password { get; set; } 
            private int _id { get; set; }

            public TestClass(int password, int id)
            {
                _password = password;
                _id = id;
            }
            public void testFunction(){
                Console.WriteLine(_password+" "+_id);
            }
        }

        class ExtendedClass : TestClass{
           
            
            public ExtendedClass(int pass,int idNum) : base (pass, idNum){
                        
            }

            public void Add(){
                Console.WriteLine("Added");
                testFunction();
            }
        }

        class LogManager{
            public ILogger? _logger { get; set; }

            public LogManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()
            {
                Console.WriteLine("Added");
                _logger?.Log();
            }
        }
        interface ILogger
        {
            public void Log();
        }

        class DbLogger : ILogger
        {
        public void Log()
            {
            Console.WriteLine("Logged Db");
            }
        }
        class FileLogger : ILogger
        {
        public void Log()
             {
            Console.WriteLine("Logged File");
             }
            }


    /*   class Classes{
          string Name { get; set; }
          int Id { get; set; }
          int Age { get; set; }
          public Classes(string Name, int Id, int Age)
          { 
            this.Name = Name;
            this.Id = Id;
            this.Age = Age;  
          }
      }
      class Database{
          public virtual void Connect(){
              Console.WriteLine("Connected");
          }
      }
      class MySql : Database{


      public override void Connect()
      {
          Console.WriteLine("Connected TO MySql");
      }
  }    */

    //protected modifiers can bu used with inherited classes but private variables not

    //InClass props 
    /*  class Customer:IPerson {
         public int Id { get; set; }
         public string? Name { get; set; }
         public string? LastName { get; set; }
         public string? City { get; set; }

         public void Add(){
             Console.WriteLine("Customer added");
         }
         public void Update(){
             Console.WriteLine("Customer updated");

         }
         public void Delete(){
             Console.WriteLine("Customer deleted");

         }

     }
     class Manager:IPerson {
         public int Id { get; set; }
         public string? Name { get; set; }
         public string? LastName { get; set; }
         public string? City { get; set; }

         public void Add(){
             Console.WriteLine("Manager added");
         }
         public void Update(){
             Console.WriteLine("Manager updated");

         }
         public void Delete(){
             Console.WriteLine("Manager deleted");

         }

     }
     interface IPerson
     {
         int Id { get; set; }
         string? Name { get; set; }
         string? LastName { get; set; }

         void Add();
         void Update();
         void Delete();
     }

     class PeopleList{
         public void Add(IPerson person){
             person.Add();
         }
     }
      */

    // A class can get multiple interfaces but not a parent class it can have only one parent class!!!
}