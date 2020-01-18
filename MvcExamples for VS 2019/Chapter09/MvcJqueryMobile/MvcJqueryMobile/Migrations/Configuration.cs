namespace MvcJqueryMobile.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MvcJqueryMobile.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcJqueryMobile.Models.MobileContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcJqueryMobile.Models.MobileContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Heroes.AddOrUpdate(
                x => x.Id,
                new Hero { Id = 1, PageId = "page_Zilean", Header = "�ɥ��u�@�� ���F", Footer = "Zilean ���F", Introduction = "���F�O�ɥ��u�@�̡A�i�H�ᦱ���N�^�����ɥ��A�i�H��ͤ�^���μĤ�^���I��C", ImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg", ImageAlt = "Zilean", VideoUrl = "https://www.youtube.com/embed/_Jc7bZZlGIo" },
                new Hero { Id = 2, PageId = "page_Teemo", Header = "�������� ����", Footer = "Teemo ����", Introduction = "�������N��Z���Чj�b�A�ϥΤF�Ķ���w���j�O�L�����@�P�r�r�C", ImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg", ImageAlt = "Teemo", VideoUrl = "https://www.youtube.com/embed/Qj48qHM1MXE" },
                new Hero { Id = 3, PageId = "page_Sona", Header = "�^�P ���R", Footer = "Sona ���R", Introduction = "���R�t�����۫߯����F��_�R�A�Ӧo���I�I�o�p���ߵ��͡C", ImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_4.jpg", ImageAlt = "Sona", VideoUrl = "https://www.youtube.com/embed/MAiOAert8us" }
            );

            context.Cars.AddOrUpdate(x => x.Id,
                new Car { Id = 1, Name = "Mercedes-AMG S63", Price = 145695, ImageUrl = "Mercedes_AMG_S63.jpg", Category = "�⨮" },
                new Car { Id = 2, Name = "Audi S8", Price = 116875, ImageUrl = "Audi_S8.jpg", Category = "�⨮" },
                new Car { Id = 3, Name = "BMW M3", Price = 66495, ImageUrl = "BMW_M3.jpg", Category = "�⨮" },
                new Car { Id = 4, Name = "Alfa Romeo Giulia Quadrifoglio", Price = 73595, ImageUrl = "AlfaRomeo_GiuliaQuadrifoglio.jpg", Category = "�⨮" },
                new Car { Id = 5, Name = "MercedesBenz GLS Class", Price = 68045, ImageUrl = "MercedesBenz_GLS.jpg", Category = "SUV" },
                new Car { Id = 6, Name = "Porsche Cayenne", Price = 60650, ImageUrl = "Porsche_Cayenne.jpg", Category = "SUV" },
                new Car { Id = 7, Name = "Honda CR-V", Price = 24985, ImageUrl = "Honda_CRV.jpg", Category = "SUV" },
                new Car { Id = 8, Name = "Bugatti Chiron", Price = 2998000, ImageUrl = "Bugatti_Chiron.jpg", Category = "�]��" },
                new Car { Id = 9, Name = "Lamborghini Huracan", Price = 203295, ImageUrl = "Lamborghini_Huracan.jpg", Category = "�]��" },
                new Car { Id = 10, Name = "Porsche 718 Boxster", Price = 57050, ImageUrl = "Porsche_718Boxster.jpg", Category = "�]��" }
            );
            
        }
    }
}
