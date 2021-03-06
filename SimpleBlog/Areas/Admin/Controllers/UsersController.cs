﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    //Set roles - Admin: not accessible to non-authorized nor non-admin users
    [Authorize(Roles = "admin")]
    [SelectedTab("Users")] // pass the active string tab
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View();
        }
    }
}