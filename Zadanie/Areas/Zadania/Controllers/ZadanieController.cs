﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadanie.Models;
using Rotativa;
using PagedList;
using PagedList.Mvc;
using OfficeOpenXml;
using System.IO;

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
                            new Dane() { id= 26,
                                         temat = "temat26",
                                         czynnosc = "czynnosc26",
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

            ViewBag.SortNazwa = string.IsNullOrEmpty(sortBy) ? "id" : "";
            ViewBag.SortDataRozpoczeciaParameter = sortBy == "data_rozpoczecia" ? "data_rozpoczecia*" :"data_rozpoczecia";
            ViewBag.SortDataZakonczeniaParameter = sortBy == "data_zakonczenia" ? "data_zakonczenia*" :"data_zakonczenia";
            ViewBag.SortStatusParameter = sortBy == "status" ? "status*" :"status";
            ViewBag.SortPriorytetParameter = sortBy == "priorytet" ? "priorytet*" :"priorytet";
            List<Dane> orderedList = taskList;
            switch (sortBy)
            {
                case "id":
                    orderedList = taskList.OrderBy(a => a.id).ToList();
                    break;
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



        public ActionResult Details(int id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = taskList.Find(x => x.id==id);
            return PartialView(task) ;
                
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        public ActionResult Edit(int id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = taskList.Find(x => x.id == id);
            return View(task);
        }

        [HttpPost]
        public ActionResult Save(Dane dane)
        {
            //jezeli jakims cudem uda sie wprowadzic zle dane, to zostanie przekierowany do Index
            if (!ModelState.IsValid)
            {   
                    return Redirect("Index");
            }
            //gdy id == 0, to jest otrzymywany z create, jezeli jest rozny od 0, to z edita
            if (dane.id == 0)
            {
                //dodanie jako kolejny element 
                int id = (taskList.Count + 1);
                dane.id = id;
                taskList.Add(dane);
                return Redirect("Index");
            }
            else
            {
                var index = taskList.FindIndex(c => c.id == dane.id);
                //sprawdzamy, czy element o podanym id istnieje w naszej liscie
                if (index >= 0)
                {
                    taskList[index] = dane;
                    return Redirect("Index");
                }
                else
         
                {
                    return Redirect("Index");
                }

            }

        }


        public ActionResult Delete(int id)
        {

            if (taskList.Find(x => x.id == id) != null)
            {
                var itemToRemove = taskList.Single(r => r.id == id);

                taskList.Remove(itemToRemove);

            }
            else
            {

            }
            return Redirect("../Index");

        }

        public ActionResult SaveAsExcel()
        {

            IPagedList<Dane> model = (IPagedList<Dane>)TempData["FullModel"];

            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("excel");
            
            ws.Cells["A1"].Value = "Czynnosc";
            ws.Cells["B1"].Value = "Temat";
            ws.Cells["C1"].Value = "Data Rozpoczęcia";
            ws.Cells["D1"].Value = "Data Zakończenia";
            ws.Cells["E1"].Value = "Status";
            ws.Cells["F1"].Value = "Priorytet";
            ws.Cells["G1"].Value = "Procent zakończenia";
            int rowStart = 2;
            foreach (var item in model)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.czynnosc;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.temat;
                ws.Cells[string.Format("C{0}", rowStart)].Style.Numberformat.Format = "dd-MM-yyyy";
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.data_rozpoczecia;
                ws.Cells[string.Format("D{0}", rowStart)].Style.Numberformat.Format = "dd-MM-yyyy";
                ws.Cells[string.Format("D{0}", rowStart)].Value = item.data_zakonczenia;
                ws.Cells[string.Format("E{0}", rowStart)].Value = item.status;
                ws.Cells[string.Format("F{0}", rowStart)].Value = item.priorytet;
                ws.Cells[string.Format("G{0}", rowStart)].Value = item.procent_zakonczenia;
                rowStart++;
            }
            ws.Cells[ws.Dimension.Address].AutoFitColumns();
            string excelName = "ToDo";

            using (var memoryStream = new MemoryStream())
            {
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment; filename=" + excelName + ".xlsx");
                pck.SaveAs(memoryStream);
                memoryStream.WriteTo(Response.OutputStream);
                Response.Flush();
                Response.End();

                return Redirect("index");
            }
        }

        public ActionResult test1()
        {
            return View();
        }

    }

}