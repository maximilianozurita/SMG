﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Mod_Dominio;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class ListOfUser : System.Web.UI.Page
    {
        public List<Usuario> Listausuarios { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            /*try
           {
               dgvListaUsuario.DataSource = usuarios.listar();
               dgvListaUsuario.DataBind();
           }
           catch (Exception)
           {

               throw;
           } */
            UsuarioNegocio usuarioNeg = new UsuarioNegocio();
            Listausuarios = usuarioNeg.listar();
          
        }
    }
}