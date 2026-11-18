using InventarioEquiposFase3N.Controllers;

namespace InventarioEquiposFase3N;

public partial class frmDepartamentoModal : Form
{
    private readonly DepartamentoController controlador;

    public frmDepartamentoModal(DepartamentoController controlador)
    {
        InitializeComponent();
        this.controlador = controlador;
        Text = "Nuevo departamento";
        AcceptButton = btnGuardar;
        CancelButton = btnCancelar;
        btnGuardar.DialogResult = DialogResult.None;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnGuardar.Click += Guardar;
    }

    private void Guardar(object? sender, EventArgs e)
    {
        try
        {
            controlador.Agregar(txtCodigo.Text, txtNombre.Text);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException or IOException or InvalidDataException or UnauthorizedAccessException)
        {
            MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
