﻿//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  31/07/2017 | Panchenko Vladislav | Manual 
//// прошу прочитайте все!
//  И сразу прощу прощения ибо сам понимаю что не все .. далеко , и можно лучше , но из за обстоятельств что смогу (немного плохо себя чувствовал )
//!*****************************************************************************
// hello, тому кто читает ! Сразу скаду пару слов почему все сделано или оставлено именно так ...
// 
// 1) Сетка , она больше для удобства розработчику , но можна отрисовати и играку , но это не естетично
// в идеале должна быть подсветка контура , но не успел сделать (иза обстоятельств)... Главное что реальзоввано розмезение всего по сетке заданого розмера (ну а отрисовку из игры на можна и убрать)
// 2) Скрол на меню (ну на панели , знаю как делать , но не стал поскольку и так места много .. но ет плохое оправдания..)
// механика добавления из менюшки , выбор обекта , (создаем клон с измененным тегом, ибо трансформация положения идет только для обектов с тегом 
// Object , полсе истечения таймерного времени (5с.) через -1. старабает  изменения тега и установка обекта на позицию (время на остановку и изменения можна вообще не делать
// но подумал пусть сделаю так с 2 таймерами , что б при надобности можна было анимацию доцепить сразу
// 3) Туман , ну там думаю все понятно Particle System X-Y (2шт) на кажую ось что б был +- плотным хотел достичь  ефекта типа "дремучего леса" (прям как мои познания *_*)
// 4) Кнопки для камеры , вделал просто трансфор без поворотов на Quaternion (но так тоже можна сделать , в закомментированом коде есть все что нужно)
// ограничил (ну хоть номинально) перемедения камеры по пространству , что б сильно далеко не уводил игрок (задел на будущее) 
//
//game plane
// еще есть проверка на занятость места по тиригерам , но она будет работать облично когда сетка Grid включена ибо тогда ставить в центр кубика.
// по поводу игровой площяди.. в общем сверху там есть лес что ограничивает територию (ну визуально) с подобием тумана 
// Да и важный момент поскольку деревья на краю ставятся в рандомной ренже то иногда есть не самые удачные варианты розстановки . но обычно выглядит довольно хаотично и +- природно 

// По поводу кода и коментариев , кода что приложен в проекте оформлен по разному , ибо встречал разные подходы , но кто ж знает какой вам подойдет больше потому 
// делал по разному 

// по поводу коментариев они на английском , и данная запись тоже могла быть , но поскольку тут много информации то что б не запутывать я не стал так делать , но могу, если нужно (есль сертефикат розговорного английского B1)
// prograss bar, знаю , видел но не успел следать (по извесной причине)... 
// Git использую только консольную версию (ну как в киге)
// и прошу Тот человек что прочитает или просто будет смотреть етот проект, напишите мне на почьту пожелания , что б дальше я смог улудшать качество 
//
//vladsk.panchenko.97@gmail.com
// 
//Благодарю за внимание! и потраченое время , с уважением Панченко Владислав .