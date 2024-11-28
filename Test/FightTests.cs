using FluentAssertions;
using TwoFighters;

namespace Test;

public class FightTests
{
    [Theory(DisplayName = "Fighter A should be able to win")]
    [InlineData(1, 1, 1, 1, "Lew", "Lew")]
    [InlineData(1, 1, 1, 1, "Harry", "Harry")]
    [InlineData(1, 1, 2, 1, "Lew", "Harry")]
    [InlineData(4, 1, 4, 1, "Lew", "Lew")]
    public void DeclareWinner_When_ShouldReturnTheWinner(int fighterHealthA, int fighterDamageA, int fighterHealthB, int fighterDamageB, string startingFighter, string expectedWinner)
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