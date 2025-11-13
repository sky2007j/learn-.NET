class program
{
	public static void Main()
	{
		int [,]x;
		x=new int[2,2];
		for(int i=0;i<x.GetLength(0);i++)
		{
			for(int j=0;j<x.GetLength(1);j++)
			{
				x[i,j]=int.Parse(System.Console.ReadLine());
			}
		}
		for(int i=0;i<x.GetLength(0);i++)
		{
			for(int j=0;j<x.GetLength(1);j++)
			{
				System.Console.Write(x[i,j]);
			}
			
			System.Console.WriteLine();
		}
	}
}

the output of this program is
10  20
30  40
