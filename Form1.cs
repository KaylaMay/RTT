using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTT.ServiceReference1;
using System.Data.SqlClient;


namespace RTT
{
    public partial class Form1 : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Name = txtName.Text;
            c.Surname = txtSurname.Text;
            if (radFemale.Checked)
            {
                c.Gender = radFemale.Text;
            }
            if (radMale.Checked)
            {
                c.Gender = radMale.Text;
            }
            c.Residential_Address = txtResAdd.Text;
            c.Work_Address = txtWrkAdd.Text;
            c.Postal_Address = txtPostAdd.Text;
            c.Cell_nr = txtCellNr.Text;
            c.Work_nr = txtWrlNr.Text;

            Service1Client service = new Service1Client();

            if (service.InsertClient(c) == 1)
            {
                MessageBox.Show("Client Added Successfully");
                txtName.Clear();
                txtSurname.Clear();
                radFemale.Checked = false;
                radMale.Checked = false;
                txtResAdd.Clear();
                txtWrkAdd.Clear();
                txtPostAdd.Clear();
                txtCellNr.Clear();
                txtWrlNr.Clear();

                Form2 openForm = new Form2();
                openForm.Show();
                Visible = false;

               
            }
        }
        private void lblExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }
    }
}
