using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcJqueryMobile.Models;
using System.Data.Entity;

namespace MvcJqueryMobile.Controllers
{
    public class PagesController : Controller
    {
        private MobileContext db = new MobileContext();
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SinglePage()
        {
            ViewBag.Header = "LOL英雄人物 -- 齊天大聖 悟空";
            ViewBag.Footer = "鬥戰勝佛 孫悟空";
            ViewBag.Image = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/MonkeyKing_0.jpg";
            ViewBag.Introduction = "孫悟是一隻由石頭中蹦出來的猴子、天產靈石孕育而生，自封花果山美猴王、齊天大聖。牠吸取日月之精華，並學習仙術，法力及武藝高強，伴隨唐三藏前往西天取經，沿路斬妖伏魔。取經後為如來佛祖授為鬪戰勝佛。";

            return View();
        }

        public ActionResult MultiPages()
        {
            List<Hero> Heroes = new List<Hero>
            {
                new Hero{ Id=1, PageId="page_Zilean", Header="時光守護者 極靈", Footer="Zilean 極靈", Introduction="極靈是時光守護者，可以扭曲任意英雄的時光，可以對友方英雄或敵方英雄施放。", ImageUrl="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg", ImageAlt="Zilean",VideoUrl="https://www.youtube.com/embed/_Jc7bZZlGIo" },
                new Hero{ Id=2, PageId="page_Teemo", Header="迅捷斥候 提摩", Footer="Teemo 提摩", Introduction="提摩的代表武器－吹箭，使用了採集於庫莽古叢林中的劇烈猛毒。", ImageUrl="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg", ImageAlt="Teemo", VideoUrl="https://www.youtube.com/embed/Qj48qHM1MXE"},
                new Hero{ Id=3, PageId="page_Sona", Header="琴仙 索娜", Footer="Sona 索娜", Introduction="索娜演奏的旋律能讓靈魂起舞，而她的沉寂卻如撕心裂肺。", ImageUrl="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_4.jpg", ImageAlt="Sona", VideoUrl="https://www.youtube.com/embed/MAiOAert8us"}
            };

            return View(Heroes);
        }

        public ActionResult MultiPagesPartial()
        {
            List<Hero> Heroes = new List<Hero>
            {
                new Hero{ Id=1, PageId="page_Zilean", Header="時光守護者 極靈", Footer="Zilean 極靈", Introduction="極靈是時光守護者，可以扭曲任意英雄的時光，可以對友方英雄或敵方英雄施放。", ImageUrl="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg", ImageAlt="Zilean",VideoUrl="https://www.youtube.com/embed/_Jc7bZZlGIo" },
                new Hero{ Id=2, PageId="page_Teemo", Header="迅捷斥候 提摩", Footer="Teemo 提摩", Introduction="提摩的代表武器－吹箭，使用了採集於庫莽古叢林中的劇烈猛毒。", ImageUrl="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg", ImageAlt="Teemo", VideoUrl="https://www.youtube.com/embed/Qj48qHM1MXE"},
                new Hero{ Id=3, PageId="page_Sona", Header="琴仙 索娜", Footer="Sona 索娜", Introduction="索娜演奏的旋律能讓靈魂起舞，而她的沉寂卻如撕心裂肺。", ImageUrl="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_4.jpg", ImageAlt="Sona", VideoUrl="https://www.youtube.com/embed/MAiOAert8us"}
            };

            return View(Heroes);
        }

        public ActionResult MultiPagesPartialDB()
        {
            return View(db.Heroes.ToList());
        }
    }
}