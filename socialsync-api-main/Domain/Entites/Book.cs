using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entites;

public class Book: BaseDomainEntity
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseYear { get; set; }
}


