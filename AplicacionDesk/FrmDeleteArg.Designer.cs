namespace AplicacionDesk
{
    partial class FrmDeleteArg
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
            lblGetAll = new Label();
            btnConsutlar = new Button();
            txtUrl = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(226, 436);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 28;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(10, 436);
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
            label4.Location = new Point(125, 307);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 26;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 249);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 25;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 195);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(245, 346);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(10, 346);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 22;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(210, 307);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 192);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 20;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(210, 249);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 19;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(157, 133);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 18;
            lblEntrar.Text = "Credenciales";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(118, 86);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 34;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(0, 89);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 33;
            lblingtoken.Text = "Ingresa el token";
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(118, 6);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(149, 41);
            lblGetAll.TabIndex = 32;
            lblGetAll.Text = "Delete ID";
            // 
            // btnConsutlar
            // 
            btnConsutlar.Location = new Point(57, 127);
            btnConsutlar.Name = "btnConsutlar";
            btnConsutlar.Size = new Size(94, 29);
            btnConsutlar.TabIndex = 31;
            btnConsutlar.Text = "Buscar";
            btnConsutlar.UseVisualStyleBackColor = true;
            btnConsutlar.Click += btnConsutlar_Click_1;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(118, 50);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 30;
            txtUrl.Text = "https://localhost:7140/api/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 53);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 29;
            label1.Text = "Ingresa la URL";
            // 
            // txtID
            // 
            txtID.Location = new Point(10, 162);
            txtID.Name = "txtID";
            txtID.Size = new Size(67, 27);
            txtID.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 139);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 36;
            label5.Text = "ID";
            // 
            // FrmDeleteArg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 475);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(txtToken);
            Controls.Add(lblingtoken);
            Controls.Add(lblGetAll);
            Controls.Add(btnConsutlar);
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
            Name = "FrmDeleteArg";
            Text = "FrmDeleteArg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label lblGetAll;
        private Button btnConsutlar;
        private TextBox txtUrl;
        private Label label1;
        private TextBox txtID;
        private Label label5;
    }
}