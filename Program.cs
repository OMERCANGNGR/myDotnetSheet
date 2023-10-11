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

        
        
        }
    }
}