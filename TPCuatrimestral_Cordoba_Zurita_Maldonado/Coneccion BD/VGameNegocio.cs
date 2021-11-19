﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Negocio
{
    public class VGameNegocio
    {

        public List<VideoGame> Listar()
        {
            List<VideoGame> lista = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name , i.url_image as imageUrl,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d, images i where v.id=i.id_product and v.Id_category=c.id and v.Id_developer=d.id;");
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

        public VideoGame FindByFK(int ID)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name , i.url_image as imageUrl,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d, images i where v.id=@Id and v.id=i.id_product and v.Id_category=c.id and v.Id_developer=d.id");
                datos.setearParametros("@Id", ID);
                datos.EjecutarLectura();
                datos.Lector.Read();
                VideoGame aux = Asignacion(datos);

                return aux;

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


        public void Agregar(VideoGame nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into videoGames (name, Description,Requerimientos,Id_category,Id_developer,Price,Descuento,Destacado,Clasificacion_PIG,Launch_Date) values ('"+ nuevo.Name +"','" + nuevo.Description + "','"+nuevo.Requerimentos+"',"+ nuevo.Categoria.Id + ","+ nuevo.Developer.ID + ","+nuevo.Price+","+nuevo.Descuento+","+ BoolToInt(nuevo.Destacado) + ","+nuevo.ClasificaconPGI+",'"+ nuevo.LaunchDate.Year + "-" + nuevo.LaunchDate.Month + "-" + nuevo.LaunchDate.Day + "');");

                datos.setearParametros("@Id", nuevo.ID);
                datos.setearParametros("@Nombre", nuevo.Name);
                datos.setearParametros("@Descripcion", nuevo.Description);
                datos.setearParametros("@Requerimentos", nuevo.Requerimentos);
                datos.setearParametros("@Precio", nuevo.Price);
                datos.setearParametros("@Descuento", nuevo.Descuento);
                datos.setearParametros("@PDestacado", BoolToInt(nuevo.Destacado));
                datos.setearParametros("@Clasificacon_PGI", nuevo.ClasificaconPGI);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@IdDeveloper", nuevo.Developer.ID);
                datos.setearParametros("@LaunchDate", nuevo.LaunchDate.Year+"-"+nuevo.LaunchDate.Month+"-"+ nuevo.LaunchDate.Day);
                datos.EjecutarAccion();
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
        public void Modificar(VideoGame Modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update videoGames set name='"+ Modificar.Name+"', Description='"+ Modificar.Description+"', Requerimientos='"+ Modificar.Requerimentos + "', Price=" + Modificar.Price+",Descuento="+Modificar.Descuento+", Destacado="+ BoolToInt(Modificar.Destacado)+", Clasificacion_PIG="+Modificar.ClasificaconPGI+ ", Id_category ="+ Modificar.Categoria.Id+ ", Id_developer="+ Modificar.Developer.ID + ", Launch_Date = '" + Modificar.LaunchDate.Year + "-" + Modificar.LaunchDate.Month + "-" + Modificar.LaunchDate.Day+"' where Id=" + Modificar.ID);
                datos.setearParametros("@Id", Modificar.ID);
                datos.setearParametros("@name", Modificar.Name);
                datos.setearParametros("@Description", Modificar.Description);
                datos.setearParametros("@Requerimientos", Modificar.Requerimentos);
                datos.setearParametros("@Price", Modificar.Price);
                datos.setearParametros("@Descuento", Modificar.Descuento);
                datos.setearParametros("@PDestacado", BoolToInt(Modificar.Destacado) );
                datos.setearParametros("@Clasificacon_PGI", Modificar.ClasificaconPGI);
                datos.setearParametros("@IdCategoria", Modificar.Categoria.Id);
                datos.setearParametros("@IdDeveloper", Modificar.Developer.ID);
                datos.setearParametros("@Launch_Date", Modificar.LaunchDate.Year + "-" + Modificar.LaunchDate.Month + "-" + Modificar.LaunchDate.Day);
                datos.EjecutarAccion();

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
        public void Eliminar(VideoGame Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM videoGames WHERE Id=@Id");
                datos.setearParametros("@Id", Eliminar.ID);
                datos.EjecutarAccion();

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
        public VideoGame Asignacion(AccesoDatos datos)
        {

            try
            {
                VideoGame aux = new VideoGame();
                aux.ID = (int)datos.Lector["Id"];
                aux.Name = (string)datos.Lector["name"];
                aux.Description = (string)datos.Lector["description"];
                aux.Requerimentos = (string)datos.Lector["Requerimientos"];
                aux.ClasificaconPGI = (int)datos.Lector["Clasificacion_PIG"];

                if (!(datos.Lector["Descuento"] is DBNull))
                    aux.Descuento = (float)(decimal)datos.Lector["Descuento"];


                aux.Destacado = (bool)datos.Lector["Destacado"];
                aux.LaunchDate = (DateTime)datos.Lector["Launch_Date"];
                if (!(datos.Lector["Price"] is DBNull))
                    aux.Price = (float)(decimal)datos.Lector["Price"];

                aux.Categoria = new Categoria
                {
                    Name = (string)datos.Lector["category_name"]
                };
                aux.Categoria.Id = (int)datos.Lector["Id_category"];
                aux.Categoria.Estado = (bool)datos.Lector["Estado"];

                aux.Developer = new Developers
                {
                    Name = (string)datos.Lector["developer_name"],
                };
                aux.Developer.ID = (int)datos.Lector["Id_developer"];
                aux.Developer.Estado = (bool)datos.Lector["Estado"];

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BoolToInt(bool value)
        {
            int OutValue=0;
            if (value)
            {
                OutValue = 1;
            }
            return OutValue;
        }

    }
}
