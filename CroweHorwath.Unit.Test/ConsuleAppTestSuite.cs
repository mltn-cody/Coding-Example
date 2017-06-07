using System;
using NSubstitute;
using NUnit.Framework;
using Ninject;
using HelloWorld_CroweHorwath;
using System.Threading.Tasks;

namespace CroweHorwath.Unit.Test
{
    [TestFixture]
    public class ConsuleAppTestSuite : BaseTest
    {
        private IWriter _writer;

        [SetUp]
        public void RunBeforeEach() {
            _writer = Substitute.For<IWriter>();
        }

        [Test]
        public async Task WriteToConsole_Direct_Success()
        {
            var writer = await Kernerl.Get<Writer>().Write("Test").ConfigureAwait(false);
            Assert.AreEqual( writer,"Success");
        }
    }
}
