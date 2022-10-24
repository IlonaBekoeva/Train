# Проект “Поезд”

# Техническое задание

## Назначение разработки 
Игра по изучению языка в игровой форме, рассчитанная на одного игрока с возможностью сохранять результаты своей игры и побивать чужие рекорды. В игре 3 языка (осетинский, грузинский и армянский) и 3 уровня сложности. На экране появляется меню игры, где можно выбрать изучаемый язык, тематику картинок, скорость поезда (медленно, средне или быстро). На экране выезжает поезд с вагонами, каждый из которых подписан на выбранном ранее языке из 3 предложенных. В первом уровне у нас 5 вагонов, во втором 10 и т.д. В каждом уровне на экране разбросаны картинки-образы слов в соответствии со словами над поездами. В первом уровне при нажатии на картинку-образ слова происходить её озвучивание на выбранном языке во втором и третьем уровнях для усложнения задачи озвучивание отключается. Задача игрока поместить перетаскиванием картинок-образов слов в вагоны. Поезд скрывается в туннеле, если в туннель заезжает не загруженный вагон, то уровень проигран. За каждый правильно загруженный вагон игроку начисляются баллы. При идеальном(все вагоны загружены правильно ) прохождении уровня также начисляются баллы (+100 баллов). Попытка погрузить образ в неправильный вагон приводит к потере жизни. При потери всех жизней уровень проигран и у игрока отнимаются баллы (-100 баллов). 

## Функционал
1. Создание меню игры. На отдельной форме находятся 6 кнопок:

         1. Играть (запускает игру)
         2. Регистрация или вход(открывает форму в которой пользователь может зарегистрироваться или войти,если играет не в первый раз)
         3. Язык (выбор языка из 3 предложенных)
         4. Тематика (выбор тематики картинок/слов из 10 предложенных(можно выбрать 1, несколько или все(в этом случае слова будут выбираться рандомно)))
         5. Скорость (выбор скорости поезда из 3 предложенных)
         6. Выход (полный выход из игры)

2. Создание формы с авторизацией пользователя (пользователь либо вводит свой ник, если играет не в первый раз, либо регистрируется)
3. Создание 3 уровней сложности
* 1 уровень: по игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке. На нижней части формы появляются картинки с изображениями, также подписанные, но уже на русском. При нажатии на данные картинки происходит озвучивание этих слов на изучаемом языке, чтобы игроку было проще найти нужный вагон. 
* 2 уровень: по игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке. На нижней части формы появляются картинки с изображениями, также подписанные, но уже на русском. На данном уровне для усложнения задачи озвучивание картинок не происходит и игрок должен сам сопоставить картинки с вагонами используя только изображения и подпись на русском языке.
* 3 уровень: по игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке.  На нижней части формы появляются картинки с изображениями. На данном уровне для усложнения задачи озвучивание картинок не происходит и игрок должен сам сопоставить картинки с вагонами используя только изображения.
4. Создание анимации движущегося поезда с вагонами
5. Добавить 3 скорости поезда(медленно, средне или быстро)
6. Создать форму с выбором тематики картинок-образов. Форма на которой можно выбрать 1 или несколько тематик:

         1. Дикие животные
         2. Домашние животные
         3. Птицы
         4. Морские обитатели
         5. Насекомые
         6. Фрукты и ягоды
         7. Овощи
         8. Посуда, мебель и Бытовая техника
         9. Цветы и деревья
         10. Транспорт
         11. Строительные инструменты
         12. Музыкальные инструменты
         13. Одежда
         14. Профессии
         15. 
7. Появление картинок-образов
8. Количество картинок зависит от уровня сложности (1 ур. - 5 картинок; 2 ур. - 10 картинок; 3 ур. - 15 картинок)

           Картинки берутся в соответствии со словами на вагонах из папки cards
           Размер картинки 450*450 пикселей
           Картинка в формате PNG
           
