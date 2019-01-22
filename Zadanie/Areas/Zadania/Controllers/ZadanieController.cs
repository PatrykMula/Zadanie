using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadanie.Models;

namespace Zadanie.Areas.Zadania.Controllers
{
    public class ZadanieController : Controller
    {
        public static List<Dane> taskList = new List<Dane>{
                            new Dane() { id= 1,
                                         temat = "temat1",
                                         czynnosc = "czynnosc1",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 2,
                                         temat = "temat2",
                                         czynnosc = "czynnosc2",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 3,
                                         temat = "temat3",
                                         czynnosc = "czynnosc3",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 4,
                                         temat = "temat4",
                                         czynnosc = "czynnosc4",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 5,
                                         temat = "temat5",
                                         czynnosc = "czynnosc5",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 6,
                                         temat = "temat6",
                                         czynnosc = "czynnosc6",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 7,
                                         temat = "temat7",
                                         czynnosc = "czynnosc7",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 8,
                                         temat = "temat8",
                                         czynnosc = "czynnosc8",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            }



                        };
        Dane oneTask = new Dane()
        {
            id = 1,
            temat = "temat1",
            czynnosc = "czynnosc1",
            opis = "jakis tam opis",

            status = 1,
            priorytet = 2,
            procent_zakonczenia = 10,

            data_rozpoczecia = DateTime.Now,
            data_zakonczenia = DateTime.Now
        };


        // GET: Zadanie
        public ActionResult Index()
        {
 //w przyszlosci te dane beda pobieranie z moq, albo z bazy danych
            return View(taskList);
        }
        public ActionResult IndexTiles()
        {
            return View(taskList);
        }
        public ActionResult Details()
        {
            return PartialView(oneTask) ;
                
        }

        public ActionResult Create()
        {


            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Dane dane)
        {

            taskList.Add(dane);
            return Redirect("Index");
        }
        public ActionResult Edit()
        {
            return PartialView(oneTask);
        }

        public ActionResult test1()
        {
            return View();
        }

    }

}