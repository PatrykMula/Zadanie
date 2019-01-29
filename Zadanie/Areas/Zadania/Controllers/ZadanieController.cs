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
        //jak doczytam o obsludze Serwisów, to prawdopodobnie przerzuce do do nich i potem dodam obsluge :D
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
                                         priorytet = 1,
                                         procent_zakonczenia = 5,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now
                            },
                            new Dane() { id= 4,
                                         temat = "temat4",
                                         czynnosc = "czynnosc4",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 5,

                                         data_rozpoczecia = DateTime.Now.AddDays(1),
                                         data_zakonczenia = DateTime.Now.AddDays(5)

                            },
                            new Dane() { id= 5,
                                         temat = "temat5",
                                         czynnosc = "czynnosc5",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 1,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now.AddDays(2),
                                         data_zakonczenia = DateTime.Now.AddDays(2)
                            },
                            new Dane() { id= 6,
                                         temat = "temat6",
                                         czynnosc = "czynnosc6",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 5,

                                         data_rozpoczecia = DateTime.Now.AddHours(5),
                                         data_zakonczenia = DateTime.Now.AddDays(6)
                            },
                            new Dane() { id= 7,
                                         temat = "temat7",
                                         czynnosc = "czynnosc7",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
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
        public ActionResult Index(string sortBy)
        {
            ViewBag.SortDataRozpoczeciaParameter = string.IsNullOrEmpty(sortBy) ? "data_rozpoczecia" : "";
            ViewBag.SortDataRozpoczeciaParameter = sortBy == "data_rozpoczecia" ? "data_rozpoczecia*" :"data_rozpoczecia";
            ViewBag.SortDataZakonczeniaParameter = sortBy == "data_zakonczenia" ? "data_zakonczenia*" :"data_zakonczenia";
            ViewBag.SortStatusParameter = sortBy == "status" ? "status*" :"status";
            ViewBag.SortPriorytetParameter = sortBy == "priorytet" ? "priorytet*" :"priorytet";
            List<Dane> orderedList = taskList;
            switch (sortBy)
            {
                case "data_rozpoczecia*":
                    orderedList = taskList.OrderByDescending(a => a.data_rozpoczecia).ToList();
                    break;
                case "data_rozpoczecia":
                    orderedList = taskList.OrderBy(a => a.data_rozpoczecia).ToList();
                    break;

                case "data_zakonczenia*":
                    orderedList = taskList.OrderByDescending(a => a.data_zakonczenia).ToList();
                    break;
                case "data_zakonczenia":
                    orderedList = taskList.OrderBy(a => a.data_zakonczenia).ToList();
                    break;

                case "status*":
                    orderedList = taskList.OrderByDescending(a => a.status).ToList();
                    break;
                case "status":
                    orderedList = taskList.OrderBy(a => a.status).ToList();
                    break;

                case "priorytet*":
                    orderedList = taskList.OrderByDescending(a => a.priorytet).ToList();
                    break;
                case "priorytet":
                    orderedList = taskList.OrderBy(a => a.priorytet).ToList();
                    break;
                

               
            }


            //w przyszlosci te dane beda pobieranie z moq, albo z bazy danych
            
            return View(orderedList);

        }
        public ActionResult IndexTiles()
        {
            var orderedList = taskList.OrderBy(a => a.priorytet);
            return View(orderedList);
        }
        [HttpPost]
        public ActionResult IndexTiles(Dane dane)
        {

            if (dane.temat != null)
            {
                List<Dane> newList = taskList.FindAll(s => s.temat.Contains(dane.temat));
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }


            if (dane.czynnosc != null)
            {
                List<Dane> newList = taskList.FindAll(s => s.czynnosc.Contains(dane.czynnosc));
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }


            if (dane.data_rozpoczecia != new DateTime())
            {
                List<Dane> newList = taskList.FindAll(s => s.data_rozpoczecia.ToShortDateString() == dane.data_rozpoczecia.ToShortDateString());
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }
            
            

            if (dane.data_zakonczenia != new DateTime())
            {
                List<Dane> newList = taskList.FindAll(s => s.data_zakonczenia.ToShortDateString() == dane.data_zakonczenia.ToShortDateString());
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }
            


            if (dane.priorytet != 0)
            {
                List<Dane> newList = taskList.FindAll(s => s.priorytet==dane.priorytet);
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }

            if (dane.procent_zakonczenia != 0)
            {
                List<Dane> newList = taskList.FindAll(s => s.procent_zakonczenia == dane.procent_zakonczenia);
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }

            if (dane.status != 0)
            {
                List<Dane> newList = taskList.FindAll(s => s.status==dane.status);
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }
           return Redirect("IndexTiles");
        }


        public ActionResult Details(int? id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = taskList.Find(x => x.id==id);
            return PartialView(task) ;
                
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        public ActionResult Delete(int? id)
        {

            if (taskList.Find(x =>x.id == id)!=null){
                var itemToRemove = taskList.Single(r => r.id == id);

                taskList.Remove(itemToRemove);

            }
            else
            {

            }
            return Redirect("../Index");

        }

        [HttpPost]
        public ActionResult Create(Dane dane)
        {
            int id = (taskList.Count + 1);//dodanie jako kolejny element 
            dane.id = id;
            taskList.Add(dane);
            return Redirect("Index");
        }


        public ActionResult Edit(int? id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = taskList.Find(x => x.id == id);
            return PartialView(task);
        }

        [HttpPost]
        public ActionResult Edit(Dane dane)
        {

            var index = taskList.FindIndex(c => c.id == dane.id);
            taskList[index] = dane;
            return Redirect("../Index");
        }



        public ActionResult test1()
        {
            return View();
        }

    }

}