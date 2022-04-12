
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using OnlineBankingSystem.Models;

namespace OnlineBankingSystem.Controllers
{
    public class HomeController : Controller
    {
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

        [Authorize]
        public ActionResult InternetBanking() //InternetBanking model
        {
            InternetBanking ib = new InternetBanking();
           /* try
            {
                OnlineBankEntities1 db = new OnlineBankEntities1();

                InternetBanking ib = new InternetBanking();
                ib.AcccountNumber = model.AcccountNumber;
                ib.Password = model.Password;
                ib.ConfirmPassword = model.ConfirmPassword;
                ib.TransactionPassword = model.TransactionPassword;
                ib.ConfirmTransactionPassword = model.ConfirmTransactionPassword;
                ib.OTP = model.OTP;

                db.InternetBankings.Add(ib);

                db.SaveChanges();

                int latestAccountNumber = ib.AcccountNumber;
            }
            catch (Exception ex)
            {

                throw ex; 
            }*/



            return View(ib);
        }

        [HttpPost]
        public ActionResult InternetBanking(InternetBanking Model)
        {
            using (OnlineBankEntities1 dbModel = new OnlineBankEntities1())
            {
                dbModel.InternetBankings.Add(Model);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = " Internet Banking form Succesfully Submitted.";
            return View("InternetBanking", new InternetBanking());
        }

        [Authorize]
        public ActionResult Savingsaccount()
        {
            savingsaccount sa = new savingsaccount();

            return View(sa);
        }

        [HttpPost]
        public ActionResult Savingsaccount(savingsaccount Model)
        {
            using (OnlineBankEntities2 dbModel = new OnlineBankEntities2())
            {
                dbModel.savingsaccounts.Add(Model);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = " Internet Banking form Succesfully Submitted.";
            return View("Savingsaccount", new savingsaccount());
        }
    }
}