using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace TouchOfDeath
{
    [Activity(Label = "TouchOfDeath", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        public int scene = 0;
		public int maxTargets = 10;
		public List<Projectile> targetArray = new List<Projectile>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

		//Fills array to max size while array is smaller than max
		void fillArray(){
			if (targetArray.Count < 10) {
				targetArray.Add (new Projectile());
			}
		}

		//Checks all objects in targetArray for death flag and removes marked objects
		void checkDead(){
			targetArray.RemoveAll(x=>x.isDead == true);
		}
			

        void Update()
        {
            switch (scene)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }

			//gameplay logic
			checkDead ();
			fillArray();

        }


    }
}

