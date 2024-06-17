using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class TestsLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            Assert.Pass();
        }
    }
}