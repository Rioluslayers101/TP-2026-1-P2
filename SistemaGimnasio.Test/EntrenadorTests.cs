using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class EntrenadorTests
    {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            //Arrenge
            Usuario usuario = new Usuario("Ana", 20, "Resistencia");
            Entrenador entrenador = new Entrenador("Carlos", "Cardio");
            //Act
            entrenador.AsignarUsuario(usuario);
            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
