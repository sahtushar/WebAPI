using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Basic.Models;
namespace WebAPI_Basic.Controllers
{
    public class CarDetailsController : ApiController
    {

      

        // GET api/cardetails/5
        public IEnumerable<Discount> Get(string id)
        {
            Discount ST = new Discount();
            Discount ST1 = new Discount();
            Discount ST2 = new Discount();
            List<Discount> li = new List<Discount>();
            if (id == "PP15")
            {
                ST.DiscountName = "15% off!";
                ST.DiscountValue = "15";
                li.Add(ST);
                return li;
            }
            else if(id=="PP50")
            {

                ST1.DiscountName = "50% off!";
                ST1.DiscountValue = "50";
                li.Add(ST1);
                return li;
            }
            else
            {
                ST2.DiscountName = "";
                ST2.DiscountValue = "0";
                li.Add(ST2);
                return li;
            }
           
        }


        [HttpPost] // POST api/cardetails
        public void PostCar([FromBody] Discount cs)
        {

        }


        [HttpPut]  // put api/cardetails/5
        public void Putcar(string id, [FromBody]Discount cs)
        {
        }


        [HttpDelete] // put api/cardetails/5
        public void Deletecar(string id)
        {
        }

    }
}
