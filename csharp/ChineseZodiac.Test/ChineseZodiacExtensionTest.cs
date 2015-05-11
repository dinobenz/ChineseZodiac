using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Dinobenz.ChineseZodiac;

namespace ChineseZodiac.Test
{
    [TestFixture]
    public class ChineseZodiacExtensionTest
    {
        [Test]
        public void When_Year_Is_Rat_Should_Return_Rat()
        {
            var actual = new DateTime(2008, 1, 1).ToChineseZodiac();
            Assert.AreEqual("ชวด	", actual);
        }

        [Test]
        public void When_Year_Is_Ox_Should_Return_Ox()
        {
            var actual = new DateTime(2009, 1, 1).ToChineseZodiac();
            Assert.AreEqual("ฉลู", actual);
        }

        [Test]
        public void When_Year_Is_Tiger_Should_Return_Tiger()
        {
            var actual = new DateTime(2010, 1, 1).ToChineseZodiac();
            Assert.AreEqual("ขาล", actual);
        }

        [Test]
        public void When_Year_Is_Rabbit_Should_Return_Rabbit()
        {
            var actual = new DateTime(2011, 1, 1).ToChineseZodiac();
            Assert.AreEqual("เถาะ", actual);
        }

        [Test]
        public void When_Year_Is_Dragon_Should_Return_Dragon()
        {
            var actual = new DateTime(2012, 1, 1).ToChineseZodiac();
            Assert.AreEqual("มะโรง", actual);
        }

        [Test]
        public void When_Year_Is_Snake_Should_Return_Snake()
        {
            var actual = new DateTime(2013, 1, 1).ToChineseZodiac();
            Assert.AreEqual("มะเส็ง", actual);
        }

        [Test]
        public void When_Year_Is_Horse_Should_Return_Horse()
        {
            var actual = new DateTime(2014, 1, 1).ToChineseZodiac();
            Assert.AreEqual("มะเมีย", actual);
        }

        [Test]
        public void When_Year_Is_Goat_Should_Return_Goat()
        {
            var actual = new DateTime(2015, 1, 1).ToChineseZodiac();
            Assert.AreEqual("มะแม", actual);
        }

        [Test]
        public void When_Year_Is_Monkey_Should_Return_Monkey()
        {
            var actual = new DateTime(2016, 1, 1).ToChineseZodiac();
            Assert.AreEqual("วอก", actual);
        }

        [Test]
        public void When_Year_Is_Rooster_Should_Return_Rooster()
        {
            var actual = new DateTime(2017, 1, 1).ToChineseZodiac();
            Assert.AreEqual("ระกา", actual);
        }

        [Test]
        public void When_Year_Is_Dog_Should_Return_Dog()
        {
            var actual = new DateTime(2018, 1, 1).ToChineseZodiac();
            Assert.AreEqual("จอ", actual);
        }

        [Test]
        public void When_Year_Is_Pig_Should_Return_Pig()
        {
            var actual = new DateTime(2019, 1, 1).ToChineseZodiac();
            Assert.AreEqual("กุน", actual);
        }
    }
}
