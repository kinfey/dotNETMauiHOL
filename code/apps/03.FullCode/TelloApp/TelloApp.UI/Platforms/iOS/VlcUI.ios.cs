using System;
using System.Threading.Tasks;
using Foundation;
using Microsoft.Maui.Graphics.Platform;
using ObjCRuntime;
using UIKit;

using MobileVLCKit;
using Microsoft.Maui.Handlers;

namespace TelloApp.UI
{
    public partial class VlcUIHandler : ViewHandler<IVlcUI, VideoPlayerView>
    {
        public VlcUIHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override VideoPlayerView CreatePlatformView()
        {
            var view = new VideoPlayerView();

            return view;
          }

        protected override void ConnectHandler(VideoPlayerView PlatformView)
        { }

        protected override void DisconnectHandler(VideoPlayerView PlatformView)
        {

            PlatformView.RemoveFromSuperview();
        }
    }


}