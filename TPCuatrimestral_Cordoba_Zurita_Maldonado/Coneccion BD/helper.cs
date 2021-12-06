using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Negocio
{
    //class helper
    //{
    //    public List<VideoGame> Filtro(string Search_query, string SP_query, string Category_query)
    //    {

    //        List<VideoGame> ListaVideogames = new List<VideoGame>();
    //        List<VideoGame> ListaAux = new List<VideoGame>();
    //        int i;
    //        //Listado de videojuegos
    //        VGameNegocio videoGame = new VGameNegocio();

    //        if (Search_query != null)
    //        {
    //            //Listar videojuegos buscados
    //            ListaVideogames = videoGame.Search(Search_query);
    //        }
    //        else if (SP_query == "Oferta")
    //        {
    //            ListaVideogames = videoGame.Ofertas();
    //        }
    //        else if (SP_query == "NewLaunch")
    //        {
    //            ListaVideogames = videoGame.NewLaunch();
    //        }
    //        else if (Category_query != null)
    //        {
    //            //Listar videojuegos filtrados
    //            for (i = 0; i < CheckBoxList.Items.Count; i++)
    //            {
    //                if (CheckBoxList.Items[i].Text == Category_query)
    //                {
    //                    CheckBoxList.Items[i].Selected = true;
    //                }
    //            }
    //        }
    //        else
    //        {
    //            //Listar videojuegos sin filtrar
    //            ListaVideogames = videoGame.Listar();
    //        }

    //        string chkbox = "";
    //        for (i = 0; i < CheckBoxList.Items.Count; i++)
    //        {
    //            if (CheckBoxList.Items[i].Selected)
    //            {
    //                if (chkbox == "")
    //                {
    //                    chkbox = CheckBoxList.Items[i].Text;
    //                }
    //                else
    //                {
    //                    chkbox += "'" + "," + "'" + CheckBoxList.Items[i].Text;
    //                }
    //            }
    //        }
    //        bool CheckSelected = false;
    //        if (chkbox != "")
    //        {
    //            CheckSelected = true;
    //            ListaAux = videoGame.Filter(chkbox);
    //        }

    //        if (CheckSelected)
    //        {
    //            ListaVideogames = ListaAux;
    //        }
    //        return ListaVideogames;

    //    }
    //}
}
