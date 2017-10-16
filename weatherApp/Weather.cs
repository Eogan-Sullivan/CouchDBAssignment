using System;

public class Weather
{
    private string town;
    private double temp;
    private double percip;
	public Weather()
	{
       town = "";
       temp = 0.0;
       percip = 0.0;
	}

    public Weather(string town,double temp,double percip)
    {
        this.town = town;
        this.temp = temp;
        this.percip = percip;
    }

    public string Town { get => town; set => town = value; }
    public double Percip { get => percip; set => percip = value; }
    public double Temp { get => temp; set => temp = value; }

  
}
