using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicio;

Console.WriteLine("Sistema de Gestión de Gimnasio");

// Crear usuario
Console.WriteLine("Ingresa el nombre del usuario:");
string nombreUsuario = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad del usuario:");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (Fuerza, Resistencia, Musculo, etc):");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear entrenador
Console.WriteLine("Ingresa el nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador:");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

// Crear rutina
Console.WriteLine("Ingresa el nombre de la rutina:");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duración de la rutina:");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina
Console.WriteLine("¿Cuántos ejercicios deseas agregar a la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");
int contadorEjercicios = 0;

while (numEjercicios > 0)
{
    contadorEjercicios++;
    Console.WriteLine($"Ejercicio: #{contadorEjercicios}");
    Console.WriteLine("Ingresa el nombre del ejercicio:");
    string nombreEjercicio = Console.ReadLine() ?? "";

    Console.WriteLine("Ingresa la cantidad de repeticiones:");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Numero de series:");
    int series = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Tiempo de descanso (en segundos):");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);
    numEjercicios--;
}

//Asignar rutina y entrenador
AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen
Console.WriteLine($"Resumen de asignación del usuario: {usuario.Nombre}");
Console.WriteLine($"Objetivo: {usuario.Objetivo}, Rutina: {usuario.RutinaAsignada.Nombre}, Duracion {usuario.RutinaAsignada.Duracion}");

Console.WriteLine("Ejercicios:");
foreach (Ejercicio e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre}|{e.Series}X{e.Repeticiones}| Descanso: {e.Descanso}");
}
Console.WriteLine($"Entrenador asignado: {entrenador.Nombre}, Especialidad: {entrenador.Especialidad}");