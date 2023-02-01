using System;
using System.Runtime.InteropServices;
using Foundation;
using MobileVLCKit;
using ObjCRuntime;

namespace MobileVLCKit
{
	[Native]
	public enum VLCMediaTrackType : long
	{
		Unknown = -1,
		Audio = 0,
		Video = 1,
		Text = 2
	}

	[Native]
	public enum VLCMediaOrientation : ulong
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight,
		LeftTop,
		LeftBottom,
		RightTop,
		RightBottom
	}

	[Native]
	public enum VLCMediaProjection : ulong
	{
		Rectangular,
		EquiRectangular,
		CubemapLayoutStandard = 256
	}

	[Native]
	public enum VLCMediaType : ulong
	{
		Unknown,
		File,
		Directory,
		Disc,
		Stream,
		Playlist
	}

	public enum VLCMediaParsedStatus : uint
	{
		Init = 0,
		Pending,
		Skipped,
		Failed,
		Timeout,
		Done
	}

	public enum VLCMediaFileStatType : uint
	{
		Mtime = 0,
		Size = 1
	}

	public enum VLCMediaFileStatReturnType
	{
		Error = -1,
		NotFound = 0,
		Success = 1
	}

	[Flags]
	public enum VLCMediaParsingOptions
	{
		ParseLocal = 0x0,
		ParseNetwork = 0x1,
		FetchLocal = 0x2,
		FetchNetwork = 0x4,
		DoInteract = 0x8
	}

	public enum VLCMediaDiscovererCategoryType : uint
	{
		Devices = 0,
		Lan,
		Podcasts,
		LocalDirectories
	}

	[Native]
	public enum VLCMediaPlayerState : long
	{
		Stopped,
		Stopping,
		Opening,
		Buffering,
		Error,
		Playing,
		Paused,
		ESAdded,
		ESDeleted,
		LengthChanged
	}

	public enum VLCMediaPlaybackNavigationAction : uint
	{
		Activate = 0,
		Up,
		Down,
		Left,
		Right
	}

	[Native]
	public enum VLCDeinterlace : long
	{
		Auto = -1,
		On = 1,
		Off = 0
	}

	// static class CFunctions
	// {
	// 	// extern NSString * _Nonnull VLCMediaPlayerStateToString (VLCMediaPlayerState state) __attribute__((visibility("default")));
	// 	[DllImport ("__Internal")]
	// 	// [Verify (PlatformInvoke)]
	// 	static extern NSString VLCMediaPlayerStateToString (VLCMediaPlayerState state);
	// }

	public enum VLCMediaPlaybackSlaveType : uint
	{
		Subtitle = 0,
		Audio
	}

	[Native]
	public enum VLCRepeatMode : long
	{
		DoNotRepeat,
		RepeatCurrentItem,
		RepeatAllItems
	}

	[Native]
	public enum VLCDialogQuestionType : ulong
	{
		Normal,
		Warning,
		Critical
	}

	[Flags]
	[Native]
	public enum VLCRendererPlay : long
	{
		Audio = 1L << 0,
		Video = 1L << 1
	}

	public enum VLCLogLevel
	{
		Error = 0,
		Warning,
		Info,
		Debug
	}

	[Flags]
	public enum VLCLogContextFlag
	{
		None = 0x0,
		Module = 1 << 0,
		FileLocation = 1 << 1,
		CallingFunction = 1 << 2,
		Custom = 1 << 3,
		All = 0xf
	}
}
