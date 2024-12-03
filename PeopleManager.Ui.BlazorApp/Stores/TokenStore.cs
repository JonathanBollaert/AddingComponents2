using Blazored.LocalStorage;
using Vives.Presentation.Authentication;

namespace PeopleManager.Ui.BlazorApp.Stores
{
    public class TokenStore(ISyncLocalStorageService localStorageService) : IBearerTokenStore
    {
        private readonly ISyncLocalStorageService _localStorageService = localStorageService;

        private const string TokenName = "BearerToken";

        public string GetToken()
        {
            return _localStorageService.GetItemAsString(TokenName) ?? string.Empty;
        }

        public void SetToken(string token)
        {
            _localStorageService.SetItem(TokenName, token);
        }
    }
}
