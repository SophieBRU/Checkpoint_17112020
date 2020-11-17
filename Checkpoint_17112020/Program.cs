using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Checkpoint_17112020
{
    class Program
    {
        static void Main()
        {
            using (var context = new CampusContext())
            {
                context.Database.EnsureDeleted();

                context.Database.EnsureCreated();

                var promotion1 = new Promotion
                {
                    Name = "Javascrip"
                };

                promotion1.Students = new List<Student>
                {
                    new Student { Lastname = "BOND", Firstname = "James" },
                    new Student { Lastname = "BALBOA", Firstname = "Rocky" },
                    new Student { Lastname = "INGALLS", Firstname = "Laura" },
                    new Student { Lastname = "CONNOR", Firstname = "Sarah" },
                    new Student { Lastname = "PAN", Firstname = "Peter" },
                };

                context.Add(promotion1);

                var promotion2 = new Promotion
                {
                    Name = "CSharp"
                };

                promotion2.Students = new List<Student>
                {
                    new Student { Lastname = "KENT", Firstname = "Clark" },
                    new Student { Lastname = "PARKER", Firstname = "Peter" },
                    new Student { Lastname = "WIDOW", Firstname = "Black" },
                    new Student { Lastname = "CROFT", Firstname = "Lara" },
                    new Student { Lastname = "HOLMES", Firstname = "Sherlock" },
                };

                context.Add(promotion2);

                context.SaveChanges();

                foreach (Promotion promotion in context.Promotions.Include(s => s.Students))
                {
                    Console.WriteLine("Liste des élèves de la promotion " +promotion.Name + " :");
                    foreach (Student student in promotion.Students)
                    {
                        Console.WriteLine("\t " + student.Lastname + " " + student.Firstname);
                    }
                }
            }
        }
    }
}
