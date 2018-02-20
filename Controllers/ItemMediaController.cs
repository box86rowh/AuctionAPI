using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DotNetNuke.Web.Api;
using AuctionData.Models;
using AuctionData.Connections;

namespace AAModules.AuctionAPI.Controllers
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
        public IEnumerable<ItemMedia> GetByParentId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ItemMedia.GetByItemId(db, id);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(ItemMedia m)
        {
            using(var db = DBConnection.GetConnection())
            {
                return ItemMedia.Delete<ItemMedia>(db, m);
            }
        }

    }

}