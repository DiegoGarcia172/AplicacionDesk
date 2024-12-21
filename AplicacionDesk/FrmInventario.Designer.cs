namespace AplicacionDesk
{
    partial class FrmInventario
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
            label6 = new Label();
            label7 = new Label();
            txtIdMateriaPrima = new TextBox();
            txtIdAlmacen = new TextBox();
            label5 = new Label();
            lblID = new Label();
            btnPut = new Button();
            btnPost = new Button();
            txtid = new TextBox();
            txtIdProducto = new TextBox();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 218);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 135;
            label6.Text = "Ingresa el ID Almacen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 185);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 134;
            label7.Text = "Ingresa el ID materiaPrima";
            // 
            // txtIdMateriaPrima
            // 
            txtIdMateriaPrima.Location = new Point(200, 182);
            txtIdMateriaPrima.Name = "txtIdMateriaPrima";
            txtIdMateriaPrima.Size = new Size(125, 27);
            txtIdMateriaPrima.TabIndex = 133;
            // 
            // txtIdAlmacen
            // 
            txtIdAlmacen.Location = new Point(198, 215);
            txtIdAlmacen.Name = "txtIdAlmacen";
            txtIdAlmacen.Size = new Size(125, 27);
            txtIdAlmacen.TabIndex = 132;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 152);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 131;
            label5.Text = "Ingresa el idProducto";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(100, 116);
            lblID.Name = "lblID";
            lblID.Size = new Size(92, 20);
            lblID.TabIndex = 130;
            lblID.Text = "Ingresa el ID";
            // 
            // btnPut
            // 
            btnPut.Location = new Point(229, 278);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(94, 29);
            btnPut.TabIndex = 129;
            btnPut.Text = "Actualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(98, 278);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 128;
            btnPost.Text = "Crear";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(200, 116);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 127;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(200, 149);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 126;
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(362, 4);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(166, 41);
            lblGetAll.TabIndex = 125;
            lblGetAll.Text = "POS y PUT";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(125, 63);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 124;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(7, 66);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 123;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(125, 27);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 122;
            txtUrl.Text = "https://localhost:7140/api/Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 30);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 121;
            label1.Text = "Ingresa la URL";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(646, 311);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 120;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(430, 311);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(113, 29);
            btnMenu.TabIndex = 119;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 182);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 118;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 124);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 117;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(545, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 116;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(665, 221);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 115;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(430, 221);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 114;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(630, 182);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 113;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(630, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 112;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(630, 124);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 111;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(577, 8);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 110;
            lblEntrar.Text = "Credenciales";
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtIdMateriaPrima);
            Controls.Add(txtIdAlmacen);
            Controls.Add(label5);
            Controls.Add(lblID);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Controls.Add(txtid);
            Controls.Add(txtIdProducto);
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
            Name = "FrmInventario";
            Text = "FrmInventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private TextBox txtIdMateriaPrima;
        private TextBox txtIdAlmacen;
        private Label label5;
        private Label lblID;
        private Button btnPut;
        private Button btnPost;
        private TextBox txtid;
        private TextBox txtIdProducto;
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