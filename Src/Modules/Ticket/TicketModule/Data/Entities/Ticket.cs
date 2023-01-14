﻿using Common.Domain;
using System.ComponentModel.DataAnnotations;

namespace TicketModule.Data.Entities;

class Ticket : BaseAggregateRoot
{
    public Guid UserId { get; set; }
    [MaxLength(100)]
    public string OwnerFullName { get; set; }

    [MaxLength(11)]
    public string PhoneNumber { get; set; }

    [MaxLength(100)]
    public string Title { get; set; }
    public string Text { get; set; }
    public TicketStatus TicketStatus { get; set; }

    public List<TicketMessage> Messages { get; set; }
}


public enum TicketStatus
{
    Pending,
    Answered,
    Closed
}

class TicketMessage : BaseAggregateRoot
{
    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }

    [MaxLength(100)]
    public string UserFullName { get; set; }
    public string Text { get; set; }


    public Ticket Ticket { get; set; }
}