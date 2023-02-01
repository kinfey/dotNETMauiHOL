using System;
using CoreGraphics;
using Foundation;
using MobileVLCKit;
using ObjCRuntime;
using UIKit;

namespace MobileVLCKit
{
	[Static]
	// [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NS_SWIFT_NAME(VLCMediaPlayer.volumeChangedNotification) const NSNotificationName VLCMediaPlayerVolumeChangedNotification __attribute__((swift_name("VLCMediaPlayer.volumeChangedNotification")));
		[Field ("VLCMediaPlayerVolumeChangedNotification", "__Internal")]
		NSString VLCMediaPlayerVolumeChangedNotification { get; }
		// extern NS_SWIFT_NAME(VLCMedia.metaChangedNotification) const NSNotificationName VLCMediaMetaChangedNotification __attribute__((swift_name("VLCMedia.metaChangedNotification")));
		[Field ("VLCMediaMetaChangedNotification", "__Internal")]
		NSString VLCMediaMetaChangedNotification { get; }

		// extern NSString *const _Nonnull VLCMediaDiscovererName __attribute__((visibility("default")));
		[Field ("VLCMediaDiscovererName", "__Internal")]
		NSString VLCMediaDiscovererName { get; }

		// extern NSString *const _Nonnull VLCMediaDiscovererLongName __attribute__((visibility("default")));
		[Field ("VLCMediaDiscovererLongName", "__Internal")]
		NSString VLCMediaDiscovererLongName { get; }

		// extern NSString *const _Nonnull VLCMediaDiscovererCategory __attribute__((visibility("default")));
		[Field ("VLCMediaDiscovererCategory", "__Internal")]
		NSString VLCMediaDiscovererCategory { get; }

		// extern NS_SWIFT_NAME(VLCMediaList.itemAddedNotification) const NSNotificationName VLCMediaListItemAddedNotification __attribute__((swift_name("VLCMediaList.itemAddedNotification")));
		[Field ("VLCMediaListItemAddedNotification", "__Internal")]
		NSString VLCMediaListItemAddedNotification { get; }

		// extern NS_SWIFT_NAME(VLCMediaList.itemDeletedNotification) const NSNotificationName VLCMediaListItemDeletedNotification __attribute__((swift_name("VLCMediaList.itemDeletedNotification")));
		[Field ("VLCMediaListItemDeletedNotification", "__Internal")]
		NSString VLCMediaListItemDeletedNotification { get; }
	
		// extern NS_SWIFT_NAME(VLCMediaPlayer.timeChangedNotification) const NSNotificationName VLCMediaPlayerTimeChangedNotification __attribute__((swift_name("VLCMediaPlayer.timeChangedNotification")));
		[Field ("VLCMediaPlayerTimeChangedNotification", "__Internal")]
		NSString VLCMediaPlayerTimeChangedNotification { get; }

		// extern NS_SWIFT_NAME(VLCMediaPlayer.stateChangedNotification) const NSNotificationName VLCMediaPlayerStateChangedNotification __attribute__((swift_name("VLCMediaPlayer.stateChangedNotification")));
		[Field ("VLCMediaPlayerStateChangedNotification", "__Internal")]
		NSString VLCMediaPlayerStateChangedNotification { get; }

		// extern NS_SWIFT_NAME(VLCMediaPlayer.titleSelectionChangedNotification) const NSNotificationName VLCMediaPlayerTitleSelectionChangedNotification __attribute__((swift_name("VLCMediaPlayer.titleSelectionChangedNotification")));
		[Field ("VLCMediaPlayerTitleSelectionChangedNotification", "__Internal")]
		NSString VLCMediaPlayerTitleSelectionChangedNotification { get; }

		// extern NS_SWIFT_NAME(VLCMediaPlayer.titleListChangedNotification) const NSNotificationName VLCMediaPlayerTitleListChangedNotification __attribute__((swift_name("VLCMediaPlayer.titleListChangedNotification")));
		[Field ("VLCMediaPlayerTitleListChangedNotification", "__Internal")]
		NSString VLCMediaPlayerTitleListChangedNotification { get; }

		// extern NS_SWIFT_NAME(VLCMediaPlayer.chapterChangedNotification) const NSNotificationName VLCMediaPlayerChapterChangedNotification __attribute__((swift_name("VLCMediaPlayer.chapterChangedNotification")));
		[Field ("VLCMediaPlayerChapterChangedNotification", "__Internal")]
		NSString VLCMediaPlayerChapterChangedNotification { get; }

		// extern NS_SWIFT_NAME(VLCMediaPlayer.snapshotTakenNotification) const NSNotificationName VLCMediaPlayerSnapshotTakenNotification __attribute__((swift_name("VLCMediaPlayer.snapshotTakenNotification")));
		[Field ("VLCMediaPlayerSnapshotTakenNotification", "__Internal")]
		NSString VLCMediaPlayerSnapshotTakenNotification { get; }
		// extern NSString *const _Nonnull VLCChapterDescriptionName __attribute__((visibility("default")));
		[Field ("VLCChapterDescriptionName", "__Internal")]
		NSString VLCChapterDescriptionName { get; }

		// extern NSString *const _Nonnull VLCChapterDescriptionTimeOffset __attribute__((visibility("default")));
		[Field ("VLCChapterDescriptionTimeOffset", "__Internal")]
		NSString VLCChapterDescriptionTimeOffset { get; }

		// extern NSString *const _Nonnull VLCChapterDescriptionDuration __attribute__((visibility("default")));
		[Field ("VLCChapterDescriptionDuration", "__Internal")]
		NSString VLCChapterDescriptionDuration { get; }

		// extern NSString *const _Nonnull VLCTitleDescriptionName __attribute__((visibility("default")));
		[Field ("VLCTitleDescriptionName", "__Internal")]
		NSString VLCTitleDescriptionName { get; }

		// extern NSString *const _Nonnull VLCTitleDescriptionDuration __attribute__((visibility("default")));
		[Field ("VLCTitleDescriptionDuration", "__Internal")]
		NSString VLCTitleDescriptionDuration { get; }

		// extern NSString *const _Nonnull VLCTitleDescriptionIsMenu __attribute__((visibility("default")));
		[Field ("VLCTitleDescriptionIsMenu", "__Internal")]
		NSString VLCTitleDescriptionIsMenu { get; }

		// extern NSString *const _Nonnull kVLCAdjustFilterContrastParameterKey;
		[Field ("kVLCAdjustFilterContrastParameterKey", "__Internal")]
		NSString kVLCAdjustFilterContrastParameterKey { get; }

		// extern NSString *const _Nonnull kVLCAdjustFilterBrightnessParameterKey;
		[Field ("kVLCAdjustFilterBrightnessParameterKey", "__Internal")]
		NSString kVLCAdjustFilterBrightnessParameterKey { get; }

		// extern NSString *const _Nonnull kVLCAdjustFilterHueParameterKey;
		[Field ("kVLCAdjustFilterHueParameterKey", "__Internal")]
		NSString kVLCAdjustFilterHueParameterKey { get; }

		// extern NSString *const _Nonnull kVLCAdjustFilterSaturationParameterKey;
		[Field ("kVLCAdjustFilterSaturationParameterKey", "__Internal")]
		NSString kVLCAdjustFilterSaturationParameterKey { get; }

