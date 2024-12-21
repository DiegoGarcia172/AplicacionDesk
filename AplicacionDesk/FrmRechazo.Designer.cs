namespace AplicacionDesk
{
    partial class FrmRechazo
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
            txtCantidadPR = new TextBox();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnPut = new Button();
            btnPost = new Button();
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
            label7 = new Label();
            dtpFechaHora = new DateTimePicker();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(64, 116);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 122;
            label11.Text = "Ingresa el id ";
            // 
            // txtid
            // 
            txtid.Location = new Point(184, 116);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 121;
            // 
            // txtCantidadPR
            // 
            txtCantidadPR.Location = new Point(184, 188);
            txtCantidadPR.Name = "txtCantidadPR";
            txtCantidadPR.Size = new Size(125, 27);
            txtCantidadPR.TabIndex = 120;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 276);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 119;
            label8.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(184, 276);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 114;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 187);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 112;
            label6.Text = "Ingresa la CantidadPR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 149);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 111;
            label5.Text = "Ingresa el IDProducto";
            // 
            // btnPut
            // 
            btnPut.Location = new Point(264, 396);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(94, 29);
            btnPut.TabIndex = 110;
            btnPut.Text = "Actualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(83, 396);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 109;
            btnPost.Text = "Crear";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(184, 149);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 108;
            // 
            // lblGetAll
            // 
            lblGetAll.AutoSize = true;
            lblGetAll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetAll.Location = new Point(375, 9);
            lblGetAll.Name = "lblGetAll";
            lblGetAll.Size = new Size(166, 41);
            lblGetAll.TabIndex = 106;
            lblGetAll.Text = "POS y PUT";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(138, 68);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(220, 27);
            txtToken.TabIndex = 105;
            // 
            // lblingtoken
            // 
            lblingtoken.AutoSize = true;
            lblingtoken.Location = new Point(20, 71);
            lblingtoken.Name = "lblingtoken";
            lblingtoken.Size = new Size(114, 20);
            lblingtoken.TabIndex = 104;
            lblingtoken.Text = "Ingresa el token";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(138, 32);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(220, 27);
            txtUrl.TabIndex = 103;
            txtUrl.Text = "https://localhost:7140/api/Rechazo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 102;
            label1.Text = "Ingresa la URL";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(659, 316);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 29);
            btnCerrar.TabIndex = 101;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(443, 316);
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
            label4.Location = new Point(558, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 99;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 129);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 98;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 97;
            label2.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(678, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 96;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnObtenerToken
            // 
            btnObtenerToken.Location = new Point(443, 226);
            btnObtenerToken.Name = "btnObtenerToken";
            btnObtenerToken.Size = new Size(113, 29);
            btnObtenerToken.TabIndex = 95;
            btnObtenerToken.Text = "Obtener Token";
            btnObtenerToken.UseVisualStyleBackColor = true;
            btnObtenerToken.Click += btnObtenerToken_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(643, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 94;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(643, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 93;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(643, 129);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 92;
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrar.Location = new Point(590, 13);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(195, 41);
            lblEntrar.TabIndex = 91;
            lblEntrar.Text = "Credenciales";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 226);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 123;
            label7.Text = "Fecha";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Location = new Point(172, 228);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(250, 27);
            dtpFechaHora.TabIndex = 124;
            // 
            // FrmRechazo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFechaHora);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(txtCantidadPR);
            Controls.Add(label8);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
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
            Name = "FrmRechazo";
            Text = "FrmRechazo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox txtid;
        private TextBox txtCantidadPR;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label6;
        private Label label5;
        private Button btnPut;
        private Button btnPost;
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
        private Label label7;
        private DateTimePicker dtpFechaHora;
    }
}