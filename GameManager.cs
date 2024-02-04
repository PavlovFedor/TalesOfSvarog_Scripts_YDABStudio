using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour{

    public GameObject chatGO, contGO, contMenuGO;
    private Chat chatScript;
    private MenuAnswer contMenuScript;

    private int step = 0;

    public GameObject scrollbarGO;
    private Scrollbar _scrollbar;

    public GameObject wife, trader, lider, healer, smith, warrior, son, grand;

    void Start()
    {
        chatScript = chatGO.GetComponent<Chat>();
        _scrollbar = scrollbarGO.GetComponent<Scrollbar>();
        contMenuScript = contMenuGO.GetComponent<MenuAnswer>();
    }

    public void EndMenuAnswer(int phase, bool ans){
        contGO.SetActive(true);
        contMenuGO.SetActive(false);
        //contMenuScript.ActivatePhase();

        switch(phase){
            case 1:
                if(ans)
                    step = 25;
                else
                    step = 26;
                break;
            case 2:
                if(ans)
                    step = 34;
                else
                    step = 36;
                break;
            case 3:
                if(ans)
                    step = 48;
                else
                    step = 51;
                break;
            case 4:
                if(ans)
                    step = 62;
                else
                    step = 63;
                break;
        } 
        stepScript();       
    }

    public void stepScript(){

        switch(step){
            case 0:
                chatScript.SendMessageToChat(0,"Темнота. Ничего кроме кромешной тьмы. Мысли в голове роятся словно пчелы. Где? Как? Почему? Проблеск. Где-то вдали на грани зрения виднеется свет. Слишком тусклый, чтобы понять что его создает, однако достаточно яркий чтобы различить оранжевые и красные оттенки в нем. ", Message.MessageType.red);
                
                step = 1;
                break;
            case 1:
                chatScript.SendMessageToChat(1,"Огонек – первое что пронзает мысли. Совсем маленький, словно догорающая лучина. Он приближается и раздается крик…", Message.MessageType.red);
                
                step = 2;
                break;
            case 2:
                chatScript.SendMessageToChat(2,"-Милый просыпайся.- раздается голос.", Message.MessageType.purple);
                step = 3;
                break;
            case 3:
                chatScript.SendMessageToChat(19,"Перед вашими открытыми глазами предстает фигура. Женщина среднего роста, с зелеными словно летние леса глазами и черными как смоль волосами. Солнце из открывшегося окна озарило изящные черты лица. Такой красавицы вовек не сыскать.", Message.MessageType.red);
                wife.SetActive(true);
                //krichit petuh
                step = 4;
                break;
            case 4:
                chatScript.SendMessageToChat(-1,"-Доброе утро, дорогая. ", Message.MessageType.yellow);
                
                step = 5;
                break;
            case 5:
                chatScript.SendMessageToChat(-1,"Одев старую, порядком изношенную одежду вы направляетесь завтракать.", Message.MessageType.red);
                
                step = 6;
                break;
            case 6:
                chatScript.SendMessageToChat(-1,"-Отец, вчера заходили соседи, просили починить инструменты.", Message.MessageType.blue);
                wife.SetActive(false);
                son.SetActive(true);
                step = 7;
                break;
            case 7:
                chatScript.SendMessageToChat(-1,"В комнате сидел мальчишка, коричневые глаза и волосы которого ярка блестели на солнце.", Message.MessageType.red);
                
                step = 8;
                break;
            case 8:
                chatScript.SendMessageToChat(-1,"-Понял, значит после обеда будешь мне помогать, а мне пока нужно сходить за материалами.", Message.MessageType.yellow);
                
                step = 9;
                break;
            case 9:
                chatScript.SendMessageToChat(-1,"-Отец, а когда ты научишь меня ковать мечи?", Message.MessageType.blue);
                
                step = 10;
                break;

            case 10:
                chatScript.SendMessageToChat(-1,"-Меч - это инструмент, который обычным людям вроде нас не нужен. Он приносит много боли как тому, кто под него попадает, так и тому кто его использует.", Message.MessageType.yellow);
                
                step = 11;
                break;

            case 11:
                chatScript.SendMessageToChat(-1,"-Но как меч может причинять боль носителю?", Message.MessageType.blue);
                
                step = 12;
                break;

            case 12:
                chatScript.SendMessageToChat(-1,"-Я надеюсь ты и не узнаешь.", Message.MessageType.yellow);
                
                step = 13;
                break;

            case 13:
                chatScript.SendMessageToChat(-1,"-Но отец!", Message.MessageType.blue);
                
                step = 14;
                break;

            case 14:
                chatScript.SendMessageToChat(-1,"-Я всё сказал! Жду в кузне после обеда. Убедись что всё подготовлено.", Message.MessageType.yellow);
                
                step = 15;
                break;
            case 15:
                chatScript.SendMessageToChat(-1,"-…", Message.MessageType.blue);
                
                step = 16;
                break;

            case 16:
                chatScript.SendMessageToChat(-1,"-Не слышу ответа.", Message.MessageType.yellow);
                
                step = 17;
                break;

            case 17:
                chatScript.SendMessageToChat(-1,"-Хорошо, отец.", Message.MessageType.blue);
                
                step = 18;
                break;

            case 18:
                chatScript.SendMessageToChat(-1,"Мальчик вышел из избы.", Message.MessageType.red);
                son.SetActive(false);
                step = 19;
                break;

            case 19:
                chatScript.SendMessageToChat(-1,"-Зачем же ты с ним так? – сказала женщина, войдя в комнату.", Message.MessageType.purple);
                wife.SetActive(true);
                step = 20;
                break;

            case 20:
                chatScript.SendMessageToChat(-1,"-Ты и сама знаешь. Ведет себя словно на смерть торопится.", Message.MessageType.yellow);
                
                step = 21;
                break;

            case 21:
                chatScript.SendMessageToChat(-1,"-В любом случае, постарайся быть с ним по мягче.", Message.MessageType.purple);
                
                step = 22;
                break;

            case 22:
                chatScript.SendMessageToChat(25,"Выйдя из-за стола, вы направляетесь к выходу из избы. Открыв дверь, свет бьет вам в лицо. Обычная деревня, мирно живущие люди, идущие работать на поля, леса омываемые ветром. Пейзаж достойный великой картины.", Message.MessageType.red);
                wife.SetActive(false);
                step = 23;
                break;

            case 23:
                chatScript.SendMessageToChat(-1,"-Время поработать.", Message.MessageType.yellow);
                step = 24;
                break;

            case 24:
                chatScript.SendMessageToChat(40,"По пути к кузне вы замечаете столпотворение. Вы уже давно привыкли к необычному виду местных жителей", Message.MessageType.red);
                contGO.SetActive(false);
                contMenuGO.SetActive(true);
                contMenuScript.ActivatePhase();
                break;

            case 25:
                chatScript.SendMessageToChat(30,"Вы пошли выполнять свою рутину. Спустя три дня деревня была разграблена и сожжена. Вы и ваша семья убиты. Конец.", Message.MessageType.red);
                
                break;

            case 26:
                chatScript.SendMessageToChat(-1,"Вы подходите к толпе и среди обычного народа вы замечаете вооруженных людей. Появляется некое смутное чувство, вязкое, жгучее и обволакивающее своими липкими щупальцами сердце.", Message.MessageType.red);
                step = 27;
                break;

            case 27:
                chatScript.SendMessageToChat(-1,"-Не к добру это.", Message.MessageType.yellow);
                step = 28;
                break;

            case 28:
                chatScript.SendMessageToChat(-1,"Вооруженные люди явно в бедственном положении. Ваш взгляд замечает их оружие и броню, как кузнец вы точно можете сказать, что они прошли ожесточенное сражение", Message.MessageType.red);
                step = 29;
                break;

            case 29:
                chatScript.SendMessageToChat(-1,"-Есть здесь травник или знахарь? – раздался голос из отряда – И еще кузнец.", Message.MessageType.white);
                lider.SetActive(true);
                step = 30;
                break;

            case 30:
                chatScript.SendMessageToChat(-1,"Роскошные доспехи и непередаваемая аура явно выдавала в этом человеке лидера.", Message.MessageType.red);
                step = 31;
                break;

            case 31:
                chatScript.SendMessageToChat(-1,"-Травник есть, да вот только оружейного кузнеца вряд ли найдете. Есть только наш местный, по инструментам. – местный староста указал на меня.", Message.MessageType.grey);
                step = 32;
                break;

            case 32:
                chatScript.SendMessageToChat(-1,"Лидер подходит к вам.", Message.MessageType.red);
                step = 33;
                break;

            case 33:
                chatScript.SendMessageToChat(-1,"-День добрый. Хоть вы с оружием не работаете, но хотя бы посмотрите, что можно сделать?", Message.MessageType.white);
                contGO.SetActive(false);
                contMenuGO.SetActive(true);
                contMenuScript.ActivatePhase();
                break;

            case 34:
                chatScript.SendMessageToChat(-1,"-Делать нечего. Давайте сюда.", Message.MessageType.yellow);
                step = 35;
                break;

            case 35:
                chatScript.SendMessageToChat(-1,"Вы ремонтируете снаряжение отряда, пока травник делает снадобья для отряда. Они благодарят вас и уходят, предупреждая что надвигается великая война.", Message.MessageType.red);
                step = 38;
                break;

            case 36:
                chatScript.SendMessageToChat(-1,"-Простите, но с оружием работать не могу.", Message.MessageType.yellow);
                step = 37;
                break;

            case 37:
                chatScript.SendMessageToChat(-1,"Отряд все равно благодарит вас и получив снадобья уходят, предупреждая что надвигается великая война.", Message.MessageType.red);
                step = 38;
                break;

            case 38:
                chatScript.SendMessageToChat(-1,"Конечно. Вот что это за чувство. Инстинкт кричащий об опасности о которой ты даже не подозреваешь. Люди, избы, заборы проносятся мимо вас. Вы врываетесь в свой дом.", Message.MessageType.red);
                lider.SetActive(false);
                step = 39;
                break;

            case 39:
                chatScript.SendMessageToChat(8,"5 Дней спустя.", Message.MessageType.green);
                step = 40;
                break;

            case 40:
                chatScript.SendMessageToChat(4,"Старая телега едет покачиваясь. Палящее солнце, словно собираясь уничтожить все живое, старательно освещает вас. Середина лета. Зеленистые моря простираются до самых горизонтов, шелест листьев ласкает слух, пение птиц убаюкивает, а бескрайнее небо ведет облака по-своему, никому неизвестному пути.", Message.MessageType.red);
                step = 41;
                break;

            case 41:
                chatScript.SendMessageToChat(5,"-Мама, когда мы приедем. – раздается голос мальчика.", Message.MessageType.blue);
                step = 42;
                break;

            case 42:
                chatScript.SendMessageToChat(6,"-Скоро, дорогой, скоро. ", Message.MessageType.purple);
                step = 43;
                break;

            case 43:
                chatScript.SendMessageToChat(10,"Хмыкнув, вы немного хлестнули поводьями. Повозка немного ускорилась. Спустя час езды вдали стал виднеться город.", Message.MessageType.red);
                step = 44;
                break;

            case 44:
                chatScript.SendMessageToChat(29,"Славный город Жневск. Место куда стягиваются все ремесленники земель здешних. Царь много раз пытался местных мастеров в столицу зазвать, однако в своем городе всяко лучше чем под барским крылом в чужом. Жневские товары были широко известны своим качеством, особенно здесь ценились кузнецы. Хорошего мастера днем со днем не сыщешь, ведь все они здесь. ", Message.MessageType.red);
                step = 45;
                break;

            case 45:
                chatScript.SendMessageToChat(-1,"Мимо вас проносится человек на коне. Все бегут от войны, словно звери от пожара. ", Message.MessageType.red);
                step = 46;
                break;

            case 46:
                chatScript.SendMessageToChat(23,"Вы въезжаете в город, величественные врата словно отделяют иной мир.", Message.MessageType.red);
                step = 47;
                break;

            case 47:
                chatScript.SendMessageToChat(35,"Такого базара нигде кроме этого места не увидеть. Оживленные люди, бегающие  и смеющиеся детишки, торговцы кричащие один сильнее другого. Такой мирный пейзаж заставляет ваше сердце радостно стучать. Вы замечаете толпу около центральной площади.", Message.MessageType.red);
                contGO.SetActive(false);
                contMenuGO.SetActive(true);
                contMenuScript.ActivatePhase();
                break;

            case 48:
                chatScript.SendMessageToChat(22,"Человек возвышается над толпой. Это тот самый, что обогнал вас ранее перед городом. Мужчина начинает говорить.", Message.MessageType.red);
                step = 49;
                break;

            case 49:
                chatScript.SendMessageToChat(-1,"-Два дня назад, на границе было разграблено и сожжено поселение Живогорск. Этим поступком нам объявили войну. Царь собирает дружину, чтобы покарать тех, кто смеет нарушать мир этих земель.", Message.MessageType.grey);
                step = 50;
                break;

            case 50:
                chatScript.SendMessageToChat(-1,"По голове словно обухом огрели. Живогорск. Наша деревня. А если бы мы там остались? Чтобы случилось с нами? В вашей голове проносятся ужасающие картины, от которых все ваше нутро готово выйти наружу . Вы сдерживаете порыв и уходите.", Message.MessageType.red);
                step = 52;
                break;

            case 51:
                chatScript.SendMessageToChat(-1,"Вы решаете пройти мимо.", Message.MessageType.red);
                step = 52;
                break;

            case 52:
                chatScript.SendMessageToChat(15,"Изба в два этажа. Сразу и не скажешь что это дом простых земледельцев. Убранство соответствует внешнему виду – не богато, но и не бедно.", Message.MessageType.red);
                step = 53;
                break;

            case 53:
                chatScript.SendMessageToChat(18,"-Вот ты где, паршивец. – донесся голос из-за вашей спины.", Message.MessageType.pink);
                grand.SetActive(true);
                step = 54;
                break;

            case 54:
                chatScript.SendMessageToChat(-1,"Вы оборачиваетесь и видите маленькую старушку.", Message.MessageType.red);
                step = 55;
                break;

            case 55:
                chatScript.SendMessageToChat(-1,"-Мама, давно же мы не виделись. ", Message.MessageType.yellow);
                step = 56;
                break;

            case 56:
                chatScript.SendMessageToChat(-1,"Вы обнимаете женщину.", Message.MessageType.red);
                step = 57;
                break;

            case 57:
                chatScript.SendMessageToChat(-1,"-Эх, украл дочку, да увез невесть куда, злодей.", Message.MessageType.pink);
                step = 58;
                break;

            case 58:
                chatScript.SendMessageToChat(-1,"В её словах чувствовалась как радость встречи, так и горечь от долгой разлуки.", Message.MessageType.red);
                step = 59;
                break;

            case 59:
                chatScript.SendMessageToChat(-1,"-Матушка, идите сюда. Мы вам и гостинцы привезли. – раздался женский голос из соседней комнаты.", Message.MessageType.yellow);
                step = 60;
                break;

            case 60:
                chatScript.SendMessageToChat(-1,"-Ой, да какие же там гостинцы я не видела то. У нас тут что хошь найти можно.", Message.MessageType.pink);
                step = 61;
                break;

            case 61:
                chatScript.SendMessageToChat(-1,"Сказав это, женщина ушла.", Message.MessageType.red);
                grand.SetActive(false);
                contGO.SetActive(false);
                contMenuGO.SetActive(true);
                contMenuScript.ActivatePhase();
                break;

            case 62:
                chatScript.SendMessageToChat(-1,"Вы входите в комнату где за столом собралась вся семья. Приятная атмосфера и улыбки присутствующих позволили вам провести этот вечер не задумываясь о проблемах и лечь спать со спокойной душой.", Message.MessageType.red);
                step = 64;
                break;

            case 63:
                chatScript.SendMessageToChat(20,"Вы решили что слишком устали после дороги. И ушли спать, слыша как смеются внизу собравшиеся.", Message.MessageType.red);
                step = 64;
                break;

            case 64:
                chatScript.SendMessageToChat(-1,"День шестой.", Message.MessageType.green);
                step = 65;
                break;

            case 65:
                chatScript.SendMessageToChat(15,"Сидеть ничего не делая явно не для вас. Тем более, когда женщины работают не покладая рук. Вы решаете, что стоит осмотреться в городе.", Message.MessageType.red);
                step = 66;
                break;

            case 66:
                chatScript.SendMessageToChat(20,"Вы решаете, что лучше отдохнуть сегодня и никуда не ходить.", Message.MessageType.red);
                step = 67;
                break;

            case 67:
                chatScript.SendMessageToChat(24,"Вы проходите по улицам города. Осматриваясь вы замечаете здание. Ну конечно, куда же могли завести кузнеца его ноги, конечно к кузне. Раз пришел – заходи.", Message.MessageType.red);
                step = 68;
                break;

            case 68:
                chatScript.SendMessageToChat(32,"На входе вас встречает статный мужчина.", Message.MessageType.red);
                smith.SetActive(true);
                step = 69;
                break;
            case 69:
                chatScript.SendMessageToChat(-1,"-День добрый, мил человек. Чего изволите?", Message.MessageType.white);
                step = 70;
                break;
            case 70:
                chatScript.SendMessageToChat(-1,"-И вам не хворать. Думалось мне работу найти, семью кормить надо, кузнец я.", Message.MessageType.yellow);
                step = 71;
                break;
            case 71:
                chatScript.SendMessageToChat(-1,"-Иш какой уверенный. Ну коль кузнец, выкуй мне добрый клинок, а там посмотрю, принять тебя или нет.", Message.MessageType.white);
                step = 72;
                break;
            case 72:
                chatScript.SendMessageToChat(-1,"Вспомнив дни своей юности, взялся за работу. Меч удался на славу.", Message.MessageType.red);
                step = 73;
                break;
            case 73:
                chatScript.SendMessageToChat(-1,"-Ну чтож. Вижу опыт у тебя имеется. Хорошо, можешь работать со мной в кузне. Звать то тебя как?", Message.MessageType.white);
                step = 74;
                break;
            case 74:
                chatScript.SendMessageToChat(-1,"-Сварог имя мое.", Message.MessageType.yellow);
                step = 75;
                break;
            case 75:
                chatScript.SendMessageToChat(-1,"-Ну, как соберешься поработать, заходи, рад буду.", Message.MessageType.white);
                smith.SetActive(false);
                step = 76;
                break;
            case 76:
                chatScript.SendMessageToChat(34,"Герой продолжает ходить по городу. Натыкается на ристалище.", Message.MessageType.red);
                step = 77;
                break;
            case 77:
                chatScript.SendMessageToChat(-1,"-О, мил человек. Вижу ладно сложен. Слыхал, война надвигается?", Message.MessageType.grey);
                warrior.SetActive(true);
                step = 78;
                break;
            case 78:
                chatScript.SendMessageToChat(-1,"-Да, слыхал.", Message.MessageType.yellow);
                step = 79;
                break;
            case 79:
                chatScript.SendMessageToChat(-1,"Вы осматриваете человека что окликнул вас. Высоких, статный, держащий меч в руке мужчина стоял прямо около ристалища и видимо был одним из дружинников, защищающих город.", Message.MessageType.red);
                step = 80;
                break;
            case 80:
                chatScript.SendMessageToChat(-1,"-Вижу не прост ты. Судя по тело либо воин, либо кузнец.", Message.MessageType.grey);
                step = 81;
                break;
            case 81:
                chatScript.SendMessageToChat(-1,"-Твоя правда. Кузнец. Сварог зовут", Message.MessageType.yellow);
                step = 82;
                break;
            case 82:
                chatScript.SendMessageToChat(-1,"-Ха, Сварог значит. Слушай кузнец, сам понимаешь какое сейчас время. В общем, приказ дан – обучить вех мужчин желающих, чуть что, защитить город. Если вдруг надумаешь, заходи, такому только рады будем. На этом откланяюсь.", Message.MessageType.grey);
                step = 83;
                break;
            case 83:
                chatScript.SendMessageToChat(-1,"Обучают всех? Странно, но шанс упускать нельзя. Может приду сюда коль время будет. ", Message.MessageType.red);
                warrior.SetActive(false);
                step = 84;
                break;
            case 84:
                chatScript.SendMessageToChat(35,"Продолжая свое маленькое путешествие, вы входите на рынок. Вот оно – сердце города. Место где можно найти почти все что душе угодно. Ходили слухи что даже сам царь считается с торговой мощью города сего.", Message.MessageType.red);
                step = 85;
                break;
            case 85:
                chatScript.SendMessageToChat(-1,"-Не может быть!", Message.MessageType.gold);
                trader.SetActive(true);
                step = 86;
                break;
            case 86:
                chatScript.SendMessageToChat(-1,"Сквозь голоса толпы вы четко слышите легкий вскрик за спиной.", Message.MessageType.red);
                step = 87;
                break;
            case 87:
                chatScript.SendMessageToChat(-1,"-Этот свет! Ошибки быть не может.", Message.MessageType.gold);
                step = 88;
                break;
            case 88:
                chatScript.SendMessageToChat(-1,"Вы оборачиваетесь и видите странного мужчину. За его спиной большой баул, полный книг.", Message.MessageType.red);
                step = 89;
                break;
            case 89:
                chatScript.SendMessageToChat(-1,"-ХАХАХА! Не ожидал что встречу человека с такой занятной судьбой.", Message.MessageType.gold);
                step = 90;
                break;
            case 90:
                chatScript.SendMessageToChat(-1,"-Вы со мной говорите? – спрашиваете вы человека.", Message.MessageType.yellow);
                step = 91;
                break;
            case 91:
                chatScript.SendMessageToChat(-1,"-Да, с вами. Видите ли, у вас непередаваемая харизма. Да еще и судьба к тому же интересна.", Message.MessageType.gold);
                step = 92;
                break;
            case 92:
                chatScript.SendMessageToChat(-1,"-Судьба? О чем это вы?", Message.MessageType.yellow);
                step = 93;
                break;
            case 93:
                chatScript.SendMessageToChat(-1,"-А, не берите в толк. Я бы хотел предложить вам кое-что. Вы можете помочь мне на рынке, а я в свою очередь помогу вам, обучу завоевывать людские сердца.", Message.MessageType.gold);
                step = 94;
                break;
            case 94:
                chatScript.SendMessageToChat(-1,"-Если вы способны завоевать сердце человека, к чему вам я?", Message.MessageType.yellow);
                step = 95;
                break;
            case 95:
                chatScript.SendMessageToChat(-1,"-Ну, видите ли, вы мужчина крепкий, не то что я. Ох, уже вечереет, простите, мне пора. Приходите сюда, если вдруг вам понадоблюсь.", Message.MessageType.gold);
                trader.SetActive(false);
                step = 96;
                break;
            case 96:
                chatScript.SendMessageToChat(-1,"Странный мужчина исчез так же внезапно, как и появился.", Message.MessageType.red);
                step = 97;
                break;
            case 97:
                chatScript.SendMessageToChat(43,"И вправду, вечереет, нужно возвращаться. Вы направляетесь домой.", Message.MessageType.red);
                step = 98;
                break;
            case 98:
                chatScript.SendMessageToChat(-1,"-Милый, ты где был? - спросил вас ласковый женский голос, как только вы переступили порог.", Message.MessageType.purple);
                wife.SetActive(true);
                step = 99;
                break;
            case 99:
                chatScript.SendMessageToChat(-1,"-Дорогая, ты же знаешь, не могу я без дела сидеть. Решил город осмотреть. ", Message.MessageType.yellow);
                step = 100;
                break;
            case 100:
                chatScript.SendMessageToChat(-1,"-Не перетрудись только. Себя побереги. - в её словах чувствовалась тревога.", Message.MessageType.purple);
                step = 101;
                break;
            case 101:
                chatScript.SendMessageToChat(-1,"-Не волнуйся ты так. Здоровья у меня как у медведя.- ваш хохот словно гром прошелся по дому.", Message.MessageType.yellow);
                step = 102;
                break;
            case 102:
                chatScript.SendMessageToChat(-1,"-Тьфу ты. Я за него волнуюсь, а он….", Message.MessageType.purple);
                step = 103;
                break;
            case 103:
                chatScript.SendMessageToChat(-1,"-Ладно, ладно. Буду осторожен только не сердись.", Message.MessageType.yellow);
                step = 104;
                break;
            case 104:
                chatScript.SendMessageToChat(-1,"Вы ласково обняли жену. Она же немного растерявшись обняла вас в ответ.", Message.MessageType.red);
                wife.SetActive(false);
                step = 105;
                break;
            case 105:
                chatScript.SendMessageToChat(-1,"-Пойдем спать милая. Солнце уже село.", Message.MessageType.yellow);
                step = 106;
                break;
            case 106:
                chatScript.SendMessageToChat(20,"День 7.", Message.MessageType.green);
                step = 107;
                break;
            case 107:
                chatScript.SendMessageToChat(-1,"-Дорогой! Проснись!", Message.MessageType.purple);
                wife.SetActive(true);
                step = 108;
                break;
            case 108:
                chatScript.SendMessageToChat(-1,"Вы резко открываете глаза.", Message.MessageType.red);
                step = 109;
                break;
            case 109:
                chatScript.SendMessageToChat(-1,"-Сынок наш, ему плохо! – слезы стремительно катились по щекам женщины.", Message.MessageType.purple);
                step = 110;
                break;
            case 110:
                chatScript.SendMessageToChat(-1,"-Где он?", Message.MessageType.yellow);
                step = 111;
                break;
            case 111:
                chatScript.SendMessageToChat(-1,"-За ним сейчас матушка ухаживает. Она сказала у них знахарь есть. Известный во всем городе. Сбегай за снадобьем к нему. Быстрее!", Message.MessageType.purple);
                step = 112;
                break;
            case 112:
                chatScript.SendMessageToChat(-1,"-Хорошо, говори где живет.", Message.MessageType.yellow);
                wife.SetActive(false);
                step = 113;
                break;
            case 113:
                chatScript.SendMessageToChat(13,"Вот и она. Вы вбегаете в избу, в нос тут же ударяет едкий запах трав и отваров.", Message.MessageType.red);
                step = 114;
                break;
            case 114:
                chatScript.SendMessageToChat(17,"-Вы знахарь? Прошу, мой сын болен. У него сильный жар, его тошнит и болит голова.", Message.MessageType.yellow);
                healer.SetActive(true);
                step = 115;
                break;
            case 115:
                chatScript.SendMessageToChat(-1,"-Успокойтесь. Объясните помедленней что произошло.", Message.MessageType.white);
                step = 116;
                break;
            case 116:
                chatScript.SendMessageToChat(-1,"-----", Message.MessageType.yellow);
                step = 117;
                break;
            case 117:
                chatScript.SendMessageToChat(-1,"-Ясно. Однако снадобья я дать не могу. Мой помощник уехал в другой город, а один я их сделать не могу.", Message.MessageType.white);
                step = 118;
                break;
            case 118:
                chatScript.SendMessageToChat(-1,"-Давайте я вам помогу! – вы чуть ли не выкрикиваете слова.", Message.MessageType.yellow);
                step = 119;
                break;
            case 119:
                chatScript.SendMessageToChat(-1,"-Ладно, раз вы так сильно хотите помочь. Следуйте за мной.", Message.MessageType.white);
                step = 120;
                break;
            case 120:
                chatScript.SendMessageToChat(-1,"*Сварог почти наугад мешает микстуры и мелит травы в ступке*", Message.MessageType.green);
                step = 121;
                break;
            case 121:
                chatScript.SendMessageToChat(-1,"-Вот и снадобье. Спасибо за вашу помощь. - говорит человек и убирает снадобье в шкафчик.", Message.MessageType.white);
                step = 122;
                break;
            case 122:
                chatScript.SendMessageToChat(-1,"-Подождите! А как же мой сын?- вас начинает переполнять злоба.", Message.MessageType.yellow);
                step = 123;
                break;
            case 123:
                chatScript.SendMessageToChat(-1,"-Ах да, ваш сын. ", Message.MessageType.white);
                step = 124;
                break;
            case 124:
                chatScript.SendMessageToChat(-1,"Знахарь достает из другого шкафчика горсть чего-то и передает вам.", Message.MessageType.red);
                step = 125;
                break;
            case 125:
                chatScript.SendMessageToChat(-1,"-Вашему сыну просто напекло голову. Пусть попьет этот чай и все будет хорошо. Однако, смотря на ваши навыки могу предложить вам работу – вы помогаете мне варить снадобья, и тем самым учитесь их варить.", Message.MessageType.white);
                step = 126;
                break;
            case 126:
                chatScript.SendMessageToChat(13,"-Может быть. Я подумаю. – только и успевает слететь с ваших уст как вы выбегаете из избы и несетесь домой. К вашему счастью чай помог сыну.", Message.MessageType.yellow);
                healer.SetActive(false);
                step = 127;
                break;
            case 127:
                chatScript.SendMessageToChat(29,"Следующие три дня проходят мимолетно. Сварог помогал в разных лавках и подзаработал немного монет.", Message.MessageType.red);
                step = 128;
                break;
            case 128:
                chatScript.SendMessageToChat(43,"День 10", Message.MessageType.green);
                step = 129;
                break;
            case 129:
                chatScript.SendMessageToChat(-1,"Вечер", Message.MessageType.green);
                step = 130;
                break;
            case 130:
                chatScript.SendMessageToChat(-1,"После работы вы возвращаетесь домой и видите столпотворение на площади. Вы подходите и слышите глашатая.", Message.MessageType.red);
                step = 131;
                break;
            case 131:
                chatScript.SendMessageToChat(-1,"-Люди добрые. Будьте готовы, ибо войска вражеские уже близко. Должны мы защитить город этот и землю нашу.", Message.MessageType.grey);
                step = 132;
                break;
            case 132:
                chatScript.SendMessageToChat(-1,"Слова человека заставили ваше сердце неприятно забиться. ", Message.MessageType.red);
                step = 133;
                break;
            case 133:
                chatScript.SendMessageToChat(-1,"Бывает, среди чистого неба пронесется гром. Нечто такое ты не ожидаешь. И именно поэтому это пугает еще сильнее.", Message.MessageType.red);
                step = 134;
                break;
            case 134:
                chatScript.SendMessageToChat(33,"За вашей спиной раздался ужасающий взрыв.", Message.MessageType.red);
                step = 135;
                break;
            case 135:
                chatScript.SendMessageToChat(-1,"*грохот молнии*", Message.MessageType.green);
                step = 136;
                break;
            case 136:
                chatScript.SendMessageToChat(36,"В густом лесу у языческого алтаря молится некто в мантии. Кто-то делает приношение идолу.", Message.MessageType.red);
                step = 137;
                break;
            case 137:
                chatScript.SendMessageToChat(33,"Вы оборачиваетесь и видите как раз за разом в стены города бьет молния. Становиться ясно что дело принимает ужасный оборот. Вы бросаетесь бежать к семье.", Message.MessageType.red);
                step = 138;
                break;
            case 138:
                chatScript.SendMessageToChat(23,"*проносится улица*", Message.MessageType.green);
                step = 139;
                break;
            case 139:
                chatScript.SendMessageToChat(24,"*и ещё одна*", Message.MessageType.green);
                step = 140;
                break;
            case 140:
                chatScript.SendMessageToChat(43,"*как же далеко мой дом*", Message.MessageType.green);
                step = 141;
                break;
            case 141:
                chatScript.SendMessageToChat(-1,"Лязганье мечей. Блеск огня. Крики агонии. Пока вы бежите все это сопровождает каждый ваш шаг. Вы вспоминаете о местах которые вы посещали, возможно вы сможете найти сейчас там что-то полезное.", Message.MessageType.red);
                step = 142;
                break;
            case 142:
                chatScript.SendMessageToChat(-1,"Вы бежите домой, понимая что на это времени нет. Снова. Опять. Это чувство обволакивающее все сердце, слишком неуловимое чтобы его описать. Охватывающая вас паника нарастает с каждым шагом приближения к вашему дому. ", Message.MessageType.red);
                step = 143;
                break;
            case 143:
                chatScript.SendMessageToChat(-1,"И вот паника сменяется гневом, таким диким, таким безжалостным. Естественно. Других эмоций в такой момент существовать не может. Вы видите как несколько ублюдков пытаются ворваться в ваш дом. ", Message.MessageType.red);
                step = 144;
                break;
            case 144:
                chatScript.SendMessageToChat(27,"*Бой*", Message.MessageType.green);
                step = 145;
                break;
            case 145:
                chatScript.SendMessageToChat(-1,"На помощь противнику приходят еще несколько человек. Вы не справляетесь. Вас оттесняют. Вы из последних сил защищаете самое дорогое что у вас есть, сокровище ценнее любого драгоценного камня. И вдруг вспышка боли пронзает вашу грудь. Один из них ударил со спины копьем в самое сердце. Вы начинаете терять сознание. Звук ломания дерева. Женские крики. Глаза перестают видеть. Последнее что вы чувствуете – влажный ручей на лице. Видимо пошел дождь.", Message.MessageType.red);
                step = 146;
                break;
            case 146:
                chatScript.SendMessageToChat(0,"Тьма. Опять. Будто обычный сон напал на тебя и ты не можешь вырваться из его цепких лап. Даже не пошевелиться. Нарастающий гул в голове выбивает вас из покоя. Это роятся мысли. И все как один твердят – виновен. ", Message.MessageType.red);
                step = 147;
                break;
            case 147:
                chatScript.SendMessageToChat(-1,"Словно тысячи мечей пронзают голову. Покой окончательно покинул вас, оставив лишь гнев. Гнев и обиду. На себя, на свою беспомощность. ", Message.MessageType.red);
                step = 148;
                break;
            case 148:
                chatScript.SendMessageToChat(-1,"НЕ СПАС! ОПОЗДАЛ! СЛАБЫЙ! БЕСПОЛЕЗНЫЙ! ", Message.MessageType.yellow);
                step = 149;
                break;
            case 149:
                chatScript.SendMessageToChat(1,"Еще мгновенье и эти мысли сведут вас с ума. Вспышка.", Message.MessageType.red);
                step = 150;
                break;
            case 150:
                chatScript.SendMessageToChat(-1,"Снова этот свет.", Message.MessageType.red);
                step = 151;
                break;
            case 151:
                chatScript.SendMessageToChat(-1,"-Такой... Яркий?", Message.MessageType.yellow);
                chatScript.SendMessageToChat(-1,"Однозначно он стал ярче. Теперь это не лучина, а факел. И как только свет стал ближе, вы поняли почему он так сиял. ОН источал ярость. Бушующий огонь – яростный настолько что способен сжечь до тла всё, даже самого себя. Вот как. Ты такой же….", Message.MessageType.red);
                step = 152;
                break;
            case 152:
                chatScript.SendMessageToChat(-1,"Вы касаетесь огня и сознание снова начинает угасать. В последние секунды вы слышите шепот. Едва различимый. Из всех слов вы смогли различить только «Север» и «найди».  Шепот прекратился и вы окончательно впали в забытие.", Message.MessageType.red);
                step = 153;
                break;
            case 153:
                chatScript.SendMessageToChat(2,"Резкий вздох. Вскочивши на месте вы осознали что можете двигаться. Тело. Оно целое, даже дыры в груди больше нет. ", Message.MessageType.red);
                step = 154;
                break;
            case 154:
                chatScript.SendMessageToChat(16,"Вы резко поднимаетесь и бежите в дом. Ха, ну конечно, было глупо надеяться. Тело вашей жены было чуть ли не у порога. Распластана по полу. Изуродована порезами. Лицо девушки было настолько истерзано что вас стошнило. Слезы сами начали течь по вашему лицу. Отчаянный крик разорвал пелену тишины покрывшую город. Крик боли.", Message.MessageType.red);
                step = 155;
                break;
            case 155:
                chatScript.SendMessageToChat(-1,"Только когда обессилев упали на земь, мысль пронеслась в голове. Сын. Где он? ", Message.MessageType.red);
                step = 156;
                break;
            case 156:
                chatScript.SendMessageToChat(-1,"*Обыск всего города*", Message.MessageType.green);
                step = 157;
                break;
            case 157:
                chatScript.SendMessageToChat(-1,"К превеликому сожалению, обыскав город, мальчишку вы так и не нашли. Ваше и без того израненное сердце просто не понимало что ему чувствовать. Вы готовы были сдаться. Но вдруг в голове сами всплыли слова. Север. Найди.", Message.MessageType.red);
                step = 158;
                break;
            case 158:
                chatScript.SendMessageToChat(30,"Если тот, кто сказал эти слова смог оживить меня после ранения в сердце, значит он что-то знает. Ничего не остается, лишь довериться странному голосу из сна. Вы направляетесь к воротам города. Ваш путь лежит на север.", Message.MessageType.red);
                step = 159;
                break;
            case 159:
                chatScript.SendMessageToChat(28,"Конец Демоверсии", Message.MessageType.green);
                step = 160;
                break;
            case 160:
                chatScript.SendMessageToChat(3,"Tales of Svarog", Message.MessageType.red);

                chatScript.SendMessageToChat(-1,"The end is just the beginning", Message.MessageType.red);
                break;
        }
    }
}
	