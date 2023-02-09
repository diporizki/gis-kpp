using kpp_gis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kpp_gis.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public JsonResult getdataPM2006(string Plate_No = "")
        {
                       if (Plate_No == "")
                     {

            var PM2006 = DataClasses1.TBL_T_LOG_DATAs
            .Select(
            f => new
            {
                f.Longitude,
                f.Latitude,
                f.Plate_No,
                f.Speed,
                f.GPSDateTime,
                f.Direction,
                f.Location,
                f.Altitude
            })
            .Where(item => item.Plate_No == "PM2006")
            .Take(100)
            .ToList();

            return Json(new
            {
                data = PM2006
            }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                var tbl_log_data = DataClasses1.TBL_T_LOG_DATAs
                .Select(
                f => new
                {
                    f.Longitude,
                    f.Latitude,
                    f.Plate_No,
                    f.Speed,
                    f.GPSDateTime,
                    f.Direction,
                    f.Location,
                    f.Altitude
                })
                .Where(item => item.Plate_No == "PM2006")
                .Take(100)
                .ToList();
                return Json(new
                {
                    data = tbl_log_data
                }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult getdataPM1026(string Plate_No = "")
        {
            var PM1026 = DataClasses1.TBL_T_LOG_DATAs

                .Select(
                f => new
                {
                    f.Latitude,
                    f.Longitude,
                    f.Plate_No,
                    f.Speed,
                    f.Direction,
                    f.Location,
                    f.GPSDateTime,
                    f.Altitude
                })
                .Where(item => item.Plate_No == "PM1026")
                .Take(100)
                .ToList();

            return Json(new
            {
                data = PM1026
            }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult getdataPM5006(string Plate_No = "")
        {
            var PM5006 = DataClasses1.TBL_T_LOG_DATAs

                .Select(
                f => new
                {
                    f.Latitude,
                    f.Longitude,
                    f.Plate_No,
                    f.Speed,
                    f.Direction,
                    f.Location,
                    f.GPSDateTime,
                    f.Altitude
                })
                .Where(item => item.Plate_No == "PM5006")
                .Take(300)
                .ToList();

            return Json(new
            {
                data = PM5006
            }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult getdataPEN49(string Plate_No = "")
        {
            var PEN49 = DataClasses1.TBL_T_LOG_DATAs

                .Select(
                f => new
                {
                    f.Latitude,
                    f.Longitude,
                    f.Plate_No,
                    f.Speed,
                    f.Direction,
                    f.Location,
                    f.GPSDateTime,
                    f.Altitude
                })
                .Where(item => item.Plate_No == "PEN49")
                .Take(100)
                .ToList();

            return Json(new
            {
                data = PEN49
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getdataPEN45(string Plate_No = "")
        {
            var PEN45 = DataClasses1.TBL_T_LOG_DATAs

                .Select(
                f => new
                {
                    f.Latitude,
                    f.Longitude,
                    f.Plate_No,
                    f.Speed,
                    f.Direction,
                    f.Location,
                    f.GPSDateTime,
                    f.Altitude
                })
                .Where(item => item.Plate_No == "PEN45")
                .Take(200)
                .ToList();

            return Json(new
            {
                data = PEN45
            }, JsonRequestBehavior.AllowGet);
        }
        //[HttpGet]
        //public jsonresult getdata2(string plate_no = "")
        //{
        //    return json(new
        //    {
        //        data = "asdasdasdasdasdasd"
        //    }, jsonrequestbehavior.allowget);
        //}
    }
}
