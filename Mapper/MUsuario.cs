using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;

namespace Mapper
{
    public class MUsuario : IGestor<BEUsuario>
    {
        Conexion Conexion;

        public bool Baja(BEUsuario oBEUsuario)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEUsuario oBEUsuario)
        {
            
            string ConsultaSql;
            if (oBEUsuario.Codigo == 0)
            {
                ConsultaSql = "Insert into Usuario (Nombre, Apellido,DNI, Sexo) " +
                    "values('" + oBEUsuario.Nombre + "', '" + oBEUsuario.Apellido + "', " + oBEUsuario.DNI + ",'" + oBEUsuario.Sexo + "' ) ";
            }
            else
            {
                ConsultaSql = "Update Usuario SET Nombre = '" + oBEUsuario.Nombre + "', Apellido = '" + oBEUsuario.Apellido + "', DNI = '" + oBEUsuario.DNI + "', Sexo = '" + oBEUsuario.Sexo + "' where codigo = " + oBEUsuario.Codigo + "";
            }
            Conexion = new Conexion();
            return Conexion.Escribir(ConsultaSql);

        }

        public BEUsuario ListarObjeto(BEUsuario oBEUsuario)
        {
            Conexion = new Conexion();

            string ConsultaSql = "Select Codigo,Nombre,Apellido,Sexo from Usuario where DNI = " + oBEUsuario.DNI + "";

            return Conexion.LeerUsuario(ConsultaSql);
        }

        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
