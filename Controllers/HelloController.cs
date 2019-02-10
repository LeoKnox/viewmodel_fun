using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using viewmodel_fun.Models;

namespace viewmodel_fun
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            FunText someText = new FunText()
            {
                fString = "this is not fun!"
            };
            return View(someText);
        }

        [HttpGet("nums")]
        public IActionResult Nums()
        {
            int[] myNums = new int[]
            {
                3, 5, 7, 2
            };
            return View(myNums);
        }
    }
}