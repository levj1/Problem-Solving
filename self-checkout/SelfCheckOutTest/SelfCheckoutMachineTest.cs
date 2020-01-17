using NUnit.Framework;
using SelfCheckOut;

namespace Tests
{
    public class Tests
    {
        private SelfCheckoutMachine sut;


        [SetUp]
        public void Setup()
        {
            sut = new SelfCheckoutMachine();
        }

        [Test]
        public void GetTotalPrice_WhenItemIsChip_ExpectTotalToBe200Cents()
        {
            sut.Scan(123);

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void GetTotalPrice_WhenItemIsSalsa_ExpectTotalToBe100Cents()
        {
            sut.Scan(456);

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void GetTotalPrice_WhenItemIsWine_ExpectTotalToBe1000Cents()
        {
            sut.Scan(789);

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(1000));
        }

        [Test]
        public void GetTotalPrice_When2WineAreScanned_ExpectTotalToBe2000Cents()
        {
            sut.Scan(789);
            sut.Scan(789);

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(2000));
        }

        [Test]
        public void GetTotalPrice_WhenItemIsCigarettes_ExpectTotalToBe550Cents()
        {
            sut.Scan(111);

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(550));
        }
        
        [Test]
        public void GetTotalPrice_When2CigarettesAreScanned_ExpectTotalToBe1100Cents()
        {
            sut.Scan(111);
            sut.Scan(111);

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(1100));
        }

        [Test]
        public void GetTotalPrice_WhenItemIsSalsaAndHaveBonusCard_ExpectTotalToBe50Cents()
        {
            sut.Scan(456);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void GetTotalPrice_When2SalsaAreScannedAndHaveBonusCard_ExpectTotalToBe100Cents()
        {
            sut.Scan(456);
            sut.Scan(456);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void GetTotalPrice_When3ChipsAreScannedAndHaveBonusCard_ExpectTotalToBe400Cents()
        {
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(400));
        }

        [Test]
        public void GetTotalPrice_When6ChipsAreScannedAndHaveBonusCard_ExpectTotalToBe800Cents()
        {
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(800));
        }

        [Test]
        public void GetTotalPrice_When4ChipsAreScannedAndHaveBonusCard_ExpectTotalToBe600Cents()
        {
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(600));
        }

        [Test]
        public void GetTotalPrice_When7ChipsAreScannedAndHaveBonusCard_ExpectTotalToBe1000Cents()
        {
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(1000));
        }


        [Test]
        public void GetTotalPrice_WhenCigaretteIsScannedAndHaveBonusCard_ExpectTotalToBe550Cents()
        {
            sut.Scan(111);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(550));
        }


        [Test]
        public void GetTotalPrice_ForSampleScenerio_Expected4050()
        {
            // 5 Chips
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            sut.Scan(123);
            // 3 Salsa
            sut.Scan(456);
            sut.Scan(456);
            sut.Scan(456);
            // 2 Wine
            sut.Scan(789);
            sut.Scan(789);
            // 2 Cigarettes
            sut.Scan(111);
            sut.Scan(111);
            sut.Scan(9999); // 9999 is the bonus card

            var result = sut.GetTotal();

            Assert.That(result, Is.EqualTo(4050));
        }
    }
}