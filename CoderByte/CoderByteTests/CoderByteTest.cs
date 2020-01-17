using NUnit.Framework;
using System;
using CoderByteNetCore;

namespace CoderByteTests
{
    public class CoderByteTest
    {
        private CoderByte sut;
        [SetUp]
        public void SetUp()
        {
            sut = new CoderByte();
        }

        [Test]
        public void TimeConvert_When0Minute_Expect0()
        {
            var result = sut.TimeConvert(0);

            Assert.That(result, Is.EqualTo("0:0"));
        }

        [Test]
        public void TimeConvert_When61Minutes_Expect1()
        {
            var result = sut.TimeConvert(61);

            Assert.That(result, Is.EqualTo("1:1"));
        }

        [Test]
        public void TimeConvert_When45Minutes_Expect045()
        {
            var result = sut.TimeConvert(45);

            Assert.That(result, Is.EqualTo("0:45"));
        }
    }
}
