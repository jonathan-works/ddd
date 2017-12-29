using AutoMapper;
using JWorks.Domain.Entity;
using JWorks.Infra.Data;
using JWorks.Infra.Data.Repository;
using JWorks.UI.Site.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JWorks.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private UserRepository userRepository = new UserRepository();

        // GET: Home
        public ActionResult Index()
        {
            
            var user = userRepository.GetAll();
            //var view =  Mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(user);

            return View(user);
        }
    }
}