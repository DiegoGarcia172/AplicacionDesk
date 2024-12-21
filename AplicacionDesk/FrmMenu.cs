﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesk
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnGetArgumentos_Click(object sender, EventArgs e)
        {
            FrmGetArgumentos frm = new FrmGetArgumentos();
            frm.Show();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDeleteArg frm = new FrmDeleteArg();
            frm.Show();
        }
        private void btnPPAlmacen_Click(object sender, EventArgs e)
        {
            FrmPostPutAlmacen frm = new FrmPostPutAlmacen();
            frm.Show();
        }

        private void BtnPostPutDepartamento_Click(object sender, EventArgs e)
        {
            FrmDepartamento frm = new FrmDepartamento();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.Show();
        }
    }
}