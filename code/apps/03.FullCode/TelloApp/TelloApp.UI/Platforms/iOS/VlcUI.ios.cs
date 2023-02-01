using System;
using System.Threading.Tasks;
using Foundation;
using Microsoft.Maui.Graphics.Platform;
using ObjCRuntime;
using UIKit;

using MobileVLCKit;
using Microsoft.Maui.Handlers;
using MapKit;
//using System.Drawing;

namespace TelloApp.UI
{
    public partial class VlcUIHandler : ViewHandler<IVlcUI, VideoPlayerView>
    {
        public VlcUIHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override VideoPlayerView CreatePlatformView()
        {



            // var player = new VLCMediaPlayer();
            // player.Media = new VLCMedia("udp://@:11111");
            // player.Delegate = new VLCMediaPlayerDelegate();
            //player.Media = new VLCMedia(NSUrl.FromString("http://streams.videolan.org/streams/mp4/Mr_MrsSmith-h264_aac.mp4"));

            //player.Play();

            //VideoPlayerView view = 
            //player.Media = new VLC Media("udp://@:11111");
            var view = new VideoPlayerView();
            //view.Frame = new RectangleF { Width = 160, Height = 90 };

            return view;
          }

        protected override void ConnectHandler(VideoPlayerView PlatformView)
        { }

        protected override void DisconnectHandler(VideoPlayerView PlatformView)
        {
            // Clean-up the native view to reduce memory leaks and memory usage
            //if (PlatformView.Delegate != null)
            //{
            //    PlatformView.Delegate.Dispose();
            //    PlatformView.Delegate = null;
            //}

            PlatformView.RemoveFromSuperview();
        }
    }

    // public class VLCPlay


}