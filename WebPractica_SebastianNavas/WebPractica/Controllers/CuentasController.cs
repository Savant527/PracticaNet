using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPractica.Models;

namespace WebPractica.Controllers
{
    public class CuentasController : Controller
    {
        //Variable para crear el password
        private readonly UserManager<IdentityUser> _userManager;
        //Variable para autenticarse
        private readonly SignInManager<IdentityUser> _signInManager;

        //Crea,os el constructor de esta clase con ctor

        public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Retoma la vista Registro Usuario
        [HttpGet]

        public async Task<IActionResult> Registro ()
        {
            RegistroUsuarios RuVista = new RegistroUsuarios();
            return View(RuVista);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Registro(RegistroUsuarios ru)
        {
           //Verifico si el modelo es válido
           if (ModelState.IsValid)
            {
                //Creo una variable
                var usuario = new AppUsuario
                {
                    UserName = ru.Email,
                    Email = ru.Email,
                    Documento = ru.Documento,
                    Nombre = ru.Nombre
                };
                //Recibe dos parametros, la variable usuario y el password
                var resultado = await _userManager.CreateAsync(usuario, ru.Password);
                //Verifica que todo salio bien
                if(resultado.Succeeded)
                {
                    //se autentica
                    await _signInManager.SignInAsync(usuario, isPersistent: false);
                    //volver a la pagina de inicio
                    return RedirectToAction("Index", "Home");
                }
                ValidarErrores(resultado);
            }
            //Si el modelo no es valido retorna a la vista donde estaba
            return View(ru);
        }
            //Manejador de errores
            private void ValidarErrores(IdentityResult resultado)
             {
            foreach (var error in resultado.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        //metodo mostrar login
        [HttpGet]

        public IActionResult Acceso()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Acceso(LoginUsuarios lu)
        {
            if(ModelState.IsValid)
            {
                //Recibe dos parámetros, la variable usuario y el password
                var resultado = await _signInManager.PasswordSignInAsync(lu.Email, lu.Password, lu.Remerberme, lockoutOnFailure: false);
                //Verifica que todo salió bien
                if (resultado.Succeeded)
                {
                    //vuelva a la página de inicio
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ingreso inválido");
                    return View(lu);
                }       
            }
            return View(lu);
        }

        //Cerrar sesión
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> SalirAplicacion()
        {
            //Cierra la sesion (Logout)
            await _signInManager.SignOutAsync();
            //Vuelve a la página de inicio
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
