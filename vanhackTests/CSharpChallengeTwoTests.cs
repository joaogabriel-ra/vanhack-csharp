using NUnit.Framework;
using vanhack;

namespace vanhackTests
{
    [TestFixture]
    public class CSharpChallengeTwoTests
    {
        CSharpChallengeTwo cSharpChallengeTwo = new CSharpChallengeTwo();

        [Test, Description("should handle the example")]
        public void ShouldHandleTheExample()
        {
            Assert.AreEqual("100 180 90 56 65 74 68 86 99", cSharpChallengeTwo.OrderWeight("56 65 74 100 99 68 86 180 90"));
        }
    }
}