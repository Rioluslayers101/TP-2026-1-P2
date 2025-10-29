using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestor
{
    public class GestorRutinas
    {
        private List<Rutina> rutinas;
        public GestorRutinas()
        {
            rutinas = new List<Rutina>();
        }

        public void CrearRutina(string nombre, int duracion)
        {
            rutinas.Add(new Rutina(nombre, duracion));
        }

        public Rutina BuscarUsuario(string nombre)
        {
            return  rutinas.FirstOrDefault(u => u.Nombre == nombre);
        }
    }
}
