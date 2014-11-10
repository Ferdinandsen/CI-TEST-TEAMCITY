CREATE SCHEMA [SKEMA_TEST_TEAMCITY]

go

EXEC sp_addextendedproperty @name = N'tSQLt.TestClass', @value = 1, @level0type = 'SCHEMA', @level0name = [SKEMA_TEST_TEAMCITY];
go