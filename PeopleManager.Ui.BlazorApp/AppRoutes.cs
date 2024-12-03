namespace PeopleManager.Ui.BlazorApp
{
    public static class AppRoutes
    {
        public static class Home
        {
            public const string Index = "/";
            public const string Details = "/details/{id:int}";

            public static string DetailsUrl(int id)
            {
                return Details.Replace("{id:int}", id.ToString());
            }
        }

        public static class Account
        {
            public const string SignIn = "/account/sign-in";
        }

        public static class People
        {
            private const string Base = "/people";

            public const string Index = $"{Base}";
            public const string Create = $"{Base}/create";
            public const string Edit = $"{Base}/edit/{{id:int}}";

            public static string EditUrl(int id)
            {
                return Edit.Replace("{id:int}", id.ToString());
            }
        }
    }
}
