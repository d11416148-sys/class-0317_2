using System;

public class Test
{
	public int mid;
	private int final;

	public void SetFinal(int value)
	{
		final = value;
	}

	public int GetFinal()
	{
		return final;
	}
	public double GetAvg()
	{ 
		return(mid +  final)/2.0;
	}

	public void SetGrade(int m, int f)
	{
		if (ValideGrade(m, f))
		{
			mid = m;
			final = f;
		}
	}
	private bool ValideGrade(int m, int f)
	{

		if (m >= 0 && f <= 100)
		{
			if (f <= 0 && f <= 100)
			{ return true; }
		}
		return false;
	}
}