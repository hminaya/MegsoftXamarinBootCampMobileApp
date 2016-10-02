using System;
using System.ComponentModel;

namespace BootCampTwitterSearch
{
	public class Tweet : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _id;
		public string id { 
			get { return _id; }
			set { _id = value; }
		}

		private string _text;
		public string text
		{
			get { return _text;}
			set {_text = value;}
		}

		private User _user;
		public User user {

			get { return _user;}
			set { _user = value; }

		}


	}

	public class User : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;


		private string _name;
		public string name { 
			get { return _name;}
			set { _name = value; }
		}

		private string _location;
		public string location { 
			get { return _location; }
			set { _location = value; }
		}

		private string _profile_image_url;
		public string profile_image_url { 
			get { return _profile_image_url; }
			set { _profile_image_url = value;}
		}


	}
}
