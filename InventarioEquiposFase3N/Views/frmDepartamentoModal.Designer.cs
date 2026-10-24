
namespace InventarioEquiposFase3N
{
    partial class frmDepartamentoModal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();

            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";

            //
            // txtCodigo
            //
            txtCodigo.Location = new Point(87, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;

            //
            // txtNombre
            //
            txtNombre.Location = new Point(87, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;

            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";

            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(23, 135);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;

            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(154, 135);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;

            //
            // frmDepartamentoModal
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(332, 180);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDepartamentoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Departamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label2;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
