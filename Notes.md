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

## Features TODO:
All features to be implemented

- [ ] Move tests settings from constants in .runsettings file
- [ ] Riot APIs
	- [x] Common library
	- [x] Account API
	- [x] League of Legends APIs
		- [x] Champion Rotations API
		- [x] Clash API
		- [x] Mastery API
		- [x] Summoner API
		- [x] Leagues API
		- [x] Challanges API
		- [x] Match API
		- [x] Spectator API
		- [x] Tournament APIs
			- [x] Tournament API
			- [x] Tournament Stub API
	- [x] Status APIs
	- [x] Valorant APIs
    	- [x] Ranked API
    	- [x] Content API
	- [x] Legends of Runeterra APIs
    	- [x] LoR Match API
    	- [x] LoR Ranked API
	- [x] TFT APIs
    	- [x] Leagues API
		- [x] Match API
		- [x] Summoner API
	- [x] League of Legends Client APIs
    	- [x] All game data endpoint
    		- GET
			- /liveclientdata/allgamedata
    		- query: int: eventID
		- [x] Active player data endpoint
    		- GET
			- /liveclientdata/activeplayer
		- [x] Active player abilities endpoint
    		- GET
			- /liveclientdata/activeplayerabilities
		- [x] Active player name endpoint
    		- GET
    		- /liveclientdata/activeplayername
		- [x] Active player runes endpoint
    		- GET
			- /liveclientdata/activeplayerrunes
		- [x] Event data endpoint
    		- GET
			- /liveclientdata/eventdata
    		- query: int: eventID
		- [x] Game stats endpoint
    		- GET
			- /liveclientdata/gamestats
		- [x] Players items endpoint
    		- GET
			- /liveclientdata/playeritems
    		- query: string: summonerName
		- [x] Player list endpoint
    		- GET
			- /liveclientdata/playerlist
    		- query: enum: teamID {ALL, UNKNOWN, CHAOS, ORDER, NEUTRAL}
		- [x] Player main runes endpoint
    		- GET
			- /liveclientdata/playermainrunes
    		- query: string: summonerName
		- [x] Player scores endpoint
    		- GET
    		- /liveclientdata/playerscores
    		- query: string: summonerName
		- [x] Player summoner spells endpoint
    		- GET
    		- /liveclientdata/playersummonerspells
    		- query: string: summonerName
	- [ ] Replay API
- [ ] Riot Data Dragon API
	- [ ] Static data requests from [game constants](https://developer.riotgames.com/docs/lol#general_game-constants) (or from custom Git Repository static JSON files)
    - [ ] Multiple Data Dragon providers (Riot Official, Community Data Dragon)
	- [ ] ***More Features TBD***

## Current WIP
- [ ] find more information about API response objects
    - [ ] perform more research about match timeline frame event types
    - [ ] find info about "bannerAccent" property for player client preferences
	- [ ] find info about "game_outcome" tie value in LoR match
	- [ ] find info about League Client game end event result values
- [ ] ***TBD***