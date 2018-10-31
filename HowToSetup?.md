# Client
- **1)** Go to this file `client\src\com\company\assembleegameclient\parameters\Parameters.as`;
- **2)** Change value of variable **IS_DEVELOPER_MODE** to **false**;
- **3)** Go to this variable, at same file, **ENVIRONMENT_DNS** and change value of **testing.loesoftgames.ignorelist.com** to your IP or DNS;
- **4)** Build your client, it'll be compiled at `client\client\client-release.swf`.

# Server
- **1)** Go to this file `server\common\config\Settings.cs`;
- **2)** Change value of variable **SERVER_MODE** to *ServerMode.Production*;
- **3)** Go to this variable, at same file, **ALLOWED_LOCAL_DNS** and change value of **testing.loesoftgames.ignorelist.com** to your IP or DNS;
- **4)** Go to this file `server\common\config\internal\Networking.cs`;
- **5)** Go to this variable **PRODUCTION_DDNS** and change value of **testing.loesoftgames.ignorelist.com** to your IP or DNS;
- **6)** Go to this variable **CROSS_DOMAIN_POLICY** and change occurrencies of **testing.loesoftgames.ignorelist.com** to your IP or DNS;
- **7)** Build your server, then to run it go to `server` folder and open in order **_storage_engine.bat** then **_initialize_game.bat**.
