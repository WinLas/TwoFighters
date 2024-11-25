namespace TwoFighters;

public class Kata
{

}

public class Fighter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int DamagePerAttack { get; set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
