using System;
using System.Collections.Generic;
using System.Text;
using Android.Widget;
using MySql.Data.MySqlClient;

namespace AppInformeGranjas.Models
{
    class ConnectMysql
    {

        private MySqlConnection connection;
        private string server;
        private string connect;
        private string database;
        private string uid;
        private string password;

        public void Connection()
        {
            try {
                connect = @"Server=databases.000webhost.com; Database=id12230130_informe_control_pollos;
                            Uid=id12230130_root; Pwd=12345;";   
                connection = new MySqlConnection(connect);
                connection.Open();
                var context = Android.App.Application.Context;
                Toast.MakeText(context, "Conectado", ToastLength.Long).Show();
                }catch (Exception ex) {
                var context = Android.App.Application.Context;
                Toast.MakeText(context, ex.Message, ToastLength.Long).Show();
                }
        }


     }
}
