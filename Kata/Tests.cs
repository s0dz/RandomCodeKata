using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual(3, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, Kata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, Kata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }

        [Test]
        public void KataTests()
        {
            Assert.AreEqual(0, Kata.DuplicateCount(""));
            Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }

        [Test]
        public void TestCases()
        {
            Assert.AreEqual(Kata.is_valid_IP("12.255.56.1"), true);
            Assert.AreEqual(Kata.is_valid_IP(""), false);
            Assert.AreEqual(Kata.is_valid_IP("abc.def.ghi.jkl"), false);
            Assert.AreEqual(Kata.is_valid_IP("123.456.789.0"), false);
            Assert.AreEqual(Kata.is_valid_IP("12.34.56"), false);
            Assert.AreEqual(Kata.is_valid_IP("12.34.56 .1"), false);
            Assert.AreEqual(Kata.is_valid_IP("12.34.56.-1"), false);
            Assert.AreEqual(Kata.is_valid_IP("123.045.067.089"), false);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", Kata.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("R L", Kata.SongDecoder("RWUBWUBWUBLWUB"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("WE ARE THE CHAMPIONS MY FRIEND", Kata.SongDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB"));
        }


    }
}