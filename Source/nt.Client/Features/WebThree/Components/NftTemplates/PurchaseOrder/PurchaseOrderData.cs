﻿namespace nt.Client.Features.WebThree.Components.NftTemplates.PurchaseOrder
{
  using Microsoft.AspNetCore.Components;
  using System;
  using System.Collections.Generic;

  public class PurchaseOrderData : ImmutableObjectBase
  {
    public List<string> PoFormValueNames = new List<string>()
    {
      "Approver",
      "DeliveryDate",
      "Department",
      "Notes",
      "Requester",
      "Item_Code",
      "Item_Discount",
      "Item_Name",
      "Item_Price",
      "Item_Qty",
      "Item_Total",
    };

    [Parameter]
    public string Approver { get; set; }

    [Parameter]
    public DateTime DeliveryDate { get; set; } = DateTime.Now;

    [Parameter]
    public string Department { get; set; }

    [Parameter]
    public string Item_Code { get; set; }

    [Parameter]
    public int Item_Discount { get; set; }

    [Parameter]
    public string Item_Name { get; set; }

    [Parameter]
    public string Item_Price { get; set; }

    [Parameter]
    public int Item_Qty { get; set; }

    [Parameter]
    public int Item_Total { get; set; }

    [Parameter]
    public string Notes { get; set; }

    [Parameter]
    public string Requester { get; set; }
  }
}