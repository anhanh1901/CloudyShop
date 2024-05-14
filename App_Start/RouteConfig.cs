﻿using System.Web.Mvc;
using System.Web.Routing;

namespace CloudyShop
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
                namespaces: new[] { "CloudyShop.Controllers" }
            );
            routes.MapRoute(
                name: "Cart",
                url: "gio-hang",
                defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "CloudyShop.Controllers" }
            );
            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
                namespaces: new[] { "CloudyShop.Controllers" }
            );
            routes.MapRoute(
               name: "vnpay_return",
               url: "vnpay_return",
               defaults: new { controller = "ShoppingCart", action = "VnpayReturn", alias = UrlParameter.Optional },
               namespaces: new[] { "CloudyShop.Controllers" }
                );
            routes.MapRoute(
                name: "News",
                url: "tin-tuc",
                defaults: new { controller = "News", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "CloudyShop.Controllers" }
            );
            routes.MapRoute(
              name: "NewsDetail",
              url: "{alias}-n{id}",
              defaults: new { controller = "News", action = "Detail", id = UrlParameter.Optional },
              namespaces: new[] { "CloudyShop.Controllers" }
          );
            routes.MapRoute(
              name: "CategoryProduct",
              url: "danh-muc-san-pham/{alias}-{id}",
              defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
              namespaces: new[] { "CloudyShop.Controllers" }
          );
            routes.MapRoute(
                name: "ProductDetail",
                url: "chi-tiet/{alias}-p{id}",
                defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional },
                namespaces: new[] { "CloudyShop.Controllers" }
            );

            routes.MapRoute(
                name: "Product",
                url: "san-pham",
                defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "CloudyShop.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "CloudyShop.Controllers" }
            );
        }
    }
}
