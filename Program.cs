using System;

public class Main

{

	public static void Mai(string[] args)

	{

		

		while (hasNext())

		{

			string boards = nextLine();

			boards = " " + boards;

			double[] c = new double[boards.Length];



			c[0] = 0;

			for (int i = 1; i < boards.Length; i++)

			{

				c[i] = 2000000000;

				if (boards[i] == '.')
				{

					c[i] = c[i - 1];
				}

				else
				{

					for (int j = 0; j < i; j++)
					{

						c[i] = Math.Min(c[i], c[j] + Math.Sqrt(1.0 * i - j));
					}
				}

			}



			Console.WriteLine(c[boards.Length - 1]);

		}

	}

    private static string nextLine()
    {
        throw new NotImplementedException();
    }

    private static bool hasNext()
    {
        throw new NotImplementedException();
    }
}
