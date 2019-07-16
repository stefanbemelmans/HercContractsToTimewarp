﻿namespace nt.Client.Features.Application.Components
{
  using nt.Client.Features.Base.Components;

  public class AccountMenuModel : BaseComponent
  {
    protected void ButtonClick() => Show = !Show;
    protected bool Show { get; set; }
    protected string ShowCssClass => Show ? "show" : null;
  }
}
