﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FormsX.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public MainViewModel()
        {
            _subtotal = 100;
            _generosity = 0.1;

            Recalculate();
        }
        private double _tip;
        public double Tip
        {
            get { return _tip; }
            set
            {
                if (_tip != value)
                {
                    _tip = value;
                    OnPropertyChanged(nameof(Tip));
                    Recalculate(); // vb võtan ära
                }
            }
        }
        private double _subtotal;
        public double Subtotal
        {
            get { return _subtotal; }
            set
            {
                if (_subtotal != value)
                {
                    _subtotal = value;
                    OnPropertyChanged(nameof(Subtotal));
                    Recalculate();
                }
            }
        }
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        private double _generosity;
        public double Generosity
        {
            get { return _generosity; }
            set
            {
                if (_generosity != value)
                {
                    _generosity = value;
                    OnPropertyChanged(nameof(Generosity));
                    Recalculate();
                }
            }
        }
        private double _total;
        public double Total
        {
            get { return _total; }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    OnPropertyChanged(nameof(Total));
                    Recalculate();
                }
            }
        }
        public void Recalculate()
        {
            Tip = Subtotal * Generosity;
            Total = Subtotal + Tip;
        }
    }
}
