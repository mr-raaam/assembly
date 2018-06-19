# Assembly

### Halo 4 Raw Injection Edition ###

This branch currently breaks injection on every other game besides Retail Halo 4 (didn't try beta, not sure when I will). This will eventually be fixed to hopefully make it into dev/master. Use at your own risk.

Current roadmap:

* Fix as many issues as possible with Halo 4 and optimize code where needed; submit an issue or tell me about it or something
* THEN bring back support for other games

Known issues:

* Maybe a memory leak?
* Models are muddy/low LOD due to prediction data not being injected/created. Actually a problem for all games but effects not as severe as H4.
* I couldn't spawn the Revenant via Forge on Valhalla, but could through a weapon, dunno why.
* PCAA tags are not supported right now/disabled as they will error upon injection into multiplayer maps without the "pca_coefficients_resource_definition" resource type present. Needs code to add the type during injection.

### Multi-Generation Blam Engine Research Tool ###

__An Xbox 360 capable of running unsigned code is required, for Xbox 360 supported games, in order to use modifications created with Assembly. Flashed disc drives will not work.__

__This repository does not support files belonging to Halo Online. For Halo Online support, the most recent and active fork as of this writing can be found [here](https://github.com/Lord-Zedd/Assembly)__

Assembly is a free, open-source Halo cache file (.map) editor that was built from the ground up. It allows users to create and distribute creative patches for game content.

Assembly was designed with three goals in mind: 

* __Flexibility__ - Assembly is capable of opening files targeted for Halo 2: Vista, Halo 3, Halo: Reach, and Halo 4. And includes a system which allows users to add in support for other formats with ease.
* __Speed__ - Spend more time researching and less time waiting for trivial tasks to complete. Even the largest tags load extremely quickly with invisible fields enabled, and the meta editor's search feature allows users to find values with ease.
* __Usability__ - Built using Windows Presentation Foundation and utilizing modern UI design concepts, Assembly is both easy to use and easy to look at.

## Downloading ##

Stable releases are made available through [GitHub's release system](https://github.com/XboxChaos/Assembly/releases).

## Compiling ##

See [Compiling Assembly from Source](https://github.com/XboxChaos/Assembly/wiki/Compiling-from-Source).

## Bug Reports ##

Assembly isn't perfect. If you encounter any issues, you are encouraged to submit bug reports through our [issue tracker](https://github.com/XboxChaos/Assembly/issues/new). Please make your reports as detailed as possible. Be sure to include any exception messages you get (if any), what map the error occurred on, and give steps showing how we can reproduce the behavior you encountered.
