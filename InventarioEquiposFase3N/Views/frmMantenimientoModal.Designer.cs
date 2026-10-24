
namespace InventarioEquiposFase3N
{
    partial class frmMantenimientoModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbEquipo = new ComboBox();
            label2 = new Label();
            radPreventivo = new RadioButton();
            radCorrectivo = new RadioButton();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtResponsable = new TextBox();
            txtCosto = new TextBox();
            label6 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(29, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Equipo";
            //
            // cmbEquipo
            //
            cmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Items.AddRange(new object[] { "Computadora", "Impresora", "Monitor", "Teclado", "Mouse", "Otro" });
            cmbEquipo.Location = new Point(242, 15);
            cmbEquipo.Margin = new Padding(4, 4, 4, 4);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(188, 33);
            cmbEquipo.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(29, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 2;
            label2.Text = "Tipo de mantenimiento";
            //
            // radPreventivo
            //
            radPreventivo.AutoSize = true;
            radPreventivo.Location = new Point(242, 58);
            radPreventivo.Margin = new Padding(4, 4, 4, 4);
            radPreventivo.Name = "radPreventivo";
            radPreventivo.Size = new Size(120, 29);
            radPreventivo.TabIndex = 3;
            radPreventivo.Text = "Preventivo";
            radPreventivo.UseVisualStyleBackColor = true;
            //
            // radCorrectivo
            //
            radCorrectivo.AutoSize = true;
            radCorrectivo.Location = new Point(374, 58);
            radCorrectivo.Margin = new Padding(4, 4, 4, 4);
            radCorrectivo.Name = "radCorrectivo";
            radCorrectivo.Size = new Size(118, 29);
            radCorrectivo.TabIndex = 4;
            radCorrectivo.Text = "Correctivo";
            radCorrectivo.UseVisualStyleBackColor = true;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(40, 101);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            //
            // dtpFecha
            //
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(242, 95);
            dtpFecha.Margin = new Padding(4, 4, 4, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(312, 31);
            dtpFecha.TabIndex = 6;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(40, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            //
            // txtDescripcion
            //
            txtDescripcion.Location = new Point(242, 136);
            txtDescripcion.Margin = new Padding(4, 4, 4, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(312, 123);
            txtDescripcion.TabIndex = 8;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(29, 276);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 9;
            label5.Text = "Tecnico Responsable";
            //
            // txtResponsable
            //
            txtResponsable.Location = new Point(242, 268);
            txtResponsable.Margin = new Padding(4, 4, 4, 4);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(155, 31);
            txtResponsable.TabIndex = 10;
            //
            // txtCosto
            //
            txtCosto.Location = new Point(242, 309);
            txtCosto.Margin = new Padding(4, 4, 4, 4);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(155, 31);
            txtCosto.TabIndex = 11;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(51, 318);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 12;
            label6.Text = "Costo";
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(92, 400);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 36);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(331, 400);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 36);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            //
            // frmMantenimientoModal
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(596, 451);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(txtCosto);
            Controls.Add(txtResponsable);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(radCorrectivo);
            Controls.Add(radPreventivo);
            Controls.Add(label2);
            Controls.Add(cmbEquipo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMantenimientoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar Mantenimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbEquipo;
        private Label label2;
        private RadioButton radPreventivo;
        private RadioButton radCorrectivo;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtResponsable;
        private TextBox txtCosto;
        private Label label6;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
