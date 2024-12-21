namespace AplicacionDesk
{
    partial class FrmGetArgumentos
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
            dgvDatos = new DataGridView();
            btnCerrar = new Button();
            btnMenu = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRegistrar = new Button();
            btnObtenerToken = new Button();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            lblEntrar = new Label();
            txtToken = new TextBox();
            lblingtoken = new Label();
            txtUrl = new TextBox();
            label1 = new Label();
            btnConsutlar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 119);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(726, 406);
            dgvDatos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1121, 320);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 28;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(886, 320);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(113, 29);
            btnMenu.TabIndex = 27;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(915, 185);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 26;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(886, 127);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 25;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(915, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1121, 230);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(886, 230);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 22;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(1000, 185);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1000, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 20;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(1000, 127);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 19;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(947, 11);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 18;
            lblEntrar.Text = "Credenciales";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(122, 52);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(412, 27);
            txtToken.TabIndex = 32;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(4, 55);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 31;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(122, 16);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(412, 27);
            txtUrl.TabIndex = 30;
            txtUrl.Text = "https://localhost:7140/api/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 29;
            label1.Text = "Ingresa la URL";
            // 
            // btnConsutlar
            // 
            btnConsutlar.Location = new Point(598, 46);
            btnConsutlar.Name = "btnConsutlar";
            btnConsutlar.Size = new Size(94, 29);
            btnConsutlar.TabIndex = 33;
            btnConsutlar.Text = "Buscar";
            btnConsutlar.UseVisualStyleBackColor = true;
            btnConsutlar.Click += btnConsutlar_Click;
            // 
            // FrmGetArgumentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 537);
            Controls.Add(btnConsutlar);
            Controls.Add(txtToken);
            Controls.Add(lblingtoken);
            Controls.Add(txtUrl);
            Controls.Add(label1);
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
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGetArgumentos";
            Text = "FrmGetArgumentos";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnCerrar;
        private Button btnMenu;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRegistrar;
        private Button btnObtenerToken;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtClave;
        private Label lblEntrar;
        private TextBox txtToken;
        private Label lblingtoken;
        private TextBox txtUrl;
        private Label label1;
        private Button btnConsutlar;
    }
}