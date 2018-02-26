using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data;
using Todo.Views;
using Xamarin.Forms;

namespace Todo
{
	public partial class App : Application
	{
		static TodoItemDatabase database;

		public App ()
		{
			InitializeComponent();

			Resources = new ResourceDictionary();
			Resources.Add("primaryGreen", Color.FromHex("91CA47"));
			Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

			var nav = new NavigationPage(new TodoListPage());
			nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
			nav.BarTextColor = Color.White;
		
			MainPage = nav;
		}

		public static TodoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new TodoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
				}
				return database;
			}
		}

		public int ResumeAtTodoId { get; set; }
	}
}
