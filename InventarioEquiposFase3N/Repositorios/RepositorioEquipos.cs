using InventarioEquiposFase3N.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioEquipos:IRepositorio<Equipo>
    {
        private readonly BindingList<Equipo> _equipos = new BindingList<Equipo>();

        public void Actualizar(Equipo entidad)
        {
            var equipoExistente = _equipos.FirstOrDefault(e => e.Codigo == entidad.Codigo);
            if (equipoExistente != null)
            {
               equipoExistente.Marca = entidad.Marca;
                equipoExistente.Modelo = entidad.Modelo;
                equipoExistente.NumeroSerie = entidad.NumeroSerie;
                equipoExistente.TipoEquipo = entidad.TipoEquipo;
                equipoExistente.FechaCompra = entidad.FechaCompra;
                equipoExistente.AnioGarantia = entidad.AnioGarantia;
                equipoExistente.Estado = entidad.Estado;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un equipo con el código {entidad.Codigo}.");
            }
        }

        public void Agregar(Equipo entidad)
        {
           if (Existecodigo(entidad.Codigo))
            {
                throw new InvalidOperationException($"Ya existe un equipo con el código {entidad.Codigo}.");
            }
            _equipos.Add(entidad);
        }

        public void Eliminar(Equipo entidad)
        {
            _equipos.Remove(entidad);
        }

        public BindingList<Equipo> ObtenerTodos()
        {
            return _equipos;
        }
        public bool ExisteNumeroSerie(string numeroSerie)
        {
            return _equipos.Any(e => e.NumeroSerie == numeroSerie);
        }
        
        public bool Existecodigo(string codigo)
        {
            return _equipos.Any(e => e.Codigo == codigo);
        }
        public Equipo? BuscarPorCodigo(string codigo)
        {
            return _equipos.FirstOrDefault(e => e.Codigo == codigo);
        }
    }
}
