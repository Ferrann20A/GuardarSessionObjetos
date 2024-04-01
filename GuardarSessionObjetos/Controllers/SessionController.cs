using GuardarSessionObjetos.Extensions;
using GuardarSessionObjetos.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuardarSessionObjetos.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult GuardarObjetoSession(int? btnpulsado)
        {
            if(btnpulsado != null)
            {
                if(btnpulsado.Value == 1)
                {
                    //CREAMOS EL OBJETO COCHE QUE QUEREMOS GUARDAR EN SESSION
                    Usuario user = new Usuario();
                    user.Nombre = "Usuario";
                    user.Email = "usuario@gmail.com";
                    user.Edad = 20;
                    user.Ciudad = "Madrid";
                    //ALMACENAMOS EN SESSION EL OBJETO COCHE UTILIZANDO LOS DOS NUEVOS METODOS
                    HttpContext.Session.SetObject("usuario", user);
                    ViewData["mensaje"] = "Se ha almacenado correctamente el objeto Usuario en Session";
                }else if(btnpulsado.Value == 2)
                {
                    //RECUPERAMOS EL OBJETO COCHE ALMANCENADO EN SESSION
                    Usuario user = HttpContext.Session.GetObject<Usuario>("usuario");
                    ViewData["coche"] = user;
                }
            }
            return View();
        }
    }
}
