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
            string someText = new string("This is fun");
            return View("Index", someText);
        }

        [HttpGet("nums")]
        public IActionResult Nums()
        {
            int[] myNums = new int[]
            {
                3, 5, 7, 2
            };
            return View("nums", myNums);
        }

        [HttpGet("user")]
        public IActionResult funUser()
        {
            funUser fUser = new funUser();
            {
                fUser.lName = "Toast";
                fUser.fName = "Burnt";
            };
            return View("user", fUser);
        }

        [HttpGet("moreusers")]
        public IActionResult manyUsers()
        {
            List<funUser> mUsers = new List<funUser>();
            {
                funUser oneUser = new funUser();
                {
                    oneUser.fName = "Burnt";
                    oneUser.lName = "Toast";
                }
                mUsers.Add(oneUser);
            };
            return View("moreusers", mUsers);
        }
    }
}