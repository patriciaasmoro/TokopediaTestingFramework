using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TokopediaTestingFramework.Configuration;

namespace TokopediaTestingFramework
{
    internal static class Browser
    {
        public static IWebDriver chromeDriver { get; set; }

        /// <summary>
        /// To go to the initial url 
        /// </summary>
        internal static void Initialize()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Url = Constants.Url.baseUrl;
        }
        
        /// <summary>
        /// Close the driver when finished testing 
        /// </summary>
        internal static void Close()
        {
            chromeDriver.Close();
        }
    }
}