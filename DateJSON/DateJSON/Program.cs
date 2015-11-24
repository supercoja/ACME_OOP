using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace DateJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("*** Dates Demo in JSON ***");
            var _people = new People("Baggins", new DateTime(2015, 11, 16));

            Console.WriteLine(" Serialize Object without specifying any date format (default)");
            string _dateDefault = JsonConvert.SerializeObject(_people, Formatting.Indented);
            Console.WriteLine(_dateDefault);

            Console.WriteLine("Serialize Object Specifying Microsoft Date - Default Pre .NET 4.5");
            var _settingsMicrosoftDateType = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            string _dateMicrosoftOldDefault = JsonConvert.SerializeObject(_people, Formatting.Indented, _settingsMicrosoftDateType);
            Console.WriteLine(_dateMicrosoftOldDefault);

            Console.WriteLine("Serialize Object Specifying Iso 8601 Date");
            var _dateIso8601 = JsonConvert.SerializeObject(_people,Formatting.Indented, new IsoDateTimeConverter());
            Console.WriteLine(_dateIso8601);

            var _deSerializeObject = JsonConvert.DeserializeObject(_dateIso8601);
            Console.WriteLine(_deSerializeObject);

            Console.WriteLine("Serialize Object Specifying Custom Date Format");
            var _settingCustomFormat = new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy"
            };
            string _dateCustom = JsonConvert.SerializeObject(_people, Formatting.Indented, _settingCustomFormat);
            Console.WriteLine(_dateCustom);

            Console.WriteLine("Serialize Object Specifying Javascript DateTime Converter");
            var _dateJS = JsonConvert.SerializeObject(_people, Formatting.Indented, new JavaScriptDateTimeConverter());
            Console.WriteLine(_dateJS);

        }
    }
}
