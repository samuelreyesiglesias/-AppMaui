using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Services
{
    public  class ComandosPrueba
    {

		public Command CounterClickCommand { get; set; }

		public ComandosPrueba()
		{
			this.CounterClickCommand = new Command(this.methodCommand);
		}

		public void methodCommand()
		{ 
			App.Current.MainPage.DisplayAlert("testing 2 UI UX MAUI", "testing a message", "ok"); 
			
		}
	}
}
