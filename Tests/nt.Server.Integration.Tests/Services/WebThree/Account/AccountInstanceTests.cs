﻿namespace nt.Server.Integration.Tests.Services.WebThree.Account
{
  using Shouldly;
  using nt.Shared.Constants.AccountAddresses;
  class AccountInstanceTests
  {
    readonly TestEthAccounts tester = new TestEthAccounts();

    public void AcctInstanceTests() => tester.TesterAcct.ShouldNotBe(null);
  }
}
