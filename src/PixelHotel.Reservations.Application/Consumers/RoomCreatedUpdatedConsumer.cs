﻿using MassTransit;
using PixelHotel.Core.Abstractions;
using PixelHotel.Core.Events;
using PixelHotel.Events.Rooms;

namespace PixelHotel.Reservations.Application.Consumers;

public class RoomCreatedUpdatedConsumer : ConsumerBase<RoomCreatedOrUpdatedEvent>
{
    private readonly ILoggerService _loggerService;

    public RoomCreatedUpdatedConsumer(ILoggerService loggerService) =>
        _loggerService = loggerService;

    public override async Task Consume(ConsumeContext<RoomCreatedOrUpdatedEvent> context)
    {
        _loggerService.Information("RoomCreatedUpdatedConsumer", context.Message.AggregateId.ToString(), context.Message.TranceId);

        await Task.CompletedTask;
    }
}
