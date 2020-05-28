using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkTerritories.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Water = table.Column<string>(nullable: true),
                    PlayGround = table.Column<string>(nullable: true),
                    SportsGround = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331740L, "Главный вход в парк расположен со стороны улицы Косыгина, рельеф местности спокойный, резкопересечённый, с перепадом высот до 30 м, площадки и дорожки выложены плиткой и асфальтом, за корпусами расположен парк с многолетними деревьями", "Памятник садово-паркового искусства – «Парк Дворца творчества детей и юношества» по адресу ул.Косыгина д.17", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562555L, "1-ый Вешняковский переулок", "Сквер по 1-му Вешняковскому проезду", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562557L, "Улица Вострухина", "Сквер у платформы Вешняки", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562559L, "Улица Гурьянова,улица Кухмистерова", "Сквер у кинотеатра Тула", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171572298L, "улица Молодцова", "Сквер по улице Молодцова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171594560L, "город Москва, Нагорный бульвар, дом 3", "Сквер по Нагорному бульвару", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171624104L, "Сквер по 2-ой Песчаной улице", "Сквер по 2-ой Песчаной улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171624212L, "Сквер по Песчаной улице", "Сквер по Песчаной улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171624504L, "улица Дыбенко дом 34", "Сквер Березовая роща", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171628003L, "Улица Большая академическая", "Сквер по улице Большая Академическая", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171629734L, "Ландшафты Москвы примыкающие к застройке Ходынского поля", "Бульвар Исторические ландшафты Москвы примыкающие к застройке Ходынского поля", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171631500L, "Вдоль 1-го Саратовского проезда", "Сквер по 1-му Саратовскому проезду", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171669835L, "проезд Нансена пересечение с улицей Снежная", "Сквер у Капустинского пруда", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171673864L, "улица Новгородская, дом 32", "Сквер по улице Новгородская, дом 32", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171673868L, "Между улицей Бестужевых и улицей Римского-Корсакова", "Сквер между улицей Бестужевых и улицей Римского-Корсакова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 272411215L, "Между Привольной улицей и Авиаконструктора Миля", "Березовая роща микрорайона 4 Жулебино", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 272622467L, "Сивяков переулок на пересечении улица Земляной Вал и Николоямской набережной", "Озелененная территория на пересечении улицы Земляной Вал и Николоямской набережной", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 272682099L, "1-я Брестская улица", "Триумфальная площадь", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 272715548L, "улица Заповедная от проезда Дежнева до Кольской улицы", "Сквер по Заповедной улице", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 272727875L, "Сквер по улице Малахитовая", "Сквер по улице Малахитовая д. 4-6", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 272767784L, "Вдоль Донецкой улицы", "Сквер «Озелененная территория ул. Донецкая»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 273428603L, "город Москва, между улицей Бартеневской, улицей Горчакова, улицей Адмирала Лазарева, улицей Адмирала Руднева", "Рекреационная зона между комплексами «А» и «Б»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 273428619L, "город Москва, между улицей Адмирала Лазарева и улицей Горчакова", "Парк 1-2 очереди в Детском ландшафтном парке в Южном Бутово", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 273573882L, "расположен между Люблинской улицей и 11-й улицей Текстильщиков", "парк Садки", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 273895912L, "набережная Тараса Шевченко между домами 23 и 25", "Сквер у памятника П.И.Багратиону", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 277904807L, "Семёновская площадь, дом 4", "Сквер на Семеновской пл.(народный парк)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562552L, "Есенинский бульвар", "Есенинский бульвар", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 277905025L, "Улица 9-я Парковая, дом 21, дом 26", "Сквер у станции метро «Первомайская»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562529L, "Улица Маршала Чуйкова дом 7", "Сквер у кинотеатра Будапешт", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562508L, "Первомайская улица", "Объект озеленения Зона Серебряно-Виноградных прудов", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489454L, "улица Самотечная, дом 17А", "Ново-Екатерининский сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489455L, "улица Самотечная", "Самотечный бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489518L, "улица Дурова дом 2", "Екатерининский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489519L, "Болотная площадь, дом 6-16", "Болотный сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489521L, "Строгинский бульвар", "Объект озеленения разделительной полосы от улицы Кулакова до Неманского проезда", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489522L, "улица 1905 года, улица Трехгорный вал, Шмитовский проезд", "Сквер у памятника Мост памяти 1905 года", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489529L, "улица Спиридоновка дом 6", "сквер у памятника Александра Блоку", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489530L, "Шитова набережная, владение 72", "Сквер на Шитовой набережной", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489537L, "улица Измайловский Вал", "Хапиловский сквер южный", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489539L, "Пересечение улицы Преображенский Вал и улицы Девятая Рота", "Хапиловский сквер северный", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489547L, "Преображенская площадь", "Сквер, прилегающий к Храму Преображения Господня (Народный парк)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489604L, "улица Байкальская", "Бульвар по Байкальской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489648L, "Сиреневый бульвар", "Сиреневый бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489989L, "город Москва, улица Профсоюзная дом 156 корпус 1", "Сквер между улицами Теплый Стан и Генерала Тюленева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171492539L, "Суворовская площадь", "Сквер на Суворовской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171492703L, "улица Чаянова, Миусская площадь, дом 2", "Сквер на ул.Чаянова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171492953L, "Антроповский сквер", "Антроповский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171493185L, "улица Яузская, дом 6", "Сквер на Интернациональной улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171532075L, "Пересечение ул Юности с Жемчуговой аллеей", "Сквер по улице Юности", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562499L, "Улица Судакова", "Сквер по ул.Судакова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562500L, "Измайловский бульвар", "Измайловский бульвар", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562504L, "улица Неглинная", "Бульвар на Неглинной улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562505L, "улица Новослободская дом 58", "парк Новослободский", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562506L, "улица Мясницкая дом 1", "Сквер по улице Мясницкая, дом 1", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562507L, "Бульвар имени Николая Химушина", "Бульвар имени Николая Химушина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171562515L, "На пересечении улиц Юных Ленинцев, Маршала Чуйкова", "Сквер у кинотеатра Высота", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489453L, "Цветной бульвар", "Цветной бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 277920374L, "улица Максимова дом 2- 4", "Парк Лесной массив по ул. Максимова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278047483L, "Электролитный проезд, 1В", "Парк Вершинина", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281526374L, "Красноказарменная улица, владение 1", "Усадьба «Лефортово»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281574236L, "ст м Волоколамская", "Объект озеленения станция метро Волоколамская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281574237L, "Пересечение улиц Берзарина и Народного Ополчения", "Скверы Берзарина", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281574251L, "Бульвар Генерала Карбышева", "Бульвар Генерала Карбышева", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281574255L, "улица Тухачевского дом 19", "Сквер по улице Тухачевского дом 19", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281574257L, "Объект озеленения разделительной полосы от улицы Дубравная до дома 47 по улице Митинская", "Объект озеленения разделительной полосы от улицы Дубравная до дома 47 по улице Митинская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281574258L, "Объект озеленения разделительной полосы от улицы Дубравная до дома 25 по улице Митинская", "Объект озеленения разделительной полосы от улицы Дубравная до дома 25 по улице Митинская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281594892L, "Улица Новопесчаная, дом 12", "Мемориальный парк героев Первой Мировой войны", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281594923L, "между улицей Куусинена и проездом Берёзовой Рощи", "Парк «Березовая роща»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281605480L, "ул Свободы д 2", "Парк долины реки Химки", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281606071L, "Новодевичий проезд", "парк Новодевичьи пруды", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281606102L, "Большая Пироговская улица", "Сквер Девичье поле", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281629338L, "Измайловское шоссе, Семёновский проезд", "Семёновский парк", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281685588L, "улица Алексея Свиридова 4", "Лесной массив между ул. Алексея Свиридова и Рублевским шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281685727L, "пересечение Электродной улицы и шоссе Энтузиастов", "Парк у Владимирского пруда", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281685740L, "Сигнальный проезд 13", "Долина реки Лихоборки", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281691717L, "Сквер у Миллионного моста", "Сквер у Миллионного моста", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281691718L, "Свободный проспект, владение 11-17", "Ивановский лесопарк", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281691942L, "3-я Северная линия", "Сквер по 3-й Северной линии", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281691972L, "1-я линия", "Сквер по 1-й Северной линии", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281691980L, "Северный проезд", "Сквер около Водной станции", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281705113L, "улица Свободы", "Озелененная территория по ул. Свободы, вл.60-80", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281705519L, "Сквер, расположенный между Малым Гнездиковским и Леонтьевским переулками", "Сквер в Леонтьевском переулке", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281711003L, "город Москва, Ленинский проспект дом 121", "Парк «Усадьба Богородицкое»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281718434L, "Между Боровским шоссе и кинотеатром", "Парк «Центральный» района Солнцево", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281526283L, "улица Белореченская, дом 43", "Парк Дюссельдорфский", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278043810L, "улица Борисовские пруды, дом 6, корпус1", "Борисовские пруды, д.6, кор.1", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281526276L, "улица Верхние Поля, дом 8", "Парк героев Отечественной Войны 1812 года", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281526246L, "Самокатная улица, дом 2, корпус 1", "Парк имени 1-го Мая", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278060724L, "Перовская улица, дом 70", "Сквер у разворотного круга троллейбуса № 53 (народный парк)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278098676L, "между 8-м и 9-м проездом Марьиной Рощи", "Сквер по 8-му и 9-му проезду Марьиной Рощи", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278977321L, "Сквер по улице Бажова", "Сквер по улице Бажова", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278981332L, "Между Ярославским шоссе и улицей Дудинка", "Сквер по улице Дудинка", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278982054L, "между улицей Бориса Галушкина и 1-м Рижским проездом", "Бульвар по Рижскому проезду", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 278992052L, "Сквер между жилыми домами № 24 и №30 по Путевому проезду", "Сквер по Путевому проезду", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279031439L, "Гостиничная улица", "Сквер по Гостиничному проезду", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279032283L, "сквер по Ботнической дом 41", "Сквер на Ботанической улице дом 41", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279033123L, "Ботаническая, 39", "Сквер у кинотеатра Рига", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279033196L, "между улицей Бориса Галушкина и улицей Касаткина", "Сквер по Рижскому проезду продолжение в районе ул. Касаткина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279034867L, "Улица Академика Королева, дом 13", "Сквер «Останкино»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279035945L, "Сквер между проезжими частями Звездного бульвара", "Звездный бульвар", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279037017L, "Улица Вильгельма Пика", "Леоновская роща", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279037544L, "Сквер между улицей Аргуновской и улицей Новомосковской", "Сквер между улицей Аргуновской и улицей Новомосковской", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279037787L, "Сквер на пересечении улиц Академика Королева и 1-й Останкинской", "Сквер на пересечении улиц Академика Королева и 1-й Останкинской", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279100290L, "Каширское шоссе, дом 52", "Сквер ДК «Москворечье»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279137517L, "Сквер напротив улицы Кондратюка, дом 1", "Сквер у кинотеатра «Космос»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279528779L, "Между улицей Амундсена и проездом Нансена", "Сквер по улице Амундсена", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279528785L, "Пересечение улицы Кольской и улицы Вересковой", "Сквер по улице Кольская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279528802L, "Вдоль улицы Серебрякова", "Сквер по проезду Серебрякова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279528878L, "Сквер напротив улицы Снежной", "Сквер по улице Снежная", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 279529084L, "между Ярославской улицей и улицей Константинова", "Ракетный бульвар", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281499818L, "Череповецкой улице дом 17", "Сквер по Череповецкой улице дом 17", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281500467L, "улица Новгородская дом 25", "Сквер по улице Новгородская дом 25", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281512637L, "Расположен между улицей Летчика Бабушкина и Енисейской улицей и улицей Искры и Печорской улицей", "Сквер «Красная дорожка»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281526271L, "улица Гурьянова от дома 25 до 43", "Парк «Печатники»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281740713L, "Загородное шоссе, 2а", "Парк у пруда «Бекет»", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171489390L, "Тверской сквер", "Тверской сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171475292L, "Улица Исаковского, дом 16 до улицы Марашала Катукова, дом 11", "Объект озеленения от улицы Исаковского дом 16 до улицы Маршала Катукова дом 11", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64856433L, "улица Свободы, владение 50-70", "Захарковский залив", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64856438L, "Иваньковское шоссе, владение 2", "Покровский берег (Химки-2)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64856479L, "Прибрежный проезд, владение 5-7", "Зона отдыха «Левобережье»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64856494L, "улица Таганская, дом 15А, стр 1", "Парк «Таганский» («Детский парк им. Прямикова»)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64864009L, "Пересечение улицы Кузьминская, улицы Тополевая и улицы Кузьминский парк, дом 1, строение 2", "Природно-исторический парк Кузьминки-Люблино", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64864023L, "Территория между улицей Изумрудная и улицей 1-я Напрудная", "Сквер по ул. Изумрудная", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64874863L, "улица Марии Поливановой 4", "Сквер по улице Марии Поливановой", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64875029L, "улица Сеславинская, дом 16 - 42", "ул. Сеславинская", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 65016400L, "3-я Подрезковская, 14", "Молжаниновский народный парк", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 91356210L, "улица Верхняя Сыромятническая, дом 2", "Верхний Сыромятнический сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 97488524L, "город Москва, улица Островитянова, улица Академика Арцимовича", "Сквер от ул. Островитянова до ул. Академика Арцимовича, вдоль д. 14 к. 1, 2.", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 128753227L, "пересечение Старопетровского проезда и ул Клары Цеткин", "Старопетровский сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144557071L, "город Москва, улица Кадырова", "Северная зона Большого пруда", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144557374L, "город Москва, улица Кадырова", "Спортивная зона парка Южное Бутово", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144557486L, "город Москва, Проектируемый проезд № 6417", "Правый берег Большого пруда в пойме реки Чуры", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144586183L, "город Москва, улица Южнобутовская", "Левый берег Большого пруда в пойме реки Чуры", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144586202L, "Пересечение Центральной и 1-й Рейсовой улицы до дома №1/21 по 1-й Рейсовой улице и дома №25к1 по Большой Внуковской улице", "Парк «Центральный»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144586219L, "на пересечении улиц шоссе Энтузиастов и улицы Авиамоторная", "Сквер имени М И Калинина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 144586223L, "От Большой Внуковской улицы до дома 3с1 по Центральной улице", "Парк за «КБО» (Комбинат бытового обслуживания)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 145424982L, "Лубянский проезд, 19", "Ильинский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167201291L, "Улица Бахрушина", "Парк «Михайловский сад»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167575498L, "Хамовнический вал дом 24", "Озелененная территория вдоль ул. Хамовнический вал", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167575501L, "Сущевский вал, владение 56", "Фестивальный парк", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167580908L, "Дружинниковская улица д 9 стр 2", "Парк Пресненский", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167581466L, "Миусская площадь у строения 4", "Парк на Миуссах", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64842816L, "Красногвардейские пруды", "Зона отдыха «Красногвардейские пруды»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167590518L, "ул Барклая 9/2", "Сквер у культурного центра Л. Рюминой", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64754166L, "город Зеленоград, 18 микрорайон, напротив корпуса 1824", "Народный парк у корпуса 1824", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64719668L, "Бульвар по улице Серпуховский вал", "Бульвар по улице Серпуховский вал", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64372920L, "город Москва, вдоль улицы Инессы Арманд (от проезда Карамзина до улицы Голубинской)", "Сквер по улице Инессы Арманд", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64524973L, "улица Ставропольская", "Сквер им. Авдеева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64539725L, "Покрышкина 4", "Сквер у ТЦ Звездочка", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592408L, "от Ангелова переулка д 5 до 3-го Митинского переулка д 6к2", "Бульварная зона микрорайона 5", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592443L, "Пятницкое шоссе д45", "Озелененная территория по Пятницкому шоссе микрорайон 4", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592459L, "от ул Дубравная до первого Митинского переулка", "Озелененная территория по Пятницкому шоссе микрорайон 2", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592462L, "Пятницкое шоссе д 29 до д 39", "Озелененная территория по Пятницкому шоссе микрорайона 3", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592472L, "от первого Митинского переулка до д7 по Пятницкому шоссе", "Озелененная территория по Пятницкому шоссе микрорайона 1 до РТС", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592587L, "Новокуркинское шоссе д51", "Бульвар МБ-2 Новокуркинское шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592594L, "Пятницкое шоссе д6 корп8", "Бульварная зона микрорайона 10 «А»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592614L, "от улицы Сходненская до улице Свободы", "сквер между Западным и Восточным мостом", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592622L, "улица Фабрициуса д 20", "Сквер у кинотеатра «Полет»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592626L, "Новокуркинское шоссе от улицы Соколово-Мещерская до улицы Юровская", "Бульвар МБ-5 Новокуркинское шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592628L, "улица Свободы", "улица Свободы от Восточного моста до Химкинского бульвара", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592645L, "ул Туристская д 20", "бульвар по ул Туристская", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592646L, "Новокуркинское шоссе от улицы Юровская до д8корп2 по улице Соловьиная роща", "Бульвар МБ-6 Новокуркинское шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592647L, "ул Планерная д 12", "Озеленённая территория между выходами метро Планерная", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64592876L, "ул Героев Панфиловцев д 8", "Сквер по улице Героев", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597799L, "улица Соколово-Мещерская д2 до д 6", "Бульвар МБ-12", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597815L, "улица Родионовская от д 3 до д 17", "Бульвар ПК-6 по улице Родионовская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597816L, "Химкинский бульвар д 14", "Химкинский бульвар", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597817L, "улица Соловьиная роща д 2-4", "Парк Березовая роща", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597818L, "бульвар Яна Райниса д 2", "бульвар Яна Райниса", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597819L, "улица Соловьиная роща д 6 корп1", "Сад-усадьба микрорайон 14 Новокуркинское шоссе", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64597821L, "ул Героев Панфиловцев д10", "сквер по ул Фомичёвой", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64736237L, "Сквер между Краснобогатырской улицей и улицей Алымова", "Сквер на Алымова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171482454L, "Лаврушинский переулок", "Объект озеленения Лаврушинский переулок, 17", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167590527L, "ул Барклая", "Сквер у магазина «Мебель»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167687174L, "По правую руку при движении по 1-й Останкинской улице от метро ВДНХ", "Парк «Останкино»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169544126L, "от Ленинского проспекта до проспекта Вернадского", "Объект природного комплекса № 143 (Долина р. Самородинки)", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169576052L, "между улицами Достоевского, Образцова и Перуновским переулком", "Сквер на площади Борьбы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169604076L, "Сквер по Черноморскому бульвару", "Сквер по Черноморскому бульвару", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 170023680L, "между Михневских и Загорьевским проездом", "территория вдоль Верхнего и Нижнего Бирюлевских прудов", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 170043299L, "город Москва, улица Бартеневская, дом 11", "Природоохранная зона «Гавриково» в Южном Бутово", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 170144346L, "вдоль улиц Марьинский Парк, Поречная", "Парк 850 - летия Москвы", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 170426655L, "территория прилегающая к новым домам по Берингову проезду", "Сквер «Знаки зодиака»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 170869733L, "На пересечении улиц Волжский бульвар, Юных Ленинцев", "Волжский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171297901L, "Щукинская, д,38", "Озеленённая территория ГКУЗ МГНПЦ борьбы с туберкулезом ДЗМ филиал по СЗАО ПТКД 13", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298226L, "ул Маршала Рыбалко д 1", "Сквер у кинотеатра Юность", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298242L, "ул Пехотная д3", "Озелененная территория ГБУЗ ГКБ № 52 ДЗМ", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298246L, "Кавказский бульвар", "Парк по Кавказскому бульвару", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298249L, "Автозаводская улица", "Сквер по Автозаводской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298254L, "Украинский бульвар 5", "Украинский бульвар", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298258L, "Пересечение Восточной и Велозаводской улиц", "Сквер по Восточной улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298260L, "Осенний бульвар 6", "Осенний бульвар", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298263L, "улица Кировоградская, между домами 19 и 17", "Сквер «Родная гавань»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298266L, "Проспект Вернадского 14", "Сквер у кинотеатра Звездный", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298267L, "Мичуринский проспект 8", "Сквер у кинотеатра Литва", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298268L, "улица Молодогвардейская, дом 29, корпус 1", "ул. Молодогвардейская, д. 29 (сквер)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298272L, "Пересечение улицы Летчика Бабушкина и Изумрудной улицы", "Сквер между улицей Летчика Бабушкина и Изумрудной улицей", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171298274L, "Староватутинский проезд", "Сквер у магазина «Природа»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171475214L, "Строгинский бульвар", "Строгинский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171475261L, "Улица Таллинская", "Объект озеленения березовая роща в Строгино", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 171475291L, "улица Новокузнецкая", "сквер у метро Новокузнецкая", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169543259L, "между улицей Лобачевского и улицей 26 Бакинских комиссаров", "Объект природного комплекса № 144 (квартал 2 Тропаревского лесничества)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167687136L, "город Зеленоград, от корпуса 1504 до корпуса 1561", "Бульвар у Михайловского пруда в Западной части города Зеленограда со стороны 15 микрорайона", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169541018L, "между улицами Обручева и Миклухо-Маклая", "Объект природного комплекса № 43 (квартал 3 Тропаревского лесничества)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169386833L, "Улица Перекопская дом 11 корпус 2", "Сквер по улице Перекопской", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717722L, "Улица Громова, дом 27", "Объект природного комплекса № 30 Парк у поселка имени Ларина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717734L, "Алтуфьевское шоссе, дом 147А", "Объект природного комплекса № 31 Долина реки Чермянки с усадьбой Алтуфьево", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717748L, "от Одоевского проезда вдоль улицы Голубинская", "Объект природного комплекса № 83 Долина реки Битцы", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717755L, "Правобережный участок ниже Вильнюсской улицы", "Объект природного комплекса № 88 Долина реки Битцы", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717758L, "Ниже Вильнюсской улицы", "Объект природного комплекса № 89 Долина реки Битцы", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717760L, "Квартал 1 Битцевского леса", "Объект природного комплекса № 90 Ясеневский лесопарк", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717767L, "Квартал 1 Битцевского леса", "Объект природного комплекса № 91 Ясеневский лесопарк", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717966L, "Можайское шоссе", "Объект природного комплекса № 179", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167717970L, "Озелененная территория в районе Ново-Переделкино", "Озелененная территория в Долине реки Сетуни Объект природного комплекса № 178", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167769932L, "Сквер по улице Толбухина дом 4 корпус 1", "Территория прилегающая к кинотеатру МИНСК", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167770568L, "Можайское шоссе дом 5", "Сквер Бородино", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167788867L, "улица Нежинская дом 8", "Нежинский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 167788877L, "Мичуринский проспект, 70", "Сквер у д. 70 по Мичуринскому проспекту", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168314854L, "улица Кравченко", "Газон вокруг Удальцовских прудов", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168314910L, "улица Нарофоминская дом 2", "парк Дружба", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168314921L, "Боровский проезд дом 2", "Бульвар между Боровским шоссе и ж-д (пруд)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168314942L, "Солнцевский проспект дом 24", "сквер Молодежный", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168315008L, "улица Богданова дом 52", "Бульвар ул. Щорса", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168315037L, "улица Богданова дом 50", "Массив по улице Богданова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168317665L, "улица Кастанаевская дом 51 корпус 3", "Сквер между улицей Герасима Курина и улицей Кастанаевская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168317692L, "Поселок Мещерский", "Зона отдыха Мещерское", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 168557636L, "Город Москва, улица Новочеремушкинская, дом 39, корпус 1", "Сквер 9-Ю", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169007562L, "Шарикоподшипниковская улица", "Сквер у Фабрики-кухни по Шарикоподшипниковской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169009593L, "Шарикоподшипниковская улица", "Шарикоподшипниковский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169386199L, "Черноморский бульвар ( от улицы Азовской до Симферопольского бульвара)", "Черноморский бульвар", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 169412094L, "1-й Тушинский проезд владение 19", "Склон лесополосы реки Сходня по 1-у Тушинскому проезду владение 19", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281747928L, "Загородное шоссе, 2", "Детский парк", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281747942L, "улица Кировоградская, владение 42", "Каскад прудов по улице Кировоградская", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281747963L, "вдоль Осташковской улицы", "Осташковский сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1015652151L, "между улицей Паромная и улицей Ключевая", "Территория вокруг прудов-регуляторов", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1015652165L, "улица Садовники, дом 1", "Сквер ветеранов Нагатино-Садовники", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1016049812L, "От дома 5 до дома 13Б по 2-й Владимирской улице", "Перовская слобода", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1019359461L, "поселение Московский", "Парк 3-го мкр. Московского", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1019545753L, "Озелененная территория вдоль улицы Маршала Федоренко", "Озелененная территория вдоль ул. Маршала Федоренко", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1019545854L, "Лихоборская набережная", "Сквер по Лихоборской набережной", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1022143703L, "Крондштатский бульвар", "Крондштатский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1022165376L, "Город Москва, улица Земляной вал дом 1 дробь 4", "Чкаловский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1022401863L, "Озелененная территория между Шипиловским проездом и Каширским шоссе (улица Дольская, владение 1)", "Озелененная территория между Шипиловским проездом и Каширским шоссе", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1022418016L, "озелененная территория вдоль реки сходня", "Правый берег р.Сходня от РЖД до Комбината строительных материалов", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1023579414L, "от 1-й Курьяновской улицы до 4-й Курьяновской улиц", "Курьяновский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1023580435L, "Проспекта Защитников Москвы", "Сквер вдоль Проспекта Защитников Москвы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1023580937L, "Батюнинская улица, дом 12", "Батюнинский пруд", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1023581111L, "улица Маршала Голованова, дом 18", "Сквер по улице Маршала Голованова", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1023581261L, "Перервинский бульвар", "Сквер Ветеранов Великой Отечественной войны", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026713753L, "Напротив улицы Снежная", "Сквер по проезду Нансена.", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026713873L, "газон вдоль жд от улицы Яблочкова, владение 3 до платформы Тимирязевская и до улицы Яблочкова, дом 49", @"газон вдоль жд от ул. Яблочкова, вл. 3 до пл.
