using vanhack;

namespace vanhackTests
{
    [TestFixture]
    public class CSharpChallengeOneTests
    {
        CSharpChallengeOne cSharpChallengeOne = new CSharpChallengeOne();

        [Test, Description("should handle simple inputs")]
        public void ShouldHandleSimpleInputs()
        {
            Assert.AreEqual(new List<List<string>> { new List<string> { "1", "2", "3" }, new List<string> { "4", "5", "6" } }, cSharpChallengeOne.ParseCsv("1,2,3\n4,5,6", ",", "\""));
        }

        [Test, Description("should handle quoted fields")]
        public void ShouldHandleQuotedFields()
        {
            Assert.AreEqual(new List<List<string>> { new List<string> { "1", "two was here", "3" }, new List<string> { "4", "5", "6" } }, cSharpChallengeOne.ParseCsv("1,\"two was here\",3\n4,5,6", ",", "\""));
        }

        [Test, Description("should handle alternate separators")]
        public void ShouldHandleAlternateSeparators()
        {
            Assert.AreEqual(new List<List<string>> { new List<string> { "1", "2", "3" }, new List<string> { "4", "5", "6" } }, cSharpChallengeOne.ParseCsv("1\t2\t3\n4\t5\t6", "\t", "\""));
        }

        [Test, Description("should handle an empty file")]
        public void ShouldHandleAnEmptyFile()
        {
            Assert.AreEqual(new List<List<string>> { new List<string> { "" } }, cSharpChallengeOne.ParseCsv("", ",", "\""));
        }
    }
}
