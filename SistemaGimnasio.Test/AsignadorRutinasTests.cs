﻿using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicio;
namespace SistemaGimnasio.Test
{
    public class AsignadorRutinasTests
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarRutinaCorrectamente()
        {
            //Arrenge
            Usuario usuario = new Usuario("Juan", 15, "Fuerza");
            Rutina rutina = new Rutina("Rutina#1", 90);

            AsignadorRutinas asignador = new AsignadorRutinas();
            //Act
            asignador.AsignarRutinaUsuario(usuario,rutina);
            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]

        public void AsignarUsuarioAEntrenador_DebeIncluirUsuario()
        {
            //Arrenge
            Usuario usuario = new Usuario("Juan", 15, "Fuerza");
            Entrenador entrenador = new Entrenador("Carlos", "Cardio");

            AsignadorRutinas asignador = new AsignadorRutinas();
            //Act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);
            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
