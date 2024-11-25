using FluentAssertions;
using TwoFighters;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "Fighter should have a name")]
    public void FighterShouldHaveAName()
    {
        var fighter = new Fighter();
        fighter.Name = "Lew";
        
        fighter.Name.Should().Be("Lew");
    }
}