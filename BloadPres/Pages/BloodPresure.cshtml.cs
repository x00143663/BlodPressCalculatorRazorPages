﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BloadPres.Pages
{
    public class BloodPresureModel : PageModel
    {
        [BindProperty]
        public BloodPresCalc bloodPresCalc { get; set; }
        public void OnGet()
        {
            bloodPresCalc = new BloodPresCalc { Dia = 72, Sys=110, };
        }
    }
}