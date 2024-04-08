﻿using Microsoft.Extensions.DependencyInjection;
using PixelHotel.Core.Abstractions;

namespace PixelHotel.Reservations.Infra.Data;

public class DataModule : IModuleRegister
{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {
        return services;
    }
}
