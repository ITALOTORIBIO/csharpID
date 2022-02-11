using OpenQA.Selenium;
using pidgeotto.Interfaces.Pages;
using pidgeotto.Interfaces.WebActions;
using pidgeotto.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace pidgeotto.Pages
{
    public class LoginPage : WebPage, ILoginPage
    {
        public LoginPage(ISeleniumUtils seleniumUtils) : base(seleniumUtils)
        {

        }

        private string email_user = "march.pkitest@gmail.com";
        private string pass_user = "snb123$";

        //WebElements

        private By tB_emailUser = By.XPath("//input[@name='username']");
        private By xP_title = By.XPath("//title");
        private By span_button = By.XPath("//span[@class='uk-margin-left uk-margin-right']");
        private By tB_passUser = By.XPath("//input[@name='password']");

        private By b_Login = By.XPath("//button");

        private By txt_Error = By.XPath("//div[@class='uk-alert-danger uk-alert']");

        //Methods

        public LoginPage goLoginPage()
        {
            _seleniumUtils.navigateToUrl(Resource1.url);
            return new LoginPage(_seleniumUtils);
        }

        public void validationofButton()
        {
            string txt_Button = _seleniumUtils.getText(b_Login);
            string title = "SIGN IN";
            Xunit.Assert.Equal(title, txt_Button);
        }

        public LoginPage insertData()
        {
            _seleniumUtils.setText(tB_emailUser, email_user);
            _seleniumUtils.setText(tB_passUser, pass_user);
            _seleniumUtils.click(b_Login);
            return new LoginPage(_seleniumUtils);
        }
    }
}
