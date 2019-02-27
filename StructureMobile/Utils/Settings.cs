
// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace StructureMobile.Utils
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>





        //  creer une classe statique qui contien les parametres

  public static class Settings
{
        // Isettings pour acceder a l api
        private static ISettings AppSettings
    {
        get
        {
            return CrossSettings.Current;
        }
    }

    #region Setting Constants

        // Ajout d un settings necessite une clé et une valeur
        // clé une chaine pour definir le nom de la clé 

    private const string UserNameKey = "UserName_key";
    private static readonly string UserNameValue = string.Empty;

    private const string TokenKey = "Token_key";
    private static readonly string TokenValue = string.Empty;


    #endregion

        // getvalue pour extraire la valeur stocké
        // AddOrUpdateValue permet de conserver la valeur 
       public static string UserName
       {
            get
            {
                return AppSettings.GetValueOrDefault(UserNameKey, UserNameValue);
            }
            set
            {
                AppSettings.AddOrUpdateValue(UserNameKey, value);
        }
        }

        public static string AccesToken
        {
            get
            {
                return AppSettings.GetValueOrDefault(TokenKey, TokenValue);
            }
            set
            {
                AppSettings.AddOrUpdateValue(TokenKey, value);
            }
        }

    }
}
