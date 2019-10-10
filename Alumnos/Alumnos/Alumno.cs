using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Alumnos
{

    class Alumno
    {
        private Int32 claveUnica { get; set; }
        private String nombre { get; set; }
        private String sexo { get; set; }
        private String correo { get; set; }
        private Int16 semestre { get; set; }
        private int idPrograma { get; set; }

        public Alumno(short claveUnica)
        {
            this.claveUnica = claveUnica;
        }

        public Alumno(string nombre)
        {
            this.nombre = nombre;

        }

        public Alumno(short claveUnica, string correo)
        {
            this.claveUnica = claveUnica;
            this.correo = correo;
        }

        public Alumno(short claveUnica, string nombre, string sexo, string correo, short semestre, int idPrograma)
        {
            this.claveUnica = claveUnica;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
            this.idPrograma = idPrograma;
        }

        public Alumno(int claveUnica, string nombre, string sexo, string correo, short semestre, int idPrograma)
        {
            this.claveUnica = claveUnica;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
            this.idPrograma = idPrograma;
        }
        public Alumno(int claveUnica, string correo)
        {
            this.claveUnica = claveUnica;

            this.correo = correo;

        }

        public Alumno()
        {
        }
        //fct add alumno, return int >0 if true 
        public int agregar(Alumno a)
        {
            int res=0;
         
           
       
            try
            {
                //abrir la conexión

                SqlConnection con;
                con = Conexion.conectar();
                //command para ejecutar ek query (insert)
                SqlCommand cmd = new SqlCommand(String.Format("insert into alumno (claveUnica, nombre,sexo,correo,semestre,idPrograma) values ({0}, '{1}','{2}','{3}',{4},{5}) ", a.claveUnica, a.nombre, a.sexo, a.correo, a.semestre, a.idPrograma), con);
                res = cmd.ExecuteNonQuery(); //núm de registros afectos 
                                             //CERRAR CONEXIÓN
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alumno  no Dado de Alta"+ex);
            }
            
            return res;
        }
        public int eliminar(int cu)
        {
            int res=0;
            try
            {
                //abrir conexion
                SqlConnection con;
                con = Conexion.conectar();

                //command para ejecutar el query (insert)
                SqlCommand cmd = new SqlCommand(String.Format("delete from alumno where claveUnica = {0}", cu), con);
                //ejecutar query
                res = cmd.ExecuteNonQuery();
                //cerrar conexion
                con.Close();
            }
            catch(Exception ex)
            {
                res = -1;
            }
       
            return res;

        }
        public int modificar(Alumno a)
        {
            int res = 0;
            try
            {
                //abrir la conexión
                SqlConnection con;
                con = Conexion.conectar();
                //command para ejecutar ek query (update)
                SqlCommand cmd = new SqlCommand(String.Format("update alumno set correo = '{0}'  where claveUnica = {1}", a.correo, a.claveUnica), con);
                res = cmd.ExecuteNonQuery(); //núm de registros afectos 
                                             //CERRAR CONEXIÓN
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Alumno  no creado" + ex);
            }
           
            return res;

        }
        public List<Alumno> buscar (string nombre)
        {
            List<Alumno> lis = new List<Alumno>();
            Alumno a;
            SqlDataReader rd;

            //abrir la conexion 
            SqlConnection con;
            con = Conexion.conectar();

            //command para ejecutar el query (insert)
            SqlCommand cmd = new SqlCommand(String.Format("select * from alumno where nombre like '%{0}%'", nombre), con);
            //ejecutar el query
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                a = new Alumno();
                a.claveUnica = rd.GetInt16(0);
                a.nombre = rd.GetString(1);
                a.sexo = rd.GetString(2);
                a.correo = rd.GetString(3);
                a.semestre = rd.GetInt16(4);
                a.idPrograma = rd.GetInt16(5);
                lis.Add(a);

            }

            con.Close();
            return lis;
            /*List<Alumno> lis = new List<Alumno>();
            Alumno a;
            SqlDataReader rd;
            //abrir la conexión
            SqlConnection con;
            con = Conexion.conectar();
            //command para ejecutar ek query ()
            SqlCommand cmd = new SqlCommand(String.Format("select * from alumno where nombre like '%{0}%'", nombre), con);
            //ejecutar el query
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                //lectura y establecimiento de la información
                a = new Alumno();
                a.claveUnica = rd.GetInt16(0);
                a.nombre = rd.GetString(1);
                a.sexo = rd.GetString(2);
                a.correo = rd.GetString(3);
                a.semestre = rd.GetInt16(4);
                a.idPrograma = rd.GetInt16(5);
                lis.Add(a);

            }

            con.Close();

            return lis;*/

        }
        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Nombre " + nombre).Append(" Clave Única " + claveUnica);
            return res.ToString();
        }

    }
}
