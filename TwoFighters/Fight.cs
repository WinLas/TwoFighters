namespace TwoFighters;

public static class Fight
{
	public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string starter)
	{
		Console.WriteLine("In the red corner: " + fighter1.Name + " and in the blue corner: " + fighter2.Name);
		Console.WriteLine(starter  + " will take the first swing! \r" );
		Console.WriteLine("----------------------------------------------");
		var currentFighter =  fighter1.Name == starter ? fighter1 : fighter2;
		var opponent = currentFighter == fighter1 ? fighter2 : fighter1;

		while (currentFighter.Health > 0 && opponent.Health > 0)
		{
			opponent.TakeDamage(currentFighter.DamagePerAttack);
			Console.WriteLine($"{currentFighter.Name} attacks {opponent.Name}; {opponent.Name} now has {opponent.Health} health. ");

			if (!opponent.IsAlive)
			{
				Console.WriteLine($"{currentFighter.Name} wins the fight!"); break;
			}
			
			(currentFighter, opponent) = (opponent, currentFighter);
		}
		return currentFighter.Name;
	}
}