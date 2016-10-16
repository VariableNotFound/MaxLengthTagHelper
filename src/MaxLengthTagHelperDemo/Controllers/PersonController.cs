using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaxLengthTagHelperDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MaxLengthTagHelperDemo.Controllers
{
    [Route("")]
    public class PersonController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(PersonViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            return Content("Ok!");
        }

    }
}
