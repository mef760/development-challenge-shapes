using DevelopmentChallenge.Data.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevelopmentChallenge.Data.Utils
{   /// <summary>
    /// Clase utilitaria para localizacion de idiomas. 
    /// En caso de nuevo idioma agregar el loadTranslation correspondiente y el json en folder /Localization
    /// </summary>
    public static class L
    {
        private static readonly Dictionary<string, Dictionary<string, string>> _translations;
        private static string _lang = "en";

        static L()
        {
            _translations = new Dictionary<string, Dictionary<string, string>>();
            LoadTranslations("es");
            LoadTranslations("en");
            LoadTranslations("it");
            // nuevo idioma aqui
        }

        private static void LoadTranslations(string language)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Localization", $"{language}.json");
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var translations = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                _translations[language] = translations;
            }
        }

        public static void SetLang(Language lang) 
        {
            switch (lang)
            {
                case Language.Spanish:
                    _lang = "es";
                    break;
                case Language.Italian:
                    _lang = "it";
                    break;
                case Language.English:
                    _lang = "en";
                    break;
                // setear nuevo idioma aqui
            }
        }

        public static string Get(string key)
        {
            if (_translations.ContainsKey(_lang) && _translations[_lang].ContainsKey(key))
            {
                return _translations[_lang][key];
            }

            return key; // Si no hay traducción, devolver la clave.
        }
    }
}
