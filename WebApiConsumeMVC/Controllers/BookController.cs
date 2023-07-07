using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApiConsumeMVC.Models;

namespace WebApiConsumeMVC.Controllers
{
    public class BookController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44370/api");
        private readonly HttpClient _client;
        public BookController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<BookViewModel> bookList = new List<BookViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Books/GetAllBooks").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                bookList = JsonConvert.DeserializeObject<List<BookViewModel>>(data);
            }
            return View(bookList);
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            BookViewModel book = new BookViewModel();
            return PartialView("Create",book);
        }
        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/Books/AddBook", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Book Created.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {TempData["errorMessage"]
                 = ex.Message;
                return View();
            }
            return View();

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                BookViewModel book = new BookViewModel();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Books/GetBookById/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    book = JsonConvert.DeserializeObject<BookViewModel>(data);
                }
                return View(book);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();

            }
           
        }
        [HttpPost]
        public IActionResult Edit(BookViewModel model)
        {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Books/UpdateBook", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Book details updated";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();

            }
            return View(model);
        }
        //[HttpGet]
        //public IActionResult Detail(int id)
        //{
        //    try
        //    {
        //        BookViewModel book = new BookViewModel();
        //        HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Books/GetBookById/" + id).Result;
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string data = response.Content.ReadAsStringAsync().Result;
        //            book = JsonConvert.DeserializeObject<BookViewModel>(data);
        //        }
        //        return PartialView("Detail", book);
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["errorMessage"] = ex.Message;
        //        return View();
        //    }
        //}
     
        public IActionResult Delete(int id)
        {
            try
            {
                _client.DefaultRequestHeaders.Accept.Clear();

                HttpResponseMessage response = _client.DeleteAsync(_client.BaseAddress + "/Books/DeleteBookById/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                   
                    TempData["successMessage"] = "Book details deleted.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();

            }
            return View();
        }
    }
}
