**Лабораторна робота № 1**<br>
**Завдання:**

Графічний редактор повинен мати систему для створення, відображення та управління геометричними фігурами.
Користувач повинен мати можливість динамічно створювати різні типи фігур, такі як трикутник, сфера та квадрат,
а також здійснювати з ними різні операції.

1. **Створити підсистему геометричних фігур**
 - створити інтерфейс IShape;
 - до інтерфейсу IShape додати метод Render(), який повертає об`єкт string;
 - створити класи, які будуть реалізовувати інтерфейс IShape (Sphere, Squad, Triangle);
2. **Додати підсистему створення геометричних фігур з використанням паттернів проектування**
**Фабричний метод та Абстрактна фабрика**
 - для фабричного методу:
  - створити інтерфейс ICreator;
  - до інтерфейсу ICreator додати метод FactoryMethod(), який повертає інтерфейс IShape (об`єкт класу, який реалізовує даний інтерфейс);
  - створити класи SphereFactory, SquadFactory, TriangleFactory,
    які реалізовують інтерфейс ICreator;
  - в кожному класі-фабриці в методі FactoryMethod() передбачити створення відповідної фігури;
 - для абстрактної фабрики:
  - створити інтерфейс IShapeAbstractFactory, який містить методи:
    CreateTriangle(), CreateSphere(), CreateSquad(). Кожний з цих методів повертає інтерфейс IShape (об`єкт класу, який реалізовує даний інтерфейс);
  - в методах CreateTriangle(), CreateSphere(), CreateSquad() передбачити створення відповідних об'єктів класів;

**Лабораторна робота № 2** <br>
**Завдання:**

В грі жанру стратегії необхідно створювати юнітів за заздалегіть заданими архетипами,
наприклад: вміє атакувати в ближньому та дальному бою, вміє застосовувати магію та атакувати в ближньому бою і т.д.
Кожний юніт повинен мати ім'я та список здібностей, які попередньо йому були додані.
Також в грі повина бути можливість обирати юніта та роботи його копію. Копіювання повинно бути двох типів: часткове та повне.
При здійсненні повного копіювання, ім'я юніта та його всі властивості, передаються новій копії,
а при частковому копіювання - новому юніту передається лише ім'я.

Для підсистеми створення юнітів за заздалегіть заданими архетипами використати шаблон проектування **Будівельник**, 
який дозволяє створювати створювати юнітів за визначеним шаблоном.
Для підсистеми копіювання юнітів використати шаблон проектування **Прототип**, 
який дозволяє робити часткову та повну копію юніта.

1. **Додати підсистему юнтів, яких можна в подальшому створювати**
- додати інтерфейс IUnit;
- до інтерфейсу IUnit додати метод AddAbility(string ability);
- створити клас Unit, який реалізовує інтерфейс IUnit, додати приватний список List<string> abilities;
2. Створити підсистему здібностей юнітів.
- додати інтерфейс IAbility
- додати класи MeleeAttack, RangedAttack та MagicAttack, які реалізовують інтерфейс IAbility
3. **Будівельник**:
- додати підсистему побудови юнтів з використанням паттерну проектування Будівельник
- створити інтерфейс IBuilder з методами, які будуть додавати здібності юнітам:
- створити клас Builder, який реалізовує інтерфейс IBuilder:
- створити клас Director, який може створювати юнітів за заздалегіть заданим архетипом
4. **Прототип**:
- Створити підсистему копіювання юнітів з використанням патерну Прототип
- створити інтерфейс IClonable з методам PartialCopy() та DeepCopy(), які повертають тип object
- реалізувати інтерфейс IClonable в класі Unit
- 
**Лабораторна робота № 3**<br>
**Завдання:**
1. В грі необхідно створювати NPC (охоронець, продавець, місцевий мешканець тощо),
в яких є паттерни поведінки, зокрема: торгівля, пересування та діалог з гравцем. В залежності від певних умов,
паттерни поведінки під час гри можуть змінюватись. Необхідно створити гнучку систему, яка дозволить легко змінювати поведінку NPC
та відкритою до масштабування.
2. В грі потрібно додати можливість поставити її на паузу. Під час паузи, ігрові об`єкти повинні перестати рухатись, програвати анімації та ефекти.
Слід врахувати, що ігрові елементи можуть мати різну логіку руху (анімація, фізика, візуальні ефекти)
3. Для спрощення процесу побудови рівнів в ігровому редакторі під час створення NPC,
необхідно додати можливість для розробників скасувати попередні дії зі створення або видалення NPC.

Для підсистеми створення NPC з динамічними паттернами поведінки, використати шаблон проектування **Стратегія**,
який дозволяє змінювати поведінку об`єктів під час виконання програми.

Для підсистеми паузи гри, використати шаблон проектування **Спостерігач**,
який дозволяє здійснювати інформування всіх зареєстрованих об`єктів щодо початку чи закінчення паузи

Для спрощення процесу побудови рівнів, додати підсистему, яка дозволяє здійснювати Undo/Redo дії під час створення NPC.
Для цього використати шаблон проектування **Команда**

1. **Створити підсистему NPC, додати інтерфейс ICitizen та реалізувати його в класах Citizen, GuardianCitizen, PeasanCitizen, TraderCitizen.**
2. **Для шаблону проектування "Стратегія"**:
 - використовуючи паттерн Стратегія, створити підсистему реалізації шаблонів поведінки для NPC, які легко можна змінити.
 - додати інтерфейс IDialogBehavior. Додати клас OpenToDialogBehavior, який реалізовуватиме цей інтерфейс
 - додати інтерфейс ITradeBehaviour. Додати класи OpenToTradeBehavior та CloseToTradeBehavior які реалізовуватимуть цей інтерфейс
 - додати інтерфейс IMovementBehaviour. Додати класи StayOnOneSpotBehaviour та PatrolingBehavior які реалізовуватимуть цей інтерфейс
 - в інтерфейсі ICitizen додати методи зміни поведінки:
   - void ChangeTradBehaviour(ITradeBehaviour tradeBehaviour);
   - void ChangeDialogBehaviour(IDialogBehaviour dialogBehaviour)
   - void ChangeMovementBehaviour(IMovementBehaviour movementBehaviour);
 - до класу Citizen додати приватні поля ITradeBehaviour, IDialogBehaviour, IMovementBehaviour та змінювати їх у відповідних методах
3. **Для шаблону проектування "Команда"**:
 - створити підсистему відміни останніх дій користувача під час роботи з NPC, для цього використати шаблон Команда
 - створити інтерфейс ICommand та реалізувати його в класах UndoUnitCreationCommand, UndoUnitDeletionCommand
 - під час створення або видалення NPC - зберігати дану інформацію в Queaue<ICommand> та за необхідності виконувати команди з черги
4. **Для шаблону проектування "Спостерігач"**:
 - створити підсистему паузи в грі, для цього використати паттерн Спостерігач.
 - cтворити інтерфейс IObserver з методами Subscribe(IListener listener), Unsubscribe(IListener listener), SendMessage(IMessage msg)
   інтерфейс реалізувати в класі Observer
 - створити інтерфейс IListener з методом Receive(IMessage msg) та реалізувати його в класі Citizen
 - створити інтерфейс IMassage та реалізувати його в класі GamePauseMessage
 - в класі Citizen, в методі Receive обробляти інформацію  про паузу під час отримання повідомлення GamePauseMessage

**Лабораторна робота № 4**<br>
**Завдання**
1. В мобільному застосунку онлайн-магазині, після закриття меню редагування профіля користувача, з метою дотримання надійності та якості роботи застосунку,
потрібно виконати ряд наступних заходів: вивільнити ресурси в оперативній памяті, зупинити асинхронні операції та зберегти дані про дії користувача в меню профіля.
2. В системі здійснення транзакцій, яка підтримує кілька способів оплати (кредитна картка, PayPal, криптовалюта)
необхідно реалізувати можливість підтримки всіх наявних видів оплати. Слід врахувати те, що перед підтвердженням оплати,
система включає в себе комплекс підготовчих та валідаційних методів, таких як підтвердження можливості оплати та безпосередня оплата

Для підсистеми, яка здійснює належний контроль за правильним виходом з екрану редагування профілю користувача, застосувати шаблон
проектування **Макрокоманда**, який дозволить створювати об`єкт зі списком команд, які виконуватимуть вивільнення ресурсів, зупинку асинхронних операцій та збереження даних

Для підсистеми, яка забезпечує контроль та виконання транзакцій з різними способами оплати, використати паттерн проектування **Шаблонний метод**,
який дозволить вибудувати структуру з порядком виконання платіжних операцій, яка буде підтримувати можливість перевизначення певних методів залежно від способу оплати.

1. **Для шаблону проектування "Макрокоманда"**:
Створити підсистему виконання макрокоманд
  - додати класи ResourceReleaseCommand, UserProfileSaveCommand, AsyncOperationCancelCommand, які реалізовують інтерфейс ICommand
  - додати клас MacroCommand, який реалізовує інтерфейс ICommand та може отримувати список підкоманд до виконання
2. **Для шаблону проектування "Шаблонний метод"**:
Створити підсистему виконання онлайн платежів з застосуванням паттерну шаблонний метод
  - додати клас PaymentProcessor, та підкласи CreditCardPayment, PayPalPayment, CryptoPayment
  - до класу PaymentProcessor додати методи:
   - protected abstract void ValidatePayment();
   - protected abstract void ExecuteTransaction();
   - private void SendConfirmation();
  - в підкласах перевизначити методи ValidatePayment() та ExecuteTransaction()


**Лабораторна робота № 5**<br>
**Завдання**
1. Для мобільного застосунку необхідно реалізувати глобальну систему життєвого циклу, в якому можна здійснювати контроль запуску застосунку,
управлянням ресурсами та ініціалізації внутрішніх сервісів.
2. Для мобільного застосунку необхідно реалізувати комплексну систему входу користувача в мережу. Вхід користувача повинен відбуватися в декілька етапів.
Поки попередній етап не буде успішним, система не повинна переходити до наступного етапу.
3. Для зручного доступу до користувачів за спільними інтересами в застосунку застосовано алгоритм breadth-first-search.
Розробити систему, яка дозволить швидко та ефективно ітерувати граф з даними

Для підсистеми, які відповідає за управлінням життєвим циклом застосунку, застосувати паттерн проектування **Стан**, який дозволить 
розробнику визначати стани та умови переходу між ними.

Для підсистеми аутентифікації та авторизації користувача, використати паттерн проектування **Ланцюжок відповідальності**, який дозволить послідовно виконувати вхід користувача
та переходити до наступного етапу за умови успішного завершення попереднього етапу

Для підсистеми пошуку користувачів за спільними інтересами, застовувати паттерн проектування **Ітератор**, який дозволить ітерувати колекцію користувачів зі спільними інтересами

1. Для шаблону проектування **Стан**: 
  Створити підсистему глобальних станів застосунку з використанням шаблону проектування **Стан**
  - додати інтерфейс IState з методами Enter(), Exit()
  - додати класи BootstrapState, ResourcesLoadingState, AppLoopState, ResourcesUnloadingState, які реалізовують інтерфейс IState
  - додати клас StateMachine, який управляє змінами станів
2. Для шаблону проектування **Ланцюжок відповідальності**: 
  З використанням шаблону Ланцюжку відповідальності, створити підсистему послідовного входу користувача в мережу
  - додати клас Handler та підкласи AuthenticationHandler, AuthorizationHandler, LiggingHandler
  - в класі Handler передбачити метод SetNext(Handler next), який отримує посилання на наступний Handler та метод Handle(),
який повинен містити логіку переходу до наступного Handle
3. Для шаблону проектування **Ітератор**:
   З використанням шаблону Ітератор, створити підсистему послідовного доступу до елементів колекції, не розкриваючи її внутрішню структуру.
  - додати клас Iterator, який реалізовує інтерфейс IEnumerator<T>
  - додати клас IteratorAggragate, який реалізовує інтерфейс IEnumerable<T> та метод List<T> GetItems();
  - додати підклас UsersCollection до класу IteratorAggragate, який буде відповідальним за додавання нових елементів
  - додати підклас UserIterator до класу Iterator, який буде відповідальним за поточний та наступний елемент в колекції

**Лабораторна робота № 6**<br>
**Завдання**
1. Для спрощеного тестування гри необхідно реалізувати сервіс обробки та виконання команд через консоль розробника.
Сервіс повинен бути зрозумілим, стійким до змін та має легко масштабовуватись
2. Для гри необхідно розробити систему, яка реалізовувує логіку обробки взаємодії користувача з елементами інтерфейсу
(введення тексту, натиснення на кнопки тощо). При цьому необхідно забезпечити відокремлення бізнес-логіки інтерфейсу користувача
з самими елементами інтерфейсу, які відображаються на екрані

Для підсистеми обробки консольних команд, застосувати патерн **Інтерпретатор**, який дозволить опрацьовувати консольні команди
з метою спрощення тестування продукту

Для підсистеми взаємодії користувача з елементами інтерфейсу застосувати паттерн **Посередник**, який дозволить реалізувати стійкий 
та відкритий до масштабування код інтерфейсу користувача.

1. Для шаблону проектування **Інтерпретатор**:
  Створення підсистеми інтерпретатора вводу користувача через консоль розробника
  - додати інтерфейс IExpression з методом Interpret()
  - додати клас Context з полями string Name, string Amount
  - додати класи SetHealthExpression, SetLevelExpression, SetMoneyExpression, CreateDefaultCharacterNonTerminal. Класи повинні реалізувати інтерфейс IExpression
  - додати клас CommandParser, з методом IExpression Parse(string command, string amount),
який в залежності від отриманої інформації в параметрах буде повертати відповідний об'єкт, який реалізовує інтерфейс IExpression'
2. Для шаблону проектування **Посередник**:
  Створення підсистеми обробки вводу користувача під час його взаємодії з елементами інтерфейсу
  - додати інтерфейс IMediator, з методом Notify(object sender, string payload)
  - додати клас MainMenuMediator, який реалізовує інтерфейс IMediator
  - додати клас BaseComponent з методом SetMediator(IMediator mediator)
  - додати підкласи MainMenuButton та SettingsButton до BaseComponent. В підкласах реалізувати методи звернення до медіатора в залежності від вводу користувача
  - в класі MainMenuMediator здійснити обробку вводу користувача

**Лабораторна робота № 7**<br>
**Завдання**
1. Створити систему управління блогом у вебдодатку, яка дозволяє: створювати, редагувати та зберігати статті з можливістю повернення до попередніх версій.
2. Створити систему, яка дозволить збирати статистику про статті (підрахунок слів, перевірка кількості зображень) за допомогою окремих модулів
без зміни основного коду статті.

Для системи управління блогом застосувати паттерн проектування **Зберігач**, який дозволить здійснювати управління життєвим циклом статей у веб-додатку

Для підсистеми збору статистики про статті, використати паттерн проектування **Відвідувач**, який дозволить здійснювати збір статистики без зміни основного коду

1. Створити підсистему Article
- додати клас Article
- до класу Article додати підкласи ShortReadArticle, LongReadArticle
2. Для шаблону проектування **Зберігач**:
Створити підсистему збереження, відтворення, та відміни змін статей з застосуванням шаблону Знімок
- додати клас ArticleMemento та реалізувати інтерфейс IMomento з методами string GetName(), Article GetState()
клас має посилання на Article.
- додати клас Originator, який буде зберігати поточний стан Article. Він повинен створювати, зберігати та відновлювати Article
- додати клас Caretracker, який з допомогою Originator буде здійснювати управління статтями та їх станами.
3.Для шаблону проектування **Відвідувач**:
Створити підсистему управління статистикою статей. Для цього застосувати шаблон Відвідувач
- додати інтерфейс IComponent з методом Accept(IVisitor visitor);
- реалізувати IComponent в класах ShortReadArticle, LongReadArticle
- додати інтерфейс IVisitor з методами void VisitLongReadArticle(LongReadArticle article),
void VisitShortReadArticle(ShortReadArticle article). В реалізації викликати відповідний до відповідальності класу метод візитора;
- додати класи ImageCountVisitor, WordsCountVisitor, які реалізовують інтерфейс IVisitor та
містять в собі логіку збирання статистика

**Лабораторна робота № 8**<br>
**Завдання**
Для ігрового рушія необхідно додати наступні функції:
- доадти можливість створювати білди для різних платформ. Дана функція повинна бути адаптивна до змін платформ, для яких створюються білди.
- під час створення білдів, передбачити опцію завантаження ресурсів перед початком процесу білдингу.
- додати зручний програмний інтерфейс (API) до існуючої системи аніматор.
- для API підсистеми анімацій, додати можливість створення візуальних ефектів після програвання анімації
- додати можливість динамічно надавати системі частинок нові ефекти
- для бібліотеки робити з фізикою, необхідно адаптувати методи, які імітують поштовх об'єкту

Для створення білдів для різних платформ, використати **паттерн проектування Міст**. Це дозволить створювати білді для різних платформ,
за необхідності додавати нові платформи.

Для роботи з підсистемою анімацій використати **паттерн проектування Фасад**, який дозволить отримати власний обробник анімацій

Для опціонального додавання візуальних ефектів, використати **паттерн проектування Замісник**, який дозволить доповнювати існуючу логіку без зміни основного коду

Для підсистеми частинок викорстати **паттерн проектування Декоратор**, який дозволить динамічно змінювати візуальні ефекти та надавати їм нові властивості'

Для роботи з бібліоткею симуляції фізики, використати **паттерн проектування Адаптер**, який дозволить адаптувати існуючі методи в бібліотеці під власні потреби

1. **Для шаблону проектування Міст**: 
  Додати підсистему створення білдів в залежності від обраної платформи з використанням шаблону Міст
  - додати інтерфейс IPlatform з методом Build()
  - додати класи IOSPlatform та AndroidPlatform, які реалізовують інтерфейс IPlatform
  - додати клас TargetPlatformBuilder, який місить поле IPlatform та метод віртуальний метод Build()
  - додати підклас TargetPlatformBuilderWithResources до TargetPlatformBuilder,
  в якому передбачити завчасне створення ресурсів перед виклоиом базового методу Build()
2. **Для шаблону проектування Фасад**: 
  Для аніматора, створити програмний інтерфейс для програвання анімацій гравця. Для цього застосувати шаблон Фасад
  - додати інтерфейс IPlayerAnimator з методами Move() та Heal()
  - додати клас PlayerAnimatorFacade, який реалізовує інтерфейс IPlayerAnimator
  - в класі PlayerAnimatorFacade додати поле Animator та з його допомогою викликати необхідні анімації в методах Move() та Heal()
3.**Для шаблону проектування Замісник**:  
  Для програвання візуальних ефектів після анімації, створити підсистему з використанням шаблону Замісник
  - додати клас, який отримує посилання на IPlayerAnimation та який реалізовує інтерфейс IPlayerAnimation
  - після програвання анімацій Move та Heal, відображати візуальні ефекти
4. **Для шаблону проектування Декоратор**: 
  Для візуальних ефектів частинок:
 - створити базовий клас Decorator, та похідні класи ColorDecorator, SizeDecorator з методом ApplyVisualEffect()
 - в залежності від дій користувача, передбачити додавання відповідних візуальних ефектів
5.**Для шаблону проектування Адаптер**:  
  Для роботи з бібліотекою по симуляції фізики
 - додати клас ForceSimulationBehaviourAdapter, який має поле ForceSimulationBehaviour, та здійснює виклик методу AddForce
