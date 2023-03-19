namespace BuberBreakfast.Models;

public class Breakfast
{    
    // we delete the "set;" because we don't want anyone assigning those values directly
    // but using a constructor
    // so No one can change the Id after it was set
    public Guid id {get;}
    public string Name {get;}
    public string Description {get;}
    public DateTime StartDateTime {get;}
    public DateTime EndDateTime {get;}
    public DateTime LastModifiedDateTime {get;}
    public List<string> Savory {get;}
    public List<string> Sweet {get;}

    public Breakfast(Guid id,
                     string name,
                     string description,
                     DateTime startDateTime,
                     DateTime endDateTime,
                     DateTime lastModifiedDateTime,
                     List<string> savory,
                     List<string> sweet)
    {
        // Here we can enforce invariants
        // for example the name and description Can't be shorter than 3...
        this.id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savory = savory;
        Sweet = sweet;
    }
}