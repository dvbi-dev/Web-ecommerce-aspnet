﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BanHangOnl
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Contact",
              url: "lien-he",
              defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "BanHangOnl.Controllers" }
          );
            routes.MapRoute(
         name: "CheckOut",
         url: "thanh-toan",
         defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
         namespaces: new[] { "BanHangOnl.Controllers" }
        );
            routes.MapRoute(
             name: "ShoppingCart",
             url: "gio-hang",
             defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "BanHangOnl.Controllers" }
         );
            routes.MapRoute(
               name: "CategoryProduct",
               url: "danh-muc-san-pham/{alias}-{id}",
               defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
               namespaces: new[] { "BanHangOnl.Controllers" }
           );
            routes.MapRoute(
              name: "detailProduct",
              url: "chi-tiet/{alias}-p{id}",
              defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional },
              namespaces: new[] { "BanHangOnl.Controllers" }
          );
            routes.MapRoute(
               name: "Products",
               url: "san-pham",
               defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "BanHangOnl.Controllers" }
           );
            routes.MapRoute(
              name: "detailNews",
              url: "chi-tiet-tin-tuc/{id}",
              defaults: new { controller = "News", action = "Detail", alias = UrlParameter.Optional },
              namespaces: new[] { "BanHangOnl.Controllers" }
          );
            routes.MapRoute(
               name: "News",
               url: "tin-tuc",
               defaults: new { controller = "News", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "BanHangOnl.Controllers" }
           );
            routes.MapRoute(
             name: "detailPosts",
             url: "chi-tiet-blog/{id}",
             defaults: new { controller = "Posts", action = "Detail", alias = UrlParameter.Optional },
             namespaces: new[] { "BanHangOnl.Controllers" }
         );
            routes.MapRoute(
               name: "Posts",
               url: "blog",
               defaults: new { controller = "Posts", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "BanHangOnl.Controllers" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BanHangOnl.Controllers" }
            );
        }
    }
}
