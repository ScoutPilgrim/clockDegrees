using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngle.TestTools
{
  [TestClass]
  public class ClockAngleTest
  {
    [TestMethod]
    public void Constructor_Test()
    {
      string testTime = "6:30";
      GetAngle testGetAngle = new GetAngle(testTime);
      Assert.AreEqual(testTime, testGetAngle.GetMyTime());
    }
    [TestMethod]
    public void GetterSetter_TestAll()
    {
      GetAngle testGetAngle = new GetAngle();
      testGetAngle.SetMyTime("7:30");
      testGetAngle.SetMyHour("7");
      testGetAngle.SetMyMinute("30");
      testGetAngle.SetHourDegree(210);
      testGetAngle.SetMinuteDegree(180);
      Assert.AreEqual("7:30", testGetAngle.GetMyTime());
      Assert.AreEqual("7", testGetAngle.GetMyHour());
      Assert.AreEqual("30", testGetAngle.GetMyMinute());
      Assert.AreEqual(210, testGetAngle.GetHourDegree());
      Assert.AreEqual(180, testGetAngle.GetMinuteDegree());
    }
    [TestMethod]
    public void SplitTime_Test()
    {
      GetAngle testGetAngle = new GetAngle("6:30");
      testGetAngle.SplitTime();
      Assert.AreEqual("6", testGetAngle.GetMyHour());
      Assert.AreEqual("30", testGetAngle.GetMyMinute());
    }
    [TestMethod]
    public void GenerateDegrees_Test()
    {
      GetAngle testGetAngle = new GetAngle();
      testGetAngle.SetMyHour("7");
      testGetAngle.SetMyMinute("30");
      testGetAngle.GenerateDegrees();
      Assert.AreEqual(210, testGetAngle.GetHourDegree());
      Assert.AreEqual(180, testGetAngle.GetMinuteDegree());
    }
    [TestMethod]
    public void DegreeDifference_Test_HourSmaller()
    {
      GetAngle testGetAngle = new GetAngle();
      testGetAngle.SetHourDegree(180);
      testGetAngle.SetMinuteDegree(210);
      Assert.AreEqual(30, testGetAngle.DegreeDifference());
    }
    [TestMethod]
    public void DegreeDifference_Test_HourBigger()
    {
      GetAngle testGetAngle = new GetAngle();
      testGetAngle.SetHourDegree(210);
      testGetAngle.SetMinuteDegree(180);
      Assert.AreEqual(30, testGetAngle.DegreeDifference());
    }
    [TestMethod]
    public void DegreeDifference_Test_HourEqual()
    {
      GetAngle testGetAngle = new GetAngle();
      testGetAngle.SetHourDegree(180);
      testGetAngle.SetMinuteDegree(180);
      Assert.AreEqual(0, testGetAngle.DegreeDifference());
    }
  }
}
