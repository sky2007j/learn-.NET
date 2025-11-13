class program
{
	public static void Main()
	{
		int [][]x;
		x=new int[3][];
		x[0]=new int[3];
		x[1]=new int[4];
		x[2]=new int[5];
		for(int i=0;i<x.Length;i++)
		{

			for(int j=0;j<x[i].Length;j++)
			{

				x[i][j]=int.Parse(System.Console.ReadLine());
			}
		}
		for(int i=0;i<x.Length;i++)
		{
			for(int j=0;j<x[i].Length;j++)
			{
				System.Console.Write(x[i][j]);
			}
			System.Console.WriteLine();
		}
	}
}

		
