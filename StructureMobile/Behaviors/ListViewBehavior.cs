using System;
using StructureMobile.Models;
using StructureMobile.Views;
using Xamarin.Forms;

namespace StructureMobile.Behaviors
{
    public class ListViewBehavior : Behavior<ListView>
    {
        ListView listView;

        //Attacher comportement a un controle
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            listView = bindable;

            listView.ItemSelected += ListView_ItemSelected;
        }


        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Product selectedProduct = (listView.SelectedItem) as Product;
            Application.Current.MainPage.Navigation.PushAsync(new ProductDetailsPage(selectedProduct));

        }


        // declencher lorsque le comportement est supprimé du controle
        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            listView.ItemSelected -= ListView_ItemSelected;
        }

    }
}
