using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

using Org.Videolan.Libvlc;
using Org.Videolan.Libvlc.Media;
using Org.Videolan.Libvlc.Util;
using Org.Videolan.Libvlc.Interfaces;
using AndroidX.CoordinatorLayout.Widget;
using Android.Media;

namespace TelloApp.UI
{
    public class VideoPlayerView : CoordinatorLayout
    {
        VLCView _vlcView;
        Context _context;

        public VideoPlayerView(Context context):base(context)
        {
            _context = context;


            var libvlc = new LibVLC(Context);


            var mMediaPlayer = new Org.Videolan.Libvlc.MediaPlayer(libvlc);


            LinearLayout relativeLayout = new LinearLayout(_context)
            {
                LayoutParameters = new CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
                {
                    Gravity = (int)GravityFlags.Center 
                }
            };

            relativeLayout.Orientation = Android.Widget.Orientation.Vertical;

            var sv = new SurfaceView(context)
            {
                LayoutParameters = new FrameLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                {
                    Gravity = GravityFlags.Center
                }

            };

            relativeLayout.AddView(sv);

            AddView(relativeLayout);

            var vout = mMediaPlayer.VLCVout;

            vout.SetVideoView(sv);

            vout.AttachViews();

            var media = new MediaA(libvlc, Android.Net.Uri.Parse("udp/h264://@0.0.0.0:11111"));

            mMediaPlayer.Media = media;

            mMediaPlayer.Play();

        }

    }
}

