using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ApiCrud.Properties.Estudantes
{
    public  static class EstudantesRotas
    {
        public static void AddRotasEstudantes(this WebApplication app)
        {
            app.MapGet("JujubaEstudantes", () => "Oi");
        }
    }
}