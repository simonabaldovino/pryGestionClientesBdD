using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryGestionClientesBdD
{
    internal class clsCliente
    {

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private String Tabla = "Cliente";

        // variables de los datos calculados en clientes deudores
        private Decimal deuda;
        private Int32 cantidad;

        private Int32 idCli;
        private String nom;
        private Decimal deu;
        private Decimal lim;
        private Int32 idAu;
        

        // propiedades para pasar las variasbles al formulario
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }
        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; }
        }

        public Int32 iDCliente 
        {
            get { return idCli; }
            set { idCli = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }
        public Decimal Limite
        {
            get { return lim; }
            set { lim = value; }
        }
        public Int32 idAutomovil
        {
            get { return idAu; }
            set { idAu = value; }
        }

        // metodos y procedimientos 

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Grilla.DataSource = DS.Tables[0];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(2) > 0)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                            cantidad++;
                            deuda = deuda + DR.GetDecimal(2);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReporteClientes()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter("ReporteClientes.csv", false,Encoding.UTF8);

                AD.WriteLine("Listado de clientes\n");
                AD.WriteLine("Código; Nombre; Deuda");

                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.Write(DR.GetDecimal(2));

                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);
                    }
                    AD.Write("\nCantidad de clientes:;;");
                    AD.WriteLine(cantidad);
                    AD.Write("Deuda de los clientes:;;");
                    AD.WriteLine(deuda);
                    AD.Write("Promedio de deuda:;;");
                    AD.WriteLine(deuda / cantidad);
                }
                AD.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Buscar(Int32 idCliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1); 
                            deu = DR.GetDecimal(2);
                            lim = DR.GetDecimal(3); 
                            idAu = DR.GetInt32(4); 
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Agregar()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();

                //llenar fila 
                fila["Nombre"] = nom;
                fila["Deuda"] = deu;
                fila["Limite"] = lim;
                fila["Automovil"] = idAu;

                // incertar fila en tabla 
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, Tabla);

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void soloEstructura(Int32 idCliente )
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "";

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Modificar(Int32 idCliente)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Cliente SET Limite = " + lim.ToString() + " WHERE idCliente = " + idCliente.ToString();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Eliminar(Int32 IdCliente)
        {
            try
            {
                String sql = "";
                sql = "DELETE * FROM Cliente WHERE idCliente = " + IdCliente.ToString();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void AgregarRegistro()
        {
            try
            {
                String sql = "";
                sql = "INSERT INTO Cliente (Nombre,Deuda,Limite,Automovil) VALUES ('" + nom + "',0, "+ lim.ToString() + "," + idAu.ToString() + ")";

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarForEach(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet(); // crear dataset
                adaptador.Fill(DS, Tabla); // lleno dataset con adaptador

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        grilla.Rows.Add(fila["Nombre"], fila["idAutomovil"]);
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ReporteCliente(String NombreArchivo) 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                AD.WriteLine("LISTADO DE CLIENTES\n");
                AD.WriteLine("Código; Nombre; Deuda");

                cantidad = 0;
                deuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["Deuda"]) > 0)
                        {
                            AD.Write(fila["idCliente"]);
                            AD.Write(";");
                            AD.Write(fila["Nombre"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Deuda"]);
                            cantidad++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                    AD.Write("\n");
                    AD.Write("Cantidad de Clientes: ;");
                    AD.WriteLine(cantidad);
                    AD.Write("Total de Deudas: ;");
                    AD.WriteLine(deuda);
                    AD.Write("Promedio de Deudas: ;");
                    AD.WriteLine(deuda / cantidad);
                }
                MessageBox.Show("El reporte se generó con éxito", "Reporte Generado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                AD.Close();
                conexion.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font LetraTexto = new Font("Arial", 8);
                Int32 f = 200;
                reporte.Graphics.DrawString("Listado de Clientes", LetraTitulo1, Brushes.Red, 100, 100);
                reporte.Graphics.DrawString("Código", LetraTitulo2, Brushes.Blue, 100, 180);
                reporte.Graphics.DrawString("Nombre del cliente", LetraTitulo2, Brushes.Blue, 150, 180);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);

                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["IdCliente"].ToString(), LetraTexto, Brushes.Black, 100, f);
                        reporte.Graphics.DrawString(fila["Nombre"].ToString(), LetraTexto, Brushes.Black, 300, f);
                        f = f + 15;
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }
    }
}
