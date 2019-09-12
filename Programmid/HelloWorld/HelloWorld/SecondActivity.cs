using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HelloWorld
{
    [Activity(Label = "SecondActivity")]
    class SecondActivity : Activity
    {
        EditText _arvField1;
        EditText _arvField2;

        Button _liitmine;
        Button _lahutamine;
        Button _korrutamine;
        Button _jagamine;

        TextView _vastus;

        protected override void OnCreate(Bundle savedInstanceState) // Main function
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_second);

            // Application

            _arvField1 = FindViewById<EditText>(Resource.Id.arv1);
            _arvField2 = FindViewById<EditText>(Resource.Id.arv2);

            _liitmine = FindViewById<Button>(Resource.Id.liitmine);
            _lahutamine = FindViewById<Button>(Resource.Id.lahutamine);
            _korrutamine = FindViewById<Button>(Resource.Id.korrutamine);
            _jagamine = FindViewById<Button>(Resource.Id.jagamine);

            _vastus = FindViewById<TextView>(Resource.Id.vastus);

           _liitmine.Click += delegate
           {
               try
               {
                   double a = Convert.ToDouble(_arvField1.Text);            
                   double b = Convert.ToDouble(_arvField2.Text);
                   double c = a + b;
                   _vastus.Text = Convert.ToString(c);
               }
               catch(System.FormatException)
               {
                   _vastus.Text = "You can enter only numbers";
               }
           };

           _lahutamine.Click += delegate
           {
               try
               {
                   double a = Convert.ToDouble(_arvField1.Text); // see on string ja ss convertin intiks            
                   double b = Convert.ToDouble(_arvField2.Text); // ja pärast kuvan selle _arvField1.Text
                   double c = a - b;
                   _vastus.Text = Convert.ToString(c);
               }
               catch(System.FormatException)
               {
                   _vastus.Text = "You can enter only numbers";
               }              
           };

           _korrutamine.Click += delegate
           {
               try
               {
                   double a = Convert.ToDouble(_arvField1.Text);
                   double b = Convert.ToDouble(_arvField2.Text);
                   double c = a * b;
                   _vastus.Text = Convert.ToString(c);
               }
               catch(System.FormatException)
               {
                   _vastus.Text = "You can enter only numbers";
               }
           };

            _jagamine.Click += delegate
           {
               try
               {
                   double a = Convert.ToDouble(_arvField1.Text);
                   double b = Convert.ToDouble(_arvField2.Text);
                   double c = Math.Round(a / b, 2);
                   _vastus.Text = Convert.ToString(c);
               }
               catch (System.FormatException)
               {
                   _vastus.Text = "You can enter only numbers";
               }
               catch (System.NullReferenceException)
               {
                   _vastus.Text = "You can't divide by 0";
               }
           };
        }
    }
}