using FluentAssertions;
using TwoFighters;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "Fighter should have a name")]
    public void FighterShouldHaveAName()
    {
        // arrange
        var fighter = new Fighter();
        
        // act
        fighter.Name = "Lew";
        
        // assert
        fighter.Name.Should().Be("Lew");
    }
    
    [Fact(DisplayName = "Fighter should have hp")]
    public void FighterShouldHaveHp()
    {
        // arrange
        var fighter = new Fighter();
        
        // act
        fighter.Health = 1;
        
        // assert
        fighter.Health.Should().Be(1);
    }
    
    [Fact(DisplayName = "Fighter should have damage per attack")]
    public void FighterShouldHaveDamagePerAttack()
    {
        // arrange
        var fighter = new Fighter();
        
        // act
        fighter.DamagePerAttack = 1;
        
        // assert
        fighter.DamagePerAttack.Should().Be(1);
    }

    [Fact(DisplayName = "Fighter should be able to take damage")]
    public void FighterShouldTakeDamage()
    {
        // arrange
        var fighter = new Fighter();
        fighter.Health = 1;

        // act
        fighter.TakeDamage(1);

        // assert
        fighter.Health.Should().Be(0);
    }

    [Theory(DisplayName = "Fighter A should be able to win")]
    [InlineData(1, 1, 1, 1, "Lew", "Lew")]
    [InlineData(1, 1, 1, 1, "Harry", "Harry")]
    [InlineData(1, 1, 2, 1, "Lew", "Harry")]
    [InlineData(4, 1, 4, 1, "Lew", "Lew")]
    public void DeclareWinnerShouldReturnTheWinner(int fighterHealthA, int fighterDamageA, int fighterHealthB, int fighterDamageB, string startingFighter, string expectedWinner)
    {
        //arrange
        var fighterA = new Fighter
        {
            Name = "Lew",
            Health = fighterHealthA,
            DamagePerAttack = fighterDamageA
        };

        var fighterB = new Fighter
        {
            Name = "Harry",
            Health = fighterHealthB,
            DamagePerAttack = fighterDamageB
        };

        //act
        var result = Fight.DeclareWinner(fighterA, fighterB, startingFighter);

        //assert
        result.Should().Be(expectedWinner);
    }
}