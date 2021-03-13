# ApiMongoImplementation
Create a .net 5.0 Api by linux docker container and MongoDb

To do List;
First of think, you create a Cluster in MongoDb websites.(https://cloud.mongodb.com/)
Step two, you will create a Cluster.(Create new Cluster)
step tree, you will setup Cluster -> Database Access. (Here, you create DbUser for db connection.İf you dont have a user, must be a create one user.)
user setting-> Setup Username.
               setup password.
               setup role Privileges.(If this user manage your db, you use the "Read and write to any database" selection.)
step four, you will setup Cluster-> Network Access.(Here you give a access privilage from network, ıf you want to access from personal computer, you can set Current Ip address.otherwise you can select  all network access. )
step five, you will go Cluster tab, find connect button.This button carry on our cluster's connection string.
Take a connection string use for code.
How to use for code:
This connectionstring must be secret.You can classifield use by user-Secrets methods in dotnet.
How to user-secrets our connectionstring in dotnet.
First of think you must be initialize user-secrets in project.after you have opened your Package manager Console,typing like this script "dotnet user-secrets init -p <project-name>"
After that you would run "CONNECTION_STRING" "<ClusterConnection page infos>" -p <Product-name> for connection string user-secrets implementation.
