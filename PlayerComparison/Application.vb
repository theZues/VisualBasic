

Module PlayerScore


	Function CalculateScore(wOBA, wRC, barrel, oSwing) As Decimal
		Dim sum As Decimal = 0D
		'Summing up stats by weighted percentages
		sum = (wOBA * 0.35D) + (wRC * 0.3D) + (barrel * 0.2D) - (oSwing * 0.15D)
		Return sum
	End Function

	Sub Main()
		Dim wOBA, wRC, barrel, oSwing, sum As Decimal

		'Getting stats from user and parsing to Decimal
		System.Console.WriteLine("Enter wOBA")
		wOBA = Decimal.Parse(System.Console.ReadLine)

		System.Console.WriteLine("Enter wRC+")
		wRC = Decimal.Parse(System.Console.ReadLine)

		System.Console.WriteLine("Enter Barrel")
		barrel = Decimal.Parse(System.Console.ReadLine)

		System.Console.WriteLine("Enter O-Swing")
		oSwing = Decimal.Parse(System.Console.ReadLine)

		sum = CalculateScore(wOBA, wRC, barrel, oSwing)

		System.Console.WriteLine("The score is:  {0}", sum)

		System.Console.ReadLine()


	End Sub


End Module

