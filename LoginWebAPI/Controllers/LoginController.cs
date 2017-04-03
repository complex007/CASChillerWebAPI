using LoginWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace LoginWebAPI.Controllers
{
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [HttpPost]
        public Login Loginpost(LoginInput logininfo)
        {
            using (var entity = new CASChillerSystemEntities())
            {
                Login login = new Login();
                string username = logininfo.Username;
                string password = logininfo.Password;
                string appname = logininfo.Appname;
                if (Membership.ValidateUser(username, password))
                {

                    aspnet_Users asp_user = entity.aspnet_Users.Where(x => x.UserName == username).FirstOrDefault();
                        User user = entity.Users.Where(y => y.userlogin_id == asp_user.UserId).FirstOrDefault();
                        List<Modules> modulelist = new List<Modules>();
                        List<user_module> uml = entity.user_module.Where(z => z.users_id == user.Users_ID && z.menu_group == appname).ToList();
                        if(uml!=null&&uml.Count!=0)
                        {
                        
                            login.Status = true;
                            for (int i = 0; i < uml.Count; i++)
                            {
                                Modules modules = new Modules();
                                int moduleid = (int)uml[i].Module_ID;
                                modules.Module_Name = entity.modules.Where(x => x.module_id == moduleid).Select(y => y.module_name).FirstOrDefault();
                                modules.Module_Display=uml[i].module_display_name;
                                int module_id = (int)uml[i].Module_ID;
                                module module = entity.modules.Where(x => x.module_id == module_id).FirstOrDefault();
                                modules.Module_Icon = module.description;
                                modulelist.Add(modules);
                            }
                            login.AppName = appname;
                            login.Token=entity.aspnet_Membership.Where(y => y.UserId == asp_user.UserId).Select(x => x.Password).FirstOrDefault();
                            login.Modules = modulelist;
                            login.Id = user.Users_ID;

                            //insert user login record to Transaction_Log table
                            Transaction_Log tl = new Transaction_Log();
                            tl.Log_Description = "User Login";
                            tl.Creation_Time = DateTime.Now;
                            tl.Creator = login.Id;
                            tl.Remarks = appname;
                            entity.Transaction_Log.Add(tl);
                            entity.SaveChanges();

                        
                        }



                }


                return login;
            }
        }



    }
}