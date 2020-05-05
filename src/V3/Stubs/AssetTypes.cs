// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/common/asset_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/common/asset_types.proto</summary>
  public static partial class AssetTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/common/asset_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92My9jb21tb24vYXNzZXRfdHlwZXMu",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbhotZ29vZ2xl",
            "L2Fkcy9nb29nbGVhZHMvdjMvZW51bXMvbWltZV90eXBlLnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8iSwoRWW91dHViZVZpZGVvQXNzZXQSNgoQeW91dHViZV92",
            "aWRlb19pZBgBIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZSI9",
            "ChBNZWRpYUJ1bmRsZUFzc2V0EikKBGRhdGEYASABKAsyGy5nb29nbGUucHJv",
            "dG9idWYuQnl0ZXNWYWx1ZSLzAQoKSW1hZ2VBc3NldBIpCgRkYXRhGAEgASgL",
            "MhsuZ29vZ2xlLnByb3RvYnVmLkJ5dGVzVmFsdWUSLgoJZmlsZV9zaXplGAIg",
            "ASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWUSRwoJbWltZV90eXBl",
            "GAMgASgOMjQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMuTWltZVR5",
            "cGVFbnVtLk1pbWVUeXBlEkEKCWZ1bGxfc2l6ZRgEIAEoCzIuLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbi5JbWFnZURpbWVuc2lvbiKiAQoOSW1h",
            "Z2VEaW1lbnNpb24SMgoNaGVpZ2h0X3BpeGVscxgBIAEoCzIbLmdvb2dsZS5w",
            "cm90b2J1Zi5JbnQ2NFZhbHVlEjEKDHdpZHRoX3BpeGVscxgCIAEoCzIbLmdv",
            "b2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlEikKA3VybBgDIAEoCzIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZSI3CglUZXh0QXNzZXQSKgoEdGV4dBgB",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZULqAQoiY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbkIPQXNzZXRUeXBlc1Byb3Rv",
            "UAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92My9jb21tb247Y29tbW9uogIDR0FBqgIeR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjMuQ29tbW9uygIeR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjNcQ29tbW9u6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OkNvbW1v",
            "bmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Enums.MimeTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.YoutubeVideoAsset), global::Google.Ads.GoogleAds.V3.Common.YoutubeVideoAsset.Parser, new[]{ "YoutubeVideoId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.MediaBundleAsset), global::Google.Ads.GoogleAds.V3.Common.MediaBundleAsset.Parser, new[]{ "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.ImageAsset), global::Google.Ads.GoogleAds.V3.Common.ImageAsset.Parser, new[]{ "Data", "FileSize", "MimeType", "FullSize" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.ImageDimension), global::Google.Ads.GoogleAds.V3.Common.ImageDimension.Parser, new[]{ "HeightPixels", "WidthPixels", "Url" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.TextAsset), global::Google.Ads.GoogleAds.V3.Common.TextAsset.Parser, new[]{ "Text" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A YouTube asset.
  /// </summary>
  public sealed partial class YoutubeVideoAsset : pb::IMessage<YoutubeVideoAsset> {
    private static readonly pb::MessageParser<YoutubeVideoAsset> _parser = new pb::MessageParser<YoutubeVideoAsset>(() => new YoutubeVideoAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<YoutubeVideoAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.AssetTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public YoutubeVideoAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public YoutubeVideoAsset(YoutubeVideoAsset other) : this() {
      YoutubeVideoId = other.YoutubeVideoId;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public YoutubeVideoAsset Clone() {
      return new YoutubeVideoAsset(this);
    }

    /// <summary>Field number for the "youtube_video_id" field.</summary>
    public const int YoutubeVideoIdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_youtubeVideoId_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string youtubeVideoId_;
    /// <summary>
    /// YouTube video id. This is the 11 character string value used in the
    /// YouTube video URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string YoutubeVideoId {
      get { return youtubeVideoId_; }
      set {
        youtubeVideoId_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as YoutubeVideoAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(YoutubeVideoAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (YoutubeVideoId != other.YoutubeVideoId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (youtubeVideoId_ != null) hash ^= YoutubeVideoId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (youtubeVideoId_ != null) {
        _single_youtubeVideoId_codec.WriteTagAndValue(output, YoutubeVideoId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (youtubeVideoId_ != null) {
        size += _single_youtubeVideoId_codec.CalculateSizeWithTag(YoutubeVideoId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(YoutubeVideoAsset other) {
      if (other == null) {
        return;
      }
      if (other.youtubeVideoId_ != null) {
        if (youtubeVideoId_ == null || other.YoutubeVideoId != "") {
          YoutubeVideoId = other.YoutubeVideoId;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_youtubeVideoId_codec.Read(input);
            if (youtubeVideoId_ == null || value != "") {
              YoutubeVideoId = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A MediaBundle asset.
  /// </summary>
  public sealed partial class MediaBundleAsset : pb::IMessage<MediaBundleAsset> {
    private static readonly pb::MessageParser<MediaBundleAsset> _parser = new pb::MessageParser<MediaBundleAsset>(() => new MediaBundleAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaBundleAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.AssetTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaBundleAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaBundleAsset(MediaBundleAsset other) : this() {
      Data = other.Data;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaBundleAsset Clone() {
      return new MediaBundleAsset(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _single_data_codec = pb::FieldCodec.ForClassWrapper<pb::ByteString>(10);
    private pb::ByteString data_;
    /// <summary>
    /// Media bundle (ZIP file) asset data. The format of the uploaded ZIP file
    /// depends on the ad field where it will be used. For more information on the
    /// format, see the documentation of the ad field where you plan on using the
    /// MediaBundleAsset. This field is mutate only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MediaBundleAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaBundleAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        _single_data_codec.WriteTagAndValue(output, Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += _single_data_codec.CalculateSizeWithTag(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MediaBundleAsset other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null || other.Data != pb::ByteString.Empty) {
          Data = other.Data;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            pb::ByteString value = _single_data_codec.Read(input);
            if (data_ == null || value != pb::ByteString.Empty) {
              Data = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// An Image asset.
  /// </summary>
  public sealed partial class ImageAsset : pb::IMessage<ImageAsset> {
    private static readonly pb::MessageParser<ImageAsset> _parser = new pb::MessageParser<ImageAsset>(() => new ImageAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.AssetTypesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageAsset(ImageAsset other) : this() {
      Data = other.Data;
      FileSize = other.FileSize;
      mimeType_ = other.mimeType_;
      fullSize_ = other.fullSize_ != null ? other.fullSize_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageAsset Clone() {
      return new ImageAsset(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _single_data_codec = pb::FieldCodec.ForClassWrapper<pb::ByteString>(10);
    private pb::ByteString data_;
    /// <summary>
    /// The raw bytes data of an image. This field is mutate only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }


    /// <summary>Field number for the "file_size" field.</summary>
    public const int FileSizeFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_fileSize_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? fileSize_;
    /// <summary>
    /// File size of the image asset in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? FileSize {
      get { return fileSize_; }
      set {
        fileSize_ = value;
      }
    }


    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType mimeType_ = global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType.Unspecified;
    /// <summary>
    /// MIME type of the image asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = value;
      }
    }

    /// <summary>Field number for the "full_size" field.</summary>
    public const int FullSizeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V3.Common.ImageDimension fullSize_;
    /// <summary>
    /// Metadata for this image at its original size.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.ImageDimension FullSize {
      get { return fullSize_; }
      set {
        fullSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImageAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      if (FileSize != other.FileSize) return false;
      if (MimeType != other.MimeType) return false;
      if (!object.Equals(FullSize, other.FullSize)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (fileSize_ != null) hash ^= FileSize.GetHashCode();
      if (MimeType != global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType.Unspecified) hash ^= MimeType.GetHashCode();
      if (fullSize_ != null) hash ^= FullSize.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        _single_data_codec.WriteTagAndValue(output, Data);
      }
      if (fileSize_ != null) {
        _single_fileSize_codec.WriteTagAndValue(output, FileSize);
      }
      if (MimeType != global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MimeType);
      }
      if (fullSize_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(FullSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += _single_data_codec.CalculateSizeWithTag(Data);
      }
      if (fileSize_ != null) {
        size += _single_fileSize_codec.CalculateSizeWithTag(FileSize);
      }
      if (MimeType != global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MimeType);
      }
      if (fullSize_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FullSize);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImageAsset other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null || other.Data != pb::ByteString.Empty) {
          Data = other.Data;
        }
      }
      if (other.fileSize_ != null) {
        if (fileSize_ == null || other.FileSize != 0L) {
          FileSize = other.FileSize;
        }
      }
      if (other.MimeType != global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType.Unspecified) {
        MimeType = other.MimeType;
      }
      if (other.fullSize_ != null) {
        if (fullSize_ == null) {
          FullSize = new global::Google.Ads.GoogleAds.V3.Common.ImageDimension();
        }
        FullSize.MergeFrom(other.FullSize);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            pb::ByteString value = _single_data_codec.Read(input);
            if (data_ == null || value != pb::ByteString.Empty) {
              Data = value;
            }
            break;
          }
          case 18: {
            long? value = _single_fileSize_codec.Read(input);
            if (fileSize_ == null || value != 0L) {
              FileSize = value;
            }
            break;
          }
          case 24: {
            MimeType = (global::Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types.MimeType) input.ReadEnum();
            break;
          }
          case 34: {
            if (fullSize_ == null) {
              FullSize = new global::Google.Ads.GoogleAds.V3.Common.ImageDimension();
            }
            input.ReadMessage(FullSize);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Metadata for an image at a certain size, either original or resized.
  /// </summary>
  public sealed partial class ImageDimension : pb::IMessage<ImageDimension> {
    private static readonly pb::MessageParser<ImageDimension> _parser = new pb::MessageParser<ImageDimension>(() => new ImageDimension());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageDimension> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.AssetTypesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageDimension() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageDimension(ImageDimension other) : this() {
      HeightPixels = other.HeightPixels;
      WidthPixels = other.WidthPixels;
      Url = other.Url;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageDimension Clone() {
      return new ImageDimension(this);
    }

    /// <summary>Field number for the "height_pixels" field.</summary>
    public const int HeightPixelsFieldNumber = 1;
    private static readonly pb::FieldCodec<long?> _single_heightPixels_codec = pb::FieldCodec.ForStructWrapper<long>(10);
    private long? heightPixels_;
    /// <summary>
    /// Height of the image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? HeightPixels {
      get { return heightPixels_; }
      set {
        heightPixels_ = value;
      }
    }


    /// <summary>Field number for the "width_pixels" field.</summary>
    public const int WidthPixelsFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_widthPixels_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? widthPixels_;
    /// <summary>
    /// Width of the image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? WidthPixels {
      get { return widthPixels_; }
      set {
        widthPixels_ = value;
      }
    }


    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_url_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string url_;
    /// <summary>
    /// A URL that returns the image with this height and width.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageDimension);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImageDimension other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HeightPixels != other.HeightPixels) return false;
      if (WidthPixels != other.WidthPixels) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (heightPixels_ != null) hash ^= HeightPixels.GetHashCode();
      if (widthPixels_ != null) hash ^= WidthPixels.GetHashCode();
      if (url_ != null) hash ^= Url.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (heightPixels_ != null) {
        _single_heightPixels_codec.WriteTagAndValue(output, HeightPixels);
      }
      if (widthPixels_ != null) {
        _single_widthPixels_codec.WriteTagAndValue(output, WidthPixels);
      }
      if (url_ != null) {
        _single_url_codec.WriteTagAndValue(output, Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (heightPixels_ != null) {
        size += _single_heightPixels_codec.CalculateSizeWithTag(HeightPixels);
      }
      if (widthPixels_ != null) {
        size += _single_widthPixels_codec.CalculateSizeWithTag(WidthPixels);
      }
      if (url_ != null) {
        size += _single_url_codec.CalculateSizeWithTag(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImageDimension other) {
      if (other == null) {
        return;
      }
      if (other.heightPixels_ != null) {
        if (heightPixels_ == null || other.HeightPixels != 0L) {
          HeightPixels = other.HeightPixels;
        }
      }
      if (other.widthPixels_ != null) {
        if (widthPixels_ == null || other.WidthPixels != 0L) {
          WidthPixels = other.WidthPixels;
        }
      }
      if (other.url_ != null) {
        if (url_ == null || other.Url != "") {
          Url = other.Url;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            long? value = _single_heightPixels_codec.Read(input);
            if (heightPixels_ == null || value != 0L) {
              HeightPixels = value;
            }
            break;
          }
          case 18: {
            long? value = _single_widthPixels_codec.Read(input);
            if (widthPixels_ == null || value != 0L) {
              WidthPixels = value;
            }
            break;
          }
          case 26: {
            string value = _single_url_codec.Read(input);
            if (url_ == null || value != "") {
              Url = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A Text asset.
  /// </summary>
  public sealed partial class TextAsset : pb::IMessage<TextAsset> {
    private static readonly pb::MessageParser<TextAsset> _parser = new pb::MessageParser<TextAsset>(() => new TextAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TextAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.AssetTypesReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextAsset(TextAsset other) : this() {
      Text = other.Text;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextAsset Clone() {
      return new TextAsset(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_text_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string text_;
    /// <summary>
    /// Text content of the text asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TextAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TextAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (text_ != null) hash ^= Text.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (text_ != null) {
        _single_text_codec.WriteTagAndValue(output, Text);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (text_ != null) {
        size += _single_text_codec.CalculateSizeWithTag(Text);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TextAsset other) {
      if (other == null) {
        return;
      }
      if (other.text_ != null) {
        if (text_ == null || other.Text != "") {
          Text = other.Text;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_text_codec.Read(input);
            if (text_ == null || value != "") {
              Text = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
