namespace TwoFighters;

public static class Fight
{
	public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string starter)
	{
		fighter2.TakeDamage(fighter1.DamagePerAttack);
        
		if (fighter2.Health > 0) return fighter2.Name;
        
		return starter;
	}
}