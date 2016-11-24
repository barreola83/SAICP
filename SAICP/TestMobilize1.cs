#region
using System.Diagnostics;
using Mobilize.Testing.WebMap.Base;
using NUnit.Framework;
using OpenQA.Selenium;
#endregion

//Please modify the namespace//
namespace SAICP //Mobilize.QA.Kendo. or Mobilize.QA.Angular.
{
    [TestFixture]
    //Modify it using this format: <ControlProperty> ie: LabelText
    public class TestMobilize1 : WebMapUnitTestBase
    {
        public TestMobilize1()
        {
            var path = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            Config(path);
            AlreadyPublished = false;
        }

        /// <summary>
        /// Scenario description: ?
        /// Acceptance criteria: ?
        /// </summary>

        [Test, Category("NewScript")] //KendoUI or AngularJS
        //Modify it using this format: <Control_Property> ie: Label_Text
        public void Control_Property()
        {
            _driver.Navigate().GoToUrl(BaseUrl);
            EnableBrowserPerformanceLogging();

            //Your script begins here.
        }

        public override string GetOutputDir()
        {
            return outputPath;
        }

    }
}
