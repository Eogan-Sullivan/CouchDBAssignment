
using System;
public class Weather
{
   private string _id;
    private string _rev;
    private string skies;
    private double temp;
    private double percip;
    public Weather()
    {
        _rev = "";
        _id = "";
        temp = 0.0;
        percip = 0.0;
    }

    public Weather(string _id, double temp, double percip,string skies)
    {
        this._id = _id;
        this.temp = temp;
        this.percip = percip;
        this.skies = skies;
    }
    public double Percip { get => percip; set => percip = value; }
    public double Temp { get => temp; set => temp = value; }
    public string Skies { get => skies; set => skies = value; }
    public string Id { get => _id; set => _id = value; }
    public string Rev { get => _rev; set => _rev = value; }
}
