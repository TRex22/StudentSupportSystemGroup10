-- Group 10 2015 SSS Database
-- Delete database BE CAREFUL
-- Some files dont remove. Remove manually before recreating the db
Use master;
ALTER database IS2G10_DBSSS set offline with ROLLBACK IMMEDIATE;
ALTER database IS2G10_DBSSS set online with ROLLBACK IMMEDIATE;
DROP DATABASE IS2G10_DBSSS;
PRINT ('DATABASE DESTORYED');