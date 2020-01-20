namespace App1
{
    using AppInformeGranjas;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using AppInformeGranjas.Models;

    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Master = new MasterMain();
            this.Detail = new NavigationPage(new DetailMain());
            ConnectMysql con = new ConnectMysql();
            con.Connection();
            
            
        }
    }
    }

