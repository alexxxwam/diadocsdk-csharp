//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ResolutionAction.proto
namespace Diadoc.Api.Proto
{
    [global::ProtoBuf.ProtoContract(Name=@"ResolutionAction")]
    public enum ResolutionAction
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownAction", Value=0)]
      UnknownAction = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ApproveAction", Value=1)]
      ApproveAction = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DisapproveAction", Value=2)]
      DisapproveAction = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SignWithApprovementSignature", Value=3)]
      SignWithApprovementSignature = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SignWithPrimarySignature", Value=4)]
      SignWithPrimarySignature = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DenySignatureRequest", Value=5)]
      DenySignatureRequest = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RejectSigning", Value=6)]
      RejectSigning = 6
    }
  
}