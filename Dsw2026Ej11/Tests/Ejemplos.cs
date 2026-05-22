using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var casoList = new CasoList();
        casoList.Agregar(new Alumno(1, "Juan", 8.5));
        casoList.Agregar(new Alumno(2, "María", 9.0));
        casoList.Agregar(new Alumno(3, "Pedro", 7.5));

        Console.WriteLine("Lista de alumnos:");
        foreach (var alumno in casoList.ObtenerLista())
            Console.WriteLine(alumno);

        Console.WriteLine("\nBuscar 'María':");
        var encontrado = casoList.BuscarPorNombre("María");
        Console.WriteLine(encontrado);

        Console.WriteLine("\nBuscar 'Carlos':");
        var noEncontrado = casoList.BuscarPorNombre("Carlos");
        Console.WriteLine(noEncontrado == null ? "No existe" : noEncontrado.ToString());

        Console.WriteLine("\nEliminar a María:");
        casoList.Eliminar(encontrado);
        foreach (var alumno in casoList.ObtenerLista())
            Console.WriteLine(alumno);

        Console.WriteLine("\nEliminar primer elemento:");
        casoList.EliminarEnPosicion(0);
        foreach (var alumno in casoList.ObtenerLista())
            Console.WriteLine(alumno);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDictionary = new CasoDictionary();
        casoDictionary.Agregar(new Alumno(101, "Ana", 8.0));
        casoDictionary.Agregar(new Alumno(102, "Luis", 7.8));
        casoDictionary.Agregar(new Alumno(103, "Sofia", 9.2));

        Console.WriteLine("Diccionario de alumnos:");
        foreach (var kvp in casoDictionary.ObtenerDiccionario())
            Console.WriteLine(kvp.Value);

        Console.WriteLine("\nBuscar legajo 102:");
        var encontrado = casoDictionary.BuscarPorClave(102);
        Console.WriteLine(encontrado);

        Console.WriteLine("\nBuscar legajo 999:");
        var noEncontrado = casoDictionary.BuscarPorClave(999);
        Console.WriteLine(noEncontrado == null ? "No existe" : noEncontrado.ToString());

        Console.WriteLine("\nEliminar legajo 101:");
        casoDictionary.EliminarPorClave(101);
        foreach (var kvp in casoDictionary.ObtenerDiccionario())
            Console.WriteLine(kvp.Value);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();

        Console.WriteLine("1. Primer libro:");
        Console.WriteLine($"{casoLinq.GetPrimero().Titulo}\n");

        Console.WriteLine("2. Último libro:");
        Console.WriteLine($"{casoLinq.GetUltimo().Titulo}\n");

        Console.WriteLine("3. Total de precios:");
        Console.WriteLine($"${casoLinq.GetTotalPrecios():N0}\n");

        Console.WriteLine("4. Promedio de precios:");
        Console.WriteLine($"${casoLinq.GetPromedioPrecios():N0}\n");

        Console.WriteLine("5. Libros con Id > 15:");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"{libro.Id} - {libro.Titulo}");

        Console.WriteLine("\n6. Libros con formato moneda:");
        foreach (var libro in casoLinq.GetLibros().Take(5))
            Console.WriteLine(libro);
        Console.WriteLine("...\n");

        Console.WriteLine("7. Libro con mayor precio:");
        var mayor = casoLinq.GetMayorPrecio();
        Console.WriteLine($"{mayor.Titulo} - ${mayor.Precio:N0}\n");

        Console.WriteLine("8. Libro con menor precio:");
        var menor = casoLinq.GetMenorPrecio();
        Console.WriteLine($"{menor.Titulo} - ${menor.Precio:N0}\n");

        Console.WriteLine("9. Libros con precio mayor al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"{libro.Titulo} - ${libro.Precio:N0}");

        Console.WriteLine("\n10. Libros ordenados por título (descendente):");
        foreach (var libro in casoLinq.GetOrdenadosDescendente().Take(5))
            Console.WriteLine(libro.Titulo);
        Console.WriteLine("...");
    }
}
