namespace AplicacionDesk
{
    partial class FrmDepartamento
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
            label5 = new Label();
            lblID = new Label();
            btnPut = new Button();
            btnPost = new Button();
            txtid = new TextBox();
            txtName = new TextBox();
            lblGetAll = new Label();
            txtToken = new TextBox();
            lblingtoken = new Label();
            txtUrl = new TextBox();
            label1 = new Label();
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
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 213);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 79;
            label5.Text = "Ingresa el nombre";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(64, 170);
            lblID.Name = "lblID";
            lblID.Size = new Size(92, 20);
            lblID.TabIndex = 78;
            lblID.Text = "Ingresa el ID";
            // 
            // btnPut
            // 
            btnPut.Location = new Point(215, 265);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(94, 29);
            btnPut.TabIndex = 77;
            btnPut.Text = "Actualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(84, 265);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 76;
            btnPost.Text = "Crear";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(167, 170);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 75;
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 210);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 74;
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(376, 9);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(166, 41);
            lblGetAll.TabIndex = 71;
            lblGetAll.Text = "POS y PUT";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(139, 68);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 70;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(21, 71);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 69;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(139, 32);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 68;
            txtUrl.Text = "https://localhost:7140/api/Departamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 67;
            label1.Text = "Ingresa la URL";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(660, 316);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 66;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(444, 316);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(113, 29);
            btnMenu.TabIndex = 65;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 64;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 129);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 63;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 62;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(679, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 61;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(444, 226);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 60;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(644, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 59;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(644, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 58;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(644, 129);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 57;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(591, 13);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 56;
            lblEntrar.Text = "Credenciales";
            // 
            // FrmDepartamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(lblID);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Controls.Add(txtid);
            Controls.Add(txtName);
            Controls.Add(lblGetAll);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDepartamento";
            Text = "FrmDepartamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lblID;
        private Button btnPut;
        private Button btnPost;
        private TextBox txtid;
        private TextBox txtName;
        private Label lblGetAll;
        private TextBox txtToken;
        private Label lblingtoken;
        private TextBox txtUrl;
        private Label label1;
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
    }
}