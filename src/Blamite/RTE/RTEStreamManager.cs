using Blamite.Blam;
using Blamite.IO;

namespace Blamite.RTE
{
	/// <summary>
	///     An implementation of IStreamManager which returns streams opened from an IRTEProvider.
	/// </summary>
	public class RTEStreamManager : IStreamManager
	{
		private readonly ICacheFile _cacheFile;
		private readonly IRTEProvider _provider;

		public RTEStreamManager(IRTEProvider provider, ICacheFile cacheFile)
		{
			_provider = provider;
			_cacheFile = cacheFile;
		}

		public IReader OpenRead()
		{
			return _provider.GetMetaStream(_cacheFile);
		}

		public IWriter OpenWrite()
		{
			return _provider.GetMetaStream(_cacheFile);
		}

		public IStream OpenReadWrite()
		{
			return _provider.GetMetaStream(_cacheFile);
		}
	}
}