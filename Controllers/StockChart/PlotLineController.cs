﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.StockChart
{
    public partial class StockChartController : Controller
    {
        // GET: PlotLine
        public ActionResult PlotLine()
        {
            return View();
        }
    }
}