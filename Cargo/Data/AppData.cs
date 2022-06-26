using System.Collections.Generic;

namespace Cargo.Data;

public static class AppData
{
    private static readonly string imagesPath = "/images";
    private static readonly string carouselImagesPath = $"{imagesPath}/carousel";

    public static string LogoPath { get; set; } = $"{imagesPath}/logo.png";

    public static List<MenuLink> MenuLinks = new()
    {
        new MenuLink { Title = "Цены и сроки", Url = "delivery"},
        new MenuLink { Title = "Услуги", Url = "services"},
        new MenuLink { Title = "О компании", Url = "about"},
        new MenuLink { Title = "Контакты", Url = "footer"},
        new MenuLink { Title = "Оформить груз", Url = "registration"}
    };

    public static List<DeliveryCard> DeliveryCards = new()
    {
        new DeliveryCard { Image = $"{imagesPath}/AutoRegular.png", Title = "Авто - обычная", Period = "9-15 дней", Weight = 5 , Price = 2.5m},
        new DeliveryCard { Image = $"{imagesPath}/AutoFast.png", Title = "Авто - ускоренная", Period = "9-15 дней", Weight = 5, Price = 2.5m},
        new DeliveryCard { Image = $"{imagesPath}/Avia.png", Title = "Авиа", Period = "9-15 дней", Weight = 5, Price = 2.5m},
        new DeliveryCard { Image = $"{imagesPath}/Train.png",  Title = "Ж/д", Period = "9-15 дней", Weight = 5, Price = 2.5m},
        new DeliveryCard { Image = $"{imagesPath}/Ship.png", Title = "Море", Period = "9-15 дней", Weight = 5, Price = 2.5m}
    };

    public static List<ServiceCard> ServicesCards = new()
    {
        new ServiceCard { Title = "Выкуп товара", Description = "Компания - это полный комплекс логистических услуг по доставке грузов из Китая в Россию - сборные грузы и цельные товарные партии, услуги посредника ТаоБао, КАРГО Китай-Россия.", Image = "images/worker.jpg"},
        new ServiceCard { Title = "Страховка груза", Description = "Компания - это полный комплекс логистических услуг по доставке грузов из Китая в Россию - сборные грузы и цельные товарные партии, услуги посредника ТаоБао, КАРГО Китай-Россия.", Image = "images/office.jpg"},
        new ServiceCard { Title = "Аренда склада", Description = "Компания - это полный комплекс логистических услуг по доставке грузов из Китая в Россию - сборные грузы и цельные товарные партии, услуги посредника ТаоБао, КАРГО Китай-Россия.", Image = "images/storage.jpg"},
        new ServiceCard { Title = "Перевод денежных средств", Description = "Компания - это полный комплекс логистических услуг по доставке грузов из Китая в Россию - сборные грузы и цельные товарные партии, услуги посредника ТаоБао, КАРГО Китай-Россия.", Image = "images/card.jpg"}
    };

    public static List<CarouselContent> CarouselContents = new()
    {
        new CarouselContent { Title = "Прямое КАРГО из Китая", Text = "Доставляем любые грузы из Китая по честной цене", ImagePath = $"{carouselImagesPath}/ship.png", ButtonText = "Рассчитать стоимость", ImageAlt = "Прямое КАРГО из Китая"},
        new CarouselContent { Title = "Гарантируем сроки!", Text = "Если мы не уложимся в обозначенные сроки,доставка груза со скидкой до 90%", ImagePath = $"{carouselImagesPath}/guarantee.png", ButtonText = "Рассчитать стоимость", ImageAlt = "Гарантируем сроки"},
        new CarouselContent { Title = "Выкуп товара с ТаоБао, 1688", Text = "Выкуп и доставка товаров с китайских торговых площадок", ImagePath = $"{carouselImagesPath}/taobao.png", ButtonText = "Рассчитать стоимость", ImageAlt = "Выкуп товара с ТаоБао"},
        new CarouselContent { Title = "Экспресс авто доставка", Text = "Доставка автотранспортом из Китая в Россию от 15 дней, от $0,5/кг", ImagePath = $"{carouselImagesPath}/track.png", ButtonText = "Рассчитать стоимость", ImageAlt = "Экспресс авто доставка"}
    };

