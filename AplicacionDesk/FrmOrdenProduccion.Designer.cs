namespace AplicacionDesk
{
    partial class FrmOrdenProduccion
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
            label11 = new Label();
            txtid = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtCantidad = new TextBox();
            txtIdEmpleado = new TextBox();
            btnPut = new Button();
            btnPost = new Button();
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
            dtpFechaOrden = new DateTimePicker();
            dtpFechaEntrega = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 113);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 122;
            label11.Text = "Ingresa el id ";
            // 
            // txtid
            // 
            txtid.Location = new Point(165, 110);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 121;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 273);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 119;
            label8.Text = "Id Empleado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 182);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 118;
            label9.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(165, 182);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 115;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(165, 266);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(125, 27);
            txtIdEmpleado.TabIndex = 114;
            // 
            // btnPut
            // 
            btnPut.Location = new Point(261, 335);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(94, 29);
            btnPut.TabIndex = 110;
            btnPut.Text = "Actualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(51, 335);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 109;
            btnPost.Text = "Crear";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(372, 11);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(166, 41);
            lblGetAll.TabIndex = 106;
            lblGetAll.Text = "POS y PUT";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(135, 70);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 105;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(17, 73);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 104;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(135, 34);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 103;
            txtUrl.Text = "https://localhost:7140/api/OrdenProduccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 102;
            label1.Text = "Ingresa la URL";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(656, 318);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 101;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(440, 318);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(113, 29);
            btnMenu.TabIndex = 100;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 189);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 99;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 131);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 98;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 97;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(675, 228);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 96;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(440, 228);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 95;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(640, 189);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 94;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(640, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 93;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(640, 131);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 92;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(587, 15);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 91;
            lblEntrar.Text = "Credenciales";
            // 
            // dtpFechaOrden
            // 
            dtpFechaOrden.Location = new Point(165, 143);
            dtpFechaOrden.Name = "dtpFechaOrden";
            dtpFechaOrden.Size = new Size(250, 27);
            dtpFechaOrden.TabIndex = 123;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(165, 228);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(250, 27);
            dtpFechaEntrega.TabIndex = 124;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 148);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 125;
            label5.Text = "Fecha Orden";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 228);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 126;
            label6.Text = "Fecha de entrega";
            // 
            // FrmOrdenProduccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(dtpFechaOrden);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtCantidad);
            Controls.Add(txtIdEmpleado);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
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
            Name = "FrmOrdenProduccion";
            Text = "FrmOrdenProduccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox txtid;
        private Label label8;
        private Label label9;
        private TextBox txtCantidad;
        private TextBox txtIdEmpleado;
        private Button btnPut;
        private Button btnPost;
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
        private DateTimePicker dtpFechaOrden;
        private DateTimePicker dtpFechaEntrega;
        private Label label5;
        private Label label6;
    }
}