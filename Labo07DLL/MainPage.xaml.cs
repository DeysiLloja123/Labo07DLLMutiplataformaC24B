using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labo07DLL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            tareacss1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new tareacss());
            };
            ExplicitDemo1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            ImplicitControlDemo1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            ImplicitDemo1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };
            GlobalDemo1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };
            InheritanceDemo1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };
            DynamicDemo1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };

            tareacss2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new tareacss());
            };
            ExplicitControlDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };
            ExplicitDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            ImplicitControlDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            ImplicitDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };
            GlobalDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };
            InheritanceDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };
            DynamicDemo2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
        }
    }
}