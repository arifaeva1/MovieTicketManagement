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
    public class AuthService
    {

        public static TokenDTO Authenticate(string email, string password)
        {
            var staff = DataAccessFactory.AuthDataAccess().Authenticate(email, password);
            if (staff != null)
            {
                var token = new Token();
                token.Email = email;
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                token.Type = "HallStaff";
                var ttk = DataAccessFactory.TokenDataAccess().Create(token);
                if (ttk != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ttk);
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public static bool IsTokenValid(string tkey)
        {
            var extk = DataAccessFactory.TokenDataAccess().Read(tkey);
            if (extk != null && extk.ExpirationTime == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var extk = DataAccessFactory.TokenDataAccess().Read(tkey);
            extk.ExpirationTime = DateTime.Now;
            if (DataAccessFactory.TokenDataAccess().Update(extk) != null)
            {
                return true;
            }
            return false;


        }
    }
}
