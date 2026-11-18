using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;

namespace InventarioEquiposFase3N.Controllers;

public class DepartamentoController(RepositorioDepartamentos repositorio)
{
    public List<Departamento> Consultar(string filtro = "")
    {
        filtro = filtro.Trim();
        return repositorio.ObtenerTodos()
            .Where(d => d.Codigo.Contains(filtro, StringComparison.OrdinalIgnoreCase)
                     || d.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase))
            .OrderBy(d => d.Nombre, StringComparer.CurrentCultureIgnoreCase)
            .ThenBy(d => d.Codigo, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public void Agregar(string codigo, string nombre) =>
        repositorio.Agregar(new Departamento { Codigo = codigo.Trim(), Nombre = nombre.Trim() });

    public void Actualizar(string codigo, string nombre) =>
        repositorio.Actualizar(new Departamento { Codigo = codigo, Nombre = nombre.Trim() });

    public void Eliminar(string codigo)
    {
        var departamento = repositorio.BuscarPorCodigo(codigo)
            ?? throw new InvalidOperationException("El departamento ya no existe.");
        repositorio.Eliminar(departamento);
    }
}
