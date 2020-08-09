using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Vtİslemleri
{ 
    public class PostService:DatabaseService<Post>
    {
        public bool Updating(PostUpdateDto item)
        {
            var data = GetById(item.Id);
            AutoMapper.Mapper.DynamicMap(item, data);
            bool sonuc = Update(data);
            return sonuc;
            
        }
        public bool Adding(PostDto item)
        {
            var data = new Post();
            AutoMapper.Mapper.DynamicMap(item, data);
            return Add(data);
        }

        public void UpdateStock(int id,int stok)
        {
            var data = GetById(id);
            data.Stock = stok;
            Update(data);
        }

       
    }
}