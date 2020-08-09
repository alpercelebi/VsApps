using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Vtİslemleri
{
    public class OrderPostService:DatabaseService<OrderPost>
    {
        public List<OrderPost> GetByUser(int id)
        {
            var data = (from p in GetAll()
                        where p.UserId == id
                        select new OrderPost
                        {
                            Stock = p.Stock,
                            OnayDurumu = p.OnayDurumu,
                            PostId = p.PostId,
                            Adress=p.Adress
                            
                        }
                      ).ToList();
            return data;
        }
    }
}