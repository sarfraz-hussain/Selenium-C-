﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_CSharp
{
    class PageObjects_LogIn
    {

        public PageObjects_LogIn()
        {

            PageFactory.InitElements(propertiesCollection.driver, this);

        }


        #region Login Page - Web Elements

        //User Name
        [FindsBy(How = How.Id, Using = "txtUsername")]
        [CacheLookup]
        private IWebElement tbUserName { get; set; }

        //Password
        [FindsBy(How = How.Id, Using = "txtPassword")]
        [CacheLookup]
        private IWebElement tbPassword { get; set; }

        //Submit Button
        [FindsBy(How = How.Name, Using = "Submit")]
        [CacheLookup]
        private IWebElement btnSubmit { get; set; }


        public readonly string pageLoadedText = "";

        public readonly string pageUrl = "https://www.seleniumeasy.com/test/";

        #endregion

        #region Login Page - Page Actions

        public MainPage Login(string username, string password)
        {

            tbUserName.EnterText(username);
            tbPassword.EnterText(password);

            Console.WriteLine("UserName is:" + tbUserName.GetText());
            Console.WriteLine("Password is:" + tbPassword.GetText());
            Console.WriteLine("UserName is:" + tbUserName.ValidateIsPresent().ToString());
            Console.WriteLine("Password is:" + tbPassword.ValidateIsPresent().ToString());
            Console.WriteLine("Page URL Matches:" + propertiesCollection.driver.ValidatePageByUrl(this.pageUrl).ToString());


            btnSubmit.click();
            return new MainPage();

            //  SeleniumSetMethods.EnterText(tbUserName, username);
            //  SeleniumSetMethods.EnterText(tbPassword, password);
            //  SeleniumSetMethods.click(btnSubmit);
            //  return new PageObjects_MainPage();
        }

        public MainPage ValidatePageLoaded()
        {
                       
            Console.WriteLine("Page URL Matches:" + propertiesCollection.driver.ValidatePageByUrl(this.pageUrl).ToString());
            return new MainPage();

        }

        #endregion
    }
}