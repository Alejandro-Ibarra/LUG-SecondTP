using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;
using System.Data;
using System.Windows.Forms;

namespace Mapper
{
    public class MUsuario : IGestor<BEUsuario>
    {
        Conexion oConexion;

        

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
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);


        }

        public bool Baja(BEUsuario oBEUsuario)
        {
            if (oBEUsuario.Materiales != null)
            {
                foreach (BEMaterial Material in oBEUsuario.Materiales)
                {
                    string Consulta = " Delete from Usuario_Materiales where CodUsuario = " + oBEUsuario.Codigo + "  and CodMateriales =" + Material.Codigo + "";
                    oConexion = new Conexion();
                    oConexion.Escribir(Consulta);
                }
            }
            string Consulta2 = "Delete from Usuario where Codigo = " + oBEUsuario.Codigo + "";
            return oConexion.Escribir(Consulta2);
        }
    

        public BEUsuario ListarObjeto(BEUsuario oBEUsuario)
        {
            try
            {
                string ConsultaSql = "Select Codigo,Nombre,Apellido,Sexo from Usuario where DNI = " + oBEUsuario.DNI + "";
                DataTable oDataTable;
                Conexion oConexion = new Conexion();
                List<BEMaterial> ListaMateriales = new List<BEMaterial>();
                oDataTable = oConexion.LeerDataTable(ConsultaSql);
                oBEUsuario.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[0]);
                oBEUsuario.Nombre = oDataTable.Rows[0].ItemArray[1].ToString();
                oBEUsuario.Apellido = oDataTable.Rows[0].ItemArray[2].ToString();
                oBEUsuario.Sexo = oDataTable.Rows[0].ItemArray[3].ToString();

                DataSet oDataSet = new DataSet();
                string ConsultaSql2 = "Select  Materiales.Codigo as CodMateriales, Materiales.Nombre as MatNombres, Materiales.Peso as MatPeso from Materiales, Usuario_Materiales where Materiales.Codigo = Usuario_Materiales.CodMateriales and Usuario_Materiales.CodUsuario = " + oBEUsuario.Codigo + "";
                oDataSet = oConexion.LeerDataSet(ConsultaSql2);
                if (oDataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataSet.Tables[0].Rows)
                    {
                        BEMaterial oBEMat = new BEMaterial();
                        oBEMat.Codigo = Convert.ToInt32(fila[0]);
                        oBEMat.Nombre = fila[1].ToString();
                        oBEMat.Peso = Convert.ToInt32(fila[2]);
                        ListaMateriales.Add(oBEMat);
                    }
                    oBEUsuario.Materiales = ListaMateriales;
                }
                else
                { oBEUsuario.Materiales = null; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return oBEUsuario;
        }
        
        public bool AgregarUsuarioMaterial(BEUsuario oBEusuario, BEMaterial oBEMaterial)
        {
            string Consulta = "INSERT INTO Usuario_Materiales (CodUsuario, CodMateriales) values(" + oBEusuario.Codigo + "," + oBEMaterial.Codigo + ")";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);
        }

        public bool EliminarMaterialAsociado(BEUsuario oBEusuario, BEMaterial oBEMaterial)
        {
            string Consulta = " Delete from Usuario_Materiales where CodUsuario = " + oBEusuario.Codigo + "  and CodMateriales =" + oBEMaterial.Codigo + "";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);
        }
        
        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }


    }
}
