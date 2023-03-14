using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using SubirFacturasLuz.Logica;
using SubirFacturasLuz.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubirFacturasLuz.Clases
{
    public class LuzLogica
    {
        private static LuzLogica _instancia = null;
        public LuzLogica()
        {

        }

        public static LuzLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new LuzLogica();
                return _instancia;
            }
        }
        public int Registrar(Luz oLuz, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
             MySqlTransaction objTransaccion = null;

            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();
                      
                    string query2= "INSERT INTO Luz_registro(Periodo,consumo,importe,factura) values(@Periodo,@consumo,@importe,@factura);select LAST_INSERT_ID();";
                             
                    MySqlCommand cmd = new MySqlCommand(query2, conexion);

                    cmd.Parameters.AddWithValue("@Periodo", oLuz.Periodo);
                    cmd.Parameters.AddWithValue("@consumo", oLuz.Consumo);
                    cmd.Parameters.AddWithValue("@importe", oLuz.Importe);
                    cmd.Parameters.AddWithValue("@factura", oLuz.Factura);

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = Convert.ToInt32(cmd.ExecuteScalar());


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar la factura";
                    }

                    objTransaccion.Commit();

                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }


            return respuesta;
        }
        public List<Luz> Listar()
        {
            List<Luz> oLista = new List<Luz>();
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id,Periodo,consumo,importe,factura from Luz_registro");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Luz()
                            {
                                Id = Convert.ToInt32(dr["id"].ToString()),
                                Periodo = Convert.ToDateTime(dr["Periodo"].ToString()),
                                Consumo = Convert.ToDecimal(dr["Consumo"].ToString()),
                                Importe = Convert.ToDecimal(dr["importe"].ToString()),
                                Factura = (byte[]) dr["Factura"],
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Luz>();
            }
            return oLista;
        }
    }
}
