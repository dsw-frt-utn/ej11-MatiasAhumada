namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();

    public void Agregar(Alumno alumno) => alumnos.Add(alumno);

    public List<Alumno> ObtenerLista() => alumnos;

    public Alumno? BuscarPorNombre(string nombre) => alumnos.Find(alu => alu.Nombre == nombre);

    public void Eliminar(Alumno alumno) => alumnos.Remove(alumno);

    public void EliminarEnPosicion(int posicion) => alumnos.RemoveAt(posicion);
}
