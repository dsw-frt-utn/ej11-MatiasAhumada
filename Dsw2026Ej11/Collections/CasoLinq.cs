namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();

    public Libro GetPrimero() => libros.First();

    public Libro GetUltimo() => libros.Last();

    public decimal GetTotalPrecios() => libros.Sum(lib => lib.Precio);

    public decimal GetPromedioPrecios() => libros.Average(lib => lib.Precio);

    public List<Libro> GetListById() => libros.Where(lib => lib.Id > 15).ToList();

    public List<string> GetLibros() => libros.Select(lib => $"{lib.Titulo} - ${lib.Precio:N0}").ToList();

    public Libro GetMayorPrecio() => libros.OrderByDescending(lib => lib.Precio).First();

    public Libro GetMenorPrecio() => libros.OrderBy(lib => lib.Precio).First();

    public List<Libro> GetMayorPromedio() => libros.Where(lib => lib.Precio > GetPromedioPrecios()).ToList();

    public List<Libro> GetOrdenadosDescendente() => libros.OrderByDescending(lib => lib.Titulo).ToList();
}
