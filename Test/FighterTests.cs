﻿using FluentAssertions;
using TwoFighters;

namespace Test;

public class FighterTests
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
}