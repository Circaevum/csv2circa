[System.Serializable]

public class SchoolData
{
    public string Time { get; set; }
    public int Day { get; set; }
    public bool Occupied { get; set; }
    public bool SchoolDay { get; set; }
    public int Hour { get; set; }
    public int LessonNumber { get; set; }
    public double LessonPct { get; set; }
    public double IndoorTemperature { get; set; }
    public double IndoorHumidity { get; set; }
    public double IndoorCO2 { get; set; }
    public double IndoorNoise { get; set; }
    public double OutdoorTemperature { get; set; }
    public double OutdoorHumidity { get; set; }
    public double OutdoorDewpoint { get; set; }
    public double OutdoorWindDirection { get; set; }
    public double OutdoorWindSpeed { get; set; }
    public double OutdoorGustSpeed { get; set; }
    public double Precipitation { get; set; }
    public double UvLevel { get; set; }
    public double SolarRadiation { get; set; }
    public bool CoolingState { get; set; }
    public bool HeatingState { get; set; }
    public bool UsabilityMask { get; set; }
}