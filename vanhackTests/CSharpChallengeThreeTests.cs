using vanhack;

namespace vanhackTests
{
    [TestFixture]
    public class CSharpChallengeThreeTests
    {
        CSharpChallengeThree cSharpChallengeThree = new CSharpChallengeThree();

        [Test, Description("five city acronyms")]
        public void FiveCityAcronyms()
        {
            Assert.AreEqual("MNL, TAG, CEB, TAC, BOR", cSharpChallengeThree.FindRoutes(new List<List<string>> { new List<string> { "MNL", "TAG" }, new List<string> { "CEB", "TAC" }, new List<string> { "TAG", "CEB" }, new List<string> { "TAC", "BOR" } }));
        }

        [Test, Description("six full city names")]
        public void SixFullCityNames()
        {
            Assert.AreEqual("Halifax, Montreal, Toronto, Chicago, Winnipeg, Seattle", cSharpChallengeThree.FindRoutes(new List<List<string>> { new List<string> { "Chicago", "Winnipeg" }, new List<string> { "Halifax", "Montreal" }, new List<string> { "Montreal", "Toronto" }, new List<string> { "Toronto", "Chicago" }, new List<string> { "Winnipeg", "Seattle" } }));
        }
    }
}
