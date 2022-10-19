# Notes
## Unit Tests notes
You must not rely on only Unit Tests to ensure that fetched data is correct. 
Their purpose here to test and debug certain functions of certain libraries in development stage.

Always make sure that data that you fetched is correct with [Riot Developer Portal](https://developer.riotgames.com/apis) values
with values in Debugger inspectors for validity.

Not all tests expected to complete successfully due to changes in fetched data. 
You are required to provide your own data for tests to expect them complete successfully!

Clash Tournaments tests cannot be always completed successfully due to perodic nature of Clash Tournaments,
so expect some tests fail when there are no active or upcoming Clash Tournaments

For champion rotations tests it is necessary to change values with correct values that were fetched from [Riot Developer Portal](https://developer.riotgames.com/apis)
because of periodic nature of Champion Rotations

## TODO:
All features to be implemented

- [ ] Move tests settings from constants in .runsettings file
- [ ] Riot APIs
	- [x] Common library
	- [x] Account API
	- [ ] League of Legends APIs
		- [x] Champion Rotations API
		- [x] Clash API
		- [x] Mastery API
		- [x] Summoner API
		- [x] Leagues API
			- [x] Leagues API
			- [x] Leagues Experimental API
		- [ ] LoL Challanges API
		- [ ] LoL Status API
		- [ ] Match API
			- [x] Get Match IDs and make overloads for filters
			- [ ] Get Match info by ID
				- [ ] Make data objects
			- [ ] Get Match timeline by ID
				- [ ] Make data objects
			- [ ] Spectator API
			- [ ] ***info TBD***
		- [ ] Tournament APIs
			- [ ] Tournament API
			- [ ] Tournament Stub API
- [ ] Riot Data Dragon API
	- [ ] Static data requests from [game constants](https://developer.riotgames.com/docs/lol#general_game-constants) (or from custom Git Repository static JSON files)
	- [ ] ***More Features TBD***