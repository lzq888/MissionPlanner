//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: webapi.proto
namespace webapi
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginMsg")]
  public partial class LoginMsg : global::ProtoBuf.IExtensible
  {
    public LoginMsg() {}
    
    private LoginRequestCode _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public LoginRequestCode code
    {
      get { return _code; }
      set { _code = value; }
    }
    private string _username;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _password = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private string _email = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"email", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string email
    {
      get { return _email; }
      set { _email = value; }
    }
    private long _startTime = default(long);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"startTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long startTime
    {
      get { return _startTime; }
      set { _startTime = value; }
    }
    private string _gcsName = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"gcsName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gcsName
    {
      get { return _gcsName; }
      set { _gcsName = value; }
    }
    private string _softwareVersion = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"softwareVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string softwareVersion
    {
      get { return _softwareVersion; }
      set { _softwareVersion = value; }
    }
    private int _protocolVersion = (int)1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"protocolVersion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int protocolVersion
    {
      get { return _protocolVersion; }
      set { _protocolVersion = value; }
    }
    private AccessCode _defaultViewPrivacy = AccessCode.PUBLIC;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"defaultViewPrivacy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(AccessCode.PUBLIC)]
    public AccessCode defaultViewPrivacy
    {
      get { return _defaultViewPrivacy; }
      set { _defaultViewPrivacy = value; }
    }
    private AccessCode _defaultControlPrivacy = AccessCode.PRIVATE;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"defaultControlPrivacy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(AccessCode.PRIVATE)]
    public AccessCode defaultControlPrivacy
    {
      get { return _defaultControlPrivacy; }
      set { _defaultControlPrivacy = value; }
    }
    private string _apiKey = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"apiKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string apiKey
    {
      get { return _apiKey; }
      set { _apiKey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoteMsg")]
  public partial class NoteMsg : global::ProtoBuf.IExtensible
  {
    public NoteMsg() {}
    
    private string _note;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"note", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string note
    {
      get { return _note; }
      set { _note = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ShowMsg")]
  public partial class ShowMsg : global::ProtoBuf.IExtensible
  {
    public ShowMsg() {}
    
    private string _text = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private string _url = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }
    private ShowMsg.Priority _priority;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ShowMsg.Priority priority
    {
      get { return _priority; }
      set { _priority = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Priority")]
    public enum Priority
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOW", Value=0)]
      LOW = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MEDIUM", Value=10)]
      MEDIUM = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HIGH", Value=20)]
      HIGH = 20
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginResponseMsg")]
  public partial class LoginResponseMsg : global::ProtoBuf.IExtensible
  {
    public LoginResponseMsg() {}
    
    private LoginResponseMsg.ResponseCode _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public LoginResponseMsg.ResponseCode code
    {
      get { return _code; }
      set { _code = value; }
    }
    private ShowMsg _message = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ShowMsg message
    {
      get { return _message; }
      set { _message = value; }
    }
    private int _callbackDelay = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"callbackDelay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int callbackDelay
    {
      get { return _callbackDelay; }
      set { _callbackDelay = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ResponseCode")]
    public enum ResponseCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OK", Value=0)]
      OK = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BAD_PASSWORD", Value=1)]
      BAD_PASSWORD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CALL_LATER", Value=2)]
      CALL_LATER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NAME_UNAVAILABLE", Value=3)]
      NAME_UNAVAILABLE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PROTOCOL_INCOMPATIBLE", Value=4)]
      PROTOCOL_INCOMPATIBLE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_FAULT", Value=5)]
      SERVER_FAULT = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StartMissionMsg")]
  public partial class StartMissionMsg : global::ProtoBuf.IExtensible
  {
    public StartMissionMsg() {}
    
    private string _notes = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"notes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string notes
    {
      get { return _notes; }
      set { _notes = value; }
    }
    private AccessCode _viewPrivacy = AccessCode.DEFAULT;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"viewPrivacy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(AccessCode.DEFAULT)]
    public AccessCode viewPrivacy
    {
      get { return _viewPrivacy; }
      set { _viewPrivacy = value; }
    }
    private AccessCode _controlPrivacy = AccessCode.DEFAULT;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"controlPrivacy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(AccessCode.DEFAULT)]
    public AccessCode controlPrivacy
    {
      get { return _controlPrivacy; }
      set { _controlPrivacy = value; }
    }
    private bool _keep;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"keep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool keep
    {
      get { return _keep; }
      set { _keep = value; }
    }
    private string _uuid = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"uuid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string uuid
    {
      get { return _uuid; }
      set { _uuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StopMissionMsg")]
  public partial class StopMissionMsg : global::ProtoBuf.IExtensible
  {
    public StopMissionMsg() {}
    
    private string _notes = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"notes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string notes
    {
      get { return _notes; }
      set { _notes = value; }
    }
    private bool _keep;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"keep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool keep
    {
      get { return _keep; }
      set { _keep = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MissionResponse")]
  public partial class MissionResponse : global::ProtoBuf.IExtensible
  {
    public MissionResponse() {}
    
    private ShowMsg _message = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ShowMsg message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PingMsg")]
  public partial class PingMsg : global::ProtoBuf.IExtensible
  {
    public PingMsg() {}
    
    private int _nonce;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nonce", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int nonce
    {
      get { return _nonce; }
      set { _nonce = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PingResponseMsg")]
  public partial class PingResponseMsg : global::ProtoBuf.IExtensible
  {
    public PingResponseMsg() {}
    
    private int _nonce;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nonce", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int nonce
    {
      get { return _nonce; }
      set { _nonce = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MavlinkMsg")]
  public partial class MavlinkMsg : global::ProtoBuf.IExtensible
  {
    public MavlinkMsg() {}
    
    private int _srcInterface;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"srcInterface", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int srcInterface
    {
      get { return _srcInterface; }
      set { _srcInterface = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _packet = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(2, Name=@"packet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> packet
    {
      get { return _packet; }
    }
  
    private long _deltaT = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"deltaT", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long deltaT
    {
      get { return _deltaT; }
      set { _deltaT = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SenderIdMsg")]
  public partial class SenderIdMsg : global::ProtoBuf.IExtensible
  {
    public SenderIdMsg() {}
    
    private int _gcsInterface;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gcsInterface", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int gcsInterface
    {
      get { return _gcsInterface; }
      set { _gcsInterface = value; }
    }
    private int _sysId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"sysId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int sysId
    {
      get { return _sysId; }
      set { _sysId = value; }
    }
    private string _vehicleUUID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"vehicleUUID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string vehicleUUID
    {
      get { return _vehicleUUID; }
      set { _vehicleUUID = value; }
    }
    private bool _canAcceptCommands;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"canAcceptCommands", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool canAcceptCommands
    {
      get { return _canAcceptCommands; }
      set { _canAcceptCommands = value; }
    }
    private string _humanName = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"humanName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string humanName
    {
      get { return _humanName; }
      set { _humanName = value; }
    }
    private string _manufacturer = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"manufacturer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string manufacturer
    {
      get { return _manufacturer; }
      set { _manufacturer = value; }
    }
    private string _vehicleType = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vehicleType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string vehicleType
    {
      get { return _vehicleType; }
      set { _vehicleType = value; }
    }
    private string _autopilotType = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"autopilotType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string autopilotType
    {
      get { return _autopilotType; }
      set { _autopilotType = value; }
    }
    private string _softwareVersion = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"softwareVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string softwareVersion
    {
      get { return _softwareVersion; }
      set { _softwareVersion = value; }
    }
    private bool _wantPipe = default(bool);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"wantPipe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool wantPipe
    {
      get { return _wantPipe; }
      set { _wantPipe = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Envelope")]
  public partial class Envelope : global::ProtoBuf.IExtensible
  {
    public Envelope() {}
    
    private Envelope.MsgCode _type = Envelope.MsgCode.MavlinkMsgCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Envelope.MsgCode.MavlinkMsgCode)]
    public Envelope.MsgCode type
    {
      get { return _type; }
      set { _type = value; }
    }
    private MavlinkMsg _mavlink = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mavlink", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public MavlinkMsg mavlink
    {
      get { return _mavlink; }
      set { _mavlink = value; }
    }
    private LoginMsg _login = null;
    [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"login", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public LoginMsg login
    {
      get { return _login; }
      set { _login = value; }
    }
    private SenderIdMsg _setSender = null;
    [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"setSender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public SenderIdMsg setSender
    {
      get { return _setSender; }
      set { _setSender = value; }
    }
    private NoteMsg _note = null;
    [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"note", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public NoteMsg note
    {
      get { return _note; }
      set { _note = value; }
    }
    private StartMissionMsg _startMission = null;
    [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"startMission", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public StartMissionMsg startMission
    {
      get { return _startMission; }
      set { _startMission = value; }
    }
    private StopMissionMsg _stopMission = null;
    [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"stopMission", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public StopMissionMsg stopMission
    {
      get { return _stopMission; }
      set { _stopMission = value; }
    }
    private PingMsg _ping = null;
    [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PingMsg ping
    {
      get { return _ping; }
      set { _ping = value; }
    }
    private LoginResponseMsg _loginResponse = null;
    [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"loginResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public LoginResponseMsg loginResponse
    {
      get { return _loginResponse; }
      set { _loginResponse = value; }
    }
    private ShowMsg _show = null;
    [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"show", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ShowMsg show
    {
      get { return _show; }
      set { _show = value; }
    }
    private MissionResponse _missionResponse = null;
    [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"missionResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public MissionResponse missionResponse
    {
      get { return _missionResponse; }
      set { _missionResponse = value; }
    }
    private PingResponseMsg _pingResponse = null;
    [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"pingResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PingResponseMsg pingResponse
    {
      get { return _pingResponse; }
      set { _pingResponse = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"MsgCode")]
    public enum MsgCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MavlinkMsgCode", Value=2)]
      MavlinkMsgCode = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginMsgCode", Value=32)]
      LoginMsgCode = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SenderIdMsgCode", Value=33)]
      SenderIdMsgCode = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NoteMsgCode", Value=34)]
      NoteMsgCode = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"StartMissionMsgCode", Value=35)]
      StartMissionMsgCode = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"StopMissionMsgCode", Value=36)]
      StopMissionMsgCode = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PingMsgCode", Value=37)]
      PingMsgCode = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginResponseMsgCode", Value=64)]
      LoginResponseMsgCode = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ShowMsgCode", Value=65)]
      ShowMsgCode = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MissionResponseCode", Value=66)]
      MissionResponseCode = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PingResponseMsgCode", Value=67)]
      PingResponseMsgCode = 67
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"AccessCode")]
    public enum AccessCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEFAULT", Value=0)]
      DEFAULT = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PRIVATE", Value=10)]
      PRIVATE = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHARED", Value=20)]
      SHARED = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RESEARCHER", Value=30)]
      RESEARCHER = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PUBLIC", Value=40)]
      PUBLIC = 40
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"LoginRequestCode")]
    public enum LoginRequestCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN", Value=0)]
      LOGIN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CREATE", Value=1)]
      CREATE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHECK_USERNAME", Value=2)]
      CHECK_USERNAME = 2
    }
  
}