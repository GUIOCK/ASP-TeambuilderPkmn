using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamBuilderPkmn;

namespace TBPUnitTests
{
    [TestClass]
    public class PokemonClassTest
    {
        private readonly Pokemon _pkm;

        public PokemonClassTest()
        {
            _pkm = new Pokemon();
        }

        [TestMethod]
        public void PokemonWithNoNameTest()
        {
            var result = _pkm.Name;
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void PokemonWithNameTest()
        {
            var newPkm = new Pokemon("Carapuce");
            var result = newPkm.Name;
            Assert.AreEqual(result, "Carapuce");
        }

        [TestMethod]
        public void PokemonWNoTypes()
        {
            var type1 = _pkm.Type1.Name;
            var type2 = _pkm.Type2.Name;
            Assert.AreEqual(type1, "none");
            Assert.AreEqual(type2, "none");
        }

        [TestMethod]
        public void GetTypeTest() {
            var result = Type.GetType("water").Name;
            Assert.AreEqual(result, "none");
        }
    }
}
