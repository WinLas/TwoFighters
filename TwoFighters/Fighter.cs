namespace TwoFighters;

public class Fighter
{
	public string Name { get; set; }
	public int Health { get; set; }
	public int DamagePerAttack { get; set; }
	public bool IsAlive => Health > 0;

	public void TakeDamage(int damage)
	{
		Health -= damage;
	}
}