using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N.Repositorios;

public class RepositorioDepartamentos : RepositorioBase<Departamento>
{
    public RepositorioDepartamentos(string? ruta = null)
        : base(ruta ?? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "InventarioEquiposFase3N", "Datos", "departamentos.json"))
    {
        if (File.Exists(RutaArchivo))
            Leer();
        else
            Guardar();
    }

    public Departamento? BuscarPorCodigo(string codigo) => _entidades.FirstOrDefault(d =>
        string.Equals(d.Codigo.Trim(), codigo.Trim(), StringComparison.OrdinalIgnoreCase));

    public override void Agregar(Departamento entidad)
    {
        entidad.Validar();
        if (BuscarPorCodigo(entidad.Codigo) != null)
            throw new InvalidOperationException("Ya existe un departamento con ese código.");
        base.Agregar(entidad);
    }

    public override void Actualizar(Departamento entidad)
    {
        entidad.Validar();
        var original = BuscarPorCodigo(entidad.Codigo)
            ?? throw new InvalidOperationException("El departamento ya no existe.");
        var indice = _entidades.IndexOf(original);
        _entidades[indice] = entidad;
        try
        {
            base.Actualizar(entidad);
        }
        catch
        {
            _entidades[indice] = original;
            throw;
        }
    }

    protected override void ValidarDatos(List<Departamento> datos)
    {
        base.ValidarDatos(datos);
        var codigos = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var departamento in datos)
        {
            try
            {
                departamento.Validar();
            }
            catch (ArgumentException ex)
            {
                throw new InvalidDataException("Hay un departamento incompleto en el archivo JSON.", ex);
            }

            if (!codigos.Add(departamento.Codigo.Trim()))
                throw new InvalidDataException("Hay códigos de departamento repetidos en el archivo JSON.");
        }
    }
}
