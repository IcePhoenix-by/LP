using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Hosting;
using LPProject.Domain.Abstract;
using LPProject.Domain.Concrete;
using LPProject.Domain.Context;
using LPProject.Domain.Entity;

namespace LPProject.WebUI.Controllers
{
    public class ShopsController : ApiController
    {
       private readonly IUnitOfWork db;

        public ShopsController()
        {
            this.db = new UnitOfWork();

        }
        // GET: api/Shops
 
        public IEnumerable<Shop> Get()
        {

            return db.Shops.GetAll();
        
        }

        // GET: api/Shops/5
        [ResponseType(typeof(Shop))]
        public IHttpActionResult Get(int id)
        {
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return NotFound();
            }

            return Ok(shop);
        }


        public IHttpActionResult Post(Shop shop)
        {
            db.Shops.Add(shop);
            db.SaveChanges();
            return Ok();
        }

        public IEnumerable<Goods> GetGoods(int id)
        {

            return db.Goodses.GetAll().Where(x=>x.ShopId==id);
         }


        public IHttpActionResult Put(Shop item)
        {


                var shop = db.Shops.Find(item.Id);
                shop.Name = item.Name;
                shop.Address = item.Address;
                shop.TimeOfWork = item.TimeOfWork;
                db.SaveChanges();
                return Ok();
        }

        public IHttpActionResult Delete(int id)
        {


                var shop = db.Shops.Find(id);
                db.Shops.Remove(shop);
                db.SaveChanges();

            

             return Ok();

        }
    

     
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}