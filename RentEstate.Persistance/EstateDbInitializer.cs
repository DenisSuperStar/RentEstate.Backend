
using RentEstate.Persistance;

namespace Notes.Persistance
{
    public class EstateDbInitializer
    {
        public static void Initialize(EstateDbContext context) {
            context.Database.EnsureCreated();
        }
    }
}
