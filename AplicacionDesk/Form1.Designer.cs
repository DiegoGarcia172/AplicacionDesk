namespace AplicacionDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUrl = new TextBox();
            btnConsutlar = new Button();
            dgvDatos = new DataGridView();
            lblGetAll = new Label();
            txtToken = new TextBox();
            lblingtoken = new Label();
            lblEntrar = new Label();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            btnObtenerToken = new Button();
            btnRegistrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnMenu = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingresa la URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(130, 40);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(125, 27);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "https://localhost:7140/api/";
            // 
            // btnConsutlar
            // 
            btnConsutlar.Location = new Point(292, 52);
            btnConsutlar.Name = "btnConsutlar";
            btnConsutlar.Size = new Size(94, 29);
            btnConsutlar.TabIndex = 2;
            btnConsutlar.Text = "Buscar";
            btnConsutlar.UseVisualStyleBackColor = true;
            btnConsutlar.Click += btnConsultar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 124);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(809, 502);
            dgvDatos.TabIndex = 3;
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(292, 8);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(132, 41);
            lblGetAll.TabIndex = 4;
            lblGetAll.Text = "GET ALL";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(130, 76);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(125, 27);
            txtToken.TabIndex = 6;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(12, 79);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 5;
            lblingtoken.Text = "Ingresa el token";
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(970, 8);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 7;
            lblEntrar.Text = "Credenciales";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(1023, 124);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1023, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(1023, 182);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 10;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(909, 227);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 11;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1144, 227);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(938, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(909, 124);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 14;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(938, 182);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 15;
            label4.Text = "Correo:";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(909, 317);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(113, 29);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1144, 317);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 638);
            Controls.Add(btnCerrar);
            Controls.Add(btnMenu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegistrar);
            Controls.Add(btnObtenerToken);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(lblEntrar);
            Controls.Add(txtToken);
            Controls.Add(lblingtoken);
            Controls.Add(lblGetAll);
            Controls.Add(dgvDatos);
            Controls.Add(btnConsutlar);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrl;
        private Button btnConsutlar;
        private DataGridView dgvDatos;
        private Label lblGetAll;
        private TextBox txtToken;
        private Label lblingtoken;
        private Label lblEntrar;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Button btnObtenerToken;
        private Button btnRegistrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnMenu;
        private Button btnCerrar;
    }
}
