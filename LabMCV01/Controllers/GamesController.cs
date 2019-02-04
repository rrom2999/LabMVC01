using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabMCV01.Models;
using System.Diagnostics;

namespace LabMCV01.Models
{
    public class GamesController : Controller
    {
       
        // GET: Games
        public ActionResult Index()
        {
            List<Game> lista = new List<Game>();
            Game J1 = new Game();
            J1.Nombre = "COD BO4"; J1.ID = 1; J1.Puntuacion = 3; J1.Categoria = "Shooter"; J1.Año = 2019; J1.Estudio = "Treyarch";
            lista.Add(J1);

            Game J2 = new Game();
            J2.Nombre = "Super Smash bros Melee"; J2.ID = 2; J2.Puntuacion = 5; J2.Categoria = "Lucha, plataformas"; J2.Año = 2002; J2.Estudio = "HAl Lab";
            lista.Add(J2);

            Game J3 = new Game();
            J3.Nombre = "The last of us"; J3.ID = 3; J3.Puntuacion = 4; J3.Categoria = "Survival"; J3.Año = 2011; J2.Estudio = "Naughty Dog";
            lista.Add(J3);

            Game J4 = new Game();
            J4.Nombre = "Mario kart 8 Deluxe"; J4.ID = 4; J4.Puntuacion = 4; J4.Categoria = "Carreras"; J4.Año = 2014; J2.Estudio = "Nintendo";
            lista.Add(J4);

            return View(lista);
        }

        public ActionResult MostrarJuego(int id)
        {
            List<Game> lista = new List<Game>();
            Game J1 = new Game();
            J1.Nombre = "COD BO4"; J1.ID = 1; J1.Puntuacion = 3; J1.Categoria = "Shooter"; J1.Año = 2019; J1.Estudio = "Treyarch";
            lista.Add(J1);

            Game J2 = new Game();
            J2.Nombre = "Super Smash bros Melee"; J2.ID = 2; J2.Puntuacion = 5; J2.Categoria = "Lucha, plataformas"; J2.Año = 2002; J2.Estudio = "HAl Lab";
            lista.Add(J2);

            Game J3 = new Game();
            J3.Nombre = "The last of us"; J3.ID = 3; J3.Puntuacion = 4; J3.Categoria = "Survival"; J3.Año = 2011; J2.Estudio = "Naughty Dog";
            lista.Add(J3);

            Game J4 = new Game();
            J4.Nombre = "Mario kart 8 Deluxe"; J4.ID = 4; J4.Puntuacion = 4; J4.Categoria = "Carreras"; J4.Año = 2014; J2.Estudio = "Nintendo";
            lista.Add(J4);
            try
            {
                foreach (var game in lista)
                {
                    if (id == game.ID)
                    {
                        return View(game);
                    }
                }
            }
            catch
            {

            }
            return View();
        }
        
    }
}