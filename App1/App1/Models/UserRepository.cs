using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppInformeGranjas.Controller;
using SQLite;

namespace AppInformeGranjas.Models
{
    public class UserRepository
    {
        private SQLiteConnection con;
        private static UserRepository instancia;
        public static UserRepository Instancia {
            get {
                if (instancia == null) {
                    throw new Exception("Error callback inicializate");
                }
                return instancia;
            }
        }
        public UserRepository(){}

        public static void Inicializador(string filename) {
            if(filename == null)
            {
                throw new ArgumentNullException();
            }
            if (instancia != null)
            {
                instancia.con.Close();
            }
                instancia = new UserRepository(filename);
            

        }

        private UserRepository(string dbPath) {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<tb_login>();
            con.CreateTable<tb_detalles>();

        }

        public String EstadoMensaje; 

       /* public int AddnewLogin(int ID_CC, string Nombre, string Apellido, int usuario) {
            int result = 0;
            try {
                result = con.Insert(new tb_login() { 
                    ID_CC = ID_CC,
                    Nombre = Nombre,
                    Apellido = Apellido,
                    usuario = usuario
                });
                EstadoMensaje = string.Format("Cantidad de filas afectadas {0}", result);
            } catch (Exception e) {
                EstadoMensaje = e.Message;
            }
            return result;
        }*/

        public int AddnewDetalle(DateTime fecha, int granja,
            int galpon, int galponero, int mortalidad, decimal alimento, decimal peso,
            int veterinario)
        {
            int result = 0;
            try
            {
                result = con.Insert(new tb_detalles()
                {
                    fecha = fecha,
                    granja = granja,
                    galpon = galpon,
                    galponero = galponero,
                    mortalidad = mortalidad,
                    alimento = alimento,
                    peso = peso,
                    veterinario = veterinario
                });
                EstadoMensaje = string.Format("Cantidad de filas afectadas {0}", result);
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return result;
        }

        public IEnumerable<tb_login> GetAllLogin() {
            try {
                return con.Table<tb_login>();
            } catch (Exception e) {
                EstadoMensaje = e.Message;
            }
            return System.Linq.Enumerable.Empty<tb_login>();
        }
        public IEnumerable<tb_detalles> GetAllDetalle()
        {
            try
            {
                return con.Table<tb_detalles>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return System.Linq.Enumerable.Empty<tb_detalles>();
        }

        public tb_login GetSpecificUser(int id_cc)
        {
            return con.Table<tb_login>().FirstOrDefault(t => t.ID_CC == id_cc);
        }


        public bool LoginValidate(int id_cc)
        {
            var data = con.Table<tb_login>();
            var d1 = data.Where(x => x.ID_CC == id_cc).FirstOrDefault();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }

        public int usuarioValidate(int id_cc)
        {
            var data = con.Table<tb_login>();
            var d1 = data.Where(x => x.ID_CC == id_cc && x.usuario == 1).FirstOrDefault();
            var d2 = data.Where(x => x.ID_CC == id_cc && x.usuario == 2).FirstOrDefault();
            if (d1 != null  || d2 != null)
            {
                if (d1 != null)
                {
                    return 1;
                }
                else {
                    return 2;
                }
            }
            else
                return 3;
        }

        public string AddUser(tb_login login)
        {
            var data = con.Table<tb_login>();
            var d1 = data.Where(x => x.ID_CC == login.ID_CC).FirstOrDefault();
            if (d1 == null)
            {
                con.Insert(login);
                return "Sucessfully Added";
            }
            else
                return "Already Mail id Exist";
        }   
        public bool updateUserValidation(int userid)
        {
            var data = con.Table<tb_login>();
            var d1 = (from values in data
                      where values.ID_CC == userid
                      select values).Single();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }

        public int Select_usuario(int id_cc) {

            return Convert.ToInt32(con.Query<tb_login>("SELECT usuario FROM tb_login WHERE ID_CC = ?", id_cc));
        }

    }
}
