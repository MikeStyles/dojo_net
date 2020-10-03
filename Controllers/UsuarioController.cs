using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DojoNetCore.Models;
using DojoNetCore;
using Microsoft.AspNetCore.Mvc;

namespace DojoNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        FirebaseAccount Instancia = FirebaseAccount.Instancia;

        Usuario usuario= new Usuario();
        
        public UsuariosController()
        {
        }
        [HttpGet]
        public async Task<List<Usuario>> Get(){
            return await Instancia.GetUSer();
        }
        [HttpPost]
        public async Task<String> Post(Usuario user){
            return await Instancia.AddUser(user);
        }

        [HttpDelete]
        public async Task<String> Delete([FromQuery]String id){
            return await Instancia.DeleteUser(id);
        }

    }
}