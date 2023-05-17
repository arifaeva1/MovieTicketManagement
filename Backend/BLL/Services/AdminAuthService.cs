using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminAuthService
    {
        public static AdminTokenDTO Authenticate(string uname, string pass)
        {

            var res = DataAccessFactory.AuthData1().Authenticate(uname, pass);
            if (res)
            {
                var token = new AdminToken();
                token.Aname = uname;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.AdminTokenData().Create(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c => {
                        c.CreateMap<AdminToken, AdminTokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<AdminTokenDTO>(ret);
                }

            }
            return null;
        }
        public static bool IsTokenValid(string tkey)
        {
            var extk = DataAccessFactory.AdminTokenData().Read(tkey);
            if (extk != null && extk.DeletedAt == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var extk = DataAccessFactory.AdminTokenData().Read(tkey);
            extk.DeletedAt = DateTime.Now;
            if (DataAccessFactory.AdminTokenData().Update(extk) != null)
            {
                return true;
            }
            return false;


        }
        public static bool IsAdmin(string tkey)
        {
            var extk = DataAccessFactory.AdminTokenData().Read(tkey);
            if (IsTokenValid(tkey) && extk.Admin.Type.Equals("Admin"))
            {
                return true;
            }
            return false;
        }
    }
}