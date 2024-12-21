namespace AplicacionDesk
{
    partial class FrmMenu
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
            BtnGetAll = new Button();
            btnGetArgumentos = new Button();
            BtnCerrar = new Button();
            btnDelete = new Button();
            btnPPAlmacen = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnPostPutDepartamento = new Button();
            lblEmpleado = new Label();
            btnEmpleado = new Button();
            label3 = new Label();
            btnInventario = new Button();
            label4 = new Label();
            btnMaquina = new Button();
            label5 = new Label();
            btnMateriaPrima = new Button();
            label6 = new Label();
            btnOrdenProduccion = new Button();
            label7 = new Label();
            btnProceso = new Button();
            label8 = new Label();
            btnProducto = new Button();
            label9 = new Label();
            btnRechazo = new Button();
            SuspendLayout();
            // 
            // BtnGetAll
            // 
            BtnGetAll.Location = new Point(23, 15);
            BtnGetAll.Name = "BtnGetAll";
            BtnGetAll.Size = new Size(113, 29);
            BtnGetAll.TabIndex = 17;
            BtnGetAll.Text = "Get All";
            BtnGetAll.UseVisualStyleBackColor = true;
            BtnGetAll.Click += BtnGetAll_Click;
            // 
            // btnGetArgumentos
            // 
            btnGetArgumentos.Location = new Point(151, 12);
            btnGetArgumentos.Name = "btnGetArgumentos";
            btnGetArgumentos.Size = new Size(113, 32);
            btnGetArgumentos.TabIndex = 18;
            btnGetArgumentos.Text = "Get All {?}";
            btnGetArgumentos.UseVisualStyleBackColor = true;
            btnGetArgumentos.Click += btnGetArgumentos_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(616, 12);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(113, 32);
            BtnCerrar.TabIndex = 19;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(23, 56);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 32);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Dellete {?}";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPPAlmacen
            // 
            btnPPAlmacen.Location = new Point(297, 33);
            btnPPAlmacen.Name = "btnPPAlmacen";
            btnPPAlmacen.Size = new Size(113, 32);
            btnPPAlmacen.TabIndex = 21;
            btnPPAlmacen.Text = "Post y Put ";
            btnPPAlmacen.UseVisualStyleBackColor = true;
            btnPPAlmacen.Click += btnPPAlmacen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 10);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 22;
            label1.Text = "Almacen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 68);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 24;
            label2.Text = "Departamento";
            // 
            // BtnPostPutDepartamento
            // 
            BtnPostPutDepartamento.Location = new Point(297, 91);
            BtnPostPutDepartamento.Name = "BtnPostPutDepartamento";
            BtnPostPutDepartamento.Size = new Size(113, 32);
            BtnPostPutDepartamento.TabIndex = 23;
            BtnPostPutDepartamento.Text = "Post y Put ";
            BtnPostPutDepartamento.UseVisualStyleBackColor = true;
            BtnPostPutDepartamento.Click += BtnPostPutDepartamento_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(297, 131);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(77, 20);
            lblEmpleado.TabIndex = 26;
            lblEmpleado.Text = "Empleado";
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(297, 154);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(113, 32);
            btnEmpleado.TabIndex = 25;
            btnEmpleado.Text = "Post y Put ";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 191);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 28;
            label3.Text = "Inventario";
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(297, 214);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(113, 32);
            btnInventario.TabIndex = 27;
            btnInventario.Text = "Post y Put ";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 244);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 30;
            label4.Text = "Maquina";
            // 
            // btnMaquina
            // 
            btnMaquina.Location = new Point(297, 267);
            btnMaquina.Name = "btnMaquina";
            btnMaquina.Size = new Size(113, 32);
            btnMaquina.TabIndex = 29;
            btnMaquina.Text = "Post y Put ";
            btnMaquina.UseVisualStyleBackColor = true;
            btnMaquina.Click += btnMaquina_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 304);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 32;
            label5.Text = "Materia Prima";
            // 
            // btnMateriaPrima
            // 
            btnMateriaPrima.Location = new Point(297, 327);
            btnMateriaPrima.Name = "btnMateriaPrima";
            btnMateriaPrima.Size = new Size(113, 32);
            btnMateriaPrima.TabIndex = 31;
            btnMateriaPrima.Text = "Post y Put ";
            btnMateriaPrima.UseVisualStyleBackColor = true;
            btnMateriaPrima.Click += btnMateriaPrima_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 369);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 34;
            label6.Text = "Orden Produccion";
            // 
            // btnOrdenProduccion
            // 
            btnOrdenProduccion.Location = new Point(297, 392);
            btnOrdenProduccion.Name = "btnOrdenProduccion";
            btnOrdenProduccion.Size = new Size(113, 32);
            btnOrdenProduccion.TabIndex = 33;
            btnOrdenProduccion.Text = "Post y Put ";
            btnOrdenProduccion.UseVisualStyleBackColor = true;
            btnOrdenProduccion.Click += btnOrdenProduccion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 10);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 36;
            label7.Text = "Proceso";
            // 
            // btnProceso
            // 
            btnProceso.Location = new Point(440, 33);
            btnProceso.Name = "btnProceso";
            btnProceso.Size = new Size(113, 32);
            btnProceso.TabIndex = 35;
            btnProceso.Text = "Post y Put ";
            btnProceso.UseVisualStyleBackColor = true;
            btnProceso.Click += btnProceso_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(440, 68);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 38;
            label8.Text = "Producto";
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(440, 91);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(113, 32);
            btnProducto.TabIndex = 37;
            btnProducto.Text = "Post y Put ";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(440, 131);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 40;
            label9.Text = "Rechazo";
            // 
            // btnRechazo
            // 
            btnRechazo.Location = new Point(440, 154);
            btnRechazo.Name = "btnRechazo";
            btnRechazo.Size = new Size(113, 32);
            btnRechazo.TabIndex = 39;
            btnRechazo.Text = "Post y Put ";
            btnRechazo.UseVisualStyleBackColor = true;
            btnRechazo.Click += btnRechazo_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(btnRechazo);
            Controls.Add(label8);
            Controls.Add(btnProducto);
            Controls.Add(label7);
            Controls.Add(btnProceso);
            Controls.Add(label6);
            Controls.Add(btnOrdenProduccion);
            Controls.Add(label5);
            Controls.Add(btnMateriaPrima);
            Controls.Add(label4);
            Controls.Add(btnMaquina);
            Controls.Add(label3);
            Controls.Add(btnInventario);
            Controls.Add(lblEmpleado);
            Controls.Add(btnEmpleado);
            Controls.Add(label2);
            Controls.Add(BtnPostPutDepartamento);
            Controls.Add(label1);
            Controls.Add(btnPPAlmacen);
            Controls.Add(btnDelete);
            Controls.Add(BtnCerrar);
            Controls.Add(btnGetArgumentos);
            Controls.Add(BtnGetAll);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGetAll;
        private Button btnGetArgumentos;
        private Button BtnCerrar;
        private Button btnDelete;
        private Button btnPPAlmacen;
        private Label label1;
        private Label label2;
        private Button BtnPostPutDepartamento;
        private Label lblEmpleado;
        private Button btnEmpleado;
        private Label label3;
        private Button btnInventario;
        private Label label4;
        private Button btnMaquina;
        private Label label5;
        private Button btnMateriaPrima;
        private Label label6;
        private Button btnOrdenProduccion;
        private Label label7;
        private Button btnProceso;
        private Label label8;
        private Button btnProducto;
        private Label label9;
        private Button btnRechazo;
    }
}