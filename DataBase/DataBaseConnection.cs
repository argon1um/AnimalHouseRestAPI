using AHRestAPI.Models;

namespace AnimalHouseRestAPI.DataBase
{
    public class DataBaseConnection
    {
        public static Ah4cContext Context { get; set; } = new Ah4cContext();
    }
}
