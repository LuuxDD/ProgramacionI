using CiclismoDesktopPorCodigo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ClientesView : Form

    {
        
        SqlCommand comand = new SqlCommand();

        //Establecemos la conexion
   

        public ClientesView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()

        {

            //Escribimos el comando y lo ejecutamos, el resultado queda en el SQLdataReader
            comand.CommandText = "Select * from Clientes";
            SqlDataReader clientesReader = comand.ExecuteReader();

            // Cargamos los datos en un dataTable para poder mostrarlo en la grilla
            DataTable clientesTable = new DataTable();
            clientesTable.Load(clientesReader);
            dataGridClientes.DataSource = clientesTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idClienteAEliminar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string nombreCliente = (string)dataGridClientes.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta si esta seguro que dea borrar

            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere borrar al cliente {nombreCliente} ?",
                "Eliminar Cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere borrar, enviamos a borrar el cliente, utilizando el id

            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from Clientes where id={idClienteAEliminar}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteView nuevoEditarClienteView = new NuevoEditarClienteView();
            nuevoEditarClienteView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int idClienteAModificar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            NuevoEditarClienteView nuevoEditarClienteView = new NuevoEditarClienteView(idClienteAModificar);
            nuevoEditarClienteView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
