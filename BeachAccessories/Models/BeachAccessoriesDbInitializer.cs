using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BeachAccessories.Models
{
    public class BeachAccessoriesDbInitializer : DropCreateDatabaseAlways<BeachAccessoriesDbContext>
    {
        protected override void Seed(BeachAccessoriesDbContext db)
        {
            db.Mats.Add(new Mat { Name = "Единороги", Color = "Синий", Price = 1000 });
            db.Mats.Add(new Mat { Name = "Лимон", Color = "Желтый", Price = 950 });
            db.Mats.Add(new Mat { Name = "Фламинго", Color = "Розовый", Price = 1100 });

            db.Mattresses.Add(new Mattress { Name = "Кресло-Матрац", Color = "Синий", Price = 700 });
            db.Mattresses.Add(new Mattress { Name = "Кресло-Шезлонг", Color = "Белый", Price = 1100 });

            db.Rings.Add(new Ring { Name = "Пончик с присыпкой", Color = "Белый", Price = 350 });
            db.Rings.Add(new Ring { Name = "Фламинго", Color = "Розовый", Price = 650 });

            db.Umbrellas.Add(new Umbrella { Name = "Зонт пляжный", Color = "Голубой", Price = 250 });
            db.Umbrellas.Add(new Umbrella { Name = "Зонт пляжный", Color = "Синий", Price = 250 });
            db.Umbrellas.Add(new Umbrella { Name = "Зонт пляжный", Color = "Салатовый", Price = 250 });

            db.Towels.Add(new Towel { Name = "Marlies Dekkers Gray", Color = "Серый", Price = 450 });
            db.Towels.Add(new Towel { Name = "Marlies Dekkers Red", Color = "Красный", Price = 450 });
            db.Towels.Add(new Towel { Name = "Saffron Yellow", Color = "Жёлтый", Price = 400 });

            db.Hats.Add(new Hat { Name = "Marc & Andre White", Color = "Белый", Price = 800 });
            db.Hats.Add(new Hat { Name = "Seafolly Black", Color = "Чёрный", Price = 650 });
            db.Hats.Add(new Hat { Name = "Seafolly Gold", Color = "Золотой", Price = 700 });



            base.Seed(db);
        }
    }
}