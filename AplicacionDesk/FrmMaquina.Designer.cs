namespace AplicacionDesk
{
    partial class FrmMaquina
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnPut = new Button();
            btnPost = new Button();
            txtName = new TextBox();
            txtTipo = new TextBox();
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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtModelo = new TextBox();
            txtIdProceso = new TextBox();
            txtOrdenProduccion = new TextBox();
            txtEstado = new TextBox();
            txtid = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 189);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 81;
            label7.Text = "Ingresa el Tipo ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 153);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 80;
            label6.Text = "Ingresa el Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 117);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 79;
            label5.Text = "Ingresa el nombre";
            // 
            // btnPut
            // 
            btnPut.Location = new Point(284, 379);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(94, 29);
            btnPut.TabIndex = 77;
            btnPut.Text = "Actualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(344, 129);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 76;
            btnPost.Text = "Crear";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 74;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(168, 186);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(125, 27);
            txtTipo.TabIndex = 72;
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(384, 9);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(166, 41);
            lblGetAll.TabIndex = 71;
            lblGetAll.Text = "POS y PUT";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(147, 68);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 70;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(29, 71);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 69;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(147, 32);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 68;
            txtUrl.Text = "https://localhost:7140/api/Maquina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 67;
            label1.Text = "Ingresa la URL";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(668, 316);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 66;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(452, 316);
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
            label4.Location = new Point(567, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 64;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 129);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 63;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 62;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(687, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 61;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(452, 226);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 60;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(652, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 59;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(652, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 58;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(652, 129);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 57;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(599, 13);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 56;
            lblEntrar.Text = "Credenciales";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 316);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 87;
            label8.Text = "Ingresa la Orden Prod";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 276);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 86;
            label9.Text = "Ingresa el idProceso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 229);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 85;
            label10.Text = "Ingresa el Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(168, 226);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 84;
            // 
            // txtIdProceso
            // 
            txtIdProceso.Location = new Point(168, 273);
            txtIdProceso.Name = "txtIdProceso";
            txtIdProceso.Size = new Size(125, 27);
            txtIdProceso.TabIndex = 83;
            // 
            // txtOrdenProduccion
            // 
            txtOrdenProduccion.Location = new Point(168, 316);
            txtOrdenProduccion.Name = "txtOrdenProduccion";
            txtOrdenProduccion.Size = new Size(125, 27);
            txtOrdenProduccion.TabIndex = 82;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(168, 150);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 88;
            // 
            // txtid
            // 
            txtid.Location = new Point(142, 379);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 89;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 381);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 90;
            label11.Text = "Ingresa el id ";
            // 
            // FrmMaquina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(txtEstado);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtModelo);
            Controls.Add(txtIdProceso);
            Controls.Add(txtOrdenProduccion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Controls.Add(txtName);
            Controls.Add(txtTipo);
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
            Name = "FrmMaquina";
            Text = "FrmMaquina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblID;
        private Button btnPut;
        private Button btnPost;
        private TextBox txtid;
        private TextBox txtName;
        private TextBox txtIdProducto;
        private TextBox txtTipo;
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
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtModelo;
        private TextBox txtIdProceso;
        private TextBox txtOrdenProduccion;
        private TextBox txtEstado;
        private Label label11;
    }
}