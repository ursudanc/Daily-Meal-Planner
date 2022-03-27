DMP
https://docs.google.com/document/d/1bbz1kRqSGE0xg66XNz1AYvYuF1T08UnJ3tMBR-kt3cU/edit?usp=sharing

DATA ANNOTATIONS : 
https://www.dotnettricks.com/learn/mvc/mvc-data-annotations-for-model-validation

HOW I CREATED TABLES : 
https://www.youtube.com/watch?v=uVne2HXkWXI

WOW( way of working)
1.View -> SQL server object explorer
2.Create a database
3.appsettings.json ->  change connectionstring to this : "Server=(localdb)\\mssqllocaldb;Database=YourDatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true"
4.tools -> nuGet package manager -> package manager console 
 write in the console 
 add-migration ANameForYourMigration
 update-database
Press Run and it should work


Dupa cum o sa observati la mn pe branch e DMP numele bazei de date, puteti sa va creati si voi una si atunci nu mai schimbati connection stringu