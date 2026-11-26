using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransIstanbul.Methods;
using BusAPP.Models;
using BusAPP.Enums;

namespace TransIstanbul.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Istanbul(IstanbulCard card)
        {
            IstanbulMethods oMethods = new IstanbulMethods();
            if (card.Vehicles == Vehicles.Bus)
            {
                oMethods.GetBalanceBus(card);
                ViewBag.ledia = oMethods.ledia();
                ViewBag.alaa = oMethods.alaa();
            }
            else if (card.Vehicles == Vehicles.MetroBus)
            {
                oMethods.GetBalanceMetroBus(card);
                ViewBag.ledia = oMethods.ledia();
                ViewBag.alaa = oMethods.alaa();
            }
            return View();       
        }

        public IActionResult Blue(BlueCard card)
        {
            BlueMethods oMethods = new BlueMethods();
            if (card.Vehicles == Vehicles.Bus)
            {
                oMethods.Bus(card);
                ViewBag.ledia = oMethods.GetPoints();
                ViewBag.alaa = oMethods.GetAmountDeducted();
            }
            else if (card.Vehicles == Vehicles.MetroBus)
            {
                oMethods.MetroBus(card);
                ViewBag.ledia = oMethods.GetPoints();
                ViewBag.alaa = oMethods.GetAmountDeducted();
            }
            return View();
        }

        public IActionResult Electronic(ElectronicCard card)
        {
            ElectronicMethods oMethods = new ElectronicMethods();
            if (card.Vehicles == Vehicles.Bus)
            {
                oMethods.BusMethod(card);
                ViewBag.ledia = oMethods.GetPoints();
                ViewBag.alaa = oMethods.GetAmountDeducted();
            }
            else if (card.Vehicles == Vehicles.MetroBus)
            {
                oMethods.MetroBusMethod(card);
                ViewBag.ledia = oMethods.GetPoints();
                ViewBag.alaa = oMethods.GetAmountDeducted();
            }
            return View();
        }
    }
}
