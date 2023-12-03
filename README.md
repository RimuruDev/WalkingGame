# Игра "Ходьба по карте"

 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/WalkingGame?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/WalkingGame?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/WalkingGame?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/WalkingGame/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/WalkingGame?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/WalkingGame?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/WalkingGame?style=flat">
  </a>
</p>

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
