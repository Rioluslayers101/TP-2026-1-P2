using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class RutinaTests
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista()
        {
            //Arrenge
            Rutina rutina = new Rutina("Basica", 50);
            Ejercicio ejercicio = new Ejercicio("Sentadilla", 15,3,60);
            Ejercicio ejercicio2 = new Ejercicio("Lagartijas", 10, 5, 30);
            //Act
            rutina.AgregarEjercicio(ejercicio);
            rutina.AgregarEjercicio(ejercicio2);
            //Assert

            Assert.NotEmpty(rutina.ObtenerEjercicios());

        }
    }
}
