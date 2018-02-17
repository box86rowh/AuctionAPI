using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DotNetNuke.Web.Api;
using AuctionData.Models;
using AuctionData.Connections;

namespace AAModules.AuctionAPIAuctionAPI.Controllers
{
        public class LocationController : DnnApiController
        {
            [AllowAnonymous]
            [HttpGet]
            public IEnumerable<Location> Get()
            {
                using (var db = DBConnection.GetConnection())
                {
                    return Location.GetAll<Location>(db);
                }
            }

            [AllowAnonymous]
            [HttpGet]
            public Location Get(int id)
            {
                using (var db = DBConnection.GetConnection())
                {
                    return Location.GetById<Location>(db, id);
                }
            }

            [AllowAnonymous]
            [HttpPut]
            public bool Put(Location i)
            {
                using (var db = DBConnection.GetConnection())
                {
                    return Location.Persist<Location>(db, i);
                }
            }

            [AllowAnonymous]
            [HttpPost]
            public bool Post(Location i)
            {
                using (var db = DBConnection.GetConnection())
                {
                    return Location.Persist<Location>(db, i);
                }
            }


            public class RouteMapper : IServiceRouteMapper
            {
                public void RegisterRoutes(IMapRoute mapRouteManager)
                {

                    mapRouteManager.MapHttpRoute(
                        moduleFolderName: "AAModules/AuctionAPI",
                        routeName: "default",
                        url: "{controller}/{id}",
                        defaults: new { id = RouteParameter.Optional },
                        namespaces: new[] { "AAModules.AuctionAPIAuctionAPI.Controllers" });
                    //http://dnndev.me/API/AAModules/AuctionAPI/Location

                }
            }
        }
   }
