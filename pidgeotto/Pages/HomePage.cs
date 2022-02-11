using OpenQA.Selenium;
using pidgeotto.Interfaces.Pages;
using pidgeotto.Interfaces.WebActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Pages
{
    public class HomePage : WebPage, IHomePage
    {
        public HomePage(ISeleniumUtils seleniumUtils) : base(seleniumUtils)
        {
        }


        //WebElements

        private By notebook_select = By.XPath("//a[@id='new-journal']");
        private By tB_nameNB = By.XPath("//input[@id='name-input']");
        private By tB_descriptionNB = By.XPath("//input[@id='description-input']");

        private By b_Add = By.XPath("//button[@id='create-btn']");
        private By b_Create = By.XPath("//button[@id='create-dropdown']");

        //Methods

        public HomePage createNB()
        {
            _seleniumUtils.click(b_Create);
            _seleniumUtils.click(notebook_select);
            _seleniumUtils.setText(tB_nameNB, "Libro_Toribio");
            _seleniumUtils.setText(tB_descriptionNB, "Tiene 20 años");
            _seleniumUtils.click(b_Add);
            return new HomePage(_seleniumUtils);
        }

    }
}
