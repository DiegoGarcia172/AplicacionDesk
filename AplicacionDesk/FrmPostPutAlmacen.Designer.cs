namespace AplicacionDesk
{
    partial class FrmPostPutAlmacen
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
            txtUrl = new TextBox();
            label1 = new Label();
            lblGetAll = new Label();
            txtOrden = new TextBox();
            txtIdProducto = new TextBox();
            txtName = new TextBox();
            txtid = new TextBox();
            btnPost = new Button();
            btnPut = new Button();
            lblID = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(651, 316);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 39;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(435, 316);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(113, 29);
            btnMenu.TabIndex = 38;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 37;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 129);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 36;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 35;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(670, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 34;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(435, 226);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 33;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(635, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(635, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 31;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(635, 129);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 30;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(582, 13);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 29;
            lblEntrar.Text = "Credenciales";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(130, 68);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 44;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(12, 71);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 43;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(130, 32);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 41;
            txtUrl.Text = "https://localhost:7140/api/Almacen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 40;
            label1.Text = "Ingresa la URL";
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(367, 9);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(166, 41);
            lblGetAll.TabIndex = 45;
            lblGetAll.Text = "POS y PUT";
            // 
            // txtOrden
            // 
            txtOrden.Location = new Point(158, 301);
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(125, 27);
            txtOrden.TabIndex = 46;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(158, 255);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 47;
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 210);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 48;
            // 
            // txtid
            // 
            txtid.Location = new Point(158, 170);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 49;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(101, 360);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 50;
            btnPost.Text = "Crear";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // btnPut
            // 
            btnPut.Location = new Point(239, 360);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(94, 29);
            btnPut.TabIndex = 51;
            btnPut.Text = "Actualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(55, 170);
            lblID.Name = "lblID";
            lblID.Size = new Size(92, 20);
            lblID.TabIndex = 52;
            lblID.Text = "Ingresa el ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 213);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 53;
            label5.Text = "Ingresa el nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 258);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 54;
            label6.Text = "Ingresa el IDProducto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 301);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 55;
            label7.Text = "Ingresa el id Orden";
            // 
            // FrmPostPutAlmacen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblID);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Controls.Add(txtid);
            Controls.Add(txtName);
            Controls.Add(txtIdProducto);
            Controls.Add(txtOrden);
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
            Name = "FrmPostPutAlmacen";
            Text = "FrmPostPutAlmacen";
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
        private TextBox txtUrl;
        private Label label1;
        private Label lblGetAll;
        private TextBox txtOrden;
        private TextBox txtIdProducto;
        private TextBox txtName;
        private TextBox txtid;
        private Button btnPost;
        private Button btnPut;
        private Label lblID;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}