		// extern NSString *const _Nonnull kVLCAdjustFilterGammaParameterKey;
		[Field ("kVLCAdjustFilterGammaParameterKey", "__Internal")]
		NSString kVLCAdjustFilterGammaParameterKey { get; }
	}

	// @interface VLCAudio : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCAudio
	{
		// @property (getter = isMuted) BOOL muted;
		[Export ("muted")]
		bool Muted { [Bind ("isMuted")] get; set; }

		// @property (assign) int volume;
		[Export ("volume")]
		int Volume { get; set; }

		// @property (readwrite) BOOL passthrough;
		[Export ("passthrough")]
		bool Passthrough { get; set; }

		// -(void)volumeDown;
		[Export ("volumeDown")]
		void VolumeDown ();

		// -(void)volumeUp;
		[Export ("volumeUp")]
		void VolumeUp ();
	}

	// @interface VLCLibrary : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCLibrary
	{
		// +(VLCLibrary * _Nonnull)sharedLibrary;
		[Static]
		[Export ("sharedLibrary")]
		// [Verify (MethodToProperty)]
		VLCLibrary SharedLibrary { get; }

		// -(instancetype _Nonnull)initWithOptions:(NSArray * _Nonnull)options;
		[Export ("initWithOptions:")]
		// [Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] options);

		// @property (readwrite, nonatomic) NSArray<id<VLCLogging>> * _Nullable loggers;
		[NullAllowed, Export ("loggers", ArgumentSemantic.Assign)]
		IVLCLogging[] Loggers { get; set; }

		// @property (readonly, copy) NSString * _Nonnull version;
		[Export ("version")]
		string Version { get; }

		// @property (readonly, copy) NSString * _Nonnull compiler;
		[Export ("compiler")]
		string Compiler { get; }

		// @property (readonly, copy) NSString * _Nonnull changeset;
		[Export ("changeset")]
		string Changeset { get; }

		// -(void)setHumanReadableName:(NSString * _Nonnull)readableName withHTTPUserAgent:(NSString * _Nonnull)userAgent;
		[Export ("setHumanReadableName:withHTTPUserAgent:")]
		void SetHumanReadableName (string readableName, string userAgent);

		// -(void)setApplicationIdentifier:(NSString * _Nonnull)identifier withVersion:(NSString * _Nonnull)version andApplicationIconName:(NSString * _Nonnull)icon;
		[Export ("setApplicationIdentifier:withVersion:andApplicationIconName:")]
		void SetApplicationIdentifier (string identifier, string version, string icon);

		// @property (assign, nonatomic) void * _Nonnull instance;
		[Export ("instance", ArgumentSemantic.Assign)]
		unsafe IntPtr Instance { get; set; }
	}

	// @protocol VLCMediaDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface VLCMediaDelegate
	{
		// @optional -(void)mediaMetaDataDidChange:(VLCMedia * _Nonnull)aMedia;
		[Export ("mediaMetaDataDidChange:")]
		void MediaMetaDataDidChange (VLCMedia aMedia);

		// @optional -(void)mediaDidFinishParsing:(VLCMedia * _Nonnull)aMedia;
		[Export ("mediaDidFinishParsing:")]
		void MediaDidFinishParsing (VLCMedia aMedia);
	}

	// @interface VLCMedia : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCMedia
	{
		// +(instancetype _Nonnull)mediaWithURL:(NSURL * _Nonnull)anURL;
		[Static]
		[Export ("mediaWithURL:")]
		VLCMedia MediaWithURL (NSUrl anURL);

		// +(instancetype _Nonnull)mediaWithPath:(NSString * _Nonnull)aPath;
		[Static]
		[Export ("mediaWithPath:")]
		VLCMedia MediaWithPath (string aPath);

		// +(NSString * _Nonnull)codecNameForFourCC:(uint32_t)fourcc trackType:(VLCMediaTrackType)trackType;
		[Static]
		[Export ("codecNameForFourCC:trackType:")]
		string CodecNameForFourCC (uint fourcc, VLCMediaTrackType trackType);

		// +(instancetype _Nonnull)mediaAsNodeWithName:(NSString * _Nonnull)aName;
		[Static]
		[Export ("mediaAsNodeWithName:")]
		VLCMedia MediaAsNodeWithName (string aName);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)anURL;
		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl anURL);

		// -(instancetype _Nonnull)initWithPath:(NSString * _Nonnull)aPath;
		[Export ("initWithPath:")]
		NativeHandle Constructor (string aPath);

		// -(instancetype _Nonnull)initWithStream:(NSInputStream * _Nonnull)stream;
		[Export ("initWithStream:")]
		NativeHandle Constructor (NSInputStream stream);

		// -(instancetype _Nonnull)initAsNodeWithName:(NSString * _Nonnull)aName;
		[Export ("initAsNodeWithName:")]
		NativeHandle InitAsNodeWithName (string aName);

		// @property (readonly) VLCMediaType mediaType;
		[Export ("mediaType")]
		VLCMediaType MediaType { get; }

		// -(NSComparisonResult)compare:(VLCMedia * _Nullable)media;
		[Export ("compare:")]
		NSComparisonResult Compare ([NullAllowed] VLCMedia media);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCMediaDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<VLCMediaDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic, strong) VLCTime * _Nonnull length;
		[Export ("length", ArgumentSemantic.Strong)]
		VLCTime Length { get; set; }

		// -(VLCTime * _Nonnull)lengthWaitUntilDate:(NSDate * _Nonnull)aDate;
		[Export ("lengthWaitUntilDate:")]
		VLCTime LengthWaitUntilDate (NSDate aDate);

		// @property (readonly, nonatomic) VLCMediaParsedStatus parsedStatus;
		[Export ("parsedStatus")]
		VLCMediaParsedStatus ParsedStatus { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		// @property (readonly, nonatomic, strong) VLCMediaList * _Nullable subitems;
		[NullAllowed, Export ("subitems", ArgumentSemantic.Strong)]
		VLCMediaList Subitems { get; }

		// @property (readonly, nonatomic) VLCMediaMetaData * _Nonnull metaData;
		[Export ("metaData")]
		VLCMediaMetaData MetaData { get; }

		// @property (readonly, copy, nonatomic) NSArray<VLCMediaTrack *> * _Nonnull tracksInformation;
		[Export ("tracksInformation", ArgumentSemantic.Copy)]
		VLCMediaTrack[] TracksInformation { get; }

		// @property (nonatomic) id _Nullable userData;
		[NullAllowed, Export ("userData", ArgumentSemantic.Assign)]
		NSObject UserData { get; set; }

		// -(VLCMediaFileStatReturnType)fileStatValueForType:(const VLCMediaFileStatType)type value:(uint64_t * _Nonnull)value;
		[Export ("fileStatValueForType:value:")]
		unsafe VLCMediaFileStatReturnType FileStatValueForType (VLCMediaFileStatType type, ulong value);

		// -(int)parseWithOptions:(VLCMediaParsingOptions)options;
		[Export ("parseWithOptions:")]
		int ParseWithOptions (VLCMediaParsingOptions options);

		// -(int)parseWithOptions:(VLCMediaParsingOptions)options timeout:(int)timeoutValue;
		[Export ("parseWithOptions:timeout:")]
		int ParseWithOptions (VLCMediaParsingOptions options, int timeoutValue);

		// -(void)parseStop;
		[Export ("parseStop")]
		void ParseStop ();

		// -(void)addOption:(NSString * _Nonnull)option;
		[Export ("addOption:")]
		void AddOption (string option);

		// -(void)addOptions:(NSDictionary * _Nonnull)options;
		[Export ("addOptions:")]
		void AddOptions (NSDictionary options);

		// -(int)storeCookie:(NSString * _Nonnull)cookie forHost:(NSString * _Nonnull)host path:(NSString * _Nonnull)path;
		[Export ("storeCookie:forHost:path:")]
		int StoreCookie (string cookie, string host, string path);

		// -(void)clearStoredCookies;
		[Export ("clearStoredCookies")]
		void ClearStoredCookies ();

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable stats;
		[NullAllowed, Export ("stats", ArgumentSemantic.Copy)]
		NSDictionary Stats { get; }

		// @property (readonly, nonatomic) NSInteger numberOfReadBytesOnInput;
		[Export ("numberOfReadBytesOnInput")]
		nint NumberOfReadBytesOnInput { get; }

		// @property (readonly, nonatomic) float inputBitrate;
		[Export ("inputBitrate")]
		float InputBitrate { get; }

		// @property (readonly, nonatomic) NSInteger numberOfReadBytesOnDemux;
		[Export ("numberOfReadBytesOnDemux")]
		nint NumberOfReadBytesOnDemux { get; }

		// @property (readonly, nonatomic) float demuxBitrate;
		[Export ("demuxBitrate")]
		float DemuxBitrate { get; }

		// @property (readonly, nonatomic) NSInteger numberOfDecodedVideoBlocks;
		[Export ("numberOfDecodedVideoBlocks")]
		nint NumberOfDecodedVideoBlocks { get; }

		// @property (readonly, nonatomic) NSInteger numberOfDecodedAudioBlocks;
		[Export ("numberOfDecodedAudioBlocks")]
		nint NumberOfDecodedAudioBlocks { get; }

		// @property (readonly, nonatomic) NSInteger numberOfDisplayedPictures;
		[Export ("numberOfDisplayedPictures")]
		nint NumberOfDisplayedPictures { get; }

		// @property (readonly, nonatomic) NSInteger numberOfLostPictures;
		[Export ("numberOfLostPictures")]
		nint NumberOfLostPictures { get; }

		// @property (readonly, nonatomic) NSInteger numberOfLatePictures;
		[Export ("numberOfLatePictures")]
		nint NumberOfLatePictures { get; }

		// @property (readonly, nonatomic) NSInteger numberOfPlayedAudioBuffers;
		[Export ("numberOfPlayedAudioBuffers")]
		nint NumberOfPlayedAudioBuffers { get; }

		// @property (readonly, nonatomic) NSInteger numberOfLostAudioBuffers;
		[Export ("numberOfLostAudioBuffers")]
		nint NumberOfLostAudioBuffers { get; }

		// @property (readonly, nonatomic) NSInteger numberOfCorruptedDataPackets;
		[Export ("numberOfCorruptedDataPackets")]
		nint NumberOfCorruptedDataPackets { get; }

		// @property (readonly, nonatomic) NSInteger numberOfDiscontinuties;
		[Export ("numberOfDiscontinuties")]
		nint NumberOfDiscontinuties { get; }
	}

	// @interface Tracks (VLCMedia)
	[Category]
	[BaseType (typeof(VLCMedia))]
	interface VLCMedia_Tracks
	{
		// @property (readonly, copy, nonatomic) NSArray<VLCMediaTrack *> * _Nonnull audioTracks;
		[Export ("audioTracks", ArgumentSemantic.Copy)]
		VLCMediaTrack[] AudioTracks();

		// @property (readonly, copy, nonatomic) NSArray<VLCMediaTrack *> * _Nonnull videoTracks;
		[Export ("videoTracks", ArgumentSemantic.Copy)]
		VLCMediaTrack[] VideoTracks();

		// @property (readonly, copy, nonatomic) NSArray<VLCMediaTrack *> * _Nonnull textTracks;
		[Export ("textTracks", ArgumentSemantic.Copy)]
		VLCMediaTrack[] TextTracks();
	}

	// @interface VLCMediaAudioTrack : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCMediaAudioTrack
	{
		// @property (readonly, nonatomic) unsigned int channelsNumber;
		[Export ("channelsNumber")]
		uint ChannelsNumber { get; }

		// @property (readonly, nonatomic) unsigned int rate;
		[Export ("rate")]
		uint Rate { get; }
	}

	// @interface VLCMediaVideoTrack : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCMediaVideoTrack
	{
		// @property (readonly, nonatomic) unsigned int height;
		[Export ("height")]
		uint Height { get; }

		// @property (readonly, nonatomic) unsigned int width;
		[Export ("width")]
		uint Width { get; }

		// @property (readonly, nonatomic) VLCMediaOrientation orientation;
		[Export ("orientation")]
		VLCMediaOrientation Orientation { get; }

		// @property (readonly, nonatomic) VLCMediaProjection projection;
		[Export ("projection")]
		VLCMediaProjection Projection { get; }

		// @property (readonly, nonatomic) unsigned int sourceAspectRatio;
		[Export ("sourceAspectRatio")]
		uint SourceAspectRatio { get; }

		// @property (readonly, nonatomic) unsigned int sourceAspectRatioDenominator;
		[Export ("sourceAspectRatioDenominator")]
		uint SourceAspectRatioDenominator { get; }

		// @property (readonly, nonatomic) unsigned int frameRate;
		[Export ("frameRate")]
		uint FrameRate { get; }

		// @property (readonly, nonatomic) unsigned int frameRateDenominator;
		[Export ("frameRateDenominator")]
		uint FrameRateDenominator { get; }
	}

	// @interface VLCMediaTextTrack : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCMediaTextTrack
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable encoding;
		[NullAllowed, Export ("encoding")]
		string Encoding { get; }
	}

	// @interface VLCMediaTrack : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCMediaTrack
	{
		// @property (readonly, nonatomic) VLCMediaTrackType type;
		[Export ("type")]
		VLCMediaTrackType Type { get; }

		// @property (readonly, nonatomic) u_int32_t codec;
		[Export ("codec")]
		uint Codec { get; }

		// @property (readonly, nonatomic) u_int32_t fourcc;
		[Export ("fourcc")]
		uint Fourcc { get; }

		// @property (readonly, nonatomic) int identifier;
		[Export ("identifier")]
		int Identifier { get; }

		// @property (readonly, nonatomic) int profile;
		[Export ("profile")]
		int Profile { get; }

		// @property (readonly, nonatomic) int level;
		[Export ("level")]
		int Level { get; }

		// @property (readonly, nonatomic) unsigned int bitrate;
		[Export ("bitrate")]
		uint Bitrate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable language;
		[NullAllowed, Export ("language")]
		string Language { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable trackDescription;
		[NullAllowed, Export ("trackDescription")]
		string TrackDescription { get; }

		// @property (readonly, nonatomic) VLCMediaAudioTrack * _Nullable audio;
		[NullAllowed, Export ("audio")]
		VLCMediaAudioTrack Audio { get; }

		// @property (readonly, nonatomic) VLCMediaVideoTrack * _Nullable video;
		[NullAllowed, Export ("video")]
		VLCMediaVideoTrack Video { get; }

		// @property (readonly, nonatomic) VLCMediaTextTrack * _Nullable text;
		[NullAllowed, Export ("text")]
		VLCMediaTextTrack Text { get; }

		// -(NSString * _Nonnull)codecName;
		[Export ("codecName")]
		// [Verify (MethodToProperty)]
		string CodecName { get; }
	}

	// @interface VLCMediaPlayerTrack : VLCMediaTrack
	[BaseType (typeof(VLCMediaTrack))]
	// [DisableDefaultCtor]
	interface VLCMediaPlayerTrack
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull trackId;
		[Export ("trackId")]
		string TrackId { get; }

		// @property (readonly, getter = isIdStable, nonatomic) BOOL idStable;
		[Export ("idStable")]
		bool IdStable { [Bind ("isIdStable")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull trackName;
		[Export ("trackName")]
		string TrackName { get; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }
	}

	// @interface VLCMediaDiscoverer : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCMediaDiscoverer
	{
		// @property (readonly, nonatomic) VLCLibrary * _Nonnull libraryInstance;
		[Export ("libraryInstance")]
		VLCLibrary LibraryInstance { get; }

		// +(NSArray * _Nonnull)availableMediaDiscovererForCategoryType:(VLCMediaDiscovererCategoryType)categoryType;
		[Static]
		[Export ("availableMediaDiscovererForCategoryType:")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AvailableMediaDiscovererForCategoryType (VLCMediaDiscovererCategoryType categoryType);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)aServiceName;
		[Export ("initWithName:")]
		NativeHandle Constructor (string aServiceName);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)aServiceName libraryInstance:(VLCLibrary * _Nullable)libraryInstance;
		[Export ("initWithName:libraryInstance:")]
		NativeHandle Constructor (string aServiceName, [NullAllowed] VLCLibrary libraryInstance);

		// -(int)startDiscoverer;
		[Export ("startDiscoverer")]
		// [Verify (MethodToProperty)]
		int StartDiscoverer { get; }

		// -(void)stopDiscoverer;
		[Export ("stopDiscoverer")]
		void StopDiscoverer ();

		// @property (readonly, weak) VLCMediaList * _Nullable discoveredMedia;
		[NullAllowed, Export ("discoveredMedia", ArgumentSemantic.Weak)]
		VLCMediaList DiscoveredMedia { get; }

		// @property (readonly) BOOL isRunning;
		[Export ("isRunning")]
		bool IsRunning { get; }
	}


	// @protocol VLCMediaListDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface VLCMediaListDelegate
	{
		// @optional -(void)mediaList:(VLCMediaList * _Nonnull)aMediaList mediaAdded:(VLCMedia * _Nonnull)media atIndex:(NSUInteger)index;
		[Export ("mediaList:mediaAdded:atIndex:")]
		void MediaAdded (VLCMediaList aMediaList, VLCMedia media, nuint index);

		// @optional -(void)mediaList:(VLCMediaList * _Nonnull)aMediaList mediaRemovedAtIndex:(NSUInteger)index;
		[Export ("mediaList:mediaRemovedAtIndex:")]
		void MediaRemovedAtIndex (VLCMediaList aMediaList, nuint index);
	}

	// @interface VLCMediaList : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCMediaList
	{
		// -(instancetype _Nonnull)initWithArray:(NSArray<VLCMedia *> * _Nullable)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor ([NullAllowed] VLCMedia[] array);

		// -(void)lock;
		[Export ("lock")]
		void Lock ();

		// -(void)unlock;
		[Export ("unlock")]
		void Unlock ();

		// -(NSUInteger)addMedia:(VLCMedia * _Nonnull)media;
		[Export ("addMedia:")]
		nuint AddMedia (VLCMedia media);

		// -(void)insertMedia:(VLCMedia * _Nonnull)media atIndex:(NSUInteger)index;
		[Export ("insertMedia:atIndex:")]
		void InsertMedia (VLCMedia media, nuint index);

		// -(BOOL)removeMediaAtIndex:(NSUInteger)index;
		[Export ("removeMediaAtIndex:")]
		bool RemoveMediaAtIndex (nuint index);

		// -(VLCMedia * _Nullable)mediaAtIndex:(NSUInteger)index;
		[Export ("mediaAtIndex:")]
		[return: NullAllowed]
		VLCMedia MediaAtIndex (nuint index);

		// -(NSUInteger)indexOfMedia:(VLCMedia * _Nonnull)media;
		[Export ("indexOfMedia:")]
		nuint IndexOfMedia (VLCMedia media);

		// @property (readonly) NSInteger count;
		[Export ("count")]
		nint Count { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCMediaListDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<VLCMediaListDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly) BOOL isReadOnly;
		[Export ("isReadOnly")]
		bool IsReadOnly { get; }

		// @property (readonly) BOOL isEmpty;
		[Export ("isEmpty")]
		bool IsEmpty { get; }
	}


	// @protocol VLCMediaPlayerDelegate <NSObject>
	[Protocol,Model]
	[BaseType (typeof(NSObject))]
	interface VLCMediaPlayerDelegate
	{
		// @optional -(void)mediaPlayerStateChanged:(NSNotification * _Nonnull)aNotification;
		[Export ("mediaPlayerStateChanged:")]
		void MediaPlayerStateChanged (NSNotification aNotification);

		// @optional -(void)mediaPlayerTimeChanged:(NSNotification * _Nonnull)aNotification;
		//[Export ("mediaPlayerTimeChanged:")]
		//void MediaPlayerTimeChanged (NSNotification aNotification);

		//// @optional -(void)mediaPlayerTitleSelectionChanged:(NSNotification * _Nonnull)aNotification;
		//[Export ("mediaPlayerTitleSelectionChanged:")]
		//void MediaPlayerTitleSelectionChanged (NSNotification aNotification);

		//// @optional -(void)mediaPlayerTitleListChanged:(NSNotification * _Nonnull)aNotification;
		//[Export ("mediaPlayerTitleListChanged:")]
		//void MediaPlayerTitleListChanged (NSNotification aNotification);

		//// @optional -(void)mediaPlayerChapterChanged:(NSNotification * _Nonnull)aNotification;
		//[Export ("mediaPlayerChapterChanged:")]
		//void MediaPlayerChapterChanged (NSNotification aNotification);

		//// @optional -(void)mediaPlayerSnapshot:(NSNotification * _Nonnull)aNotification;
		//[Export ("mediaPlayerSnapshot:")]
		//void MediaPlayerSnapshot (NSNotification aNotification);

		//// @optional -(void)mediaPlayerStartedRecording:(VLCMediaPlayer * _Nonnull)player;
		//[Export ("mediaPlayerStartedRecording:")]
		//void MediaPlayerStartedRecording (VLCMediaPlayer player);

		//// @optional -(void)mediaPlayer:(VLCMediaPlayer * _Nonnull)player recordingStoppedAtPath:(NSString * _Nonnull)path;
		//[Export ("mediaPlayer:recordingStoppedAtPath:")]
		//void MediaPlayer (VLCMediaPlayer player, string path);
	}

	// @interface VLCMediaPlayer : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCMediaPlayer
	{
		// @property (readonly, nonatomic) VLCLibrary * _Nonnull libraryInstance;
		[Export ("libraryInstance")]
		VLCLibrary LibraryInstance { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCMediaPlayerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<VLCMediaPlayerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithLibrary:(VLCLibrary * _Nonnull)library;
		[Export ("initWithLibrary:")]
		NativeHandle Constructor (VLCLibrary library);

		// -(instancetype _Nonnull)initWithOptions:(NSArray * _Nonnull)options;
		[Export ("initWithOptions:")]
		// [Verify (StronglyTypedNSArray)]
		NativeHandle Constructor (NSObject[] options);

		// -(instancetype _Nonnull)initWithLibVLCInstance:(void * _Nonnull)playerInstance andLibrary:(VLCLibrary * _Nonnull)library;
		[Export ("initWithLibVLCInstance:andLibrary:")]
		unsafe NativeHandle Constructor (IntPtr playerInstance, VLCLibrary library);

		// @property (strong) id _Nullable drawable;
		[NullAllowed, Export ("drawable", ArgumentSemantic.Strong)]
		NSObject Drawable { get; set; }

		// @property (nonatomic) char * _Nullable videoAspectRatio;
		[NullAllowed, Export ("videoAspectRatio", ArgumentSemantic.Assign)]
		unsafe sbyte VideoAspectRatio { get; set; }

		// -(void)setCropRatioWithNumerator:(unsigned int)numerator denominator:(unsigned int)denominator;
		[Export ("setCropRatioWithNumerator:denominator:")]
		void SetCropRatioWithNumerator (uint numerator, uint denominator);

		// @property (nonatomic) float scaleFactor;
		[Export ("scaleFactor")]
		float ScaleFactor { get; set; }

		// -(void)saveVideoSnapshotAt:(NSString * _Nonnull)path withWidth:(int)width andHeight:(int)height;
		[Export ("saveVideoSnapshotAt:withWidth:andHeight:")]
		void SaveVideoSnapshotAt (string path, int width, int height);

		// -(void)setDeinterlaceFilter:(NSString * _Nullable)name;
		[Export ("setDeinterlaceFilter:")]
		void SetDeinterlaceFilter ([NullAllowed] string name);

		// -(void)setDeinterlace:(VLCDeinterlace)deinterlace withFilter:(NSString * _Nonnull)name;
		[Export ("setDeinterlace:withFilter:")]
		void SetDeinterlace (VLCDeinterlace deinterlace, string name);

		// @property (readonly, nonatomic) VLCAdjustFilter * _Nonnull adjustFilter;
		[Export ("adjustFilter")]
		VLCAdjustFilter AdjustFilter { get; }

		// @property (nonatomic) BOOL adjustFilterEnabled __attribute__((deprecated("Use -[VLCMediaPlayer adjustFilter].enabled instead")));
		[Export ("adjustFilterEnabled")]
		bool AdjustFilterEnabled { get; set; }

		// @property (nonatomic) float contrast __attribute__((deprecated("Use -[VLCMediaPlayer adjustFilter].contrast instead")));
		[Export ("contrast")]
		float Contrast { get; set; }

		// @property (nonatomic) float brightness __attribute__((deprecated("Use -[VLCMediaPlayer adjustFilter].brightness instead")));
		[Export ("brightness")]
		float Brightness { get; set; }

		// @property (nonatomic) float hue __attribute__((deprecated("Use -[VLCMediaPlayer adjustFilter].hue instead")));
		[Export ("hue")]
		float Hue { get; set; }

		// @property (nonatomic) float saturation __attribute__((deprecated("Use -[VLCMediaPlayer adjustFilter].saturation instead")));
		[Export ("saturation")]
		float Saturation { get; set; }

		// @property (nonatomic) float gamma __attribute__((deprecated("Use -[VLCMediaPlayer adjustFilter].gamma instead")));
		[Export ("gamma")]
		float Gamma { get; set; }

		// @property (nonatomic) float rate;
		[Export ("rate")]
		float Rate { get; set; }

		// @property (readonly, nonatomic, weak) VLCAudio * _Nullable audio;
		[NullAllowed, Export ("audio", ArgumentSemantic.Weak)]
		IntPtr Audio { get; }

		// @property (readonly, nonatomic) CGSize videoSize;
		[Export ("videoSize")]
		CGSize VideoSize { get; }

		// @property (readonly, nonatomic) BOOL hasVideoOut;
		[Export ("hasVideoOut")]
		bool HasVideoOut { get; }

		// @property (nonatomic, strong) VLCTime * _Nonnull time;
		[Export ("time", ArgumentSemantic.Strong)]
		VLCTime Time { get; set; }

		// @property (readonly, nonatomic, weak) VLCTime * _Nullable remainingTime;
		[NullAllowed, Export ("remainingTime", ArgumentSemantic.Weak)]
		VLCTime RemainingTime { get; }

		// @property (nonatomic) int64_t minimalTimePeriod;
		[Export ("minimalTimePeriod")]
		long MinimalTimePeriod { get; set; }

		// @property (nonatomic) NSTimeInterval timeChangeUpdateInterval;
		[Export ("timeChangeUpdateInterval")]
		double TimeChangeUpdateInterval { get; set; }

		// -(int)addPlaybackSlave:(NSURL * _Nonnull)slaveURL type:(VLCMediaPlaybackSlaveType)slaveType enforce:(BOOL)enforceSelection;
		[Export ("addPlaybackSlave:type:enforce:")]
		int AddPlaybackSlave (NSUrl slaveURL, VLCMediaPlaybackSlaveType slaveType, bool enforceSelection);

		// @property (readwrite) NSInteger currentVideoSubTitleDelay;
		[Export ("currentVideoSubTitleDelay")]
		nint CurrentVideoSubTitleDelay { get; set; }

		// @property (readwrite) float currentSubTitleFontScale;
		[Export ("currentSubTitleFontScale")]
		float CurrentSubTitleFontScale { get; set; }

		// @property (readwrite) int currentChapterIndex;
		[Export ("currentChapterIndex")]
		int CurrentChapterIndex { get; set; }

		// -(void)previousChapter;
		[Export ("previousChapter")]
		void PreviousChapter ();

		// -(void)nextChapter;
		[Export ("nextChapter")]
		void NextChapter ();

		// -(int)numberOfChaptersForTitle:(int)titleIndex;
		[Export ("numberOfChaptersForTitle:")]
		int NumberOfChaptersForTitle (int titleIndex);

		// -(NSArray * _Nonnull)chapterDescriptionsOfTitle:(int)titleIndex;
		[Export ("chapterDescriptionsOfTitle:")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] ChapterDescriptionsOfTitle (int titleIndex);

		// @property (readwrite) int currentTitleIndex;
		[Export ("currentTitleIndex")]
		int CurrentTitleIndex { get; set; }

		// @property (readonly) int numberOfTitles;
		[Export ("numberOfTitles")]
		int NumberOfTitles { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull titleDescriptions;
		[Export ("titleDescriptions", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] TitleDescriptions { get; }

		// @property (readonly) int indexOfLongestTitle;
		[Export ("indexOfLongestTitle")]
		int IndexOfLongestTitle { get; }

		// @property (nonatomic) int audioChannel;
		[Export ("audioChannel")]
		int AudioChannel { get; set; }

		// @property (readwrite) NSInteger currentAudioPlaybackDelay;
		[Export ("currentAudioPlaybackDelay")]
		nint CurrentAudioPlaybackDelay { get; set; }

		// @property (readonly, weak) NSArray * _Nullable equalizerProfiles;
		[NullAllowed, Export ("equalizerProfiles", ArgumentSemantic.Weak)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] EqualizerProfiles { get; }

		// -(void)resetEqualizerFromProfile:(unsigned int)profile;
		[Export ("resetEqualizerFromProfile:")]
		void ResetEqualizerFromProfile (uint profile);

		// @property (readwrite) BOOL equalizerEnabled;
		[Export ("equalizerEnabled")]
		bool EqualizerEnabled { get; set; }

		// @property (readwrite) CGFloat preAmplification;
		[Export ("preAmplification")]
		nfloat PreAmplification { get; set; }

		// @property (readonly) unsigned int numberOfBands;
		[Export ("numberOfBands")]
		uint NumberOfBands { get; }

		// -(CGFloat)frequencyOfBandAtIndex:(unsigned int)index;
		[Export ("frequencyOfBandAtIndex:")]
		nfloat FrequencyOfBandAtIndex (uint index);

		// -(void)setAmplification:(CGFloat)amplification forBand:(unsigned int)index;
		[Export ("setAmplification:forBand:")]
		void SetAmplification (nfloat amplification, uint index);

		// -(CGFloat)amplificationOfBand:(unsigned int)index;
		[Export ("amplificationOfBand:")]
		nfloat AmplificationOfBand (uint index);

		// @property (nonatomic, strong) VLCMedia * _Nullable media;
		[NullAllowed, Export ("media", ArgumentSemantic.Strong)]
		VLCMedia Media { get; set; }

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)gotoNextFrame;
		[Export ("gotoNextFrame")]
		void GotoNextFrame ();

		// -(void)fastForward;
		[Export ("fastForward")]
		void FastForward ();

		// -(void)fastForwardAtRate:(float)rate;
		[Export ("fastForwardAtRate:")]
		void FastForwardAtRate (float rate);

		// -(void)rewind;
		[Export ("rewind")]
		void Rewind ();

		// -(void)rewindAtRate:(float)rate;
		[Export ("rewindAtRate:")]
		void RewindAtRate (float rate);

		// -(void)jumpWithOffset:(int)offset;
		[Export ("jumpWithOffset:")]
		void JumpWithOffset (int offset);

		// -(void)jumpBackward:(double)interval;
		[Export ("jumpBackward:")]
		void JumpBackward (double interval);

		// -(void)jumpForward:(double)interval;
		[Export ("jumpForward:")]
		void JumpForward (double interval);

		// -(void)extraShortJumpBackward;
		[Export ("extraShortJumpBackward")]
		void ExtraShortJumpBackward ();

		// -(void)extraShortJumpForward;
		[Export ("extraShortJumpForward")]
		void ExtraShortJumpForward ();

		// -(void)shortJumpBackward;
		[Export ("shortJumpBackward")]
		void ShortJumpBackward ();

		// -(void)shortJumpForward;
		[Export ("shortJumpForward")]
		void ShortJumpForward ();

		// -(void)mediumJumpBackward;
		[Export ("mediumJumpBackward")]
		void MediumJumpBackward ();

		// -(void)mediumJumpForward;
		[Export ("mediumJumpForward")]
		void MediumJumpForward ();

		// -(void)longJumpBackward;
		[Export ("longJumpBackward")]
		void LongJumpBackward ();

		// -(void)longJumpForward;
		[Export ("longJumpForward")]
		void LongJumpForward ();

		// -(void)performNavigationAction:(VLCMediaPlaybackNavigationAction)action;
		[Export ("performNavigationAction:")]
		void PerformNavigationAction (VLCMediaPlaybackNavigationAction action);

		// -(BOOL)updateViewpoint:(float)yaw pitch:(float)pitch roll:(float)roll fov:(float)fov absolute:(BOOL)absolute;
		[Export ("updateViewpoint:pitch:roll:fov:absolute:")]
		bool UpdateViewpoint (float yaw, float pitch, float roll, float fov, bool absolute);

		// @property (nonatomic) float yaw;
		[Export ("yaw")]
		float Yaw { get; set; }

		// @property (nonatomic) float pitch;
		[Export ("pitch")]
		float Pitch { get; set; }

		// @property (nonatomic) float roll;
		[Export ("roll")]
		float Roll { get; set; }

		// @property (nonatomic) float fov;
		[Export ("fov")]
		float Fov { get; set; }

		// @property (readonly, getter = isPlaying, nonatomic) BOOL playing;
		[Export ("playing")]
		bool Playing { [Bind ("isPlaying")] get; }

		// @property (readonly, nonatomic) VLCMediaPlayerState state;
		[Export ("state")]
		VLCMediaPlayerState State { get; }

		// @property (nonatomic) double position;
		[Export ("position")]
		double Position { get; set; }

		// @property (readonly, getter = isSeekable, nonatomic) BOOL seekable;
		[Export ("seekable")]
		bool Seekable { [Bind ("isSeekable")] get; }

		// @property (readonly, nonatomic) BOOL canPause;
		[Export ("canPause")]
		bool CanPause { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable snapshots;
		[NullAllowed, Export ("snapshots", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Snapshots { get; }

		// @property (readonly, nonatomic) UIImage * _Nullable lastSnapshot;
		[NullAllowed, Export ("lastSnapshot")]
		UIImage LastSnapshot { get; }

		// -(void)startRecordingAtPath:(NSString * _Nonnull)path;
		[Export ("startRecordingAtPath:")]
		void StartRecordingAtPath (string path);

		// -(void)stopRecording;
		[Export ("stopRecording")]
		void StopRecording ();

		// -(BOOL)setRendererItem:(VLCRendererItem * _Nullable)item;
		[Export ("setRendererItem:")]
		bool SetRendererItem ([NullAllowed] VLCRendererItem item);
	}



	// @interface Tracks (VLCMediaPlayer)
	[Category]
	[BaseType (typeof(VLCMediaPlayer))]
	interface VLCMediaPlayer_Tracks
	{
		// @property (readonly, copy, nonatomic) NSArray<VLCMediaPlayerTrack *> * _Nonnull audioTracks;
		[Export ("audioTracks", ArgumentSemantic.Copy)]
		VLCMediaPlayerTrack[] AudioTracks();

		// @property (readonly, copy, nonatomic) NSArray<VLCMediaPlayerTrack *> * _Nonnull videoTracks;
		[Export ("videoTracks", ArgumentSemantic.Copy)]
		VLCMediaPlayerTrack[] VideoTracks();

		// @property (readonly, copy, nonatomic) NSArray<VLCMediaPlayerTrack *> * _Nonnull textTracks;
		[Export ("textTracks", ArgumentSemantic.Copy)]
		VLCMediaPlayerTrack[] TextTracks();

		// -(void)deselectAllAudioTracks;
		[Export ("deselectAllAudioTracks")]
		void DeselectAllAudioTracks ();

		// -(void)deselectAllVideoTracks;
		[Export ("deselectAllVideoTracks")]
		void DeselectAllVideoTracks ();

		// -(void)deselectAllTextTracks;
		[Export ("deselectAllTextTracks")]
		void DeselectAllTextTracks ();
	}

	// @interface Deprecated (VLCMediaPlayer)
	[Category]
	[BaseType (typeof(VLCMediaPlayer))]
	interface VLCMediaPlayer_Deprecated
	{
		// @property (readwrite) int currentVideoTrackIndex __attribute__((deprecated("Use -[VLCMediaPlayer videoTracks] instead")));
		[Export ("currentVideoTrackIndex")]
		int CurrentVideoTrackIndex();

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Use -[VLCMediaPlayer videoTracks] instead") NSArray * videoTrackNames __attribute__((deprecated("Use -[VLCMediaPlayer videoTracks] instead")));
		[Export ("videoTrackNames", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] VideoTrackNames();

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Use -[VLCMediaPlayer videoTracks] instead") NSArray * videoTrackIndexes __attribute__((deprecated("Use -[VLCMediaPlayer videoTracks] instead")));
		[Export ("videoTrackIndexes", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] VideoTrackIndexes();

		// @property (readonly, nonatomic) int numberOfVideoTracks __attribute__((deprecated("Use -[VLCMediaPlayer videoTracks] instead")));
		[Export ("numberOfVideoTracks")]
		int NumberOfVideoTracks();

		// @property (readwrite) int currentVideoSubTitleIndex __attribute__((deprecated("Use -[VLCMediaPlayer textTracks] instead")));
		[Export ("currentVideoSubTitleIndex")]
		int CurrentVideoSubTitleIndex();

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Use -[VLCMediaPlayer textTracks] instead") NSArray * videoSubTitlesNames __attribute__((deprecated("Use -[VLCMediaPlayer textTracks] instead")));
		[Export ("videoSubTitlesNames", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] VideoSubTitlesNames();

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Use -[VLCMediaPlayer textTracks] instead") NSArray * videoSubTitlesIndexes __attribute__((deprecated("Use -[VLCMediaPlayer textTracks] instead")));
		[Export ("videoSubTitlesIndexes", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] VideoSubTitlesIndexes();

		// @property (readonly, nonatomic) int numberOfSubtitlesTracks __attribute__((deprecated("Use -[VLCMediaPlayer textTracks] instead")));
		[Export ("numberOfSubtitlesTracks")]
		int NumberOfSubtitlesTracks();

		// @property (readwrite) int currentAudioTrackIndex __attribute__((deprecated("Use -[VLCMediaPlayer audioTracks] instead")));
		[Export ("currentAudioTrackIndex")]
		int CurrentAudioTrackIndex();

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Use -[VLCMediaPlayer audioTracks] instead") NSArray * audioTrackNames __attribute__((deprecated("Use -[VLCMediaPlayer audioTracks] instead")));
		[Export ("audioTrackNames", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AudioTrackNames();

		// @property (readonly, copy, nonatomic) DEPRECATED_MSG_ATTRIBUTE("Use -[VLCMediaPlayer audioTracks] instead") NSArray * audioTrackIndexes __attribute__((deprecated("Use -[VLCMediaPlayer audioTracks] instead")));
		[Export ("audioTrackIndexes", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AudioTrackIndexes();

		// @property (readonly, nonatomic) int numberOfAudioTracks __attribute__((deprecated("Use -[VLCMediaPlayer audioTracks] instead")));
		[Export ("numberOfAudioTracks")]
		int NumberOfAudioTracks();
	}

	// @protocol VLCMediaListPlayerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface VLCMediaListPlayerDelegate
	{
		// @optional -(void)mediaListPlayerFinishedPlayback:(VLCMediaListPlayer * _Nonnull)player;
		[Export ("mediaListPlayerFinishedPlayback:")]
		void MediaListPlayerFinishedPlayback (VLCMediaListPlayer player);

		// @optional -(void)mediaListPlayer:(VLCMediaListPlayer * _Nonnull)player nextMedia:(VLCMedia * _Nonnull)media;
		[Export ("mediaListPlayer:nextMedia:")]
		void MediaListPlayer (VLCMediaListPlayer player, VLCMedia media);

		// @optional -(void)mediaListPlayerStopped:(VLCMediaListPlayer * _Nonnull)player;
		[Export ("mediaListPlayerStopped:")]
		void MediaListPlayerStopped (VLCMediaListPlayer player);
	}

	// @interface VLCMediaListPlayer : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCMediaListPlayer
	{
		// @property (readwrite) VLCMediaList * _Nullable mediaList;
		[NullAllowed, Export ("mediaList", ArgumentSemantic.Assign)]
		VLCMediaList MediaList { get; set; }

		// @property (readwrite) VLCMedia * _Nullable rootMedia;
		[NullAllowed, Export ("rootMedia", ArgumentSemantic.Assign)]
		VLCMedia RootMedia { get; set; }

		// @property (readonly) VLCMediaPlayer * _Nonnull mediaPlayer;
		[Export ("mediaPlayer")]
		VLCMediaPlayer MediaPlayer { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCMediaListPlayerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<VLCMediaListPlayerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithDrawable:(id _Nonnull)drawable;
		[Export ("initWithDrawable:")]
		NativeHandle Constructor (NSObject drawable);

		// -(instancetype _Nonnull)initWithOptions:(NSArray * _Nonnull)options;
		[Export ("initWithOptions:")]
		// [Verify (StronglyTypedNSArray)]
		NativeHandle Constructor (NSObject[] options);

		// -(instancetype _Nonnull)initWithOptions:(NSArray * _Nullable)options andDrawable:(id _Nullable)drawable;
		[Export ("initWithOptions:andDrawable:")]
		// [Verify (StronglyTypedNSArray)]
		NativeHandle Constructor ([NullAllowed] NSObject[] options, [NullAllowed] NSObject drawable);

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// @property (readonly, nonatomic) BOOL next;
		[Export ("next")]
		bool Next { get; }

		// @property (readonly, nonatomic) BOOL previous;
		[Export ("previous")]
		bool Previous { get; }

		// -(void)playItemAtNumber:(NSNumber * _Nonnull)index;
		[Export ("playItemAtNumber:")]
		void PlayItemAtNumber (NSNumber index);

		// @property (readwrite) VLCRepeatMode repeatMode;
		[Export ("repeatMode", ArgumentSemantic.Assign)]
		VLCRepeatMode RepeatMode { get; set; }

		// -(void)playMedia:(VLCMedia * _Nonnull)media;
		[Export ("playMedia:")]
		void PlayMedia (VLCMedia media);
	}

	// @interface VLCMediaThumbnailer : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCMediaThumbnailer
	{
		// +(VLCMediaThumbnailer * _Nonnull)thumbnailerWithMedia:(VLCMedia * _Nonnull)media andDelegate:(id<VLCMediaThumbnailerDelegate> _Nonnull)delegate;
		[Static]
		[Export ("thumbnailerWithMedia:andDelegate:")]
		VLCMediaThumbnailer ThumbnailerWithMedia (VLCMedia media, VLCMediaThumbnailerDelegate @delegate);

		// +(VLCMediaThumbnailer * _Nonnull)thumbnailerWithMedia:(VLCMedia * _Nonnull)media delegate:(id<VLCMediaThumbnailerDelegate> _Nonnull)delegate andVLCLibrary:(VLCLibrary * _Nullable)library;
		[Static]
		[Export ("thumbnailerWithMedia:delegate:andVLCLibrary:")]
		VLCMediaThumbnailer ThumbnailerWithMedia (VLCMedia media, VLCMediaThumbnailerDelegate @delegate, [NullAllowed] VLCLibrary library);

		// -(void)fetchThumbnail;
		[Export ("fetchThumbnail")]
		void FetchThumbnail ();

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCMediaThumbnailerDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<VLCMediaThumbnailerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic) VLCMedia * _Nonnull media;
		[Export ("media", ArgumentSemantic.Assign)]
		VLCMedia Media { get; set; }

		// @property (assign, readwrite, nonatomic) CGImageRef _Nullable thumbnail;
		[NullAllowed, Export ("thumbnail", ArgumentSemantic.Assign)]
		CGImage Thumbnail { get; set; }

		// @property (readwrite) void * _Nonnull libVLCinstance;
		[Export ("libVLCinstance", ArgumentSemantic.Assign)]
		unsafe IntPtr LibVLCinstance { get; set; }

		// @property (assign, readwrite, nonatomic) CGFloat thumbnailHeight;
		[Export ("thumbnailHeight")]
		nfloat ThumbnailHeight { get; set; }

		// @property (assign, readwrite, nonatomic) CGFloat thumbnailWidth;
		[Export ("thumbnailWidth")]
		nfloat ThumbnailWidth { get; set; }

		// @property (assign, readwrite, nonatomic) float snapshotPosition;
		[Export ("snapshotPosition")]
		float SnapshotPosition { get; set; }
	}

	// @protocol VLCMediaThumbnailerDelegate
	[Protocol, Model]
    [BaseType (typeof (NSObject))]
	interface VLCMediaThumbnailerDelegate
	{
		// @required -(void)mediaThumbnailerDidTimeOut:(VLCMediaThumbnailer * _Nonnull)mediaThumbnailer;
		//[Abstract]
		[Export ("mediaThumbnailerDidTimeOut:")]
		void MediaThumbnailerDidTimeOut (VLCMediaThumbnailer mediaThumbnailer);

		// @required -(void)mediaThumbnailer:(VLCMediaThumbnailer * _Nonnull)mediaThumbnailer didFinishThumbnail:(CGImageRef _Nonnull)thumbnail;
		//[Abstract]
		[Export ("mediaThumbnailer:didFinishThumbnail:")]
		void MediaThumbnailer (VLCMediaThumbnailer mediaThumbnailer, CGImage thumbnail);
	}

	// @interface VLCMediaMetaData : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCMediaMetaData
	{
		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable artist;
		[NullAllowed, Export ("artist")]
		string Artist { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable genre;
		[NullAllowed, Export ("genre")]
		string Genre { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable copyright;
		[NullAllowed, Export ("copyright")]
		string Copyright { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable album;
		[NullAllowed, Export ("album")]
		string Album { get; set; }

		// @property (nonatomic) unsigned int trackNumber;
		[Export ("trackNumber")]
		uint TrackNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable metaDescription;
		[NullAllowed, Export ("metaDescription")]
		string MetaDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rating;
		[NullAllowed, Export ("rating")]
		string Rating { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable date;
		[NullAllowed, Export ("date")]
		string Date { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable setting;
		[NullAllowed, Export ("setting")]
		string Setting { get; set; }

		// @property (nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Assign)]
		NSUrl Url { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable language;
		[NullAllowed, Export ("language")]
		string Language { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable nowPlaying;
		[NullAllowed, Export ("nowPlaying")]
		string NowPlaying { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable publisher;
		[NullAllowed, Export ("publisher")]
		string Publisher { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable encodedBy;
		[NullAllowed, Export ("encodedBy")]
		string EncodedBy { get; set; }

		// @property (nonatomic) NSURL * _Nullable artworkURL;
		[NullAllowed, Export ("artworkURL", ArgumentSemantic.Assign)]
		NSUrl ArtworkURL { get; set; }

		// @property (nonatomic) unsigned int trackID;
		[Export ("trackID")]
		uint TrackID { get; set; }

		// @property (nonatomic) unsigned int trackTotal;
		[Export ("trackTotal")]
		uint TrackTotal { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable director;
		[NullAllowed, Export ("director")]
		string Director { get; set; }

		// @property (nonatomic) unsigned int season;
		[Export ("season")]
		uint Season { get; set; }

		// @property (nonatomic) unsigned int episode;
		[Export ("episode")]
		uint Episode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable showName;
		[NullAllowed, Export ("showName")]
		string ShowName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable actors;
		[NullAllowed, Export ("actors")]
		string Actors { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable albumArtist;
		[NullAllowed, Export ("albumArtist")]
		string AlbumArtist { get; set; }

		// @property (nonatomic) unsigned int discNumber;
		[Export ("discNumber")]
		uint DiscNumber { get; set; }

		// @property (nonatomic) unsigned int discTotal;
		[Export ("discTotal")]
		uint DiscTotal { get; set; }

		// @property (readonly, nonatomic) VLCPlatformImage * _Nullable artwork;
		[NullAllowed, Export ("artwork")]
		UIImage Artwork { get; }

		// -(BOOL)save;
		[Export ("save")]
		// [Verify (MethodToProperty)]
		bool Save { get; }

		// -(void)prefetch;
		[Export ("prefetch")]
		void Prefetch ();

		// -(void)clearCache;
		[Export ("clearCache")]
		void ClearCache ();
	}

	// @protocol VLCCustomDialogRendererProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface VLCCustomDialogRendererProtocol
	{
		// @required -(void)showErrorWithTitle:(NSString * _Nonnull)error message:(NSString * _Nonnull)message;
		//[Abstract]
		[Export ("showErrorWithTitle:message:")]
		void ShowErrorWithTitle (string error, string message);

		// @required -(void)showLoginWithTitle:(NSString * _Nonnull)title message:(NSString * _Nonnull)message defaultUsername:(NSString * _Nullable)username askingForStorage:(BOOL)askingForStorage withReference:(NSValue * _Nonnull)reference;
		//[Abstract]
		[Export ("showLoginWithTitle:message:defaultUsername:askingForStorage:withReference:")]
		void ShowLoginWithTitle (string title, string message, [NullAllowed] string username, bool askingForStorage, NSValue reference);

		// @required -(void)showQuestionWithTitle:(NSString * _Nonnull)title message:(NSString * _Nonnull)message type:(VLCDialogQuestionType)questionType cancelString:(NSString * _Nullable)cancelString action1String:(NSString * _Nullable)action1String action2String:(NSString * _Nullable)action2String withReference:(NSValue * _Nonnull)reference;
		//[Abstract]
		[Export ("showQuestionWithTitle:message:type:cancelString:action1String:action2String:withReference:")]
		void ShowQuestionWithTitle (string title, string message, VLCDialogQuestionType questionType, [NullAllowed] string cancelString, [NullAllowed] string action1String, [NullAllowed] string action2String, NSValue reference);

		// @required -(void)showProgressWithTitle:(NSString * _Nonnull)title message:(NSString * _Nonnull)message isIndeterminate:(BOOL)isIndeterminate position:(float)position cancelString:(NSString * _Nullable)cancelString withReference:(NSValue * _Nonnull)reference;
		//[Abstract]
		[Export ("showProgressWithTitle:message:isIndeterminate:position:cancelString:withReference:")]
		void ShowProgressWithTitle (string title, string message, bool isIndeterminate, float position, [NullAllowed] string cancelString, NSValue reference);

		// @required -(void)updateProgressWithReference:(NSValue * _Nonnull)reference message:(NSString * _Nullable)message position:(float)position;
		//[Abstract]
		[Export ("updateProgressWithReference:message:position:")]
		void UpdateProgressWithReference (NSValue reference, [NullAllowed] string message, float position);

		// @required -(void)cancelDialogWithReference:(NSValue * _Nonnull)reference;
		//[Abstract]
		[Export ("cancelDialogWithReference:")]
		void CancelDialogWithReference (NSValue reference);
	}

	// @interface VLCDialogProvider : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCDialogProvider
	{
		// -(instancetype _Nullable)initWithLibrary:(VLCLibrary * _Nullable)library customUI:(BOOL)customUI;
		[Export ("initWithLibrary:customUI:")]
		NativeHandle Constructor ([NullAllowed] VLCLibrary library, bool customUI);

		// @property (readwrite, nonatomic, weak) id<VLCCustomDialogRendererProtocol> _Nullable customRenderer;
		[NullAllowed, Export ("customRenderer", ArgumentSemantic.Weak)]
		VLCCustomDialogRendererProtocol CustomRenderer { get; set; }

		// -(void)postUsername:(NSString * _Nonnull)username andPassword:(NSString * _Nonnull)password forDialogReference:(NSValue * _Nonnull)dialogReference store:(BOOL)store;
		[Export ("postUsername:andPassword:forDialogReference:store:")]
		void PostUsername (string username, string password, NSValue dialogReference, bool store);

		// -(void)postAction:(int)buttonNumber forDialogReference:(NSValue * _Nonnull)dialogReference;
		[Export ("postAction:forDialogReference:")]
		void PostAction (int buttonNumber, NSValue dialogReference);

		// -(void)dismissDialogWithReference:(NSValue * _Nonnull)dialogReference;
		[Export ("dismissDialogWithReference:")]
		void DismissDialogWithReference (NSValue dialogReference);
	}

	// @interface VLCTime : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCTime 
	{
		// +(VLCTime * _Nonnull)nullTime;
		[Static]
		[Export ("nullTime")]
		// [Verify (MethodToProperty)]
		VLCTime NullTime { get; }

		// +(VLCTime * _Nonnull)timeWithNumber:(NSNumber * _Nullable)aNumber;
		[Static]
		[Export ("timeWithNumber:")]
		VLCTime TimeWithNumber ([NullAllowed] NSNumber aNumber);

		// +(VLCTime * _Nonnull)timeWithInt:(int)aInt;
		[Static]
		[Export ("timeWithInt:")]
		VLCTime TimeWithInt (int aInt);

		// +(int64_t)clock;
		[Static]
		[Export ("clock")]
		// [Verify (MethodToProperty)]
		long Clock { get; }

		// +(int64_t)delay:(int64_t)ts;
		[Static]
		[Export ("delay:")]
		long Delay (long ts);

		// -(instancetype _Nonnull)initWithNumber:(NSNumber * _Nullable)aNumber;
		[Export ("initWithNumber:")]
		NativeHandle Constructor ([NullAllowed] NSNumber aNumber);

		// -(instancetype _Nonnull)initWithInt:(int)aInt;
		[Export ("initWithInt:")]
		NativeHandle Constructor (int aInt);

		// @property (readonly, nonatomic) NSNumber * _Nullable value;
		[NullAllowed, Export ("value")]
		NSNumber Value { get; }

		// @property (readonly) NSString * _Nonnull stringValue;
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly) NSString * _Nonnull verboseStringValue;
		[Export ("verboseStringValue")]
		string VerboseStringValue { get; }

		// @property (readonly) NSString * _Nonnull minuteStringValue;
		[Export ("minuteStringValue")]
		string MinuteStringValue { get; }

		// @property (readonly) int intValue;
		[Export ("intValue")]
		int IntValue { get; }

		// @property (readonly) NSString * _Nonnull subSecondStringValue;
		[Export ("subSecondStringValue")]
		string SubSecondStringValue { get; }

		// -(NSComparisonResult)compare:(VLCTime * _Nonnull)aTime;
		[Export ("compare:")]
		NSComparisonResult Compare (VLCTime aTime);

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual (IntPtr tmp);

		// -(NSUInteger)hash;
		[Export ("hash")]
		// [Verify (MethodToProperty)]
		nuint Hash { get; }
	}

	// @protocol VLCTranscoderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface VLCTranscoderDelegate
	{
		// @optional -(void)transcode:(VLCTranscoder * _Nonnull)transcoder finishedSucessfully:(BOOL)success;
		[Export ("transcode:finishedSucessfully:")]
		void FinishedSucessfully (VLCTranscoder transcoder, bool success);
	}

	// @interface VLCTranscoder : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCTranscoder
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCTranscoderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<VLCTranscoderDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(BOOL)reencodeAndMuxSRTFile:(NSString * _Nonnull)srtPath toMP4File:(NSString * _Nonnull)mp4Path outputPath:(NSString * _Nonnull)outPath;
		[Export ("reencodeAndMuxSRTFile:toMP4File:outputPath:")]
		bool ReencodeAndMuxSRTFile (string srtPath, string mp4Path, string outPath);
	}

	// @protocol VLCRendererDiscovererDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface VLCRendererDiscovererDelegate
	{
		// @required -(void)rendererDiscovererItemAdded:(VLCRendererDiscoverer * _Nonnull)rendererDiscoverer item:(VLCRendererItem * _Nonnull)item;
		//[Abstract]
		[Export ("rendererDiscovererItemAdded:item:")]
		void RendererDiscovererItemAdded (VLCRendererDiscoverer rendererDiscoverer, VLCRendererItem item);

		// @required -(void)rendererDiscovererItemDeleted:(VLCRendererDiscoverer * _Nonnull)rendererDiscoverer item:(VLCRendererItem * _Nonnull)item;
		//[Abstract]
		[Export ("rendererDiscovererItemDeleted:item:")]
		void RendererDiscovererItemDeleted (VLCRendererDiscoverer rendererDiscoverer, VLCRendererItem item);
	}

	// @interface VLCRendererDiscovererDescription : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCRendererDiscovererDescription
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull longName;
		[Export ("longName")]
		string LongName { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name longName:(NSString * _Nonnull)longName;
		[Export ("initWithName:longName:")]
		NativeHandle Constructor (string name, string longName);
	}

	// @interface VLCRendererDiscoverer : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCRendererDiscoverer
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSArray<VLCRendererItem *> * _Nonnull renderers;
		[Export ("renderers", ArgumentSemantic.Copy)]
		VLCRendererItem[] Renderers { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		VLCRendererDiscovererDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<VLCRendererDiscovererDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nullable)initWithName:(NSString * _Nonnull)name;
		[Export ("initWithName:")]
		NativeHandle Constructor (string name);

		// -(BOOL)start;
		[Export ("start")]
		// [Verify (MethodToProperty)]
		bool Start { get; }

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// +(NSArray<VLCRendererDiscovererDescription *> * _Nullable)list;
		[Static]
		[NullAllowed, Export ("list")]
		// [Verify (MethodToProperty)]
		VLCRendererDiscovererDescription[] List { get; }
	}

	// @interface VLCRendererItem : NSObject
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCRendererItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull iconURI;
		[Export ("iconURI")]
		string IconURI { get; }

		// @property (readonly, assign, nonatomic) int flags;
		[Export ("flags")]
		int Flags { get; }
	}

	// @protocol VLCFilterParameter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface VLCFilterParameter
	{
		// @required @property (nonatomic) id _Nonnull value;
		//[Abstract]
		[Export ("value", ArgumentSemantic.Assign)]
		NSObject Value { get; set; }

		// @required @property (readonly, nonatomic) id _Nonnull defaultValue;
		//[Abstract]
		[Export ("defaultValue")]
		NSObject DefaultValue { get; }

		// @required @property (readonly, nonatomic) id _Nonnull minValue;
		//[Abstract]
		[Export ("minValue")]
		NSObject MinValue { get; }

		// @required @property (readonly, nonatomic) id _Nonnull maxValue;
		//[Abstract]
		[Export ("maxValue")]
		NSObject MaxValue { get; }

		// @required -(BOOL)isValueSetToDefault;
		//[Abstract]
		[Export ("isValueSetToDefault")]
		// [Verify (MethodToProperty)]
		bool IsValueSetToDefault { get; }
	}

	// @protocol VLCFilter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface VLCFilter
	{
		// @required @property (readonly, nonatomic, weak) VLCMediaPlayer * _Nullable mediaPlayer;
		//[Abstract]
		[NullAllowed, Export ("mediaPlayer", ArgumentSemantic.Weak)]
		VLCMediaPlayer MediaPlayer { get; }

		// @required @property (getter = isEnabled, nonatomic) BOOL enabled;
		//[Abstract]
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @required @property (readonly, nonatomic) NSDictionary<NSString *,id<VLCFilterParameter>> * _Nonnull parameters;
		// [Abstract]
		// [Export ("parameters")]
		// NSDictionary<NSString, VLCFilterParameter> Parameters { get; }

		// @required -(BOOL)resetParametersIfNeeded;
		//[Abstract]
		[Export ("resetParametersIfNeeded")]
		// [Verify (MethodToProperty)]
		bool ResetParametersIfNeeded { get; }

		// @required -(void)applyParametersFrom:(id<VLCFilter> _Nonnull)otherFilter;
		//[Abstract]
		[Export ("applyParametersFrom:")]
		void ApplyParametersFrom (VLCFilter otherFilter);
	}


	// @interface VLCAdjustFilter : NSObject <VLCFilter>
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCAdjustFilter : VLCFilter
	{
		// @property (readonly, nonatomic) id<VLCFilterParameter> _Nonnull contrast;
		[Export ("contrast")]
        VLCFilterParameter Contrast { get; }

		// @property (readonly, nonatomic) id<VLCFilterParameter> _Nonnull brightness;
		[Export ("brightness")]
		VLCFilterParameter Brightness { get; }

		// @property (readonly, nonatomic) id<VLCFilterParameter> _Nonnull hue;
		[Export ("hue")]
        VLCFilterParameter Hue { get; }

		// @property (readonly, nonatomic) id<VLCFilterParameter> _Nonnull saturation;
		[Export ("saturation")]
        VLCFilterParameter Saturation { get; }

		// @property (readonly, nonatomic) id<VLCFilterParameter> _Nonnull gamma;
		[Export ("gamma")]
		VLCFilterParameter Gamma { get; }

		// +(instancetype _Nonnull)createWithVLCMediaPlayer:(VLCMediaPlayer * _Nonnull)mediaPlayer;
		[Static]
		[Export ("createWithVLCMediaPlayer:")]
		IntPtr CreateWithVLCMediaPlayer (VLCMediaPlayer mediaPlayer);

		// -(instancetype _Nonnull)initWithVLCMediaPlayer:(VLCMediaPlayer * _Nonnull)mediaPlayer __attribute__((objc_designated_initializer));
		[Export ("initWithVLCMediaPlayer:")]
		//[DesignatedInitializer]
		NativeHandle Constructor (VLCMediaPlayer mediaPlayer);
	}

	// @interface VLCLogContext : NSObject
	[BaseType (typeof(NSObject))]
	interface VLCLogContext
	{
		// @property (readonly, nonatomic) uintptr_t objectId;
		[Export ("objectId")]
		UIntPtr ObjectId { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull objectType;
		[Export ("objectType")]
		string ObjectType { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull module;
		[Export ("module")]
		string Module { get; }

		// @property (readonly, nonatomic) NSString * _Nullable header;
		[NullAllowed, Export ("header")]
		string Header { get; }

		// @property (readonly, nonatomic) NSString * _Nullable file;
		[NullAllowed, Export ("file")]
		string File { get; }

		// @property (readonly, nonatomic) int line;
		[Export ("line")]
		int Line { get; }

		// @property (readonly, nonatomic) NSString * _Nullable function;
		[NullAllowed, Export ("function")]
		string Function { get; }

		// @property (readonly, nonatomic) unsigned long threadId;
		[Export ("threadId")]
		nuint ThreadId { get; }
	}

	// @protocol VLCLogMessageFormatting <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface IVLCLogMessageFormatting
	{
		// @required @property (readwrite, nonatomic) VLCLogContextFlag contextFlags;
		//[Abstract]
		[Export ("contextFlags", ArgumentSemantic.Assign)]
		VLCLogContextFlag ContextFlags { get; set; }

		// @required @property (readwrite, nonatomic) id _Nullable customContext;
		//[Abstract]
		[NullAllowed, Export ("customContext", ArgumentSemantic.Assign)]
		NSObject CustomContext { get; set; }

		// @required -(NSString * _Nonnull)formatWithMessage:(NSString * _Nonnull)message logLevel:(VLCLogLevel)level context:(VLCLogContext * _Nullable)context;
		//[Abstract]
		[Export ("formatWithMessage:logLevel:context:")]
		string LogLevel (string message, VLCLogLevel level, [NullAllowed] VLCLogContext context);
	}

	// @protocol VLCLogging <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface IVLCLogging
	{
		// @required @property (readwrite, nonatomic) VLCLogLevel level;
		//[Abstract]
		[Export ("level", ArgumentSemantic.Assign)]
		VLCLogLevel Level { get; set; }

		// @required -(void)handleMessage:(NSString * _Nonnull)message logLevel:(VLCLogLevel)level context:(VLCLogContext * _Nullable)context;
		//[Abstract]
		[Export ("handleMessage:logLevel:context:")]
		void LogLevel (string message, VLCLogLevel level, [NullAllowed] VLCLogContext context);
	}

	// @protocol VLCFormattedMessageLogging <VLCLogging>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface IVLCFormattedMessageLogging : IVLCLogging
	{
		// @required @property (readwrite, nonatomic) id<VLCLogMessageFormatting> _Nonnull formatter;
		//[Abstract]
		[Export ("formatter", ArgumentSemantic.Assign)]
		IVLCLogMessageFormatting Formatter { get; set; }
	}

	// @interface VLCConsoleLogger : NSObject <VLCFormattedMessageLogging>
	//[BaseType (typeof(NSObject))]
	//interface VLCConsoleLogger : IVLCFormattedMessageLogging
	//{
	//	// @property (readwrite, nonatomic) id<VLCLogMessageFormatting> _Nonnull formatter;
	//	[Export ("formatter", ArgumentSemantic.Assign)]
	//	IntPtr Formatter { get; set; }
	//}

	// @interface VLCFileLogger : NSObject <VLCFormattedMessageLogging>
	[BaseType (typeof(NSObject))]
	// [DisableDefaultCtor]
	interface VLCFileLogger : IVLCFormattedMessageLogging
	{
		// @property (readonly, nonatomic) NSFileHandle * _Nonnull fileHandle;
		[Export ("fileHandle")]
		NSFileHandle FileHandle { get; }

		// @property (readwrite, nonatomic) id<VLCLogMessageFormatting> _Nonnull formatter;
		[Export ("formatter", ArgumentSemantic.Assign)]
		IVLCLogMessageFormatting Formatter { get; set; }

		// +(instancetype _Nonnull)createWithFileHandle:(NSFileHandle * _Nonnull)fileHandle;
		[Static]
		[Export ("createWithFileHandle:")]
		VLCFileLogger CreateWithFileHandle (NSFileHandle fileHandle);

		// -(instancetype _Nonnull)initWithFileHandle:(NSFileHandle * _Nonnull)fileHandle __attribute__((objc_designated_initializer));
		[Export ("initWithFileHandle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSFileHandle fileHandle);
	}

	// @interface VLCLogMessageFormatter : NSObject <VLCLogMessageFormatting>
	[BaseType (typeof(NSObject))]
	interface VLCLogMessageFormatter : IVLCLogMessageFormatting
	{
	}
}
