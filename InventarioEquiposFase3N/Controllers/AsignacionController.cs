using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Controllers
{
    public class AsignacionController
    {
        private readonly RepositorioAsignaciones _repositorioAsignacion;

        public AsignacionController(RepositorioAsignaciones repositorio)
        {
            _repositorioAsignacion = repositorio;
        }

        public BindingList<Asignacion> ObtenerTodos()
        {
            return _repositorioAsignacion.ObtenerTodos();
        }

        public void Agregar(Asignacion asignacion)
        {
            if (asignacion == null)
            {
                throw new ArgumentNullException("La asignación no puede ser nula");
            }
            _repositorioAsignacion.Agregar(asignacion);
        }

        public void Actualizar(Asignacion original, Asignacion copia)
        {
            if (original == null || copia == null)
            {
                throw new ArgumentNullException("Los datos de la asignación no pueden estar vacíos");
            }

            var respaldo = new Asignacion
            {
                Equipo = original.Equipo,
                Empleado = original.Empleado,
                FechaAsignacion = original.FechaAsignacion,
                FechaDevolucion = original.FechaDevolucion,
                Observacion = original.Observacion
            };
            copiarPropiedades(copia, original);
            try
            {
                _repositorioAsignacion.Actualizar(original);

            }
            catch (Exception ex)
            {
                copiarPropiedades(respaldo, original);
                throw new Exception("Error al actualizar la asignación: " + ex.Message);

            }
        }
        public void Eliminar(Asignacion asignacion)
        {
            if (asignacion == null)
            {
                throw new ArgumentNullException("La asignación no puede ser nula");
            }
            _repositorioAsignacion.Eliminar(asignacion);
        }

        private static void copiarPropiedades(Asignacion original, Asignacion copia)
        {
            original.Empleado = copia.Empleado;
            original.Equipo = copia.Equipo;
            original.FechaAsignacion = copia.FechaAsignacion;
            original.FechaDevolucion = copia.FechaDevolucion;
            original.Observacion = copia.Observacion;
        }

    }
}
