using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

class Program
{
    static void Main(string[] args)
    {
        //Tutorial seguido
        //https://www.youtube.com/watch?v=4I4qdmC6kFc
        
        IWebDriver driver = new FirefoxDriver(@"C:\Users\ffgal\OneDrive\Documentos\C#\scraped\bin\Debug\net5.0\");
        driver.Url = "http://localhost/";

        // IWebElement textbox = driver.FindElement(By.Name("q"));
        // textbox.SendKeys("GalRod Arte en Resina");
        
        //textbox.Submit();
        driver.Quit();
    }
}