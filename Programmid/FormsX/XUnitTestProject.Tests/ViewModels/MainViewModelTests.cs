using FormsX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Tests.ViewModels
{
    public class MainViewModelTests
    {
        [Fact]
        public void Recalculate_SubTotal100_Should_Return_Total120()
        {
            var mainViewModel = new MainViewModel();
            mainViewModel.Subtotal = 100;
            mainViewModel.Generosity = 0.1;
            Assert.Equal(110, mainViewModel.Total);
        }
    }
}