﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Models;

namespace XForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            notesListView.ItemsSource = await App.Database.GetNotesAsync();

            //    var notes = new List<Note>();
            //    var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            //    foreach (var filename in files)
            //    {
            //        notes.Add(new Note
            //        {
            //            Filename = filename,
            //            Text = File.ReadAllText(filename),
            //            Date = File.GetCreationTime(filename)
            //        });
            //    }
            //    notesListView.ItemsSource = notes.OrderBy(d => d.Date).ToList();
        }

            async void OnNoteAddedClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = new Note()
                });
            }
            async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem != null)
                {
                    await Navigation.PushAsync(new NoteEntryPage
                    {
                        BindingContext = e.SelectedItem as Note
                    });
                }
            }
        }
}