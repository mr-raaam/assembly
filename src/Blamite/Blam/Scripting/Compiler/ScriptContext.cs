namespace Blamite.Blam.Scripting.Compiler
{
	/// <summary>
	///     Contains script objects which scripts can reference by name.
	/// </summary>
	public class ScriptContext
	{
		/// <summary>
		///     Gets or sets available object references.
		/// </summary>
		/// <value>Available object references.</value>
		public ScriptObject[] ObjectReferences { get; set; }

		/// <summary>
		///     Gets or sets available trigger volumes.
		/// </summary>
		/// <value>Available trigger volumes.</value>
		public ScriptObject[] TriggerVolumes { get; set; }

		/// <summary>
		///     Gets or sets available cutscene flags.
		/// </summary>
		/// <value>Available cutscene flags.</value>
		public ScriptObject[] CutsceneFlags { get; set; }

		/// <summary>
		///     Gets or sets available cutscene camera points.
		/// </summary>
		/// <value>Available cutscene camera points.</value>
		public ScriptObject[] CutsceneCameraPoints { get; set; }

		/// <summary>
		///     Gets or sets available cutscene titles.
		/// </summary>
		/// <value>Available cutscene titles.</value>
		public ScriptObject[] CutsceneTitles { get; set; }

		/// <summary>
		///     Gets or sets available device groups.
		/// </summary>
		/// <value>Available device groups.</value>
		public ScriptObject[] DeviceGroups { get; set; }

		/// <summary>
		///     Gets or sets available AI squad groups.
		/// </summary>
		/// <value>Available AI squad groups.</value>
		public ScriptObject[] AISquadGroups { get; set; }

		/// <summary>
		///     Gets or sets available AI squads.
		/// </summary>
		/// <value>Available AI squads.</value>
		public ScriptObject[] AISquads { get; set; }

		/// <summary>
		///     Gets or sets the block to read AI squad single locations from.
		/// </summary>
		/// <value>The block to read AI squad single locations from.</value>
		public ScriptObjectTagBlock AISquadSingleLocations { get; set; }

		/// <summary>
		///     Gets or sets the block to read AI squad group locations from.
		/// </summary>
		/// <value>The block to read AI squad group locations from.</value>
		public ScriptObjectTagBlock AISquadGroupLocations { get; set; }

		/// <summary>
		///     Gets or sets available AI objectives.
		/// </summary>
		/// <value>Available AI objects.</value>
		public ScriptObject[] AIObjects { get; set; }

		/// <summary>
		///     Gets or sets the block to read AI object waves from.
		/// </summary>
		/// <value>The block to read AI object waves from.</value>
		public ScriptObjectTagBlock AIObjectWaves { get; set; }

		/// <summary>
		///     Gets or sets available starting profiles.
		/// </summary>
		/// <value>Available object references.</value>
		public ScriptObject[] StartingProfiles { get; set; }

		/// <summary>
		///     Gets or sets available zone sets.
		/// </summary>
		/// <value>Available object references.</value>
		public ScriptObject[] ZoneSets { get; set; }

        /// <summary>
        ///     Gets or sets available zone sets.
        /// </summary>
        /// <value>Available object references.</value>
        public ScriptObject[] DesignerZones { get; set; }

        /// <summary>
        ///     Gets or sets available object folders.
        /// </summary>
        /// <value>Available object folders.</value>
        public ScriptObject[] ObjectFolders { get; set; }

		/// <summary>
		///     Gets or sets available point sets.
		/// </summary>
		/// <value>Available point sets.</value>
		public ScriptObject[] PointSets { get; set; }

		/// <summary>
		///     Gets or sets the tag block to read point set points from.
		/// </summary>
		/// <value>The block to read point set points from.</value>
		public ScriptObjectTagBlock PointSetPoints { get; set; }


        /// <summary>
        ///     Gets or sets available AI Lines.
        /// </summary>
        /// <value>Available point sets.</value>
        public ScriptObject[] AILines { get; set; }

        /// <summary>
        ///     Gets or sets the reflexive to Ai Line Variants from.
        /// </summary>
        /// <value>The reflexive to read point set points from.</value>
        public ScriptObjectTagBlock AILineVariants { get; set; }

        /// <summary>
        ///     Gets or sets the unit_seat_mapping count.
        /// </summary>
        /// <value>The number of unit seat mappings int he cache file.</value>
        public int UnitSeatMappingCount { get; set; }
    }
}