﻿namespace Rent_UI3.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
