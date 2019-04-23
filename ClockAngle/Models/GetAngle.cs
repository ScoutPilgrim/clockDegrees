using System;

namespace ClockAngle
{
  public class GetAngle
  {
    private string MyTime = "";
    private string MyHour = "";
    private string MyMinute = "";
    private int HourDegree = 0;
    private int MinuteDegree = 0;

    public GetAngle(string myTime)
    {
      MyTime = myTime;
    }
    public GetAngle()
    {

    }
    public void SplitTime()
    {
      string[] splitString = MyTime.Split(":");
      MyHour = splitString[0];
      MyMinute = splitString[1];
    }
    public void GenerateDegrees()
    {
      int hourTime = int.Parse(MyHour);
      int minTime = int.Parse(MyMinute);
      HourDegree = hourTime * 30;
      MinuteDegree = (minTime/5) * 30;
    }
    public int DegreeDifference()
    {
      if(HourDegree == MinuteDegree){
        return 0;
      }else if(HourDegree > MinuteDegree){
        return HourDegree - MinuteDegree;
      }else{
        return MinuteDegree - HourDegree;
      }
    }
    public string GetMyHour()
    {
      return MyHour;
    }
    public void SetMyHour(string myHour)
    {
      MyHour = myHour;
    }
    public string GetMyMinute()
    {
      return MyMinute;
    }
    public void SetMyMinute(string myMinute)
    {
      MyMinute = myMinute;
    }
    public string GetMyTime()
    {
      return MyTime;
    }
    public void SetMyTime(string myTime)
    {
      MyTime = myTime;
    }
    public int GetHourDegree()
    {
      return HourDegree;
    }
    public void SetHourDegree(int hourDegree)
    {
      HourDegree = hourDegree;
    }
    public int GetMinuteDegree()
    {
      return MinuteDegree;
    }
    public void SetMinuteDegree(int minuteDegree)
    {
      MinuteDegree = minuteDegree;
    }
  }
}
