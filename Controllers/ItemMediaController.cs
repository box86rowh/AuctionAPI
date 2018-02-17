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
    public class ItemMediaController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<ItemMedia> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return ItemMedia.GetAll<ItemMedia>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ItemMedia Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ItemMedia.GetById<ItemMedia>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put(ItemMedia i)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ItemMedia.Persist<ItemMedia>(db, i);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post(ItemMedia i)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ItemMedia.Persist<ItemMedia>(db, i);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<ItemMedia> GetByItemId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ItemMedia.GetByItemId(db, id);
            }
        }


        public class RouteMapper : IServiceRouteMapper
        {
            public void RegisterRoutes(IMapRoute mapRouteManager)
            {

                mapRouteManager.MapHttpRoute(
                    moduleFolderName: "AAModules/AuctionAPI",
                    routeName: "GetByItemId",
                    url: "{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional },
                    namespaces: new[] { "AAModules.AuctionAPIAuctionAPI.Controllers" });
                //http://dnndev.me/API/AAModules/AuctionAPI/ItemMedia/GetByItemId/1

                mapRouteManager.MapHttpRoute(
                    moduleFolderName: "AAModules/AuctionAPI",
                    routeName: "default",
                    url: "{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional },
                    namespaces: new[] { "AAModules.AuctionAPIAuctionAPI.Controllers" });
                //http://dnndev.me/API/AAModules/AuctionAPI/ItemMedia

            }
        }
    }
}