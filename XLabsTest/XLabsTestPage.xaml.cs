using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XLabsTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XLabsTestPage : ContentPage
	{
		public XLabsTestPage()
		{
			XLabs.Forms.Controls.CheckBox cb;
			InitializeComponent();
		}
	}
}

