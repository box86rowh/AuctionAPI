using System.Web.Http;
using DotNetNuke.Web.Api;

namespace AAModules.AuctionAPI
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {

            mapRouteManager.MapHttpRoute(
            moduleFolderName: "AAModules/AuctionAPI",
            routeName: "GetByParentId",
            url: "{controller}/{action}/{id}",
            namespaces: new[] { "AAModules.AuctionAPI.Controllers" });
            //http://dnndev.me/API/AAModules/AuctionAPI/ItemMedia/GetByParentId/1

            mapRouteManager.MapHttpRoute(
                moduleFolderName: "AAModules/AuctionAPI",
                routeName: "default",
                url: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional },
                namespaces: new[] { "AAModules.AuctionAPI.Controllers" });
            //http://dnndev.me/API/AAModules/AuctionAPI/Auction
        }
    }
}