9. Создание общей библиотека слов и картинок
10. Перетаскивание картинок
11. Проверка на правильность (слово - картинка)
12. Проверка на завершение игры (проигрыш или победа)
13. Начисление баллов за правильность заполнения вагона +10 за правильно загруженный вагон или - 10, если вагон загружен не верно
14. Начисление баллов за правильно пройденный уровень(+100) или (-100) за проигрыш
15. Подсчёт жизней; -1 жизнь, если неправильно загруженный вагон заехал в тоннель
16. Озвучивание образов (при нажатии на картинку-образ происходит ее озвучивание)
17. Автоматическое добавление новых слов (т.е. разработка приложения по пополнению библиотеки картинок)
18. Сортировка картинок по тематике
19. Переход на следующий уровень сложности 

## Этапы реализации

### Версия 1.0 (01.05.2022 г.)

* Создание анимации движущегося поезда с вагонами
* Появление картинок-образов
* Количество картинок зависит от уровня сложности (1 ур. - 5 картинок; 2 ур. - 10 картинок; 3 ур. - 15 картинок)

        Картинки берутся в соответствии со словами на вагонах из папки cards
        Размер картинки 450*450 пикселей
        Картинка в формате PNG
        
* Перетаскивание картинок
* Проверка на правильность (слово - картинка)
* Проверка на завершение игры (проигрыш или победа)
* Подсчёт жизней: -1 жизнь, если неправильно загруженный вагон заехал в тоннель


### Версия 2.0 (21.11.2022 г.)

* Создание меню игры. На отдельной форме находятся 6 кнопок:

         1. Играть (запускает игру)
         2. Регистрация или вход(открывает форма в которой пользователь может зарегистрироваться или войти,если играет не в первый раз)
         3. Язык (выбор языка из 3 предложенных)
         4. Тематика (выбор тематики картинок/слов из 10 предложенных(можно выбрать 1, несколько или все(в этом случае слова будут выбираться рандомно)))
         5. Скорость (выбор скорости поезда из 3 предложенных)
         6. Выход (полный выход из игры)

* Создание формы с авторизацией пользователя (пользователь либо вводит свой ник, если играет не в первый раз, либо регистрируется)
* Создание 3 уровней сложности

            1 уровень: по игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке. На нижней части формы появляются картинки с изображениями, также подписанные, но уже на русском. При нажатии на данные картинки происходит озвучивание этих слов на изучаемом языке, чтобы игроку было проще найти нужный вагон. 
            2 уровень: по игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке. На нижней части формы появляются картинки с изображениями, также подписанные, но уже на русском. На данном уровне для усложнения задачи озвучивание картинок не происходит и игрок должен сам сопоставить картинки с вагонами используя только изображения и подпись на русском языке.
            3 уровень: по игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке.  На нижней части формы появляются картинки с изображениями. На данном уровне для усложнения задачи озвучивание картинок не происходит и игрок должен сам сопоставить картинки с вагонами используя только изображения.
            
* Сортировка картинок по тематике
* Добавить 3 скорости поезда(медленно, средне или быстро)
* Создать форму с выбором тематики картинок-образов. Форма на которой можно выбрать 1 или несколько тематик:

         1. Дикие животные
         2. Домашние животные
         3. Птицы
         4. Морские обитатели
         5. Насекомые
         6. Фрукты и ягоды
         7. Овощи
         8. Посуда, мебель и Бытовая техника
         9. Цветы и деревья
         10. Транспорт
         11. Строительные инструменты
         12. Музыкальные инструменты
         13. Одежда
         14. Профессии
         
### Версия 3.0 (19.12.2022 г.)

* Начисление баллов за правильность заполнения вагона +10 за правильно загруженный вагон или - 10, если вагон загружен не верно
Начисление баллов за правильно пройденный уровень(+100) или (-100) за проигрыш
* Озвучивание образов (при нажатии на картинку-образ происходит ее озвучивание)
* Автоматическое добавление новых слов (т.е. разработка приложения по пополнению библиотеки картинок)



Ссылка на текст курсовой работы: https://docs.google.com/document/d/19zmvRFRe4nJ_96ThIgzWdJTo5EyV3qAp-dOMc-Trm4o/edit?usp=sharing 

Ссылка на презентацию курсовой работы: https://docs.google.com/presentation/d/1Mc-72WotIeDzLkksBb6EGWdEFHUbJaZM5IIv-eg6AAQ/edit?usp=sharing
