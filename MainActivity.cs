using System;
using System.IO;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using AndroidX.AppCompat.App;

namespace Public_library
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtusername;
        EditText txtPassword;
        Button btncreate;
        Button btnsign;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnsign = FindViewById<Button>(Resource.Id.btnlogin);
            btncreate = FindViewById<Button>(Resource.Id.btnregister);
            txtusername = FindViewById<EditText>(Resource.Id.txtusername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtpwd);

            btnsign.Click += Btnsign_Click;
            btncreate.Click += Btncreate_Click;
        }
        private void Btncreate_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(New_User_Activity));
        }

        private void Btnsign_Click(object sender, EventArgs e)
        {
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "books.sqlite");
                var db = new SQLiteConnection(dpPath);
                var data = db.Table<Tbl_Login>();

                var data1 = data.Where(x => x.username == txtusername.Text && x.password == txtPassword.Text).FirstOrDefault();

                if (data1 != null)
                {
                    Toast.MakeText(this, "Login Success", ToastLength.Short).Show();

                    StartActivity(typeof(Logged_in_Activity));

                }
                else
                {
                    Toast.MakeText(this, "Username or Password invalid", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();

            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}



      
      



