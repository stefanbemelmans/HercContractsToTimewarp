﻿namespace nt.Shared.Features.WebThree.Contracts.NftCreator.GetNftByType
{
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;

  [Function(name: "getNFTData")] // This works
  public class GetNftByTypeFunctionDef : FunctionMessage
  {
    [Parameter(type: "uint", name:"id", order: 1)]
    public int NftId { get; set; }
  }
}
