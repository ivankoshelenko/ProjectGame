INCLUDE globals.ink
VAR scriptEnding = 0

{talkedToNathalie == 0:->greeting |-> justHi}

=== greeting ===
Здравствуйте, вы Алексей Иванович?
* [Да]
-Натали: Как здорово, что вы, наконец, приехали!
*[Продолжить]
-Натали: Мы сильно заждались вас. Нам уж надоело мучиться отпостоянных напастей.
*[Продолжить]
-Натали: Вот буквально сегодня Роман Степанович не мог справиться с воротами!
*[Продолжить]
~talkedToNathalie = 1
-Натали: Не могли бы вы помочь ему? Он будет ждать по дороге вправо.
    *[Да,конечно]
    ->GoodBye

    *[Спасибо за тёплый приём, сейчас отправлюсь к нему.]
    ->GoodBye
    *[Эх вы, Поставили умные ворота,а умного начальника не нашли.]
    -> BadBye
=== GoodBye ===
Удачи!
*[Закончить диалог]
~ scriptEnding =1
-> END

===BadBye===
Какой грубиян!
*[Закончить диалог]
~ scriptEnding =1
-> END    
 
===justHi===
Иди к Роману Степанычу!
*[Иду]
~ scriptEnding =1
-> END 