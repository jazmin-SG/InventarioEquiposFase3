using InventarioEquiposFase3N.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioEmpleados : IRepositorio<Empleado>
    {
        private readonly BindingList<Empleado> _empleados = new BindingList<Empleado>();
        private int _siguienteId = 1;
        public void Agregar(Empleado entidad)
        {
            if(ExisteDui(entidad.Dui))
            {
                throw new ArgumentException("Ya existe un empleado con el mismo DUI");
            }

            entidad.Id = _siguienteId++;
            _empleados.Add(entidad);
        }
        public void Actualizar(Empleado entidad) 
        {
            var empleadoOriginal = _empleados.FirstOrDefault(e => e.Id == entidad.Id);
            if (empleadoOriginal != null)
            {
                empleadoOriginal.Dui = entidad.Dui;
                empleadoOriginal.Nombre = entidad.Nombre;
                empleadoOriginal.Apellido = entidad.Apellido;
                empleadoOriginal.Cargo = entidad.Cargo;
                empleadoOriginal.Departamento = entidad.Departamento;
                empleadoOriginal.Correo = entidad.Correo;
            }
            else 
            {
                throw new KeyNotFoundException("No se ha encontrado el empleado");
            }
        }
        public void Eliminar(Empleado entidad) 
        {
            _empleados.Remove(entidad);
        }
        public BindingList<Empleado> ObtenerTodos() 
        {
            return _empleados;
        }
        public BindingList<Empleado> BuscarTexto(string busqueda) 
        {
            if (string.IsNullOrWhiteSpace(busqueda)) 
            {
                return _empleados;
            }

            var textoMinuscula = busqueda.ToLower();
            var filtrar = _empleados.Where(e =>
            e.Nombre.ToLower().Contains(textoMinuscula) ||
            e.Apellido.ToLower().Contains(textoMinuscula) ||
            e.Dui.ToLower().Contains(textoMinuscula)).ToList();

            return new BindingList<Empleado>(filtrar);
        }

        public bool ExisteDui(string dui, Empleado? excluir = null) 
        {
            return _empleados.Any(e => e.Dui == dui && (excluir == null || e.Id != excluir.Id));
        }
    }
}
