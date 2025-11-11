class c3
{
  public static void Main()
  {
    double avg;
    int a,b,c,total;
    System.Console.WriteLine("enter 1st subject marks");
    a=int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("enter 2nd subject marks");
    b=int.Parse(System.console.ReadLine());
    System.Console.WriteLine("enter 3rd subject marks");
    c=int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("total");
    total=a+b+c;
    System.Console.WriteLine(total);
    avg=total/3;
    System.Console.WriteLine("average");
    System.Console.WriteLine(avg);
    if(avg>=90)
    {
      System.Console.WriteLine("A grade");
    }
    else if(avg>=80)
    {
      System.Console.WriteLine("B grade");
    }
    else if(avg>=70)
    {
      System.Console.WriteLine("C grade");
    }
    else
    {
      System.Console.WriteLine("fail");
    }
  }
}


output: enter 1st subject marks
90
enter 2nd subject marks
80
enter 3nd subject marks
70
total
240
avg
80
B grade
