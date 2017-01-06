//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: proto_struct.proto
namespace game.protobuf.data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"struct_serverList")]
  public partial class struct_serverList : global::ProtoBuf.IExtensible
  {
    public struct_serverList() {}
    
    private string _ip = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ip
    {
      get { return _ip; }
      set { _ip = value; }
    }
    private uint _port = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint port
    {
      get { return _port; }
      set { _port = value; }
    }
    private uint _serverId = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serverId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint serverId
    {
      get { return _serverId; }
      set { _serverId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"struct_PlayerSimpleInfo")]
  public partial class struct_PlayerSimpleInfo : global::ProtoBuf.IExtensible
  {
    public struct_PlayerSimpleInfo() {}
    
    private ulong _id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _level = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"struct_PlayerDetailInfo")]
  public partial class struct_PlayerDetailInfo : global::ProtoBuf.IExtensible
  {
    public struct_PlayerDetailInfo() {}
    
    private ulong _id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _level = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"struct_ChatInfo")]
  public partial class struct_ChatInfo : global::ProtoBuf.IExtensible
  {
    public struct_ChatInfo() {}
    
    private uint _channelId = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"channelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint channelId
    {
      get { return _channelId; }
      set { _channelId = value; }
    }
    private struct_PlayerSimpleInfo _Sender = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Sender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public struct_PlayerSimpleInfo Sender
    {
      get { return _Sender; }
      set { _Sender = value; }
    }
    private struct_PlayerSimpleInfo _Receiver = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Receiver", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public struct_PlayerSimpleInfo Receiver
    {
      get { return _Receiver; }
      set { _Receiver = value; }
    }
    private string _TalkMsg = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"TalkMsg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TalkMsg
    {
      get { return _TalkMsg; }
      set { _TalkMsg = value; }
    }
    private ulong _time = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}