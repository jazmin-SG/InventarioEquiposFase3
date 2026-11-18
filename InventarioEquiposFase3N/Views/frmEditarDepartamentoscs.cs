using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N;

public partial class frmEditarDepartamentos : Form
{
    private readonly DepartamentoController controlador;

    public frmEditarDepartamentos(DepartamentoController controlador, string codigo)
    {
        InitializeComponent();
        this.controlador = controlador;
        Text = "Editar departamento";
        cbxCodigo.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCodigo.DisplayMember = nameof(Departamento.Codigo);
        cbxCodigo.ValueMember = nameof(Departamento.Codigo);
        cbxCodigo.SelectedIndexChanged += (_, _) =>
            txtDepartamento.Text = (cbxCodigo.SelectedItem as Departamento)?.Nombre ?? "";
        cbxCodigo.DataSource = controlador.Consultar();
        cbxCodigo.SelectedValue = codigo;
        AcceptButton = btnEditar;
        CancelButton = btnCancelar;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnEditar.Click += Guardar;
    }

    private void Guardar(object? sender, EventArgs e)
    {
        if (cbxCodigo.SelectedItem is not Departamento d) return;
        try
        {
            controlador.Actualizar(d.Codigo, txtDepartamento.Text);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException or IOException or InvalidDataException or UnauthorizedAccessException)
        {
            MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
