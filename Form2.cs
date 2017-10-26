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
using System.IO;

namespace RTT
{
    public partial class Form2 : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Client> clientl = new List<Client>();
            Service1Client service = new Service1Client();
            dataGridView1.DataSource = service.GetClient();
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("Clients.txt");
            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                writer.Write("Client: " + x);
                writer.Write(" ");
                for (int a = 0; a < dataGridView1.Columns.Count-2; a++)
                {
                    writer.Write(dataGridView1.Rows[x].Cells[a].Value.ToString()+",");
                }
                writer.Write("\n************************************\n");
                //writer.Write("\n ");
            }
            writer.Close();
            MessageBox.Show("Clients Exported");
            Close();


            Form1 openForm = new Form1();
            openForm.Show();
            Visible = false;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {

            _dragging = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
