﻿using Newtonsoft.Json;
using System.Collections.Generic;

public class Coord
{
    public float Lon { get; set; }
    public float Lat { get; set; }
}

public class WeatherDetail
{
    public int Id { get; set; }
    public string Main { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}

public class MainWeather
{
    public float Temp { get; set; }
    public float Feels_like { get; set; }
    public float Temp_min { get; set; }
    public float Temp_max { get; set; }
    public int Pressure { get; set; }
    public int Humidity { get; set; }
    public int Sea_level { get; set; }
    public int Grnd_level { get; set; }
}

public class Wind
{
    public float Speed { get; set; }
    public int Deg { get; set; }
}

public class Clouds
{
    public int All { get; set; }
}

public class Sys
{
    public int Type { get; set; }
    public int Id { get; set; }
    public string Country { get; set; }
    public int Sunrise { get; set; }
    public int Sunset { get; set; }
}

public class Weather
{
    [JsonProperty("weather")]
    public List<WeatherDetail> WeatherDetails { get; set; }  // Maps "weather" JSON key to WeatherDetails

    public Coord Coord { get; set; }
    public string Base { get; set; }
    public MainWeather Main { get; set; }
    public int Visibility { get; set; }
    public Wind Wind { get; set; }
    public Clouds Clouds { get; set; }
    public int Dt { get; set; }
    public Sys Sys { get; set; }
    public int Timezone { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Cod { get; set; }
}
