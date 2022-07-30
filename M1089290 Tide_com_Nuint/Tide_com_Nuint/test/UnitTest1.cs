using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.PageOMethod;
namespace Tide_com_Nuint
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            method.InitializeDriver();
        }
        [Test]
        public void SearchBartest()
        {
            SearchBar.NavigateURL();
            SearchBar.ClickOnSearchBar();
            SearchBar.EnterDataInSearchBar();
            SearchBar.TakeSshottest();
        }
        [Test]
        public void LiveChattest()
        {
            LiveChat.NavigateURL();
            LiveChat.ClickOnLiveChat();
            LiveChat.ScrollToLiveChat();
            LiveChat.TakeSshottest();
        }
        [Test]
        public void Selectloctiontest()
        {
            Selectloction.NavigateURL();
            Selectloction.ClickOnbutton();
            Selectloction.SelectLanguage();
            Selectloction.TakeSshottest();
        }
        [Test]
        public void ContactUstest()
        {
            ContactUs.NavigateURL();
            ContactUs.ClickOnButton();
            ContactUs.TakeSshottest();
        }
        [Test]
        public void ShopProductstest()
        {
            ShopProducts.NavigateURL();
            ShopProducts.ClickOnButton();
            ShopProducts.SelectProducts();
            ShopProducts.ClickOnFindRetailers();
            ShopProducts.TakeSshottest();
        }
        [Test]
        public void What_sNewtest()
        {
            What_sNew.NavigateURL();
            What_sNew.ClickOnWhat_sNewButton();
            What_sNew.ClickOnLatestArticles();
            What_sNew.TakeSshottest();
        }
        [Test]
        public void HowtoWashClothestest()
        {
            HowtoWashClothes.NavigateURL();
            HowtoWashClothes.ClickOnButton();
            HowtoWashClothes.TakeSshottest();
        }
        [Test]
        public void OurCommitmenttest()
        {
            OurCommitment.NavigateURL();
            OurCommitment.ClickOnButton();         
            OurCommitment.ScrollToElement();
            OurCommitment.ClickOnElement();
            OurCommitment.TakeSshottest();
        }

    }
}