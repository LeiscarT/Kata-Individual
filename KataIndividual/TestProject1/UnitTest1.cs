using NUnit.Framework;
using KataIndividual;

namespace TestProject1
{
    public class Tests
    {
      
        [Test]
        public void textTransform_stringIsEmpty_throw()
        {
            TextTransform result = new TextTransform();
            Assert.That(() => result.convertToCame(null), Throws.ArgumentNullException);
         
        }


        [Test]
        public void textTransform_stringhasTittleCase_isEqual()
        {
            TextTransform result = new TextTransform();
            string expect = "hola Mundo";
            string input = "Hola Mundo";
            string transform = result.convertToCame(input);
            Assert.AreEqual(expect, transform);

        }

        [Test]
        public void textTransform_stringhaslowerCase_isEqual()
        {
            TextTransform result = new TextTransform();
            string expect = "hola Mundo";
            string input = "hola mundo";

            string transform = result.convertToCame(input);
            Assert.AreEqual(expect, transform);

        }


        [Test]
        public void textTransform_stringhasDifferentCase_isEqual()
        {
            TextTransform result = new TextTransform();
            string expect = "hola Mundo";
            string input = "HoLa MundO";

            string transform = result.convertToCame(input);

            Assert.AreEqual(expect, transform);

        }

    }
}