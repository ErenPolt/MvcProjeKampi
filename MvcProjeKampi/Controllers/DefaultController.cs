﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        //-------------------------------------------------------------------------------
        //Sidebar, Başlıklar;
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
        //----------------------------------------------------------------------------------
        //Başlıkların, Yazılarını taşıyacak partialview;
        public PartialViewResult Index(int id = 0)
        {
            var contentlist = cm.GetListByHeadingId(id);
            return PartialView(contentlist);
        }
        //----------------------------------------------------------------------------------
    }
}