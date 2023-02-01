using System;

using Android.OS;
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Microsoft.Maui.Handlers;
using Android.App;

using TelloApp.UI;


using Org.Videolan.Libvlc;
using Org.Videolan.Libvlc.Interfaces;
using Org.Videolan.Libvlc.Media;
using Org.Videolan.Libvlc.Util;

namespace TelloApp.UI
{
    public partial class VlcUIHandler : ViewHandler<IVlcUI, VideoPlayerView>
    {
        VideoPlayerView _videoView;

        public VlcUIHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override VideoPlayerView CreatePlatformView()
        {
            _videoView = new VideoPlayerView(Context) {  };

            return _videoView;

        }

        protected override void ConnectHandler(VideoPlayerView PlatformView)
        {
        }

        protected override void DisconnectHandler(VideoPlayerView PlatformView)
        {
        }
    }
}

