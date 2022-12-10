using System;
using System.IO;
using TPFinal.Data;
using Xamarin.Forms;

namespace TPFinal
{
    public partial class App : Application
    {
        static MercadoriaDatabase database;

        // Create the database connection as a singleton.
        public static MercadoriaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MercadoriaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}