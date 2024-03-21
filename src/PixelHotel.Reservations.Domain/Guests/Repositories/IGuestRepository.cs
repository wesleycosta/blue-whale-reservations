﻿using PixelHotel.Core.Abstractions;
using PixelHotel.Reservations.Business.Guests.Aggregates;

namespace PixelHotel.Reservations.Business.Guests.Abstractions;

public interface IGuestRepository : IRepositoryBase<Guest>
{
}
