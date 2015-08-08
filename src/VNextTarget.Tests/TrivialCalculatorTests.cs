using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNextTarget.Tests
{
    using NUnit.Framework;

    using VNextTarget.Core;

    [TestFixture]
    public class TrivialCalculatorTests
    {
        [Test]
        public void Add_WhenInputsAreCorrect_ThenAnswerIsProduced()
        {
            var subject = new TrivialCalculator();

            var result = subject.Add(2, 5);

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_WhenInputsAreInvalid_ThenSomethingHappens()
        {
            Assert.Fail("Oh no dear me!");
        }
    }
}
