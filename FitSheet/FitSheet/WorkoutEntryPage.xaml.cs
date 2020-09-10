using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitSheet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutEntryPage : ContentPage
    {
        public WorkoutEntryPage()
        {
            InitializeComponent();
        }
        async void AddExerciseClicked(object sender, EventArgs e)
        {
            var exercise = new FitSheet.Models.Exercise();
        }

    }
}