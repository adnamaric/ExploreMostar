curl -OutFile "exploremostar.bak" “https://github.com/adnamaric/ExploreMostar/blob/master/Database/exploreMostar.bak?raw=true”
docker cp "exploremostar.bak" exploremostar2345_ms-sql-server_1:/var/backups
curl -OutFile "sqlquery.sql" “C:\Users\User\source\repos\ExploreMostar2345\SQLQuery.sql”
docker cp "sqlquery.sql" exploremostar2345_ms-sql-server_1:/var/backups 
docker exec -u sa containername exploremostar2345_ms-sql-server_1 -f exploremostar2345_ms-sql-server_1:/var/backups/sqlquery.sql 
cat C:\Users\User\source\repos\ExploreMostar2345\SQLQuery.sql | docker exec -i exploremostar2345_ms-sql-server_1 ms-sql-server_1 -U sa -d exploreMostar
docker exec -it sql "bash"
#!/bin/bash
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'Pa55w0rd2020'
RESTORE DATABASE exploreMostar
FROM DISK = '/var/backups/exploremostar.bak'
WITH MOVE 'exploreMostar' TO '/var/opt/mssql/data/exploreMostar.mdf',
MOVE 'exploreMostar_log' TO '/var/opt/mssql/data/exploreMostar.ldf'
GO