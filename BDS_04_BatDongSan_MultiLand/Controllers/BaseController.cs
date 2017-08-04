﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnperoFrontend.WebService;
namespace AnperoFrontend.Controllers
{
    public class BaseController : Controller
    {

        public static int StoreID = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["storeID"]);
        public static string TokenKey = System.Configuration.ConfigurationManager.AppSettings["storeTokenKey"];
        public static int shortCacheTime = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["shortCacheTime"]);
        public void GetTopArticle()
        {
            WebService.SearchArticleResults rs = new WebService.SearchArticleResults();
            WebService.AnperoService service = new WebService.AnperoService();
            if (HttpRuntime.Cache["TopArticle"] != null)
            {
                rs = (WebService.SearchArticleResults)HttpRuntime.Cache["TopArticle"];
            }
            else
            {
                rs = service.SearchArticle(StoreID, TokenKey, 0, 1, 4, 2);
                if (rs != null)
                {
                    HttpRuntime.Cache.Insert("TopArticle", rs, null, DateTime.Now.AddMinutes(shortCacheTime), TimeSpan.Zero);
                }

            }
            ViewData["FeatureArticle"] = rs;
        }
        public void SetupCommonProduct()
        {
          
            WebService.SearchResult BestsaleProduct;
            WebService.AnperoService sv = new WebService.AnperoService();
            if (HttpRuntime.Cache["BestsaleProduct"] != null)
            {
                BestsaleProduct = (WebService.SearchResult)HttpRuntime.Cache["BestsaleProduct"];
            }
            else
            {
                BestsaleProduct = sv.SearchProduct(StoreID, TokenKey, "", "", "", 0, 1999999990, 1, 8, "", SearchOrder.TimeDesc, 1);
                if (BestsaleProduct != null)
                {
                    HttpRuntime.Cache.Insert("BestsaleProduct", BestsaleProduct, null, DateTime.Now.AddMinutes(shortCacheTime), TimeSpan.Zero);
                }

            }
            ViewData["BestsaleProduct"] = BestsaleProduct;
        }

    }
    public class BuildCommonHtml : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            WebService.AnperoService service = new WebService.AnperoService();
            int shortCacheTime = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["shortCacheTime"]);
            if (HttpRuntime.Cache["commonInfo"] != null)
            {
                filterContext.Controller.ViewData["commonInfo"] = HttpRuntime.Cache["commonInfo"];
            }
            else
            {

                var rs = service.GetCommonConfig(CommonConfig.StoreID, CommonConfig.TokenKey);
                filterContext.Controller.ViewData["commonInfo"] = rs;
                if (rs != null)
                {
                    HttpRuntime.Cache.Insert("commonInfo", rs, null, DateTime.Now.AddMinutes(shortCacheTime), TimeSpan.Zero);
                }


            }

            WebService.Ads[] Slide = null;
            if (HttpRuntime.Cache["Slide"] != null)
            {
                filterContext.Controller.ViewData["slide"] = (WebService.Ads[])HttpRuntime.Cache["Slide"];
            }
            else
            {
                Slide = service.GetRandomAdsSlide(CommonConfig.StoreID, CommonConfig.TokenKey, PageContent.Slide, 1);

                filterContext.Controller.ViewData["slide"] = Slide;
                if (Slide != null)
                {
                    HttpRuntime.Cache.Insert("Slide", Slide, null, DateTime.Now.AddMinutes(shortCacheTime + 3), TimeSpan.Zero);
                }
            }



        }
    }

    public partial class CommonConfig
    {
        public static int StoreID = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["storeID"]);
        public static string TokenKey = System.Configuration.ConfigurationManager.AppSettings["storeTokenKey"];
    }
    public static class SearchOrder
    {

        public static string PriceDesc = "pricedesc";
        public static string PricedAsc = "pricedasc";
        public static string TimeDesc = "timeDesc";
        public static string NameDesc = "nameDesc";
        public static string NameAsc = "nameAsc";
    }
    public static class PageContent
    {
        public static string Slide = "slide";
        public static string Ads1 = "ads1";
        public static string Ads2 = "ads2";
        public static string Ads3 = "ads3";

    }

}