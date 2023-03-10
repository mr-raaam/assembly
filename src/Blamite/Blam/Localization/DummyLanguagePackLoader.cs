using System.Collections.Generic;
using System.Linq;
using Blamite.IO;

namespace Blamite.Blam.Localization
{
	/// <summary>
	///     Dummy implementation of <see cref="ILanguagePackLoader" /> which claims no languages are available.
	/// </summary>
	public class DummyLanguagePackLoader : ILanguagePackLoader
	{
		/// <summary>
		/// Gets the set of available languages.
		/// </summary>
		public IEnumerable<GameLanguage> AvailableLanguages
		{
			get { return Enumerable.Empty<GameLanguage>(); }
		}

		/// <summary>
		/// Loads the language pack for a language.
		/// </summary>
		/// <param name="language">The language of the pack to load.</param>
		/// <param name="reader">The stream to read from.</param>
		/// <returns>
		/// The language pack that was loaded, or <c>null</c> if no pack exists for the language.
		/// </returns>
		public LanguagePack LoadLanguage(GameLanguage language, IReader reader)
		{
			return null;
		}

		/// <summary>
		/// Saves the language pack for a language.
		/// </summary>
		/// <param name="pack">The pack to save.</param>
		/// <param name="stream">The stream to write to.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void SaveLanguage(LanguagePack pack, IStream stream)
		{
		}
	}
}