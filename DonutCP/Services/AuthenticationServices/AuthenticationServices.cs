﻿using DonutCP.Model;
using System;
using System.Threading.Tasks;

namespace DonutCP.Services.AuthenticationServices
{
    class AuthenticationServices : IAuthenticationServices
    {
        //private readonly IAuthenticationService _authenticationService;
        //private readonly IAccountStore _accountStore;

        //public AuthenticationServices(IAuthenticationService authenticationService, IAccountStore accountStore)
        //{
        //    _authenticationService = authenticationService;
        //    _accountStore = accountStore;
        //}

        //public Account CurrentAccount
        //{
        //    get
        //    {
        //        return _accountStore.CurrentAccount;
        //    }
        //    private set
        //    {
        //        _accountStore.CurrentAccount = value;
        //        StateChanged?.Invoke();
        //    }
        //}

        //public bool IsLoggedIn => CurrentAccount != null;

        //public event Action StateChanged;

        //public async Task Login(string username, string password)
        //{
        //    CurrentAccount = await _authenticationService.Login(username, password);
        //}

        //public void Logout()
        //{
        //    CurrentAccount = null;
        //}

        //public async Task<RegistrationResult> Register(string email, string username, string password)
        //{
        //    return await _authenticationService.Register(email, username, password);
        //}
    }
}
