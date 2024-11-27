namespace TwoFighters;

public static class Fight
{
	public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string starter)
	{
		var currentFighter =  fighter1.Name == starter ? fighter1 : fighter2;
		var opponent = currentFighter == fighter1 ? fighter2 : fighter1;

		while (currentFighter.Health > 0 && opponent.Health > 0)
		{
			opponent.TakeDamage(currentFighter.DamagePerAttack);
			Console.WriteLine($"{currentFighter.Name} attacks {opponent.Name}; {opponent.Name} now has {opponent.Health} health");
			
			if (!opponent.IsAlive) break;
			
			(currentFighter, opponent) = (opponent, currentFighter);
		}
		
		return currentFighter.Name;
	}
}