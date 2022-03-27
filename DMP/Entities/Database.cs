// Licence file E:\OneDrive\Documents\ReversePOCO.txt not found.
// Please obtain your licence file at www.ReversePOCO.co.uk, and place it in your documents folder shown above.
// Defaulting to Trial version.


// ------------------------------------------------------------------------------------------------
// WARNING: Failed to load provider "System.Data.SqlClient" - Cannot open database "Northwind" requested by the login. The login failed. Login failed for user 'DESKTOP-P1TQSIU\DAN'.
// Allowed providers:
//    "System.Data.Odbc"
//    "System.Data.OleDb"
//    "System.Data.OracleClient"
//    "System.Data.SqlClient"
//    "Microsoft.SqlServerCe.Client.4.0"

/*   at System.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, SqlCredential credential, Object providerInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString userConnectionOptions, SessionData reconnectSessionData, DbConnectionPool pool, String accessToken, Boolean applyTransientFaultHandling, SqlAuthenticationProviderManager sqlAuthProviderManager)
   at System.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, DbConnectionPoolKey poolKey, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnectionPool pool, DbConnection owningObject, DbConnectionOptions options, DbConnectionPoolKey poolKey, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at System.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, UInt32 waitForMultipleObjectsTimeout, Boolean allowCreate, Boolean onlyOneCheckConnection, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   at System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   at System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   at System.Data.SqlClient.SqlConnection.Open()
   at Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.DatabaseReader.Init() in E:\II_PROJECT\Daily-Meal-Planner\DMP\Entities\EF.Reverse.POCO.v3.ttinclude:line 12200
   at Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.SqlServerDatabaseReader.Init() in E:\II_PROJECT\Daily-Meal-Planner\DMP\Entities\EF.Reverse.POCO.v3.ttinclude:line 15604
   at Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.Generator.Init(DatabaseReader databaseReader, String singleDbContextSubNamespace) in E:\II_PROJECT\Daily-Meal-Planner\DMP\Entities\EF.Reverse.POCO.v3.ttinclude:line 4138
   at Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.GeneratorFactory.Create(FileManagementService fileManagementService, Type fileManagerType, String singleDbContextSubNamespace) in E:\II_PROJECT\Daily-Meal-Planner\DMP\Entities\EF.Reverse.POCO.v3.ttinclude:line 6284*/
// ------------------------------------------------------------------------------------------------

