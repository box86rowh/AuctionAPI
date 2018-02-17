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
    public class AuctionController : DnnApiController
    {

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Auction> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return Auction.GetAll<Auction>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public Auction Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Auction.GetById<Auction>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody]Auction a)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Auction.Persist<Auction>(db, a);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody]Auction a)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Auction.Persist<Auction>(db, a);
            }
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
            //http://dnndev.me/API/AAModules/AuctionAPI/Auction
        }
    }


}