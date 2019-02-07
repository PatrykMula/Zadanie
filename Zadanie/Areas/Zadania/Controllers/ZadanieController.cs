using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadanie.Models;
using Rotativa;
using PagedList;
using PagedList.Mvc;



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
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 9,
                                         temat = "temat9",
                                         czynnosc = "czynnosc9",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 10,
                                         temat = "temat10",
                                         czynnosc = "czynnosc10",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 11,
                                         temat = "temat11",
                                         czynnosc = "czynnosc11",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 12,
                                         temat = "temat12",
                                         czynnosc = "czynnosc12",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 13,
                                         temat = "temat13",
                                         czynnosc = "czynnosc13",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 14,
                                         temat = "temat14",
                                         czynnosc = "czynnosc14",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 15,
                                         temat = "temat15",
                                         czynnosc = "czynnosc15",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 16,
                                         temat = "temat16",
                                         czynnosc = "czynnosc16",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 17,
                                         temat = "temat17",
                                         czynnosc = "czynnosc17",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 18,
                                         temat = "temat18",
                                         czynnosc = "czynnosc18",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 19,
                                         temat = "temat19",
                                         czynnosc = "czynnosc19",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 20,
                                         temat = "temat20",
                                         czynnosc = "czynnosc20",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 21,
                                         temat = "temat21",
                                         czynnosc = "czynnosc21",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 22,
                                         temat = "temat22",
                                         czynnosc = "czynnosc22",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 23,
                                         temat = "temat23",
                                         czynnosc = "czynnosc23",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 24,
                                         temat = "temat24",
                                         czynnosc = "czynnosc24",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 25,
                                         temat = "temat25",
                                         czynnosc = "czynnosc25",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 27,
                                         temat = "temat27",
                                         czynnosc = "czynnosc27",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 28,
                                         temat = "temat28",
                                         czynnosc = "czynnosc28",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 29,
                                         temat = "temat29",
                                         czynnosc = "czynnosc29",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 30,
                                         temat = "temat30",
                                         czynnosc = "czynnosc30",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 31,
                                         temat = "temat31",
                                         czynnosc = "czynnosc31",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 32,
                                         temat = "temat32",
                                         czynnosc = "czynnosc32",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 33,
                                         temat = "temat33",
                                         czynnosc = "czynnosc33",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 34,
                                         temat = "temat34",
                                         czynnosc = "czynnosc34",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 35,
                                         temat = "temat35",
                                         czynnosc = "czynnosc35",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 36,
                                         temat = "temat36",
                                         czynnosc = "czynnosc36",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },
                            new Dane() { id= 37,
                                         temat = "temat37",
                                         czynnosc = "czynnosc37",
                                         opis = "jakis tam opis",

                                         status = 1,
                                         priorytet = 2,
                                         procent_zakonczenia = 10,

                                         data_rozpoczecia = DateTime.Now,
                                         data_zakonczenia = DateTime.Now.AddDays(1)
                            },


                            new Dane() { id= 38,
                                         temat = "temat38",
                                         czynnosc = "czynnosc38",
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



//****************************************************************************************************************************************************************************************************************************
        // GET: Zadanie
        public ActionResult Index(string sortBy,int? page,int? pageCount)
        {
            ViewBag.CurrentSort = sortBy;
            ViewBag.CurrentPageCount = pageCount;

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
            int pageSize = (pageCount ?? 10);
            int pageNumber = (page ?? 1);
            return View(orderedList.ToPagedList(pageNumber,pageSize));

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
                List<Dane> newList = taskList.FindAll(s => s.priorytet == dane.priorytet);
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
                List<Dane> newList = taskList.FindAll(s => s.status == dane.status);
                if (newList.Count < 1)
                    return View();
                else return View(newList);

            }
            return Redirect("IndexTiles");
        }




        public ActionResult SaveAsPdf()
        {
            /*dodawanie do pdf juz dziala, ale jeszcze trzeba dodac nowy widok,
            do ktorego bedzie przekazywany model,
            poniewaz wybrane rozwiazanie przerabia otrzymana strone na pdf
            W przyszlosci można zastosować inne rozwiazanie np. RazorPDF, iTexta, albo IronPDF
            fajnym rozwiazaniem wydaje sie byc kendo UI, ale jest drogi :D*/
            /*trzeba jeszcze dodac:
             * zapytanie, czy na pewno zapisac
             * dodac pytanie o nazwe
             * ewentualnie gdzie zapisac*/
            {
                var model = TempData["FullModel"];
                //Code to get content
                return new Rotativa.ViewAsPdf("Index", model) { FileName = "TestViewAsPdf.pdf" };
            }


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


        [HttpPost]
        public ActionResult Create(Dane dane)
        {
            int id = (taskList.Count + 1);//dodanie jako kolejny element 
            dane.id = id;
            taskList.Add(dane);
            return Redirect("Index");
        }


        public ActionResult Delete(int id)
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


        public ActionResult Edit(int id)
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