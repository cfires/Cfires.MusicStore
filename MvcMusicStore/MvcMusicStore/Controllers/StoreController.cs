using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name="Disco"},
                new Genre { Name="Jazz"},
                new Genre { Name="Rock"}
            };
            return View(genres);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="genre">流派</param>
        /// <returns></returns>
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        /// <summary>
        /// 专辑详情页
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}