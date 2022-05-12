using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410754346.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult SignUp(string name, string account, string password)
        {
            if (name == null || name == "")
            {
                ViewBag.NameMessage = "請輸入姓名";
            }else if(account == null || account == "")
            {
                ViewBag.AccountMessage = "請輸入帳戶";
            }else if(password == null || password == "")
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            else
            {
                ViewBag.Message = "註冊成功";
            }

            //if (name != null && name != "" && account != null && account != "" && password != null && password != "")
            //{
                
            //}
            return View();
        }
    }
}