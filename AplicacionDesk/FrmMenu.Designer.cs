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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(297, 154);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 25;
            button1.Text = "Post y Put ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmpleado);
            Controls.Add(button1);
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
        private Button button1;
    }
}