﻿using Gangster.ApiModel.Common;

namespace Gangster.ApiModel.Gangster;

public class Gangster : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DOB { get; set; }
}
