namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void Agregar(Alumno alumno) => alumnos[alumno.Id] = alumno;

    public Alumno? BuscarPorClave(int legajo) => alumnos.ContainsKey(legajo) ? alumnos[legajo] : null;

    public Dictionary<int, Alumno> ObtenerDiccionario() => alumnos;

    public void EliminarPorClave(int legajo) => alumnos.Remove(legajo);
}
