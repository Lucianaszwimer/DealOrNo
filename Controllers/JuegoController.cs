using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DealOrNoDeal.Models;

namespace DealOrNoDeal.Controllers
{
    public class JuegoController : Controller
    {
        public IActionResult index()
        {
           ViewBag.importe = DealOrNo.ListaImportes();
            return View();
        }
     public IActionResult final(string decision, int MaletinCerrado = -1)
        {
            ViewBag.decision= decision;
            ViewBag.elegido = DealOrNo.MaletinElegido();
            ViewBag.Maletines = DealOrNo.ListaMaletines();
            ViewBag.Turno = DealOrNo.TurnosRestantes();
            ViewBag.MaletinCerrado = MaletinCerrado;
            return View();
        }
        public IActionResult elegirPrimerMaletin(int maletin)
        {
            DealOrNo.IniciarJuego(maletin);
            ViewBag.Maletines=DealOrNo.ListaMaletines();
            ViewBag.importes=DealOrNo.ListaImportes();
            ViewBag.JugadasRestantes=DealOrNo.JugadasRestantes();
            ViewBag.ImportesDescartados = DealOrNo.ImportesDescartados;
            return View("Juego");
        }

        public IActionResult eleccionMaletin(int maletin)
        {
            ViewBag.Maletines=DealOrNo.ListaMaletines();
            ViewBag.importes=DealOrNo.ListaImportes();
            ViewBag.ImporteMaletin= DealOrNo.AbrirMaletin(maletin);
            ViewBag.JugadasRestantes=DealOrNo.JugadasRestantes();
            ViewBag.ImportesDescartados = DealOrNo.ImportesDescartados;
            if(ViewBag.JugadasRestantes==0){
                ViewBag.OfertaBanca=DealOrNo.OfertaBanca();
                return View("decision");
            }else{
                ViewBag.volverJuego = "true"; // ver linea 10 de juego
                return View("juego");
            }
        }
        public IActionResult decision(string decision)
        {
            ViewBag.Turno = DealOrNo.TurnosRestantes();
            ViewBag.Decision= DealOrNo.DecisionOferta(decision); 
            ViewBag.OfertaBanca=DealOrNo.OfertaBanca();
            ViewBag.importes= DealOrNo.ListaImportes();
            ViewBag.Maletines = DealOrNo.ListaMaletines();
            if(ViewBag.Decision==-1){
              ViewBag.ImportesDescartados = DealOrNo.ImportesDescartados;
               if(ViewBag.Turno == 0){
                   ViewBag.elegido = DealOrNo.MaletinElegido();
                    return View("decision");
                }else{
                    ViewBag.JugadasRestantes=DealOrNo.JugadasRestantes();
                    ViewBag.volverJuego = decision; // ver linea 10 de juego
                    return View("juego");
                }
            }else{
            ViewBag.elegido = DealOrNo.MaletinElegido();
            return View("final");
            }
        }
    }
}
