# Разбиение сервисов по уровням

1. **Entity** - Data Access Layer
1. **DTO** - Business Rules Layer
1. **VM** - Presentation Layer

Вышестоящие сервисы обращаются строго к нижестоящим:
**VM** -> **DTO** -> **Entity**

---
## Entity - Data Access Layer

Сервисы работы с источниками данных (БД, сторонние API)

---
## DTO - Business Rules Layer

Сервисы, реализующие бизнес-логику

---
## VM - Presentation Layer

Сервисы, отвечающие за подготовку моделей данных, для отображения пользователям
