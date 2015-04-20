//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetPersonalInfoMsg.proto
// Note: requires additional types generated from: UserData.proto
// Note: requires additional types generated from: GroupData.proto
namespace protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPersonalInfoReq")]
  public partial class GetPersonalInfoReq : global::ProtoBuf.IExtensible
  {
    public GetPersonalInfoReq() {}
    
    private bool _userInfo = (bool)false;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"userInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool userInfo
    {
      get { return _userInfo; }
      set { _userInfo = value; }
    }
    private bool _friendInfo = (bool)false;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"friendInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool friendInfo
    {
      get { return _friendInfo; }
      set { _friendInfo = value; }
    }
    private bool _groupInfo = (bool)false;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"groupInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool groupInfo
    {
      get { return _groupInfo; }
      set { _groupInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPersonalInfoRsp")]
  public partial class GetPersonalInfoRsp : global::ProtoBuf.IExtensible
  {
    public GetPersonalInfoRsp() {}
    
    private protocol.GetPersonalInfoRsp.ResultCode _resultCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"resultCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public protocol.GetPersonalInfoRsp.ResultCode resultCode
    {
      get { return _resultCode; }
      set { _resultCode = value; }
    }
    private protocol.UserItem _userInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"userInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public protocol.UserItem userInfo
    {
      get { return _userInfo; }
      set { _userInfo = value; }
    }
    private readonly global::System.Collections.Generic.List<protocol.UserItem> _friends = new global::System.Collections.Generic.List<protocol.UserItem>();
    [global::ProtoBuf.ProtoMember(3, Name=@"friends", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<protocol.UserItem> friends
    {
      get { return _friends; }
    }
  
    private readonly global::System.Collections.Generic.List<protocol.GroupItem> _groups = new global::System.Collections.Generic.List<protocol.GroupItem>();
    [global::ProtoBuf.ProtoMember(4, Name=@"groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<protocol.GroupItem> groups
    {
      get { return _groups; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ResultCode")]
    public enum ResultCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUCCESS", Value=0)]
      SUCCESS = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FAIL", Value=1)]
      FAIL = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}