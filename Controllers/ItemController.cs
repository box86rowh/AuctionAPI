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
    public class ItemController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            using(var db = DBConnection.GetConnection())
            {
                return Item.GetAll<Item>(db);
            }  
        }

        [AllowAnonymous]
        [HttpGet]
        public Item Get(int id)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Item.GetById<Item>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put(Item i)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Item.Persist<Item>(db, i);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post(Item i)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Item.Persist<Item>(db, i);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Item> GetByParentId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Item.GetByAuctionId(db, id);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(Item i)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Item.Delete<Item>(db, i);
            }
        }

    }
}