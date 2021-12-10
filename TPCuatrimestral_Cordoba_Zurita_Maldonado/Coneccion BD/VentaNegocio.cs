﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Conexion_BD
{
    public class VentaNegocio
    {
        public List<Venta> ListarSegunUser(int Id_user)
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();
            Venta aux = new Venta();
            try
            {
                datos.SetearConsulta("Select id, Id_user, FechaVenta, suma from ventas where id_user=" + Id_user + ";");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    aux = Asignacion(datos);

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();
            Venta aux = new Venta();
            try
            {
                datos.SetearConsulta("Select id, Id_user,FechaVenta, suma from ventas;");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    aux = Asignacion(datos);

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }
        public int Agregar(Venta nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into videoGames (Id_user, suma) output inserted.ID values (" + nuevo.Id_user + "," + nuevo.Suma + ");");
                datos.setearParametros("@Id", nuevo.Id);
                datos.setearParametros("@Id_user", nuevo.Id_user);
                datos.setearParametros("@Nombre", nuevo.Suma);
                datos.EjecutarLectura();
                datos.Lector.Read();

                return (int)datos.Lector["ID"];

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public Venta Asignacion(AccesoDatos datos)
        {
            try
            {
                Venta aux = new Venta();
                aux.Id = (int)datos.Lector["Id"];
                aux.Id_user = (int)datos.Lector["Id_user"];
                aux.FechaVenta = (DateTime)datos.Lector["FechaVenta"];
                aux.Suma = (int)datos.Lector["suma"];
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
