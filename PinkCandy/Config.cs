using Exiled.API.Interfaces;
namespace PinkCandy
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
        public int Chance { get; set; } = 15;
    }
}


