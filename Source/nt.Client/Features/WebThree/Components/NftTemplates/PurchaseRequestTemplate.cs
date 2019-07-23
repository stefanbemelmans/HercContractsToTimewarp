﻿namespace nt.Client.Features.WebThree.Components.NftTemplates
{
  using System.Collections.Generic;

  public class PurchaseRequestTemplate : TemplateForm
  {
    public PurchaseRequestTemplate()
    {
      NftId = 4;
      TemplateFormName = "Purchase Request";

      ItemFormData = new Dictionary<string, string>()
      {
        {"StockNumber", ""},
        {"Description", "" },
        {"Qty", "" },
        {"UnitPrice", "" },
        {"ExtendedCost", "" }

      };

      TemplateFormData = new Dictionary<string, string>()
      {
        {"Date", "" },
        {"Requester", "" },
        {"Department", "" },
        {"ChargeTo", "" },
        {"Vendor", "" },
        {"VendorAddress", "" },
        {"VendorContact", "" },
        {"Phone", "" },
        {"DateNeeded", "" },
        {"ShipVia", "" }
      };
    }
  }
}