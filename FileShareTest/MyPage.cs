using System;

using Xamarin.Forms;
using RestSharp;
using System.IO;
namespace FileShareTest
{
	public class MyPage : ContentPage
	{
		public Label lbl;

		public MyPage ()
		{
			//set layout
			StackLayout st = new StackLayout {
				VerticalOptions = LayoutOptions.Center
			};

			//set label
			lbl = new Label {
				XAlign = TextAlignment.Center,
				Text = "Ufuk!"
			};

			//add to screen
			st.Children.Add(lbl);
			Content = st;
		}

		public void uploadFile(string path)
		{
			//set base url
			var client = new RestClient("http://test.onevoicescj.com/api/v1/file/uploadImage/");

			//set request method
			var request = new RestRequest("avatars/ufuk{id}", Method.POST);
			request.AddUrlSegment("id", "1234"); // replaces matching token in request.Resource

			// add files to upload (works with compatible verbs)
			request.AddFile("pdfFile.pdf",path.Replace ("file://", ""));

			// execute aync request
			client.ExecuteAsync(request, response => {
				Console.WriteLine(response.Content);
			});
		}
	}
}


