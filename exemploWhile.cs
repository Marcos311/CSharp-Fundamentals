using System;
class HelloWorld {
  static void Main() {
    
    int number=int.Parse(Console.ReadLine());
    int count=0;
    
    while(number!=0){
       Console.WriteLine("Enter the number : ");
       number = int.Parse(Console.ReadLine());
       count += number;
    }
    Console.WriteLine("The sum of the number is : " + count);
  }
}