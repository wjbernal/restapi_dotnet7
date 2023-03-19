using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    /*  
        We are going to store in memory,
        but over here we actually do id use some respository 
        or entity framework to store to store in the database
    */
    private static readonly Dictionary<Guid, Breakfast> _breakfast = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfast.Add(breakfast.id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfast[id];
    }

    void IBreakfastService.DeleteBreakfast(Guid id)
    {
        _breakfast.Remove(id);
    }

    void IBreakfastService.UpsertBreakfast(Breakfast breakfast)
    {
        //add it to the dictionary. If exists update
        _breakfast[breakfast.id] = breakfast;
    }
}
