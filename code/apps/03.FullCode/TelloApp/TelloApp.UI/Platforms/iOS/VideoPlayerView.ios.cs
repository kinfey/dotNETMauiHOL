//using AVFoundation;
//using AVKit;
//using CoreMedia;
using Foundation;
using Microsoft.Maui.ApplicationModel;
using System.Diagnostics;
using UIKit;
using CoreGraphics;

using MobileVLCKit;
using AVKit;
using System.Drawing;

namespace TelloApp.UI
{
    public class VideoPlayerView : UIView
    {
        UIViewController _playerViewController;
        VLCMediaPlayer _player;

        public VideoPlayerView()
        {

            _playerViewController = new UIViewController();

            _player = new VLCMediaPlayer();
            _playerViewController.View.Frame = new RectangleF { Width = 400, Height = 300 };


            //NSUrl.FromString("http://streams.videolan.org/streams/mp4/Mr_MrsSmith-h264_aac.mp4")
            var media =  new VLCMedia(NSUrl.FromString("udp/h264://@0.0.0.0:11111"));

            _player.Media = media;


            _player.Delegate = new VLCDelegate();
            _player.Drawable = _playerViewController.View;

            _player.Play();


            AddSubview(_playerViewController.View);
        }
    }

    public class VLCDelegate : VLCMediaPlayerDelegate
    {
        public VLCDelegate()
        {

        }

        public override void MediaPlayerStateChanged(Foundation.NSNotification notification)
        {
            Console.WriteLine("State changed ");
        }
    }
}