using Otel.Business.Abstract; //use 
using Otel.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Otel.Business.ExtensionMethods;//use
namespace Otel.Business.Concrete
{
    public class LoginManager : ILoginService
    {
        private readonly IUserDal _userDal;
        public LoginManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<string> Login(string email, string password)
        {
            List<string> result = new List<string>();
            if (email == null)
            {
                result.Add("Email Boş Bırakılamaz.");
            }
            if (password == null)
            {
                result.Add("Şifre Giriniz.");
            }
            if (email.CheckEmail())
            {
                result.Add("Email Hatalı");
            }
            if (result.Count == 0)
            {
                string passwordMd5 = password.ToMd5();
                bool loginCheck = _userDal.Any(x => x.UserName == email && x.Password == password.ToMd5());
                if (loginCheck)
                {

                }
                else
                {

                }
            }
        }
    }
}
