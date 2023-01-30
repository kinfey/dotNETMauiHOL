namespace TelloMAUI;

public partial class MainPage : ContentPage
{
    TelloSDK tello = new();

    public MainPage()
	{
		InitializeComponent();


        tello.Connect();
        tello.Command("command");
    }

    

    void btnTakeOff_Clicked(System.Object sender, System.EventArgs e)
    {
        tello.TakeOff();
    }

    void btnLand_Clicked(System.Object sender, System.EventArgs e)
    {
        tello.Land();
    }

    void btnUp_Clicked(System.Object sender, System.EventArgs e)
    {
        tello.FlyCMD("up 20");
    }

    void btnDown_Clicked(System.Object sender, System.EventArgs e)
    {
        tello.FlyCMD("down 20");
    }

    void btnLeft_Clicked(System.Object sender, System.EventArgs e)
    {
        tello.FlyCMD("left 20");
    }

    void btnRight_Clicked(System.Object sender, System.EventArgs e)
    {
        tello.FlyCMD("right 20");
    }
}

