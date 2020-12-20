using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebNurgalieva.Models
{
    public class DBInitializer: DropCreateDatabaseAlways<DogContext>
    {
        protected override void Seed(DogContext context)
        {
            context.Dogs.Add(new Dog() { Name = "Алабай - большой добряк", Price = 12000, Img ="img/olabay.jpg" });
            context.Dogs.Add(new Dog() { Name = "Немецкая Овчарка - верный защитник", Price = 10000, Img = "img/ovch.jpg" });
            context.Dogs.Add(new Dog() { Name = "Боксер - милый Злюка", Price = 12000, Img = "img/boxer.jpg" });
            context.Dogs.Add(new Dog() { Name = "Бульдог - тот самый из мультфильма Рио ", Price = 15000, Img = "img/buld.jpg" });
            context.Dogs.Add(new Dog() { Name = "Хаски - благородный милашка", Price = 17000, Img = "img/haski.jpg" });

            base.Seed(context);
        }
    }
}