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

            //SetBackgroundColor(Android.Graphics.Color.Red);

            var libvlc = new LibVLC(Context);


            var mMediaPlayer = new Org.Videolan.Libvlc.MediaPlayer(libvlc);


            LinearLayout relativeLayout = new LinearLayout(_context)
            {
                LayoutParameters = new CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
                {
                    Gravity = (int)GravityFlags.Center 
                }
            };


            //FrameLayout frameLayout = new FrameLayout(_context)
            //{
            //    LayoutParameters = new CoordinatorLayout.LayoutParams(480, 270) { }
            //};



            relativeLayout.Orientation = Android.Widget.Orientation.Vertical;


            var sv = new SurfaceView(context)
            {
                LayoutParameters = new FrameLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                {
                    Gravity = GravityFlags.Center
                }

            };





            //_vlcView = new VLCView(context)
            //{
            //    //LayoutParameters = new RelativeLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent),
            //    MediaPlayer = mMediaPlayer
            //};

            //_vlcView.TriggerLayoutChangeListener();

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



    public class VLCView : SurfaceView , IVLCVout.ICallback , AWindow.ISurfaceCallback
    {

        Org.Videolan.Libvlc.MediaPlayer mMediaPlayer;
        LibVLC libvlc;
        MediaA media;
        VLCVideoLayout vlclayout;
        SurfaceView playerView;
        AWindow mAWindow;


        public Org.Videolan.Libvlc.MediaPlayer? MediaPlayer
        {
            get => mMediaPlayer;
            set
            {
                if (mMediaPlayer != value)
                {
                    Detach();
                    mMediaPlayer = value;

                    if (mMediaPlayer != null)
                    {
                        Attach();
                    }
                }
            }
        }

        void Attach()
        {
            if (mMediaPlayer == null)
                throw new NullReferenceException(nameof(mMediaPlayer));

            mAWindow = new AWindow(this);
            mAWindow.AddCallback(this);
            mAWindow.SetVideoView(this);
            mAWindow.AttachViews();

           

        }

        public void TriggerLayoutChangeListener() => mAWindow?.SetWindowSize(160, 90);

        void Detach()
        {
            mAWindow?.RemoveCallback(this);
            mAWindow?.DetachViews();

            mAWindow?.Dispose();
            mAWindow = null;
        }

        public VLCView(Context context) : base(context)
        {

        }

        public void OnSurfacesCreated(IVLCVout p0)
        {
        }

        public void OnSurfacesCreated(AWindow p0)
        {
        }

        public void OnSurfacesDestroyed(IVLCVout p0)
        {
        }

        public void OnSurfacesDestroyed(AWindow p0)
        {
        }
    }
}

