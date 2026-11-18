using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N;

public partial class frmDepartamentos : Form
{
    private readonly DepartamentoController controlador;
    private readonly ToolStripTextBox filtro = new() { Name = "txtBuscar", ToolTipText = "Buscar por código o nombre" };

    public frmDepartamentos(DepartamentoController controlador)
    {
        InitializeComponent();
        this.controlador = controlador;
        toolStrip1.Items.Add(new ToolStripSeparator());
        toolStrip1.Items.Add(new ToolStripLabel("Buscar"));
        toolStrip1.Items.Add(filtro);
        dtgDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dtgDepartamentos.MultiSelect = false;
        filtro.TextChanged += (_, _) => Refrescar();
        toolBtnNuevoDepartamento.Click += Nuevo;
        toolBtnEditarDepartamento.Click += Editar;
        toolBtnEliminarDepartamento.Click += Eliminar;
        btnSalir.Click += (_, _) => Close();
        Refrescar();
    }

    private Departamento? Seleccionado => dtgDepartamentos.CurrentRow?.DataBoundItem as Departamento;

    private void Refrescar()
    {
        var datos = controlador.Consultar(filtro.Text);
        dtgDepartamentos.DataSource = datos;
        dtgDepartamentos.Columns[nameof(Departamento.Codigo)]!.HeaderText = "Código";
        toolBtnEditarDepartamento.Enabled = toolBtnEliminarDepartamento.Enabled = datos.Count > 0;
    }

    private void Nuevo(object? sender, EventArgs e)
    {
        using var modal = new frmDepartamentoModal(controlador);
        if (modal.ShowDialog(this) == DialogResult.OK)
        {
            filtro.Text = string.Empty;
            Refrescar();
        }
    }

    private void Editar(object? sender, EventArgs e)
    {
        if (Seleccionado is not Departamento d) return;
        using var modal = new frmEditarDepartamentos(controlador, d.Codigo);
        if (modal.ShowDialog(this) == DialogResult.OK) Refrescar();
    }

    private void Eliminar(object? sender, EventArgs e)
    {
        if (Seleccionado is not Departamento d) return;
        if (MessageBox.Show(this, $"¿Eliminar el departamento {d.Codigo} ({d.Nombre})?",
            "Departamentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        try
        {
            controlador.Eliminar(d.Codigo);
            Refrescar();
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidOperationException or InvalidDataException)
        {
            MessageBox.Show(this, ex.Message, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
