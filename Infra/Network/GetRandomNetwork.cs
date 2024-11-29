using Nc.Helpers.Extensions;
using Nc.Helpers.Methods;
using System.Text.RegularExpressions;

namespace Nc.Infra.Network;

public static class GetRandomNetwork {
    public static string IpAddress => $"{GetRandom.UInt8()}.{GetRandom.UInt8()}.{GetRandom.UInt8()}.{GetRandom.UInt8()}";
    public static string HardwareVersion => $"{GetRandom.UInt16()}.{GetRandom.UInt16()}";
    public static string Location => capitalCities.Random();
    public static string ConnectorType => Type.Random();
    public static string Material => Materials.Random();
    public static string Latitude => $"{GetRandom.UInt8(0, 90)}\u00b0 {GetRandom.UInt8(0,60)}' {GetRandom.UInt8(0,60)}\" {(GetRandom.Bool() ? "N" : "S")}";
    public static string Longitude => $"{GetRandom.UInt8(0, 180)}\u00b0 {GetRandom.UInt8(0,60)}' {GetRandom.UInt8(0,60)}\" {(GetRandom.Bool() ? "E" : "W")}";
    public static string GenerateValueText(Type type, int index, string? valueType = null) {
        var className = type.Name.Replace("DbInitializer", "");
        var splitClassName = Regex.Replace(className, "(\\B[A-Z])", " $1");
        return $"{splitClassName} {index} {valueType}";
    }

    public static string GenerateSerialNum() {
        var year = GetRandom.UInt8(0,99);
        var prefix = GetRandom.String(3,3).ToUpper();
        var weekNumber = GetRandom.UInt8(0, 52);
        var uniqueIdentifier = $"{GetRandom.UInt8(10, 99)}{GetRandom.String(2, 2).ToUpper()}";
        return $"{prefix}{year}{weekNumber}{uniqueIdentifier}";
    }

    private static readonly List<string> capitalCities = [
        "Tirana", "Andorra la Vella", "Yerevan", "Vienna", "Baku", "Minsk", "Brussels", "Sarajevo", "Sofia", "Zagreb",
        "Nicosia", "Prague", "Copenhagen", "Tallinn", "Helsinki", "Paris", "Tbilisi", "Berlin", "Athens", "Budapest",
        "Reykjavik", "Dublin", "Rome", "Astana", "Pristina", "Riga", "Vaduz", "Vilnius", "Luxembourg", "Valletta",
        "Chisinau", "Monaco", "Podgorica", "Amsterdam", "Skopje", "Oslo", "Warsaw", "Lisbon", "Bucharest", "Moscow",
        "San Marino", "Belgrade", "Bratislava", "Ljubljana", "Madrid", "Stockholm", "Bern", "Ankara", "Kyiv", "London",
        "Vatican City", "Canberra", "Ottawa", "Beijing", "Tokyo", "New Delhi", "Jakarta", "Abuja", "Cairo", "Pretoria", "Riyadh",
        "Tehran", "Islamabad", "Baghdad", "Jerusalem", "Bangkok", "Kuala Lumpur", "Manila", "Seoul", "Hanoi", "Wellington"
    ];

    private static readonly List<string> Type = ["C", "MHV", "SHV", "BNC", "UHF", "Other"];
    private static readonly List<string> Materials = ["Steel", "Aluminium", "Concrete", "Wood", "Stainless Steel", "Other"];
}
