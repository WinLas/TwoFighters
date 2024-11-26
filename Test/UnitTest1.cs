using System.Net;
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
    public void FighterShouldHaveHP()
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

    [Fact(DisplayName = "A fighter should win")]
    public void DeclareWinnerShouldReturnTheWinner()
    {
        //arrange
        var fighter1 = new Fighter
        {
            Name = "Lew",
            Health = 5,
            DamagePerAttack = 3
        };

        var fighter2 = new Fighter
        {
            Name = "Harry",
            Health = 1,
            DamagePerAttack = 1
        };

        //act

        var result = Fight.DeclareWinner(fighter1, fighter2, fighter1.Name);

        //assert

        result.Should().Be(fighter1.Name);

    }
    
    [Fact(DisplayName = "A fighter should win")]
    public void DeclareWinner_WhenHarryStarts_ShouldReturnHarryAsWinner()
    {
        //arrange
        var fighter1 = new Fighter
        {
            Name = "Lew",
            Health = 1,
            DamagePerAttack = 1
        };

        var fighter2 = new Fighter
        {
            Name = "Harry",
            Health = 1,
            DamagePerAttack = 1
        };

        //act

        var result = Fight.DeclareWinner(fighter1, fighter2, fighter2.Name);

        //assert

        result.Should().Be(fighter2.Name);
    }
    
}