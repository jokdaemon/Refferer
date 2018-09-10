using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class MultiColumnSample : Form
    {
        public MultiColumnSample()
        {
            InitializeComponent();

            autocompleteMenu1.MaximumSize = new System.Drawing.Size(250, 400);
            var columnWidth = new int[] { 50, 100, 250 };

            /*
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "001", "Mr. Adam Smith" }, "Adam Smith") {ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "002", "Ms. Eva Smith" }, "Eva Smith") { ColumnWidth = columnWidth, ImageIndex = 1 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "007", "Mr. Bond, James Bond" }, "James Bond") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "666", "Mr. Sam, Serios Sam" }, "Serios Sam") { ColumnWidth = columnWidth, ImageIndex = 0 });
            */
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "12", "CBROBOT", "Робот системы Клиент - банк" }, "Робот системы Клиент - банк", "12 CBROBOT Робот системы Клиент - банк") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "13", "CARDROBOT", "Робот АКС" }, "Робот АКС", "13 CARDROBOT Робот АКС") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "46", "WEBBANKSVC", "Пользователь Вебсервиса" }, "Пользователь Вебсервиса", "46 WEBBANKSVC Пользователь Вебсервиса") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "51", "MEGABANK\\MTSUser", "Сервер приложений Account manager" }, "Сервер приложений Account manager", "51 MEGABANK\\MTSUser Сервер приложений Account manager") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "52", "bll", "Отчеты сервера приложений" }, "Отчеты сервера приложений", "52 bll Отчеты сервера приложений") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "60", "KseRobot", "Робот интеграции с информационными киосками" }, "Робот интеграции с информационными киосками", "60 KseRobot Робот интеграции с информационными киосками") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "101", "TRIPOLSKY", "Трипольський Сергій Євгенович" }, "Трипольський Сергій Євгенович", "101 TRIPOLSKY Трипольський Сергій Євгенович") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "104", "VALYA", "Рівчак Валентина Іванівна" }, "Рівчак Валентина Іванівна", "104 VALYA Рівчак Валентина Іванівна") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "127", "TerenkovskyiID", "Теренковський Іван Дмитрович" }, "Теренковський Іван Дмитрович", "127 TerenkovskyiID Теренковський Іван Дмитрович") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "128", "SHKUMAT", "Шкумат Олексій Васильович" }, "Шкумат Олексій Васильович", "128 SHKUMAT Шкумат Олексій Васильович") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "154", "VLAD", "Шполянский В.В." }, "Шполянский В.В.", "154 VLAD Шполянский В.В.") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "194", "POPAZOV", "Попазов Костянтин Петpович" }, "Попазов Костянтин Петpович", "194 POPAZOV Попазов Костянтин Петpович") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "209", "TETINKA", "Хахалева Т.И." }, "Хахалева Т.И.", "209 TETINKA Хахалева Т.И.") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "235", "NEDAV", "Недавня Вікторія Сергіївна" }, "Недавня Вікторія Сергіївна", "235 NEDAV Недавня Вікторія Сергіївна") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "305", "rodina", "Піднебенна Валеpія Володимиpівна" }, "Піднебенна Валеpія Володимиpівна", "305 rodina Піднебенна Валеpія Володимиpівна") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "326", "martinova", "Мартинова Тетяна Юріївна" }, "Мартинова Тетяна Юріївна", "326 martinova Мартинова Тетяна Юріївна") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "428", "bondarenko", "Бондаренко Р.А." }, "Бондаренко Р.А.", "428 bondarenko Бондаренко Р.А.") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "446", "fedunova", "Федунова Тетяна Миколаївна" }, "Федунова Тетяна Миколаївна", "446 fedunova Федунова Тетяна Миколаївна") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "473", "lisih", "Лисих К.О." }, "Лисих К.О.", "473 lisih Лисих К.О.") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "494", "gusyn", "Гусєва Юлія Миколаївна" }, "Гусєва Юлія Миколаївна", "494 gusyn Гусєва Юлія Миколаївна") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "525", "solovey", "Соловей Е.Н." }, "Соловей Е.Н.", "525 solovey Соловей Е.Н.") { ColumnWidth = columnWidth });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "1000", "megabank\\joker", "Слободян Віталій Петpович" }, "Слободян Віталій Петpович", "1000 megabank\\joker Слободян Віталій Петpович") { ColumnWidth = columnWidth });



        }
    }
}
