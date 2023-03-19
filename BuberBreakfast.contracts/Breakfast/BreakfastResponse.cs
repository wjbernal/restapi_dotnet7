using System;
using System.Collections.Generic;

namespace BuberBreakfast.contracts.Breakfast;

public record BreakfastResponse(
    Guid id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime lastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);