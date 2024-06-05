using System;
using System.Collections.Generic;

namespace AHRestAPI.Models;

public partial class Orderedservice
{
    public int NoteId { get; set; }

    public int OrderId { get; set; }

    public sbyte Booking { get; set; }

    public sbyte Bookingplus { get; set; }

    public sbyte Medicine { get; set; }

    public sbyte Photosession { get; set; }

    public virtual Order Order { get; set; } = null!;
}
