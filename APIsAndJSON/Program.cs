namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var temp = OpenWeatherMapAPI.CurrTemp();
            var desc = OpenWeatherMapAPI.CurrDescription();

            RonVSKanyeAPI.RonKanyeConvo(desc, temp);
        }
    }
}
