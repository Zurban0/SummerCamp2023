﻿using EjercicioCorreosMVC.Models;
using EjercicioCorreosMVC.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioCorreosMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMails servicioMails;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
             ViewBag.lista = this.servicioMails.EnviarCorreo();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}