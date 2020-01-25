﻿using System;
using System.Collections.Generic;
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

        public int AddnewLogin(int ID_CC, string Nombre, string Apellido, int usuario) {
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
        }

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
    }
}