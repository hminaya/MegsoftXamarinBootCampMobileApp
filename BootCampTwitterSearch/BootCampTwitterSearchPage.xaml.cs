using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace BootCampTwitterSearch
{
	public partial class BootCampTwitterSearchPage : ContentPage
	{

		TweetViewModel vm;

		public BootCampTwitterSearchPage()
		{
			InitializeComponent();

			vm = new TweetViewModel();
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{

			var results = await TweetHelper.Search(this.txtSearchTerm.Text);

			vm.TweetResults = results;
			xResultsView.ItemsSource = vm.TweetResults;

		}
	}
}
