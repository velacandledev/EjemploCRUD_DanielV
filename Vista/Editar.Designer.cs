namespace Vista
{
    partial class Editar
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
            btnGuardar = new Button();
            txtFecha = new DateTimePicker();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(332, 363);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(332, 289);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(300, 31);
            txtFecha.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(332, 234);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(300, 31);
            txtPrecio.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(332, 179);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 34);
            txtDescripcion.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(332, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 31);
            txtNombre.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 289);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 12;
            label4.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 234);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 11;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 179);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 10;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 122);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 59);
            label5.Name = "label5";
            label5.Size = new Size(28, 25);
            label5.TabIndex = 18;
            label5.Text = "Id";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(396, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 19;
            lblId.Text = "Id";
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblId);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(txtFecha);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Editar";
            Text = "Editar";
            Load += Editar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private DateTimePicker txtFecha;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label lblId;
    }
}