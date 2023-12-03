# Игра "Ходьба по карте"

## Описание

Игра "Ходьба по карте" — это консольная игра, написанная на C# с использованием .NET 7. В игре участвуют несколько игроков, которые по очереди бросают кости и перемещаются по карте. Если игрок наступает на ловушку, он отступает назад, если нет — продвигается вперед. Цель игры — достичь конца карты. Побеждает игрок, который первым достигает финиша.

## Начало работы

Для запуска игры клонируйте репозиторий и выполните следующие команды:

```bash
dotnet restore
dotnet build
dotnet run
```
## Правила игры
- Каждый игрок по очереди бросает кости, чтобы определить количество шагов.
- Шаги игрока могут быть от 1 до 6.
- На карте расположены ловушки. При попадании в ловушку игрок отступает на определенное количество шагов.
- Побеждает игрок, который первым достигнет конца карты размером 50 клеток.

## Настройка игры
Игра предоставляет возможность настройки через класс GameSettings, где вы можете задать:

- Количество игроков (PlayersCount).
- Размер карты (MaxMapSize).
- Количество ловушек (TrapsCount).
- Диапазон штрафных шагов (PunishmentRange).
- Диапазон шагов игрока (PlayerStepsRange).

## Структура проекта
- Bootstrapper: Точка входа в игру, инициализирует настройки и запускает игру.
- Game: Основной класс игры, управляет игровым процессом.
- Player: Класс, представляющий игрока, его позицию и движение по карте.
- Trap: Класс, представляющий ловушку на карте.
- GameSettings: Класс настроек игры, используется для конфигурации параметров игры.
- Vector2Int: Вспомогательный класс для работы с парой целых чисел.

## Контрибьюторы
- [RimuruDev](https://github.com/RimuruDev) - Рефакторинг и улучшение игры.
- [AlexScience](https://github.com/AlexScience) - Оригинальная концепция и разработка игры.

## Ссылки
Оригинальный проект игры: [walkingGame](https://github.com/AlexScience/walkingGame)

## Лицензия
Этот проект распространяется под лицензией MIT.
