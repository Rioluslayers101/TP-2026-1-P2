using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Servicio
{
  public class AsignadorRutinas
{
    public void AsignarRutinaUsuario(Usuario usuario,Rutina rutina)
    {
        usuario.AsignarRutina(rutina);
        }
        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador)
        {
            entrenador.AsignarUsuario(usuario);
        }
}
}