Тимирязевская и до ул. Яблочкова, д.49", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026730788L, "улица Вересковая", "Сквер по улице Вересковая", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026730797L, "улица Седова", "Сквер у библиотеки по улице Седова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026744311L, "Напротив метро Свиблово", "Сквер у станции метро Свиблово", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026773111L, "Вдоль улицы Уржумская", "Сквер по улице Уржумская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026773148L, "вдоль улицы Енисейская", "Сквер по улице Енисейская ( у галантереи)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026773883L, "Вдоль реки Яуза", "Территория по Тенистому проезду-Знаковый объект", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1026779146L, "Пойма реки Яуза", "Озелененная территория по Тенистому проезду, дом 2 корпус 1 (пойма Яузы)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1027022921L, "между Дмитровским шоссе и Селигерской улицей", "Парк имени Святослава Фёдорова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1015652105L, "от улицы Автозаводская до улицы Ленинская Слобода", "Сквер по улице Мастеркова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028449090L, "улица 1812 года, 2к2", "Сквер по ул. 1812 года", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1007245978L, "парк Купеческие угодья", "парк Купеческие угодья", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 969546403L, "Территория вдоль Панфиловского проспекта около корпуса 1106", "Сквер «60-летия Победы»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 909726423L, "вдоль Мичуринского проспекта и Винницкой улицы", "Долина реки Раменки", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 909730394L, "Народный парк Хлобыстова", "Народный парк Хлобыстова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 911562444L, "Киевский сквер на пересечении Бережковской набережной и улицы Большая Дорогомиловской", "Сквер на Бережковской набережной у Киевского вокзала", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 911785723L, "Территория, прилегающая к корпусу 9А", "Базовский сквер", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 911786745L, "Зона тихого отдыха для взрослых", "Зона отдыха Лебедь", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 911800961L, "Сквер по Коровинскому шоссе", "Орловский сад", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 911801150L, "Ходынский бульвар, з/у 1", "Парк «Ходынское поле» (основная территория)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 918050464L, "улица Борисовские пруды и Бесединское шоссе", "Фаунистический заказник Братеевская пойма", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 918424535L, "Территория Алтуфьевского района", "Сквер по улице Бегичева и проезду Черского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 919112124L, "Сквер по Булатниоквской улице", "Сквер по Булатниковской улице (пруды)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 919116476L, "Варшавское шоссе, владение 26", "Велосквер", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 919206185L, "Бескудниковский бульвар", "Бескудниковский бульвар", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 919206262L, "Бескудниковский бульвар", "Бескудниковский бульвар д.15 к.1- д.23", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 919206263L, "Бескудниковский бульвар", "Бескудниковский бульвар д.3- д.9", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926244694L, "Вдоль улицы Академика Флерова и Долгопрудненское шоссе", "Объект природного комплекса № 21 Северо-Восточного административного округа города Москвы Парк проектный, район Северный", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926244723L, "Между домами 2/1 и 4/2 по Кутузовскому проспекту", "Парк Украинский бульвар у гостиницы Украина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926844851L, "Озелененная территория за Очаковский шоссе", "Озелененная территория п Очаковскому шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926845029L, "Озелененная территория по улице Рябиновая", "Озелененная территория по улице Рябиновая", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926845088L, "Сквер от улицы Большая Очаковская до улицы Наташи Ковшовой", "Сквер по улице Большая Очаковская", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926846293L, "Около Долгопрудненское шоссе, 3", "Парк проектный Долгие пруды", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 926865556L, "Метро Жулебино", "Сквер Генерала Кузнецова", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 929764068L, "улица Василия Ботылева 45", "парк прилегающий к храму иконы Богоматери «Неувядаемый цвет»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 930235316L, "Пересечение Зои и Александра Космодемьянских и улица Клары Цеткин", "сквер Зои и Александра Космодемьянских", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 932974704L, "Озелененная территория между Весковским переулком и 1-ой Миусской улицей", "Весковский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 969545934L, "озелененная территория между корпусами 1005, 1006, 1007, 1015", "Лесопарковая территория у корпуса 1007", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1006752695L, "Расположен у корпуса 360 вдоль жилой застройки новых корпусов: 331,326,330,335,332,336 (строительные номера)", "Сквер «Флейта»(3 микрорайон)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904589202L, "Сокольническая площадь дом 9", "Сокольническая площадь, дом 9 (Сквер у магазина «Зенит»)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028449491L, "между улицами Кутузовский проезд и Кульнева", "Сквер за музеем Бородинская панорама", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028450054L, "Кутузовский проспект 39", "Сквер д.39 по Кутузовскому проспекту", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029292979L, "Бульварная зона 4 мкр", "Бульварная зона 4 мкр", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029334022L, "Между Осенний бульвар дом 11 и Осенний бульвар дом 15", "Площадь Защитников неба в Крылатском ЗАО", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029335794L, "Мосфильмовская 35", "Мосфильмовская ул., д.35 (сквер)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029335993L, "Между домом 53 и 49 по улице Крылатские холмы", "Сквер у дома 51 по улице Крылатские Холмы", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029839312L, "Территория по улице Тайнинская к реке Яуза", "Территория по ул. Тайнинская к реке Яуза", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029841428L, "Газоны по улице Стартовая", "Газоны по улице Стартовая", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1030014559L, "Забелина улица", "Сквер Мандельштама", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1030015215L, "Территория между Джамгаровским прудом и Перловским кладбищем", "Территория между Джамгаровским прудом и Перловским кладбищем", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1030055482L, "Территория за госпиталем ВОВ по улица Стартовая, дом 4", "Территория за госпиталем ВОВ по ул.Стартовая, д.4", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031009416L, "между улицей Народного Ополчения и 3 ей Хорошевской улицей", "Территория Октябрьского радиополя", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031035562L, "Сельскохозяйственная 26 стр 8", "Лыжно-роллерная трасса Сельскохозяйственная 26 стр 8", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031043265L, "Бульвар по улице Гарибальди от улицы Профсоюзная до улицы Новочеремушкинская", "Бульвар по улице Гарибальди от улицы Профсоюзная до улицы Новочеремушкинская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031044387L, "Бульвар Дмитрия Ульянова", "Дм. Ульянова (Ленинский - Севастопольский)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031045748L, "бульвар вдоль улицы Новочеремушкинская", "улица Новочеремушкинская", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031060184L, @"улица Капотня
2-й квартал Капотни, 15", "Парк у городской больницы №49", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031060203L, "Территория берега Москва-реки от Бесединского моста до СК Нефтянник-2", "Территория берега Москва-реки от Бесединского моста до СК Нефтянник-2", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031060238L, "1-й Капотнинский проезд 5175", "1-й Капотнинский пр. (проезд 5175)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031061839L, "Ореховый бульвар, владение 26, корпус 3Б", "Шмелевский ручей", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031068593L, "от улицы Декабристов до Северного бульвара", "Сквер по улице Пестеля", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031089033L, "Сквер Таежный", "Сквер по ул.Таймырская-ул.Таежная", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1031139772L, "улица Маршала Кожедуба, 10", "Народный парк по улице Маршала Кожедуба", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1033142449L, "Север на пересечении улицы Измайловский вал д20 и улицы Ткацкая", "Сквер на Измайловском валу", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1033143418L, "на пересечении Амурской улицы и Иркутской улицы", "Сквер на Амурской улице", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1033143876L, "Лухмановская улица в районе дома 17", "ул. Лухмановская, вл.17", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1033143937L, "Сквер на пересечении улицы Юности и улицы Красный Казанец,от дома 13 до дома 15 по улицы Юности", "Сквер Красный Казанец", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029291273L, "Бульварная зона 7 мкр", "Бульварная зона 7 мкр.", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028449870L, "улица Неверовского 13", "Сквер по ул. Генерала Ермолова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1029290413L, "на пересечении Кутузовского проспекта и Большой Дорогомиловской улицы", "Сквер у обелиска «Москва-город-герой»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028783600L, "город Зеленоград 23 микрорайон между корп 2301 и Георгиевским проспектом", "Зона отдыха «Зеленый бор» (23 мкр.)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028520038L, "Сквер на улице Мосфильмовская", "ул. Мосфильмовская, д.10 (сквер)", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028522407L, "Территория, прилегающая к оврагу по улице Кутузова", "Парк в пойме реки Ивницы", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028522498L, "Пруд по улице Красных Зорь", "Богдановский пруд", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028524075L, "проспект Вернадского", "Пруды на пр. Вернадского", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028651258L, "Боровское шоссе, дом 33", "Сквер у управы (р-н Ново- Переделкино)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028664000L, "4-я Курьяновская улица", "Курьяновский парк", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028665538L, "улица Щорса дом 4", "ул. Щорса (массив)", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028678355L, "улица Богданова дом 10", "Аллея Советско-чехословацкой дружбы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028700785L, "Мичуринский проспект, 58", "Парковая территория у дома 58 по Мичуринскому проспекту", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028700856L, "Университетский проспект", "Университетский проспект (бульвар)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028701893L, "улица Марии Поливановой", "Сквер Марии Поливановой", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028707532L, "Ярцевская улица, 1Ас1", "Сквер на пересечении улиц Бобруйской и Ярцевской.", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028708035L, "От улицы Партизанская до улицы Полоцкая", "Кунцевский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028754143L, "Вернадского пр-т 127", "Сквер у магазина Польская мода", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770235L, "Мичуринский проспект за домом 70", "Парк за домом 70 по Мичуринскому проспекту", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770261L, "набережная Тараса Шевченко дом 15", "Бульвар по набережной Тараса Шевченко", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770397L, "вдоль Бережковской набережной от ул Потылихи до ул Большая Дорогомиловская", "Бережковская набережная", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770491L, "ул Матвеевская д 1", "Сквер по Аминьевскому шоссе", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770520L, "ул Ивана Франко 12 вдоль станции метро", "Парковая территория от станции метро Кунцевская до ул Ек Будановой", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770562L, "ул Ярцевская 21", "Сквер у кинотеатра Брест", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028770609L, "ул Ярцевская вл 25", "Сквер у станции метро Молодежная", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028772145L, "Бульвар по улице Полоцкая", "Бульвар по улице Полоцкая", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028772226L, "ул Кастанаевская 52", "Парк, вдоль линии метро (от ст.м.Пионерская до ст.м.Филевский парк)", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028772267L, "вдоль улицы Большая филевская от улицы Минская до улицы Полосухина", "Бульвар по ул.Б.Филевская (р-н Фили-Давыдково)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028776680L, "Территория вдоль улицы Соловьиная роща и мкр 7А -7Б, (парк Зеленый театр)", "Территория вдоль улицы Соловьиная роща и мкр 7А -7Б, (парк Зеленый театр)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1028784674L, "город Зеленоград у корп 1701 между Георгиевским проспектом и Заречной улицей", "Территория парковой зоны у Нижнекаменского пруда", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904588423L, "Сокольническая площадь", "Сокольническая площадь(Сквер у фирмы «Сокольники»)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904587695L, "Сиреневый бульвар, дом 77", "Сиреневый бульвар, дом 77 (между разворотной площадкой автобусов и забором колледжа)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904461581L, "Улилица Преображенская, дом 5/7", "Сквер по улилицы Преображенская, дом 5 дробь 7", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 639273701L, "поселение Первомайское, возле улиц Рабочая и Центральная", "Территория усадьбы Старо-Никольское (парк)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 639419580L, "город Москва, улица Паустовского, дом 8, корпус 1", "Пруды по улице Паустовского", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 642001524L, "Первомайская улица", "Зона Серебряно-Виноградных прудов", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 659868145L, "Расположен между стадионом Локомотив, Черкизовским прудом, зданиями по адресу: Большая Черкизовская дом 21, строение 2 и Большая Черкизовская дом 23", "Государственное бюджетное образовательное учреждение дополнительного образования города Москвы «Центр дополнительного образования детей «Черкизовский парк»», (Детский Черкизовский парк)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 660360484L, "Большой Спасоглинищевский переулок", "Парк Горка", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 660617055L, "улица Варварка, домовладение 6, строение 1", "Парк «Зарядье»", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 660791495L, "Огородный проезд 20-25", "Сквер имени Кирова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 660854925L, "улица Удальцова, дом 3, корпус 2, корпус 4, корпус 6", "Пешеходная зона по ул. Удальцова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 694647978L, "Брюсов переулок 6", "Сквер у дома Композиторов", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 796175153L, "Территория вдоль улицы Соловьиная роща д 8-10 (микрорайон 5 А, бульвар МБ-7)", "Территория вдоль улицы Соловьиная роща д 8-10 (микрорайон 5 А, бульвар МБ-7)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832622002L, "Территория примыкающая к ФГБУ Эндокринологическому научному центру Минздрава РФ", "Парк Академический", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832648935L, "Между улицами Уральская и Алтайская", "Сквер в Гольяново", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832653372L, "Керамический поезд, дом 65-71", "Парк «Северные Дубки»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832653398L, "Лобненская улица, дом 13А", "Парк «Вагоноремонт»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832653420L, "Ленинградский проспект, дом 40", "Парк Петровский", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832653438L, "Метро Войковская", "Парк Воровского", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832653453L, "Ленинградский проспект, владение 59", "Чапаевский парк", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832654588L, "Сквер расположен между Лазоревым проездом и поймой реки Яузы", "Сквер, прилегающий к Лазоревому проезду", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832654632L, "Долина реки Битца от улицы Куликовская до бульвара Дмитрия Донского", "Пойма реки Битца", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 832663824L, "Академика Королёва улица дом 19 А", "Парк «Дубовая роща по Прудовому проезду»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833034864L, "Новомарьинская улица, дом 7", "Парк «Братиславский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833035006L, "Пересечение улиц Перерва и Братиславская", "Парк «имени Артёма Боровика»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833035639L, "Батайский проезд, дом 3 - 65, улица Поречная, дом 3 - 21", "Парк «850-летия Москвы» (основная территория)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833042764L, "Сквер у метро Ботанический сад", "Сквер у метро Ботанический сад (парк Сад Будущего)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833042800L, "проспект Мира, владение 186-188", "Парк Ростокинский акведук", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 628142609L, "озелененная территории вдоль Керамического проезда", "Озелененная территория по Керамическому проезду", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833042977L, "улица Северодвинская", "Пойма реки Яузы вдоль улицы Северодвинская", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 622433901L, "Пересечение улиц Марьинский Парк и Верхние Поля", "Территория проектируемого парка им. 850-летия Москвы, напротив 12 и 14 мкр. Марьинского парка", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 423005341L, "Сквер возле станции МЦК Площадь Гагарина", "Сквер Площадь Гагарина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281747976L, "улица Большая Садовая, владение 16", "Сад «Аквариум»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281747985L, "рядом со станцией метро Славянский бульвар", "Можайский плодовый сад", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281769192L, "район Строгино", "Плодовый сад по Неманскому проезду", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281769203L, "Массив по улице Чертановская дом 32", "Массив по улице Чертановская 32", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 281888941L, "город Москва, между улицами Черневской и Горчакова", "Досуговый центр в пойме реки Чуры", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 282009617L, "улица Саляма Адиля дом 4", "Сквер у кинотеатра Патриот", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 282117804L, "Кутузовский проспект, владение 38, строение 1,2,3", "Сквер у музея-панорамы «Бородинская битва»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 282253874L, "около дома по улице Сельскохозяйственная дом 41", "Пойма реки Яуза", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 282254938L, "Сквер вдоль проезда Якушкина возле дома 7", "Сквер по проезду Якушкина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 282254946L, "Сквер вдоль улицы Каргопольская возле дома №6", "Cквер по улице Каргопольская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323411090L, "Жилой квартал в 16 микрорайоне, между Панфиловским проспектом и 657 проездом", "Бульвар в западной части города Зеленограда со стороны 16 микрорайона", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323411129L, "Лаврушинский переулок,17", "Сквер имени И.С.Шмелева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323411823L, "улица Генерала Белова дом 2", "Народный парк Яблоневый сад", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323411990L, "Парковая территория между улица Барвихинская, дом 4, корпус 1 и МКАД", "ул. Барвихинская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323528801L, "город Москва, улица Молодежная дом 3", "Бульвар по улице Молодежной", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323528823L, "пересечение переулка Сивцев Вражек и Афанасьевского переулка", "Сивцев Вражек переулок (сквер)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323528848L, "Семеновская набережная, 1/3", "Сквер Молодежный", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323528914L, "Андроньевская набережная", "Большой Андроньевский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323528916L, "Андроньевская набережная", "Нижний Андроньевский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 323528920L, "Костомаровская Набережная", "Наставнический сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 338204055L, "Улица Буракова, дом 8", "Сквер по улице Буракова, монумент «Великий почин»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 401923575L, "Улица Осташковская, улица Изумрудная, Осташковский проезд", "Парк Торфянка", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 405050343L, "улица Перерва", "Аллея Ветеранов", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 423004398L, "Между домом №1 и домом № 20 строение 1 по Жулебинскому Бульвару", "Жулебинский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 423004401L, "От улицы Жулебинский Бульвар до Лермонтовского Проспекта", "Пронская улица", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 425505195L, "Ограничен улицей Криворожская, Проектируемым проездом № 460 и Нахимовским проспектом", "Долина реки Котловки", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 833043577L, "Долина реки Яузы от улицы Широкая до проезда Дежнева", "Долина реки Яузы от ул. Широкая до проезда Дежнева", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 835364389L, "улица Бакинская", "Аршиновский парк", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 835507718L, "Братеевский проезд", "Пойма реки Городни", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903906302L, "Первая очередь набережной Москвы реки капотня", "Парк на набережной Москвы-реки в районе Капотня", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903941834L, "площадь Викторио Кодовильи", "Сквер на площади Кодовильи", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903942967L, "Западная улица дом 3-5", "Западная улица дом 3-5 (Сквер у банка)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904069407L, "Сквер по улицы Атарбекова", "Сквер по улицы Атарбекова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904071205L, "между улицей Буженинова и улицей Суворовская", "Сквер между улицей Буженинова и улицей Суворовская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904073184L, "Сквер у Храма Дмитрия Салунского", "Сквер у Храма Дмитрия Салунского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904084402L, "улица Верхоянская", "Сквер по улице Верхоянская", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904084827L, "На углу улицы Стромынка дом 15 и улицы Короленко", "Сквер на углу улицы Стромынка дом 15 и улицы Короленко", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904085093L, "пересечение улицы Верхоянская с улицей Летчика Бабушкина", "Сквер у Исполкома", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904087463L, "Метро Партизанская", "Сквер №2 напротив станции метро «Партизанская»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904088217L, "улица Лескова", "Сквер по улице Лескова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904089014L, "Озелененная территория по улице Плещеева (в районе дома 28)", "Народный парк по ул. Плещеева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904230045L, "На углу первогого перекрестка Измайловского зверинца", "Сквер на углу первогого перекрестка Измайловского зверинца", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904230642L, "Третья Парковая улица дом 53", "Сквер у кинотеатра «Eнисей»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904231256L, "улица 16-Парковая", "Сквер по ул. 16-Парковая", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904232231L, "Сокольническая площадь дом 7", "Сквер Молодежный (народный парк)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904233071L, "9-го мая улица, дом 1", "9-го мая улица, дом 1 (сквер)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904233907L, "улица Сокольнический вал, дом 2", "улица Сокольнический вал, дом 2", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904285913L, "Проспект Буденного, дом 32", "Сквер у ДК им Ленина, проспект Буденного, дом 32 (народный парк)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904286662L, "Большая Семёновская улица, дом 11 строение 3", "Сквер у Электрозаводского моста", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904388489L, "Семеновская площадь, дом 5", "Сквер у кинотеатра «Родина», Семеновская площадь, дом 5", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904390340L, "Сокольническая площадь, дом7", "Сквер «Луч» по Сокольнической площади дом 7", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904459215L, "Федеративный проспекту, дом 27А", "Сквер по Федеративному проспекту, дом 27А", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904459807L, "пллощадь Журавлева", "Сквер на пллощади Журавлева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 904460115L, "Между улицей Матросская Тишина и 5 Сокольнической улицей", "Сквер между улицей Матросская Тишина и 5 Сокольнической улицей", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903902346L, "улица Русаковская дом 22", "Сквер по улицы Русаковская, дом 22", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903893040L, "от 7 Парковой улицы до 15 Парковой улицы", "Пешеходная зона Измайловского проспекта", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903873795L, "Пересечение Садового кольца и Полуярославской набережной", "сквер имени Академика Сахарова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903868544L, "Сквер по Открытому шоссе у кинотеатра Янтарь", "Сквер по Открытому шоссе у кинотеатра «Янтарь»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 836839596L, "От Мичуринского проспекта, д4с1 до проспект Вернадского, д4к1с1", "Озелененная территория МГУ", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 836855251L, "От Мичуринского проспекта до Университетского проспекта", "Парк перед посольством КНР", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 836874071L, "от улицы Тропаревская до Ленинского проспекта", "Парк «Никулино»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 836897816L, "улица Борисовские пруды", "Южный кластер", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 838296543L, "от улицы Богданова до Боровского шоссе", "парк «60 лет Октября»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 842406708L, "Аэродромная улица 11", "Парк «Дубовая роща «Маяк»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 858837317L, "Волгоградский проспект, владение 168Д", "Усадьба «Деда Мороза» в музее-заповеднике «Кузьминки-Люблино»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 860063622L, "Сквер по улице Люблинская напротив дома 9 с1", "Сквер по ул. Люблинская у памятника А.С. Пушкина", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 870141696L, "Житная улица 4", "Сквер Аргентинской Республики", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 881603734L, "между улицей Лобачевского, дом 94 и улицей Удальцова", "Территория бульвара «Никулина Роща»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 885660949L, "улица Борисовские пруды", "Парк «Братеевская пойма»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 885781365L, "Проспект Лихачева", "Парк «Тюфелева роща»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64372562L, "ул Свободы д 26", "Сквер «Салют»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 889155925L, "Варшавское шоссе, дом 131, корпус 1-5", "Варшавские пруды", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 895850473L, "озелененная территория вдоль реки сходня", "Левый берег реки Сходня от Рижской железной дороги до базы спортивного общества Буревестник", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 896481589L, "Садовая-Триумфальная улица, дом 10/13", "Садово-Триумфальный сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 896738185L, "На пересечении улиц: Измайловская площадь и улица Первомайская", "Сквер у ДК Строителей,Измайловская пл.,вл.1а (Народный парк)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901264265L, "Бульвар Маршала Рокоссовского, дом 12", "Бульвар Маршала Рокоссовского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901554619L, "Между улицами Плеханова и 1-я Владимирская", "Бульвар у Зеленого проспекта", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901556876L, "Между улицей Кетчерская и железно-дорожной станцией Новогиреево", "Сквер по ул.Кетчерская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901559389L, "1-й Щипковский переулок", "Ильичевский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901636358L, "улица Хавская, дом 3", "Сквер по Хавской улице", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901656796L, "Чонгарский бульвар", "Чонгарский бульвар", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 901710847L, "Варшавское шоссе, дом 114, корпус 1", "Сквер у РИК", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 902775697L, "5 проезд Подбельского", "Сквер по 5-му проезду Подбельского", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 903867781L, "Сквер у дома 20 и 24 по Зеленому проспекту", "Сквер у дома 20 и 24 по Зеленому проспекту", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 895756809L, "Усачева улица 1а", "Парк Усадьба Трубецких в Хамовниках", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1033144040L, "Сквер между проспектом Ветеранов и рекой Яуза", "Сквер между проспектом Ветеранов и рекой Яуза", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64372561L, "ул Митинская 17к3", "Бульварная зона микрорайона 7", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64372161L, "ул Митинская д52к2", "Бульварная зона микрорайона 3", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331979L, "Окружен: Донской улицей, 3-им Донским проездом, улицей Стасовой, 4-ым Донским проездом", "Донской сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331980L, "Расположена между Елецкой улицей и Гурьевским проездом", "Берёзовая роща", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331981L, "вдоль Коломенской набережной до Затонной улицы, дом 22", "Народный парк – Парк спорта", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331982L, "Варшавское шоссе дом13а", "Детский парк на Варшавском шоссе", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331983L, "территория между улица Чертановская, дом 27 и улица Кировоградская, дом22", "Парк 30-летия Победы", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331984L, "территория между Борисовским проездом и Ореховым проездом", "Сквер-сад по Ореховому проезду", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331985L, "Варшавское шоссе владение 2", "Народный парк «Южный дворик»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331987L, "территория между улица Чертановская дом 9, корпус 4 и улица Кировоградская, дом 8, корпус 3", "Школьный парк на Кировоградской улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331988L, "улица Дорожная, владение 5 - 7", "Народный парк «Покровский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331989L, "улица Ереванская, владение 27", "Народный парк имени Надежды Рушевой", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331990L, "территория между улицей Лобанова, дом 9 и улицей Трофимова, дом 8", "Народный парк Кожуховский", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331991L, "проезд Черепановых, 24с1", "Народный парк на проезде Черепановых", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331992L, "улица Усиевича, 12", "Народный парк у кинотеатра «Баку»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331993L, "Часовая улица, дом 21А", "Народный парк по Головановскому переулку", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331995L, "1й Лихачевский, д 4, к 2А", "Парк Петра Алексеева", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331996L, "1-ый Новоподмосковный переулок, 2", "Народный парк по улице Космонавта Волкова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331997L, "Клинская улица, 2с1", "Парк «Грачёвка»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331998L, "3-й Лихачевский переулок, 2к3", "Парк Усадьба Михалково", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331999L, "Дегунинская улица, 2к2", "Народный парк у Дегунинского пруда", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332000L, "Между домами 24 и 24 корпус 3 на Большой Академической улице", "Народный парк Вишневый сад", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332001L, "улица Волочаевская дом 38", "Парк «Строгановские дачи»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332002L, "Пересечение улицы Авиаконструктора Миля и Жулебинского бульвара", "Парковая зона на улице Авиаконструктора Миля", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332003L, "улица Мельникова владение 7", "Парковая зона на прилегающей территория к Храму по улице Мельникова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332004L, "1-й Краснокурсантский проезд улица Красноказарменная", "Сквер на Краснокурсантской площади", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332005L, "На пересечение улиц Юных Ленинцев, Артюхиной, 8-й Текстильщиков, Малышева", "Сквер по улице Артюхиной", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331978L, "улица Ленинская Слобода, дом 26", "Мини-парк на Восточной улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332006L, "Вдоль жилых домов по Волжскому бульвару дом 3, корпус 1 до Саратовской улицы, дом 31", "Солнечный", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331977L, "улица Большая Тульская, дом 11", "Японский сад камней на Большой Тульской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331975L, "Восточная улица, дом 4", "Детский парк на Восточной улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331947L, "Пересечение улицы Городецкая и улицы Суздальская", "Городецкий бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331949L, "Пересечение Полимерной улицы и Новогиреевской улицы", "Русские узоры", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331950L, "Между Главной улицей и улицей 9 Мая", "Брошенный сад", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331951L, "улица Лухмановская, владения 29-33", "Парковая зона на Лухмановской улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331952L, "Пересечение улицы Западная и улицы 9 Мая", "Парк «Южный»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331953L, "Зеленый проспект 76", "Сквер между Зелёным проспектом и Фрязевской улицей", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331954L, "Пересечение 7-го проезда Подбельского и Открытого шоссе", "Парковая зона на Открытом шоссе", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331955L, "Между Салтыковской улицей и Святым озером", "Сквер у храма", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331957L, "Парковая зона вблизи набережной канала реки Москвы по Авиационная улица", "Щукинская набережная", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331958L, "Лодочная улица", "Кленовый сквер", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331959L, "Бульварная зона от Дубравной улицы до 3-го Митинского переулка", "Бульвар 70-летия Победы", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331960L, "Москва, Территория березовой рощи между ул 3 Хорошевская 7 и Новохорошевским проездом 10", "Парковая зона на территории народного парка «Березовая Роща» между 3-ей Хорошёвской улицей и Новохорошёвским проездом", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331961L, "Большая Набережная 25", "Сквер на Набережной", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331962L, "Улица Маршала Новикова, дом 12, корпус 2", "Сквер Юность", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331963L, "улица Твардовского, дом 14, корпус 1-3", "Парк «Соколиная гора»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331964L, "Москва улица Таллинская, владение 32", "Парк «70 лет битвы под Москвой»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331966L, "Бочвара 17", "Живописный сквер", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331967L, "улица Исаковского 24", "Парк Скворечный", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331968L, "вдоль Сходненской улицы", "Сходненский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331969L, "Даниловская площадь", "Сквер у пам. Даниилу Московскому", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331970L, "Харьковская улица", "Бульвар вдоль Харьковской улицы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331971L, "улица Чертановская дом 8", "Народный парк «Чертановское подворье»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331972L, "Сумской проезд, дом 29", "Детский парк на Сумском проезде", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331973L, "Медынская улица, дом7а", "Парк «Школьный»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331974L, "от улицы Кошкина, дом 12 корпус 1 до Кантемировской улицы, дом 18, корпус 5", "Народный парк вдоль Кантемировской улицы", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331976L, "улица Ключевая, владение 6", "Народный парк «Исток»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331946L, "Малая Семёновская улица, между Медовым и Мажоровым переулками", "Сквер на Малой Семёновской Сквер дружбы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332007L, "Улица Зарайская владение 51-55", "Парк Плющево", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332009L, "Улица Саранская владение 5-7", "Сквер вокруг Храма Иоанна Кронштадского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 13409090L, "от улицы Верхние поля дом 35 до улицы Новороссийской дом 32", "Аллея Молодых Семей", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 13409093L, "улица Пруд Ключики дом 1-3", "Сквер 65-летия Победы в Великой Отечественной войне 1941-1945 годов в Лефортово", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 13409094L, "Жулебинский бульвар", "Парковая зона на Жулебинском бульваре", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 13430925L, "Между улицами Мезенская и Оборонная", "Сквер по ул. Оборонная", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14151273L, "Хибинский проезд, дом 14", "Народный парк «Хибинский сквер»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14151283L, "Краснобогатырская улица, дом 21 (между проезжей частью и жилым домом)", "Сквер на Краснобогатырской", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14152016L, "Перовская улица, напротив дома 61", "Перовский сквер", "нет", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14152021L, "город Зеленоград, у корпуса 234А", "Народный парк «Поляна сказок»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14152411L, "город Зеленоград, Народный парк от корпуса 1446 до корпуса 1471", "Народный парк «Живые камни»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14235587L, "улица Седова", "Сквер по улице Седова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14235588L, "улица Кибальчича", "Сквер по улице Кибальчича", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14235589L, "улица Таймырская", "Сквер по улице Таймырская", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14932970L, "Спасопесковский переулок", "Сквер на Спасопесковском переулке", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14932977L, "улица Остоженка, дом 38", "Сквер на Остоженке у дома 38", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 14932979L, "улица Остоженка дом 41", "Сквер на Остоженке у дома 41", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19627129L, "набережная реки Десны в районе улицы Заречной", "Парк «Заречье»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19644940L, "Большой Патриарший переулок", "Парк Патриаршие пруды", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19648396L, "между Полярной улицей и проездом Шокальского", "Сквер им. 50-летия ВЛКСМ", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19649121L, "улица Инженерная, дом 1", "Озелененная территория у кинотеатра Марс", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19649127L, "улица Константинова", "Сквер по улице Константинова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19649132L, "улица Череповецкая", "Озелененная территория по улице Череповецкая", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19656403L, "находится на пересечении шоссе с долгопрудненской аллей", "Зона отдыха Долгие пруды", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 19656430L, "Находится рядом с проектируемым проездом 5557", "Парк проектный", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 20974244L, "Гоголевский бульвар", "Сквер на Гоголевском бульваре", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 20974279L, "ул Академика Петровского", "Сквер по ул. Академика Петровского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 13388381L, "от дома 9а по Северному бульвару до пересечения с Юрловским проездом", "Сквер на Северном бульваре", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332008L, "1-я Карачаровская улица и Перовское шоссе", "Карачарово", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4395899L, "Между Подольским шоссе и Павловской улицей", "Сквер Чингиза Айтматова", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332038L, "Первый Смоленский переулок 22", "Тихий уголок", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332010L, "Территория Яблоневого сада в 3-м квартале Капотни, дом 4", "Народный парк «Яблоневый сад в Капотне»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332011L, "улица Федора Полетаева", "Сквер на улице Фёдора Полетаева", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332012L, "Госпитальная площадь, улица Госпитальный вал", "«Госпитальный» сквер", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332014L, "Улица 2-я Вольская дом 11 корпус 3 дом 17, корпус 2 строение 1", "Парковая зона на 2-й Вольской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332015L, "На пересечение улиц Армавирская, Краснодарская, Таганрогская", "Парк имени Чехова", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332016L, "2-й квартал Капотни дом 9", "Парк у памятника «погибшим Капотнинцам»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332017L, "Железнодорожная платформа Новая", "Сквер у платформы «Новая»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332018L, "Вдоль улицы Госпитальный Вал от Крюковской улицы до Боровой улицы", "Пригородный сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332019L, "На пересечение улиц Краснодарская, Белореченская, Новороссийская, Совхозная", "Парковая зона в микрорайоне 39б", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332020L, "Улица Гурьянова, владение 83", "Парк на набережной в Печатниках", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332021L, "Между Проектируемым проездом №5175 и 2-м кварталом района Капотня", "Парк вдоль проктируемого проезда № 5175", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332023L, "поселение Новофёдоровское, возле деревни Яковлевское", "Фестивально-прогулочный парк «Сосны»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332024L, "поселение Марушкинское, в пойме ручья Алёшина", "Детский парк «Ручеёк»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332025L, "поселение Краснопахорское, возле села Былово, русло реки Пахра", "Спортивный парк «Красная Пахра»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332027L, "Расположен между улицей Советской Армии, Олимпийским проспектом и Суворовской площадью", "Екатерининский парк", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332028L, "Дворовая территория по Хилкову переулку возле дома 3", "Лукоморье", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332029L, "Новокузнецкая улица рядом с домом 33, строение 1", "Сквер на Новокузнецкой улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332030L, "улица Трубная дом 15", "Парковая зона на Трубной улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332031L, "Пересечение Рабочей и Новорогожской улиц", "Парковая зона на пересечении Рабочей и Новорогожской улиц", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332032L, "Мытная улица, дом 40-44", "Сиреневый парк", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332033L, "Вдоль Люсиновской улицы от дома 2 до дома 48/50, строение 10", "Сквер на Люсиновской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332034L, "Бауманская улица дом 38", "Парковая зона на Бауманской улице", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332035L, "улица Большая Якиманка дом 35", "Дворик на Большой Якиманке у дома 35", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332036L, "Пестовский переулок дом 2 строение 1", "Парковая зона на улице Станиславского", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332037L, "Со стороны Банного переулка, дом 2 с 2", "Газон на Банном переулке", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4332039L, "Шелепихинская набережная, дом 8А", "Причальный", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 24345796L, "Бутовский лесопарк квартал 36, (природный комплекс № 113)", "лесопарк Бутовский ПК 113", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331945L, "Зелёный проспект, дом 26", "Сквер «Афганцев»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331943L, "шоссе Энтузиастов, дом 19", "Сквер у колледжа", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331807L, "улица Крымский Вал, дом 9", "ЦПКиО им. М. Горького", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331808L, "Кузьминский парк, дом 1, строение 2", "Парк культуры и отдыха «Кузьминки» (основная территория)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331813L, "Парк Дружба", "Парк «Дружба»", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331818L, "Угличская улица, владение 13", "Лианозовский парк", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331819L, "улица Менжинского, дом 6, строение 3", "Парк Бабушкинский (основная территория)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331820L, "Тополёвая аллея, владение 6, строение 1", "Музей русской усадебной культуры «Усадьба князей Голицыных «Влахернское-Кузьминки»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331824L, "Парк Северного речного вокзала", "Парк «Северного речного вокзала»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331829L, "между Волгоградским проспектом, Алтуфьевским шоссе и 84 км МКАД", "Усадьба «Алтуфьево»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331830L, "Свободный проспект, дом 2", "Зона отдыха «Терлецкая Дубрава»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331831L, "пересечение Мичуринского проспекта с улицей Лобачевского", "Парк «Олимпийской деревни»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331832L, "между улицами Пенягинская и Митинская", "Ландшафтный парк «Митино»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331838L, "между улицами Краснодонская и Заречье", "Присоединенная территория между улицами Краснодонская и Заречье", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331839L, "проспект Андропова, дом 58А", "Парк Садовники", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331842L, "Воронцовский парк, владения 1, 2, 5, 6, 7", "Воронцовский парк", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331845L, "Воробьевская набережная, Андреевская набережная", "Природный заказник «Воробьёвы горы»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331846L, "Аллея Большого Круга, дом 7 (границы территории: 1-й и 2-й улицы Измайловского Зверинца, Электродного проезда, шоссе Энтузиастов, Главной аллеи, Измайловского проспекта - до трамвайных путей)", "Измайловский парк", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331847L, "улица Каретный ряд, дом 3, строение 7", "Сад «Эрмитаж»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331848L, "город Москва, Старая Басманная улица, дом 15А, строение 4", "Сад культуры и отдыха имени Н.Э. Баумана", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331849L, "Мантулинская улица, дом 5", "Парк Красная Пресня (основная территория)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331850L, "1-я Останкинская улица, дом 5", "Музей-усадьба «Останкино»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331851L, "улица Юности, дом 2", "Усадьба Кусково", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331852L, "Каширское шоссе, дом 80, корпус 1", "Парк по Борисовским прудам", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331853L, "Белозерская улица, дом 19", "Парк «Этнографическая деревня Бибирево»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331857L, "проспект Андропова, дом 39", "Территория усадьбы «Коломенское»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331858L, "город Москва, Летняя улица, дом 1, строение 1", "Территория усадьбы «Люблино»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331805L, "улица Братьев Фонченко, дом 7", "Парк Победы на Поклонной горе", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331859L, "между Сухонской улицей, проездом Шокальского, улицей Осташковская, Олонецким проездом и улицей Менжинского", "Сквер по Олонецкому проезду", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331798L, "улица Борисовские пруды, дом 1", "Зона отдыха Борисовские пруды", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331795L, @"улица Софьи Ковалевской, владение
1", "Парк по Ангарской улице", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331742L, "улица Большая Филёвская, дом 9", "Детский парк «Фили»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331744L, "Восточная часть района Ясенево", "Природно-исторический парк «Битцевский лес»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331745L, "улица Вилиса Лациса, дом 18, корпус 3", "Природно-исторический парк «Тушинский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331751L, "между МКАД и улицей Академика Анохина, Тропаревской улицей и Востряковским шоссе", "Ландшафтный заказник «Тропарёвский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331755L, "Кузьминская улица, дом 10", "Природно-исторический парк «Кузьминки-Люблино»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331758L, "Зеленоград лесопарковая зона между 4 и 12 микрорайоном", "Крюковский лесопарк Дунькин пруд", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331759L, "между Липецкой улицей, владение 5А и Шипиловским проездом, до улицы Борисовских Прудов, напротив дома 16", "Природно-исторический парк «Царицыно»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331762L, "1-я Останкинская улица, дом 1, строение 1", "Природно-исторический парк «Останкино»", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331764L, "лесопарк Измайловский", "Природно-исторический парк «Измайлово»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331765L, "Черное озеро, Белое озеро, устье реки Рудневки", "Природно-исторический парк «Косинский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331766L, "Теплостанская возвышенность", "Ландшафтный заказник «Тёплый Стан»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331767L, "4-я линия Хорошевского Серебряного Бора, дом 74, строение 1", "Памятник природы «Серебряный Бор»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331769L, "Иваньковское шоссе, дом 8, строение 2", "Природно-исторический парк «Покровское-Стрешнево»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331776L, "Между Новосходненским шоссе, деревней Новоподрезково и рекой Сходня", "Ландшафтный заказник «Долина реки Сходни в районе Молжаниновский»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331779L, "между МКАД, Кутузовским проспектом, Мичуринским проспектом и третьим транспортным кольцом", "Природный заказник «Долина реки Сетунь»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331781L, "между Москвой-рекой и Молодогвардейской улицей, Большой Филевской улицей и МКАД", "Природно-исторический парк «Москворецкий»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331782L, "Парк культуры и отдыха Сокольники", "Природно-исторический парк «Сокольники»", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331784L, "Родионовская улица, дом 16, строение 1", "Ландшафтный заказник «Долина реки Сходни в Куркино»", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331786L, "Большая Филёвская улица, владение 22", "Парк «Фили»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331787L, "Таганская улица, дом 40 - 42", "Парк Таганский (Основная территория)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331788L, "улица Крымский Вал, владение 2", "Музеон", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331790L, "город Москва, городок имени Баумана, дом 2, строение 14", "Территория усадьбы «Измайлово»", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331792L, "Стартовая улица, дом 10", "Парк у Джамгаровского пруда", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331793L, "пересечение улицы Юности и аллеи Жемчуговой", "Парк у прудов «Радуга»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331794L, "улица Дубки", "Парк «Дубки»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331797L, "Щелковское шоссе, владение 10 - 12", "Парк «Сиреневый сад»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331944L, "Территория напротив дома 29 по Салтыковской улице", "Парк между Салтыковской улицей и Салтыковским лесопарком", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331863L, "улица Удальцова, дом 22А", "Парк «50-летия Октября»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331867L, "улица Свободы, владение 50-70", "Парк «Северное Тушино»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331912L, "от дома 7 до дома 11 корпус 4 по Алтуфьевскому шоссе", "Парковая зона реки Лихоборка", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331914L, "вдоль Юрловского проезда", "Парк «Победы»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331915L, "Чукотский проезд", "Парковая зона в пойме реки Яуза вдоль Ленской улицы, Чукотского проезда", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331916L, "Озеленённая территория - между улицей Санникова и улицей Хачатуряна", "Парк «Отрадное»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331917L, "6-я северная линия", "Парк в районе Северной водопроводной станции", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331918L, "Сквер вдоль улицы Полковая", "Сквер вдоль улицы Полковая", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331919L, "Напротив домов 13 и 15 по Юрловскому проезду", "Народный парк в пойме реки Чермянка вдоль Юрловского проезда", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331920L, "1-я Северная линия", "Парк на конечной остановке", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331921L, "город Зеленоград, 5а микрорайон у корпуса 533", "Народный парк «Бабочка»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331925L, "город Зеленоград, Территория между большим городским прудом и Озерной аллеи", "Дендропарк в районе Старое Крюково", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331926L, "город Зеленоград, вдоль корпуса 1121", "Сквер имени 50-летия города Зеленограда", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331927L, "город Зеленоград, от корпуса 416 до корпуса 456", "Сквер у 4-го микрорайона города Зеленограда", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331928L, "г Зеленоград, 10 мкр от Школьного озера до улицы Филаретовская", "Народный парк «Панфиловский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331930L, "от дома 56 корпус 2 до дома 64 по улице Кастанаевская", "Парк вдоль «Мазиловского» пруда", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331931L, "Студенческая улица дом 9", "Сквер Студенческий", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331932L, "от дома 33 корпус 3 по улица Крылатская до дома 30 корпус 7 по улице Крылатские холмы", "Парк в Крылатском", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331933L, "улица Говорова дом 1", "Можайский парк «Дубки»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331935L, "улица Озерная дом 17 - дом 27 корпус 2", "Место массового отдыха Большой Очаковский пруд", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331936L, "Боровское шоссе дом 14-16", "Парк по Боровскому шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331937L, "Ивана Франко улица дом 12-16", "Парк у Префектуры, включая зеленую территорию вдоль четной стороны ул. Ив. Франко до д.18, к.1", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331938L, "Славянский бульвар дом 5 - дом 9", "Давыдковский микропарк", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331939L, "Можайское шоссе дом 4", "Сквер Можайское шоссе д 4", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331940L, "улица Василия Ботылева дом 37 строение 2", "Парк в посёлке Рублёво", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331941L, "улица Академика Анохина владение 2", "Парк по улице Академика Анохина", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331942L, "Вдоль улицы Никулинская", "Парк Школьников", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331910L, "от Заповедной улицы до пересечения Сельскохохяйственной улицы", "Парковая зона в пойме реки Чермянка", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331866L, "город Москва, улица Сокольнический Вал, дом 1, строение 1", "Парк Сокольники", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331909L, "Пойма реки Чермянка в районе дома 28 по улице Плещеева", "пойма реки Чермянка вдоль ул. Плещеева, д.28", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331905L, "От станции метро Бибирево вдоль Костромской улицы до улицы Пришвина и дублера Алтуфьевского шоссе (вдоль роддома)", "Парк света по улице Костромская", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331868L, "улица Лазо, владение 7", "Парк культуры и отдыха «Перовский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331869L, "Дольская улица, дом 1", "Государственный музей-заповедник «Царицыно»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331870L, "улица Руставели, владение 7", "Парк «Гончаровский»", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331871L, "Большая Грузинская улица, дом 1", "Московский Зоопарк", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331879L, "Внутри квартала жилого комплекса между домом 2А по Симферопольскому бульвару, домом 16 по Фруктовой улице и домом 7, корпус 2 по Нахимовскому проспекту", "Территория, прилегающая к Симферопольскому бульвару, дом 2А", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331880L, "Ленинский проспект, дома 82-86", "Сквер по Ленинскому проспекту", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331882L, "Нахимовский проспект, владение 6", "Сквер по Нахимовскому проспекту", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331883L, "улица Шверника, дома 7-11", "Зона отдыха «Новые Черёмушки 10С»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331884L, "улица Каховка, дома 9-13", "Парк «Зюзино»", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331885L, "вдоль линии легкого метро, станция Бунинская аллея", "Парковая зона вдоль линии легкого метро «Бутовской линии»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331886L, "улица Академика Арцимовича", "Парковая зона по улице Академика Арцимовича", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331887L, "улица Академика Понтрягина", "Парковая зона на улице Академика Понтрягина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331888L, "улица Профсоюзная, дома 130, 132", "Сквер «Родничок»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331890L, "улица Профсоюзная, дома 96-98", "Сквер «Беляево-Богородское»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331891L, "Территория ограничена улицами Старобитцевская, Ратная, Старокачаловская и бульвар Дмитрия Донского", "Парковая зона на территории природного комплекса № 92 «Долина реки Битца»", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331893L, "пересечение улиц Болотниковская и Керченская", "Сквер на пересечении улиц Болотниковская и Керченская", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331894L, "улица Айвазовского (разделительный газон на участке от Литовского бульвара до Севастопольского проспекта)", "Бульвар вдоль улицы Айвазовского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331895L, "На пересечении Симферопольского бульвара и Нахимовского проспекта", "Сквер на пересечении Симферопольского бульвара и Нахимовского проспекта", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331896L, "Профсоюзная улица, дом 142", "Сквер «70-летия Победы в Великой Отечественной Войне 1941-1945 годов»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331898L, "Севастопольский проспект, дом 53", "Парковая зона в пойме рек Котловка и Коршуниха", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331899L, "улица Новочеремушкинская (участок от улицы Цюрупы до улицы Болотниковской)", "Сквер имени Федора Григорьевича Ерастова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331900L, "На пересечении проезда Карамзина и улицы Инессы Арманд", "Прилегающая территория к пруду по улице Инессы Арманд", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331901L, "Фруктовая улица, дом 11", "Сквер ДК «ЗИЛ»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331902L, "Вдоль Юрловского проезда, напротив дома 17", "Пойма реки Чермянки вдоль Юрловского проезда", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331903L, "Северный проезд", "Парк между конечной остановкой авт. 763 и Универмагом", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 4331907L, "между улицей Санникова и улицей Хачатуряна", "Озеленённая территория - между улицей Санникова и улицей Хачатуряна", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 24345836L, "Бутовский лесопарк квартал 30 природный комплекс № 101", "лесопарк Бутовский ПК 101", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 24345845L, "Бутовский лесопарк квартал 30 природный комплекс № 100", "лесопарк Бутовский ПК 100", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 24345850L, "Бутовский лесопарк кварталы 13, 14, природный комплекс № 94", "лесопарк Бутовский ПК 94", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64219651L, "Северо-Восточный Административный округ район Бабушкинский улица Чичерина", "Сквер по улице Чичерина", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64236160L, "между улицей Сальвадора Альенде, дом 3 и Песчаным переулком, дом 20", "Сквер Сальвадора Альенде", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64236164L, "в районе домов № 26 корпус 2 и №24 по улице 800-летия Москвы", "Народный парк «Наша Победа»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64244105L, "между Вагоноремонтной улицей и Карельским бульваром", "«Аллея Славы»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64245325L, "улица Тимирязевская, владения 25-27", "сквер по улице Тимирязевская, владения 25-27", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64247510L, "город Москва, между проспектом Вернадского и Университетским проспектом", "Парк имени 40-летия ВЛКСМ", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364389L, "ул Маршала Василевского д 1 к 1", "Сквер на площади Академика Курчатова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364452L, "Ул Большая Полянка д 39", "Сквер по улице Большая Полянка у дома 39", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364453L, "Ордынский тупик", "Сквер на Ордынском тупике", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364461L, "ул Малая Никитская д 4", "Сквер у Никитских Ворот", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364469L, "ул Шаболовка д 7", "Сквер на ул. Шаболовка у дома 7", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364479L, "ул Шаболовка д 2-4", "Сквер на ул. Шаболовка у домов 2-4", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364486L, "ул Большая Никитская", "Сквер у памятника Алексею Толстому", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364487L, "ул Маршала Бирюзова д 1", "Сквер у завода Энергоприбор", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364489L, "ул Расплетина д2", "Территория сквера Генерала Берзарина от ул Расплетина до ул Народного Ополчения", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364490L, "Якиманский проезд", "Сквер у Памятника Димитрова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364491L, "Спиридоньевский пер - Б Козихинский пер", "Большой Козихинский переулок 13 с 1", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364493L, "ул Берзарина д16", "Сквер у мемориала по ул Берзарина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364495L, "Большая Садовая ул д 6-8", "Сквер на Большой Садовой у домов 6-8", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364497L, "2й Спасоналивковский пер 16/5", "Сквер по 2-му Спасоналивковскому переулку", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364498L, "ул Гамалеи д19 к1", "Сквер на ул Гамалеи", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364499L, "ул Маршала Бирюзова д 32", "Сквер по ул. Маршала Бирюзова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364502L, "Елисеевский переулок", "Сквер у памятника Мстислава Растроповича", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364504L, "На протяжении ул Василевского", "Озелененная территория по ул. Василевского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364507L, "Шведский тупик", "Сквер по Шведскому тупику", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64205971L, "Чистопрудный бульвар", "Сквер на Чистопрудном бульваре", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364512L, "Шмитовский проезд 19 с 1", "Мантулинская ул", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64057612L, "от дома 5 по улице Павла Корчагина до дома 10 к 1 по улице Константинова", "Сквер Памяти героев", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64014132L, "по левую сторону проспекта Мира при движении из центра", "ВДНХ", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004128L, "Большой Могильцевский пер д 7", "Сквер на Большом Могильцевском переулке", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004130L, "Большой Левшинский пер д 6 стр 1", "Сквер у памятника Нансену", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004131L, "Уланский переулок дом 4/6", "Сквер на переулке Уланского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004135L, "Живарев переулок 15", "Грохольский сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004159L, "Земледельческий переулок д 20", "Сквер у памятника Александрову", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004408L, "улица Каланчевская, напротив дома 17", "Сквер Большевичка", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004782L, "улица Каланчевская д 32", "Сквер на улице Каланчевская у дома 32", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012865L, "Беговая улица, 22", "Сквер у ипподрома", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012871L, "Миусская площадь", "Миусский сквер", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012872L, "Коптевский бульвар от улицы Коптевская до улицы Большая Академическая", "Коптевский бульвар", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012874L, "2-й Щемиловский переулок", "Детский парк № 2", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012876L, "Перуновский переулок дом 3", "Перуновский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012877L, "улица Петровка дом 36", "Сквер на улице Петровка у дома 36", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012878L, "Спасопесковский переулок", "Сквер по Спасопесковскому переулку", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012880L, "Карманицкий переулок", "Сквер по Карманицкому переулку", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012881L, "Воздвиженка улица 11", "Арбатский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64012882L, "Никитский бульвар 5", "Сквер у музея имени Гоголя", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013082L, "Смоленская площадь 5", "Сквер по Смоленской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013088L, "Кременчугская улица", "Кременчугский бульвар", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013090L, "улица Большая Никитская владение 7/10", "Сквер по Большой Никитской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013092L, "улица Донская 21", "Сквер по улице Донская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013093L, "улица Академика Петровского", "Сквер Академика Петровского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013105L, "улица Серафимовича 3-5", "Cквер по улице Серафимовича", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013107L, "город Москва, проспект 60-летия Октября дом 31/18 корпус 1", "Сквер Хо Ши Мина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64013118L, "город Москва, улица Гарибальди (от Ленинского проспекта до улицы Профсоюзной)", "Бульвар по улице Гарибальди", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64055960L, "улица Беловежская дом 33", "Место массового отдыха Декоративный пруд", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004127L, "Тургеневская площадь дом 2", "Сквер на Тургеневской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364517L, "ул Авиационная д 20", "Озелененная территория по ул. Авиационная", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364534L, "Шмитовский пр-д д 2", "Сквер у районной Управы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366229L, "пересечение улицы Николоямская и улицы Верхняя Радищевская", "Интернациональный сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366453L, "улица Николоямская дом 1", "Сквер у библиотеки Иностранной литературы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366779L, "улица Большая Андроньевская 25-33", "Фестивальный сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366955L, "переулок Большой Факельный дом 24", "Вокзальный сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366956L, "Андроньевский проезд дом 2-8", "Рублевский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366959L, "Серебрянический переулок", "Сквер по Серебряническому переулку", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64367058L, "улица Народная дом 11-13", "Народный сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64367109L, "Ул Народного Ополчения д 20к1", "Озелененная территория по ул Народного Ополчения", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64367440L, "пересечение шоссе Энтузиастов и улицы Золоторогожский вал", "Сквер у метро Площадь Ильича", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64367706L, "ул Маршала Жукова д 2", "Озелененная территория по ул 3я Хорошевская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64368358L, "улица Динамовская", "Сквер у метро Крестьянская застава", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64368435L, "ул Вишневая д 6", "Сквер по ул Вишневая", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64368437L, "пересечение Саринского проезда и Крестьянской площади", "Сквер Крестьянская застава", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64368438L, "Рогожский вал дом 4", "Рогожский вал дом 4", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64369007L, "ул Вишневая д7", "Сквер у ДК «Красный Октябрь»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64369435L, "ул Свободы д10", "Сквер у кинотеатра «Метеор»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64369544L, "Пятницкое шоссе д23", "Сквер на Пятницком шоссе (территория памятника)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64369657L, "ул Свободы д13 к2", "Сквер у Префектуры", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64369947L, "ул Свободы д 18", "Сквер по ул Свободы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64370329L, "Ангелов переулок д6к3", "Бульварная зона микрорайона 4", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64370438L, "ул Свободы д 23", "Сквер на ул Свободы", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64371147L, "улица Пятницкая дом 25", "Сквер у Радиокомитета", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64371601L, "Космодамианская набережная дом 4/22", "Сквер по Космодамианской набережной у домов 4-22", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64371820L, "От ул Вишневой до ул Большая Набережная д 25 к1", "Озелененная территория по ул Малая Набережная", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64371965L, "улица Садовническая дом 36", "Устьинский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366228L, "улица Абельмановская 17", "Абельмановский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364520L, "ул 1905 года", "Сквер на улице 1905 года у метро", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366203L, "ул Катукова д 2 до д 22 к1", "Бульвар по ул Катукова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366041L, "Сибирский проезд дом 20", "Боенский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364541L, "Волоколамское шоссе д 30", "Озелененная территория по Волоколамскому шоссе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364550L, "Кудринская площадь д 1", "Сквер Кудринской площади", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364552L, "Красногвардейский бульвар д 1", "Сквер на Красногвардейском бульваре у дома 1 у бензоколонки", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364555L, "ул Подвойского", "Сквер по ул Подвойского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364568L, "Тверской бульвар", "Сквер на Тверском бульваре", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364573L, "ул Кулакова д 6 к 3 д 8", "Сквер по ул. Кулакова", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364580L, "ул Исаковского д 28 к1", "Сквер по ул Исаковского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364585L, "Никитский бульвар", "Сквер на Никитском бульваре", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364587L, "Тишинская пл", "Сквер на Тишинской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364588L, "Б Грузинская д 20", "Сквер по Большой Грузинской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364592L, "ул Заморенова", "Озелененный участок у метро Краснопресненская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364596L, "ул Сергея Макееева", "Озелененный участок по ул. Сергея Макеева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364597L, "Озелененная территория от Большой Грузинской до Зоологической улицы", "Озелененная территория от Большой Грузинской до Зоологической улицы", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364598L, "Б Садовая д 5", "Сквер на улице Большая Садовая, у дома 5", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364599L, "Страстной бульвар", "Сквер на Страстном бульваре", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364600L, "Петровский бульвар", "Сквер на Петровском бульваре", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364601L, "Рождественский бульвар", "Сквер на Рождественском бульваре", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364602L, "Сретенский бульвар", "Сретенский бульвар", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364603L, "Покровский бульвар", "Покровский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64364604L, "Яузский бульвар", "Яузский бульвар", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64365969L, "улица Средняя Калитниковская", "Сквер у Калитниковского пруда", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64365985L, "улица Талалалихина пересечение с улицей Малая Калитниковская", "Талалихинский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366007L, "улица Рогожский вал", "Рогожский вал ул., д.6, д.8, д.10", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366013L, "ул Таллинская д 3 к1 до д 19 к1", "Сквер по ул. Таллинская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366019L, "улица Средняя Калитниковская", "Калитниковский сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64366176L, "улица Абельмановская дом 28-49", "Крестьянский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004123L, "1-й Тружеников пер вл 17А", "Сквер на переулке Тружеников", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004122L, "ул Пречистенка д 30", "Сквер у памятника Сурикову", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004121L, "Коломенская набережная от дома 6 до дома 26", "Пешеходная зона по Коломенской набережной от дома 6 до дома 26", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466733L, "Окружают улицы: 10-й километр Московской Кольцевой Автодороги и Привольная улица", "Природный заказник «Жулебинский»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466737L, "Вдоль 81-го километра Московской Кольцевой Автодороги", "Хлебниковский лесопарк (квартал 127 леспаркхоза «Северный» у платформы «Марк» Савеловского направления Московской железной дороги", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466915L, "Окружают улицы: 10-й километр Московской Кольцевой Автодороги и Волгоградский проспект", "Планируемый к созданию природный заказник «Выхинский» (природный комплекс № 100)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467004L, "Вдоль Ленинградского шоссе", "Крюковский лесопарк (природный комплекс № III)", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467027L, "Окружен улицами: Челобитьевское шоссе, Дмитровское шоссе, 83-й километр Московской Кольцевой Автодороги", "Планируемый к созданию природный заказник «Северный» (природный комплекс № 25)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467028L, "Вдоль 80-го километра Московской Кольцевой Автодороги", "Хлебниковский (Коровинский) лесопарк (квартал 126 леспаркхоза «Северный», природный коплекс № 19)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467197L, "Вблизи Панфиловского проспекта, владения 158, 160", "Крюковский лесопарк (природный комплекс № V)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467295L, "Панфиловский проспект, владение 222А", "Крюковский лесопарк (природный комплекс № VIII)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467341L, "Окружен улицами: Череповецкая улица, Угличская улица", "Планируемый к созданию ландшафтный заказник «Лианозовский» (природный комплекс № 54)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467342L, "Окружен улицами: Ленинградским шоссе и проектируемым проездом № 5253, народный парк Ровесник", "Крюковский лесопарк (природный комплекс № 4)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467349L, "Окружен улицами: улица Лескова, Алтуфьевское шоссе, 86-й километр Московской Кольцевой Автодороги, Мелиховская улица", "Планируемый к созданию комплексный заказник «Алтуфьевский» (природный комплекс № 34)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467388L, "Вдоль улицы Дубки", "Парк «Дубки» по улице Дубки (природный комплекс № 148)", "нет", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467389L, "Окружен улицами: улица Юности, Московский проспект", "Крюковский лесопарк (природный комплекс № X)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467480L, "Вдоль Новодачной улицы", "Планируемый к созданию фаунистический заказник «Долгие пруды» (природный комплекс № 13)", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467504L, "Окружен улицами: Алабушевская улица и проспект Генерала Алексеева", "Крюковский лесопарк (природный комплекс № VII)", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467620L, "Окружен улицами: Московский проспект, Никольский проезд", "Крюковский лесопарк (природный комплекс № XI)", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467689L, "Окружен улицами: Челобитьевское шоссе, Дмитровское шоссе", "Хлебниковский лесопарк (природный комплекс № 23)", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467840L, "Окружен улицами: от пересечения Московского проспекта с Никольским проездом до восточной границы Зеленограда, Восточная промзона и проектируемым проездом № 4921", "Крюковский лесопарк (природный комплекс № XII)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467842L, "Окружен улицами: Дмитровское шоссе, Долгопрудная аллея", "Планируемый к созданию фаунистический заказник «Долгие пруды» (природный комплекс № 1)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58467981L, "Окружен улицами: проектируемый проезд № 237, Дмитровское шоссе", "Планируемый к созданию природный заказник «Северный» (природный комплекс № 16)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468019L, "Окружен улицами: Между Панфиловским проспектом и проектируемым проездом № 5372", "Крюковский лесопарк (природный комплекс № XIV)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468097L, "Вдоль Пятницкого шоссе", "Митинский лесопарк (квартал 66 Новогорского лесничества), район Митино (природный комплекс № 22)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468207L, "Окружен улицами: Череповецкая улица, Псковская улица, Зональная улица, Угличская улица", "Планируемый к созданию ландшафтный заказник «Лианозовский» (природный комплекс № 27)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468269L, "Окружен улицами: от проектируемого проезда № 5372 до 2-го Западного проезда, Панфиловским проспектом", "Крюковский лесопарк (природный комплекс № XV)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468447L, "Окружен улицами: Череповецкая улица, Псковская улица, Лианозовский проезд", "Планируемый к созданию ландшафтный заказник «Лианозовский» (природный комплекс № 53)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466684L, "Вдоль 28-го километра Московской Кольцевой Автодороги", "Видновский лесопарк (квартал 13, природный комплекс № 189)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468577L, "Окружен: Панфиловским проспектом и Рабочей улицей, набережной пруда Ищучий, Центральным проспектом и Озёрной аллеей", "Крюковский лесопарк (природный комплекс № XVII)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466468L, "Окружен улицами: Варшавское шоссе, вдоль 33-го километра Московской Кольцевой Автодороги, Дорожной улицы", "Аннинский лесопарк (квартал 30 Битцевского леса, природный комплекс № 181)", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466358L, "улица Ворошилова, дом 110", "Крюковский лесопарк (природный комплекс № XXVII)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 25142883L, "от ул Беломорская улица, 16А до Фестивальная улица, 17к1", "Сквер у кинотеатра Нева", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 25765327L, "улица Лавочкина, 32", "Народный парк по ул. Лавочкина, д. 32", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37143894L, "Между улицей Кошкина, дом 19, корпус 1 и улицей Кантемировская, дом 4, корпус 3", "Сквер «Кантемировский»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37143964L, "Между улицей Сумская и улицей Днепропетровская", "Сквер у кинотеатра «Ашхабад»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37144148L, "Улица Ереванская, между кинотеатром Эльбрус и Кавказским бульваром", "Сквер у кинотеатра «Эльбрус»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37144228L, "Пересечение улицы Генерала Белова с улицей Воронежская", "Парк на пересечении улицы Генерала Белова с улицей Воронежская", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37154034L, "Вдоль 76-го километра Московской Кольцевой Автодороги", "Химкинский лесопарк (кварталы № 32, 33 Красногорского леспаркхоза, природный комплекс № 45)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37220242L, "Территория между мкр 15 и мкр 4 Парк Дубрава", "Территория между мкр 15 и мкр 4 Парк Дубрава", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37229204L, "улица Красноказарменная, дом 2", "Сквер на Красноказарменной улице, д.2 (сквер Воинов-победителей)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37362713L, "Красноказарменная улица, дом 8", "Парк Казачьей Славы", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37367483L, "ул Вятская 41", "Народный парк «Автомобилист»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37442359L, "Малыгинский проезд", "Сквер по Малыгинскому проезду", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37442491L, "пересечение улицы 1905 года улицы Трехгорный Вал и Шмитовский проезд", "Сквер 1905 года", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 37752177L, "Проспект Мира", "Алексеевская горка", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 38382991L, "Дмитровское шоссе, дом 49, корпус 1", "Сквер у кинотеатра «Комсомолец»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 38427984L, "Фрунзенская набережная, дом 8", "Ботанический сад Сад имени П.И.Травникова", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 39340858L, "между Рассветной аллеей, аллеей Первой Маёвки и улицей Юности", "Объект природного комплекса ПК № 80 Лесопарк Кусково", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 39683561L, "Ленинградский проспект дома 47 - 49", "Сквер у южного выхода станции метро Аэропорт", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 57274027L, "Россия, Москва, Петровско-Разумовский проезд, 29", "Савеловский парк", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 57697540L, "улица Винокурова дом 4", "Сквер Диета", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 57849361L, "улица Нагорная дом 39 корпус 4", "Парк «Сосенки»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 57958239L, "город Москва улица Болотниковская", "Парк имени 70-летия Победы", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 57974413L, "город Москва улица 2-я Северодонецкая", "Сквер Защитников Московского неба", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466224L, "Вдоль 22-го километра Московской Кольцевой Автодороги", "Видновский (Зябликовский) лесопарк, квартал 2 (природный комплекс № 180)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466330L, "Окружен улицами: Ленинградское шоссе и проездом № 5253", "Крюковский лесопарк (природный комплекс № 6)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58466442L, "Вдоль Боровского шоссе", "25 квартал Баковского лесопарка", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468582L, "Окружен улицами: Студёный проезд, Полярная улица, 89-й километр Московской Кольцевой Автодороги", "Планируемый к созданию природный заказник «Медведковский» (природный комплекс № 38)", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468625L, "Вдоль Авиационной улицы", "Лесопарк «Покровское-Стрешнево», квартал 11 (Всехсвятская роща) по Авиационной улице (природный комплекс № 94)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468734L, "Окружен улицами: Озёрная аллея, Каштановая аллея", "Крюковский лесопарк (природный комплекс № XVII) народный парк 40-летия Победы и Дунькин пруд", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001932L, "улица Гиляровского 68", "Сквер на ул. Гиляровского у дома 68", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001997L, "улица Спартаковская", "Елоховский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64002062L, "улица Старая Басманная 35", "Площадь Разгуляй", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64002349L, "улица Бакунинская 43-55", "Сквер на улице Бакунинская у домов 43-55", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64002431L, "Рубцовская набережная", "Рубцовский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64002510L, "Сыромятнический 3-ий переулок, против д 1,3", "Нижний Сыромятнический сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64002655L, "улица Радио пересечение с Елизаветинским переулком", "Сквер по улице Радио", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003202L, "Центросоюзный переулок", "Сквер на Центросоюзном переулке", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003203L, "улица Покровка 5", "Парковая зона на улице Покровка у дома 5", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003204L, "Семеновская набережная", "Аллея Серп и Молот", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003394L, "улица 2-я Фрунзенская", "Бульвар на 2-ой Фрунзенской", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003466L, "улица 3-я Фрунзенская", "Бульвар на 3-й Фрунзенской", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003534L, "переулок Сивцев Вражек д 11", "Сквер по переулку Сивцев Вражек", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003599L, "ул Тимура Фрунзе", "Сквер на Тимура Фрунзе", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003650L, "ул 1-я Фрунзенская", "Сквер на 1-й Фрунзенской ул", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003709L, "ул 1-я Фрунзенская д 22", "Сквер у Министерства обороны", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003774L, "ул Остоженка д 17", "Сквер на Остоженке у дома 17", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64003833L, "Комсомольский пр-т д 1", "Сквер у Крымской эстакады", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004107L, "7-й Ростовский пер д 1", "Озелененный участок над Ростовским откосом", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004108L, "пер 1-й Вражский", "Сквер на 1-м Вражском (ЗАГС)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004109L, "ул Усачева от 10-летия Октября до Учебного переулка", "Сквер по ул. Усачева", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004113L, "Лужнецкий проезд д 1А", "Сквер на Лужнецком проезде", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004116L, "Лужнецкий проезд", "Сквер на Лужнецком проезду (от Учебного переулка)", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004117L, "Лужнецкий проезд д 1", "Сквер у памятника «Молодым ученым»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64004120L, "ул 10 Летия Октября 13с1", "Сквер у метро Спортивная", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001926L, "улица Покровка 20", "Сквер Чернышевского", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001922L, "Покровский бульвар 10", "Сквер Милютинский сад", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001816L, "Борисоглебский переулок 9", "Сквер по Борисоглебскому переулку у Монгольского посольства", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001767L, "улица Поварская 15", "Сквер у памятника Бунину", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468872L, "деревня Малино вдоль Солнечной улицы", "Крюковский лесопарк (природный комплекс № XXVI)", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 58468887L, "Вдоль Щукинской улицы", "Лесопарк «Покровское-Стрешнево», квартал 12 (Щукинский лесопарк) по Щукинской улице (природный комплекс № 98)", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 59769450L, "Вдоль Щукинской улицы", "Лесопарк «Покровское-Стрешнево» по Щукинской улице (природный комплекс № 97)", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 60819921L, "Проспект Мира", "Объект озеленения Аллея Героев космоса и сквер, прилегающий к Мемориальному музею космонавтики", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 60820910L, "Дмитровское шоссе, дом 58", "Сквер у 7-го автобусного парка", "нет", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 60825059L, "Московская аллея", "Московская аллея", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61000611L, "Краснохолмская набережная владение 11", "Сквер на Краснохолмской набережной", "да", "нет", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61003248L, "Калужская площадь", "Сквер на Калужской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61004417L, "Большая Сухаревская площадь, Панкратьевский переулок", "Сквер на Сухаревской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61006256L, "Площадь Гагарина", "Площадь Гагарина", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61021998L, "Лермонтовская площадь", "Лермонтовский сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61026075L, "Пересечение Устьинского проезда, улицы Яузская и Устьинской набережной", "Устьинский Сквер", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64372252L, "улица Пятницкая дом 67", "Сквер по улице Пятницкая у дома 67", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61029422L, "улица Смоленская дом 1", "Сквер на Смоленской площади", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61274171L, "Ул Алабяна напротив дома № 3", "Сквер «Арбатец»", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 62421970L, "Волжский бульвар", "«Волжский бульвар, ПК №33»", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 62435316L, "улица Новорязанская 29", "Милютинский парк", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 62920437L, "между улицей Кантемировская и пролетарским Проспектом", "Сквер на Кантемировской улице", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 63809599L, "Вдоль Проектируемого проезда № 5408 и 5314", "Голубинский лесопарк", "да", "да", "да" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 63835513L, "Ореховый бульвар участок между владениями 28Б и 57", "Озелененная территория в конце Орехового бульвара", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 63985578L, "переулок Огородная Слобода, 6", "Сквер в переулке Огородная Слобода, у дома 6", "да", "да", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 63985580L, "Леонтьевский переулок", "Сквер у Леонтьевского переулка", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 63985596L, "на пересечении улиц Кубанская, Люблинская", "Кубанская улица, озеленения 2-й категории", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001126L, "улица Большая Грузинская, 25", "Георгиевский сквер", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001326L, "улица Поварская 33", "Сквер у Дома Актера", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 64001667L, "Большой Ржевский переулок", "Сквер у Бельгийского посольства", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 61090768L, "Гончарная набережная", "Сквер на Гончарной набережной", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1035309315L, "улица Чертановская, дом 32", "Озелененная территория около Красного пруда", "нет", "нет", "да" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
