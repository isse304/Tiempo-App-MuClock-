using CommunityToolkit.Maui.Views;

namespace SEClockApp.PopUps;

public partial class AboutPopUp : Popup
{
	public AboutPopUp()
	{
		InitializeComponent();
	}

	private void AboutCloseHandler(object sender, EventArgs e) => Close();
}