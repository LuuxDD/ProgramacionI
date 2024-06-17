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
        public async Task TestObtenerLibros()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libros= await librosRepository.ObtenerLibrosAsync();

            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public async Task TestAgregarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libros = await librosRepository.AgregarAsync("LibroTest", "AutoTest", "Editorial est","PortadaTest", "GeneroTest");

            Assert.That(libros.nombre, Is.Not.EqualTo("LibroTest"));
        }
    }


    }
}