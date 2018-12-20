namespace Automation.OnlinerSuite
{
    public static class ElementPaths
    {
        public static string loginButton = "//div[@class='auth-bar__item auth-bar__item--text']";
        public static string loginFieldName = "//input[@placeholder='Ник или e-mail']";
        public static string loginFieldPass = "//input[@placeholder='Пароль']";
        public static string loginButtonSubmit = "//div[@class='auth-form__control auth-form__control_condensed-additional']//button[@type = 'submit']";
        public static string searchBar = "//input[@class='fast-search__input']";
        public static string firstSearchResult = "//div[@class='result__item result__item_product']//div[@class='product__title']/a[1]";
    }
}