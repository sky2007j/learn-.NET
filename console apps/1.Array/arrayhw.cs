class program
{
	public static void Main()
	{
		int []a;
		a=new int[10];
		for(int i=0;i<a.Length;i++)
		{
			a[i]=int.Parse(System.Console.ReadLine());
		}
		int search=int.Parse(System.Console.ReadLine());
		for(int i=0;i<a.Length;i++)
		{
			if(search==a[i])
			{
				System.Console.WriteLine(a[i]);
				break;
			}
			else if(i==a.Length)
			{
				System.Console.WriteLine("element not fount");
			}
		}
	}
}
// this is a homw work program
