using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Vtİslemleri
{
    public class AdminService:DatabaseService<Admin>
    {
        public LoginDto LoginAdmin(string userName, string Password)
        {
            var userInfo = (from item in GetAll()
                            where item.UserName == userName && item.Pass == Password
                            select new LoginDto
                            {
                                id = item.Id,
                                userName = item.UserName,
                                pass = item.Pass
                            }
              ).SingleOrDefault();

            return userInfo;

        }
    }
}