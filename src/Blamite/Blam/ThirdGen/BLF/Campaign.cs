using System;
using System.Collections.Generic;
using System.IO;
using Blamite.IO;

namespace Blamite.Blam.ThirdGen.BLF
{
	public class Campaign : IDisposable
	{
		// Private Modifiers
		public enum GameIdentifier : uint
		{
			Halo3 = 0x13180001,
			Halo4 = 0x1AD80003
		}

		private CmpnInfo _campaign;
		private EndianStream _stream;
		private int languageCount = 12;
		private int mapIDcount = 64;

		public Campaign(string blfLocation)
		{
			Initalize(new FileStream(blfLocation, FileMode.OpenOrCreate));
		}

		public Campaign(Stream blfStream)
		{
			Initalize(blfStream);
		}

		public Stream Stream
		{
			get { return _stream.BaseStream; }
		}

		public CmpnInfo HaloCampaign
		{
			get { return _campaign; }
			set { _campaign = value; }
		}

		private void Initalize(Stream blfStream)
		{
			_stream = new EndianStream(blfStream, Endian.BigEndian);

			// Load Campaign shit
			LoadCampaign();
		}

		private void UpdateLanguageCount(GameIdentifier gameIdent)
		{
			switch (gameIdent)
			{
				case GameIdentifier.Halo3:
					languageCount = 12;
					break;
				case GameIdentifier.Halo4:
					languageCount = 17;
					break;
				default:
					throw new InvalidOperationException("The Campaign BLF file is from an unknown Halo Version");
			}
		}

		#region Loading Code

		public void LoadCampaign()
		{
			_campaign = new CmpnInfo();

			// Load Game Identification
			_stream.SeekTo(0x36);
			_campaign.Game = (GameIdentifier)_stream.ReadUInt32();
			UpdateLanguageCount(_campaign.Game);

			// Load Campaign Names
			LoadCampaignNames();

			// Load Campaign Descriptions
			LoadCampaignDescriptions();

			// Load Map IDs
			LoadMapIDs();

			// Load Unlock Bytes
			LoadUnlockBytes();
		}

		public void LoadCampaignNames()
		{
			_campaign.MapNames.Clear();

			const int baseOffset = 0x44;
			for (int i = 0; i < languageCount; i++)
			{
				_stream.SeekTo(baseOffset + (i*0x40));
				_campaign.MapNames.Add(_stream.ReadUTF16());
			}
		}

		public void LoadCampaignDescriptions()
		{
			_campaign.MapDescriptions.Clear();

			int baseOffset = _campaign.Game == GameIdentifier.Halo4 ? 0x8C4 : 0x644;
			for (int i = 0; i < languageCount; i++)
			{
				_stream.SeekTo(baseOffset + (i*0x100));
				_campaign.MapDescriptions.Add(_stream.ReadUTF16());
			}
		}

		public void LoadMapIDs()
		{
			int baseOffset = _campaign.Game == GameIdentifier.Halo4 ? 0x19C4 : 0x1244;
			for (int i = 0; i < mapIDcount; i++)
			{
				_stream.SeekTo(baseOffset + (i * 0x4));
				_campaign.MapIDs.Add(_stream.ReadInt32());
			}
		}

		public void LoadUnlockBytes()
		{
			if (_campaign.Game == GameIdentifier.Halo4)
			{
				const int baseOffset = 0x1AC4;
				for (int i = 0; i < mapIDcount; i++)
				{
					_stream.SeekTo(baseOffset + (i * 0x1));
					_campaign.UnlockBytes.Add(_stream.ReadByte());
				}
			}
		}

		#endregion

		#region Update Code

		public void UpdateCampaign()
		{
			// Update Map Names
			UpdateMapNames();

			// Update Map Descrptions
			UpdateMapDescriptions();

			// Update Map IDs
			UpdateMapIDs();

			// Update Unlock Bytes
			UpdateUnlockBytes();
		}

		public void UpdateMapNames()
		{
			const int baseOffset = 0x44;
			for (int i = 0; i < _campaign.MapNames.Count; i++)
			{
				int seekVal = baseOffset + (i*0x40);

				_stream.SeekTo(seekVal);
				_stream.WriteUTF16(_campaign.MapNames[i]);
			}
		}

		public void UpdateMapDescriptions()
		{
			int baseOffset = _campaign.Game == GameIdentifier.Halo4 ? 0x8C4 : 0x644;
			for (int i = 0; i < _campaign.MapDescriptions.Count; i++)
			{
				int seekVal = baseOffset + (i*0x100);

				_stream.SeekTo(seekVal);
				_stream.WriteUTF16(_campaign.MapDescriptions[i]);
			}
		}

		public void UpdateMapIDs()
		{
			int baseOffset = _campaign.Game == GameIdentifier.Halo4 ? 0x19C4 : 0x1244;
			for (int i = 0; i < _campaign.MapIDs.Count; i++)
			{
				int seekVal = baseOffset + (i * 0x4);
				_stream.SeekTo(seekVal);
				_stream.WriteInt32(_campaign.MapIDs[i]);
			}
		}

		public void UpdateUnlockBytes()
		{
			if (_campaign.Game == GameIdentifier.Halo4)
			{
				const int baseOffset = 0x1AC4;
				for (int i = 0; i < _campaign.MapIDs.Count; i++)
				{
					int seekVal = baseOffset + (i * 0x1);
					_stream.SeekTo(seekVal);
					_stream.WriteByte(_campaign.UnlockBytes[i]);
				}
			}
		}

		public void Dispose()
		{
			_stream.Dispose();
		}

		#endregion

		public class CmpnInfo
		{
			public GameIdentifier Game { get; set; }
			public IList<string> MapDescriptions = new List<string>();
			public IList<string> MapNames = new List<string>();
			public IList<int> MapIDs = new List<int>();
			public IList<byte> UnlockBytes = new List<byte>();
		}
	}
}
