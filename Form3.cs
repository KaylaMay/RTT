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

namespace RTT
{
    public partial class Form3 : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


       
        public Form3()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Client c = new Client()
            {
                Cust_id = Convert.ToInt32(txtCustid.Text),
                Name=txtName.Text,
                Surname=txtSurname.Text,
                Gender=radFemale.Text,
                Residential_Address=txtResAdd.Text,
                Work_Address=txtWrkAdd.Text,
                Postal_Address=txtPostAdd.Text,
                Cell_nr=txtCellNr.Text,
                Work_nr=txtWrlNr.Text


        };


            Service1Client service = new Service1Client();
            if (service.UpdateClient(c) == 1)
            {
                MessageBox.Show("Client Information Updated Successfully.");

                Form1 openForm = new Form1();
                openForm.Show();
                Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Client c = new Client()
            {
                Cust_id = Convert.ToInt32(txtCustid.Text)

            };


            Service1Client service = new Service1Client();
            if (service.DeleteClient(c) == 1)
            {
                MessageBox.Show("Client Information Updated Successfully.");

                Form1 openForm = new Form1();
                openForm.Show();
                Visible = false;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
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

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {

            _dragging = false;
        }
    }
}
