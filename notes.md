* dotnet add package System.Data.SQLite
* dotnet add package SqlKata
* dotnet add package SqlKata.Execution
* dotnet add package AutoMapper
* dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
* dotnet dev-certs https --trust


todo:
* авторизация
* пейджинг (для списков героев)
* JsonPatch
* GraphQL
* Кэширование (inmemory, redis)

1) AuthService (User, Roles)
2) ActionFilter https://medium.com/geekculture/how-i-use-an-actionfilter-in-net-core-to-streamline-authorization-f12acbea7788
3) AutoMapper (docs) https://automapper.org/ 
4) AutoMapper (how to) https://jimmybogard.com/automapper-usage-guidelines/
5) про Lazy регистрацию сервисов https://stackoverflow.com/questions/44934511/does-net-core-dependency-injection-support-lazyt
6) Cache (Redis) - https://medium.com/@jaydeepvpatil225/implementation-of-the-redis-cache-in-the-net-core-api-c8276167ef0c
7) Cache (InMemory) - https://medium.com/@jaydeepvpatil225/implement-in-memory-cache-in-the-net-core-api-251ce58c37bc
8) CancelationToken и асинхронные (долгие) запросы - - отмена долгих асинхронных долгих запросов