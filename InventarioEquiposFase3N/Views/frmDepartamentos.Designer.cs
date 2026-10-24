
namespace InventarioEquiposFase3N
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoDepartamento = new ToolStripButton();
            toolBtnEditarDepartamento = new ToolStripButton();
            toolBtnEliminarDepartamento = new ToolStripButton();
            dtgDepartamentos = new DataGridView();
            btnSalir = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDepartamentos).BeginInit();
            SuspendLayout();

            //
            // toolStrip1
            //
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoDepartamento, toolBtnEditarDepartamento, toolBtnEliminarDepartamento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(899, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";

            //
            // toolBtnNuevoDepartamento
            //
            toolBtnNuevoDepartamento.Image = Properties.Resources.plus;
            toolBtnNuevoDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoDepartamento.Name = "toolBtnNuevoDepartamento";
            toolBtnNuevoDepartamento.Size = new Size(76, 24);
            toolBtnNuevoDepartamento.Tag = "";
            toolBtnNuevoDepartamento.Text = "Nuevo";

            //
            // toolBtnEditarDepartamento
            //
            toolBtnEditarDepartamento.Image = Properties.Resources.boton_editar;
            toolBtnEditarDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnEditarDepartamento.Name = "toolBtnEditarDepartamento";
            toolBtnEditarDepartamento.Size = new Size(72, 24);
            toolBtnEditarDepartamento.Text = "Editar";

            //
            // toolBtnEliminarDepartamento
            //
            toolBtnEliminarDepartamento.Image = (Image)resources.GetObject("toolBtnEliminarDepartamento.Image");
            toolBtnEliminarDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarDepartamento.Name = "toolBtnEliminarDepartamento";
            toolBtnEliminarDepartamento.Size = new Size(87, 24);
            toolBtnEliminarDepartamento.Text = "Eliminar";

            //
            // dtgDepartamentos
            //
            dtgDepartamentos.AllowUserToAddRows = false;
            dtgDepartamentos.AllowUserToDeleteRows = false;
            dtgDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDepartamentos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDepartamentos.EnableHeadersVisualStyles = false;
            dtgDepartamentos.Location = new Point(0, 27);
            dtgDepartamentos.Name = "dtgDepartamentos";
            dtgDepartamentos.ReadOnly = true;
            dtgDepartamentos.RowHeadersWidth = 51;
            dtgDepartamentos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgDepartamentos.Size = new Size(892, 194);
            dtgDepartamentos.TabIndex = 1;

            //
            // btnSalir
            //
            btnSalir.Location = new Point(764, 230);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;

            //
            // frmDepartamentos
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(899, 271);
            Controls.Add(btnSalir);
            Controls.Add(dtgDepartamentos);
            Controls.Add(toolStrip1);
            Location = new Point(0, 39);
            Name = "frmDepartamentos";
            Text = "Departamentos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDepartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoDepartamento;
        private ToolStripButton toolBtnEditarDepartamento;
        private ToolStripButton toolBtnEliminarDepartamento;
        private DataGridView dtgDepartamentos;
        private Button btnSalir;
    }
}
