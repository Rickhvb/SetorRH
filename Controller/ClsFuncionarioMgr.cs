using System;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Controlador
{
    public class ClsFuncionarioMgr
    {

        clsDados cnGeneral = null;
        ClsContacto objContacto = null;
        DataTable tblDatos = null;


        public ClsContactoMgr(ClsContacto parObjContacto)
        {
            objContacto = parObjContacto;
        }
        //RETORA TABLA CON LOS CONTACTOS
        public DataTable Listar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new clsDatos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objContacto.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPContacto");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        //GUARDA CONTACTO
        public void Guardar()
        {



            try
            {
                cnGeneral = new clsDatos();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objContacto.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Id";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objContacto.Id;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objContacto.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Telefono";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 20;
                parParameter[3].SqlValue = objContacto.Telefono;

                cnGeneral.EjecutarSP(parParameter, "SPContacto");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        public void Actualizar()
        {



            try
            {
                cnGeneral = new clsDatos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objContacto.opc;

                //parParameter[1] = new SqlParameter();
                //parParameter[1].ParameterName = "@Id";
                //parParameter[1].SqlDbType = SqlDbType.Int;
                //parParameter[1].SqlValue = objContacto.Id;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objContacto.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Telefono";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objContacto.Telefono;

                cnGeneral.EjecutarSP(parParameter, "SPContacto");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}