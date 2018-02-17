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
    public class AuctionMediaController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<AuctionMedia> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return AuctionMedia.GetAll<AuctionMedia>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public AuctionMedia Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return AuctionMedia.GetById<AuctionMedia>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put(AuctionMedia i)
        {
            using (var db = DBConnection.GetConnection())
            {
                return AuctionMedia.Persist<AuctionMedia>(db, i);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post(AuctionMedia i)
        {
            using (var db = DBConnection.GetConnection())
            {
                return AuctionMedia.Persist<AuctionMedia>(db, i);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<AuctionMedia> GetByParentId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return AuctionMedia.GetByAuctionId(db, id);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(AuctionMedia m)
        {
            using (var db = DBConnection.GetConnection())
            {
                return AuctionMedia.Delete<AuctionMedia>(db, m);
            }
        }

        
    }

}