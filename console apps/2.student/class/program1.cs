class student 
{
	private int pid;
	private string pname;
	private double price;
	public void read()
	{
		pid=int.Parse(System.Console.ReadLine());
		pname=System.Console.ReadLine();
		price=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine(" {0} {1} {2}",pid,pname,price);
	}
}
class program
{
	public static void Main()
	{
		student s=new student();
		s.read();
		s.print();
	}
}
