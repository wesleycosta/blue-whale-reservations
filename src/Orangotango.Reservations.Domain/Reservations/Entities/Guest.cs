﻿using MassTransit.SagaStateMachine;

namespace Orangotango.Reservations.Domain.Reservations.Entities;

public sealed class Guest
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public Guest(string name,
        string email)
    {
        Name = name;
        Email = email;
    }
}
