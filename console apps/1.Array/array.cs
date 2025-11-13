class program
{
	public static void Main()
	{
		int []a;
		a=new int[5];
		for(int i=0;i<a.Length;i++)
		{
			a[i]=int.Parse(System.Console.ReadLine());
		}
		for(int i=0;i<a.Length;i++)
		{
			System.Console.WriteLine(a[i]);
		}
	}
}
/*
the output of this program is
10
20
30
40
50
*/
