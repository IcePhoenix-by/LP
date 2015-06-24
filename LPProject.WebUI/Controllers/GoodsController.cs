using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LPProject.Domain.Abstract;
using LPProject.Domain.Concrete;
using LPProject.Domain.Context;
using LPProject.Domain.Entity;

namespace LPProject.WebUI.Controllers
{
    public class GoodsController : ApiController
    {
        private readonly IUnitOfWork db;

        public GoodsController()
        {
            
             db=new UnitOfWork();
        }
        // GET: api/Goods
        public IHttpActionResult Post(Goods goods)
        {
            db.Goodses.Add(goods);
            db.SaveChanges();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {


            var goods = db.Goodses.Find(id);
            db.Goodses.Remove(goods);
            db.SaveChanges();



            return Ok();

        }
    }
}