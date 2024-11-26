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

public static class Fight
{
    public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string starter)
    {
        

        return "Lew";
    }
}
