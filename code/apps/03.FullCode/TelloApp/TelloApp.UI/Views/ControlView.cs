namespace TelloApp.UI;


#if IOS

using Foundation;
using MobileVLCKit;

#endif


public class ControlView : View{

    readonly TelloSDK tello = new();

	[State]
	readonly TelloStatus telloStatus = new();

    public ControlView()
    {
        tello.Connect();
        tello.Command("command");
        tello.Command("streamon");
    }


    [Body]
    View body()
        => new VStack {
           new VStack
           {
             new VlcUI().Padding(20).Alignment(Alignment.TopLeading)
           }.Frame(width:400,height:300).Alignment(Alignment.Center),
           new Grid{
            new VStack(){
                new HStack(){
                    new ImageButton("up.png" ,()=>{
                        tello.FlyCMD("up 20");
                    }).Frame(width:50,height:50).Alignment(Alignment.Center),
                },
                new HStack(){
                    new ImageButton("left.png" ,()=>{
                        tello.FlyCMD("left 20");
                    }).Frame(width:50,height:50).Alignment(Alignment.Leading),
                    new ImageButton(telloStatus.DroneStatus ,()=>{
                        if(telloStatus.TakeOff){
                           tello.TakeOff();
                        }
                        else
                        {
                           tello.Land();
                        }
                        telloStatus.TakeOff = !telloStatus.TakeOff;
                    }).Frame(width:80,height:80).Alignment(Alignment.Center),
                    new ImageButton("right.png" ,()=>{
                            tello.FlyCMD("right 20");
                    }).Frame(width:50,height:50).Alignment(Alignment.Trailing),
                },
                new HStack(){
                    new ImageButton("down.png" ,()=>{
                            tello.FlyCMD("down 20");
                    }).Frame(width:50,height:50).Alignment(Alignment.Center),
                },
            }.Alignment(Alignment.Top),
          }.Alignment(Alignment.Top)
        }.Background(Color.FromRgb(82, 45, 210)).Alignment(Alignment.Top);

    
	public class TelloStatus : BindingObject
	{
        public TelloStatus()
        {
            TakeOff = true;
        }   
		public bool TakeOff
		{
			get => GetProperty<bool>();
			set => SetProperty(value);
		}

		public string DroneStatus
		{
			get
			{
				return TakeOff ? "fly_takeoff.png" : "fly_land.png";
			}
            set => SetProperty(value);
		}

	}

}