    public static List<FeatureModel> Features = new()
    {
        new FeatureModel { ImagePath = "/images/customs.png", Content = "Таможенное оформление груза"},
        new FeatureModel { ImagePath = "/images/insurance.png", Content = "Страховка груза"},
        new FeatureModel { ImagePath = "/images/check.png", Content = "Проверка товара на брак"},
        new FeatureModel { ImagePath = "/images/delivery-truck.png", Content = "Доставка в любой город РФ"},
        new FeatureModel { ImagePath = "/images/speech-bubble.png", Content = "Консолидация на складе"},
        new FeatureModel { ImagePath = "/images/like.png", Content = "Ответственное хранение груза"},
        new FeatureModel { ImagePath = "/images/credit-card.png", Content = "Помощь в оплате товара"},
        new FeatureModel { ImagePath = "/images/stack.png", Content = "Упаковка, переупаковка, паллетирование груза к международной перевозке"}
    };

    public static List<AccordionItem> AccordionContent = new()
    {
        new AccordionItem {Title = "Как рассчитывается стоимость доставки?", Text = "Да, мы предоставляем такую услугу, мы можем взять оплату товара в Китае на себя. Если у вас нет валютного счёта, то можете оплатить товар в рублях на наш счет в России."},
        new AccordionItem {Title = "Как происходит оплата за доставку груза?", Text = "Да, мы предоставляем такую услугу, мы можем взять оплату товара в Китае на себя. Если у вас нет валютного счёта, то можете оплатить товар в рублях на наш счет в России."},
        new AccordionItem {Title = "Как быстро оформить заказ на доставку из Китая в Россию?", Text = "Да, мы предоставляем такую услугу, мы можем взять оплату товара в Китае на себя. Если у вас нет валютного счёта, то можете оплатить товар в рублях на наш счет в России."},
        new AccordionItem {Title = "Можно ли через вас оплатить товар поставщику?", Text = "Да, мы предоставляем такую услугу, мы можем взять оплату товара в Китае на себя. Если у вас нет валютного счёта, то можете оплатить товар в рублях на наш счет в России."},
        new AccordionItem {Title = "В чём особенность КАРГО доставки из Китая", Text = "Да, мы предоставляем такую услугу, мы можем взять оплату товара в Китае на себя. Если у вас нет валютного счёта, то можете оплатить товар в рублях на наш счет в России."},
        new AccordionItem {Title = "Какой срок доставки из Китая?", Text = "Да, мы предоставляем такую услугу, мы можем взять оплату товара в Китае на себя. Если у вас нет валютного счёта, то можете оплатить товар в рублях на наш счет в России." }
    };

    public static List<RegistrationBlockModel> RegistrationBlocks = new()
    {
        new RegistrationBlockModel 
        { 
            Image = "images/crane.png", ImageAlt = "Оформление",
            ParagraphsList = new() 
            {
                "Для того, чтобы начать сотрудничество, необходимо оформить груз указав информацию о содержимом груза, его стоимость и количество. А так-же прикрепив фотографии к заявке.",
                "Если требуется проверка товара на соответсвие количеству, то при оформлении груза на нашем сайте укажите это в графе \"Примечание\". Данная услуга платная и составляет 3 юаня за одну позицию в заказе. Любые дополнительные проверки груза обсуждаются индивидуально в том числе и их стоимость.",
                "До отправки груза на наш склад в Китае обязательно позаботьтесь о том, чтобы сделать маркировку, с номером Вашего заказа у нас на сайте, для каждой внешней коробки, чтобы мы смогли определить именно Ваш груз. Если у Вас нет возможности сделать это самостоятельно, то попросите об этом своего поставщика."
            } 
        },
        new RegistrationBlockModel
        {
            Image = "images/track.png", ImageAlt = "Отправка",
            ParagraphsList = new()
            {
                "После отправки груза на наш склад в Китае, Вам обязательно нужно указать трек-номер для отслеживания посылок по Китаю для каждой позиции в заказе. Внести трек-номер можно на странице заказа. Трек-номер - это ещё одна мера для идентификации Вашего груза на нашем складе.",
                "Если Вы оформили груз по нашей инструкции и сделали все правильно, то при получении Вашего груза на складе в Китае статус заказа изменится на \"На складе\"."
            }
        }
    };
}
