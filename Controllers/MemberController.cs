using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AZapp.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using System.IO.Compression;
using Microsoft.EntityFrameworkCore.Design;


namespace AZapp.Controllers;

public class MemberController : Controller
{
    public static WishList _model = new WishList();
    private readonly ListPC listPC = new ListPC();
    private readonly PCsService _pcservice;

    public MemberController(PCbibDbContext context, PCsService pcsservice)
    {
        _pcservice = pcsservice;
    }

    [HttpGet]
    public IActionResult Create()
    {
        var mview = new ModelView();
        return View(mview);
    }

    [HttpPost]
    public async Task<IActionResult> UploadFile(IFormFile uploadedFile)
    {
        if (uploadedFile != null && uploadedFile.Length > 0)
        {
            var path = Path.Combine("wwwroot/UploadedFiles", uploadedFile.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(stream);
            }
            return RedirectToAction("Form", new { FileName = uploadedFile.FileName });
        }

        return View();
    }

    public async Task<IActionResult> Form(string FileName)
    {
        // Example: read selected value from file
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UploadedFiles", FileName);
        string file = await System.IO.File.ReadAllTextAsync(filePath);

        _model.TopPriority = file.Split(".")[0].Split(",").ToList();
        _model.Want = file.Split(".")[1].Split(",").ToList();
        _model.Have = file.Split(".")[2].Split(",").ToList();

        _model.TopPriority.RemoveAt(_model.TopPriority.Count() - 1);
        _model.Want.RemoveAt(_model.Want.Count() - 1);
        _model.Have.RemoveAt(_model.Have.Count() - 1);

        return RedirectToAction("Create");
    }

    public IActionResult MPage_(string valeur)
    {
        var model = new ModelView
        {
            member = valeur,
            ListPCs = _pcservice.GetAllPCs(valeur)
        };

        return View(model);
    }


    public IActionResult MPage(string value)
    {
        ModelView view = new ModelView();
        view.member = value;
        view.ListPCs = _pcservice.GetAllPCs(value);
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == value)
            {
                view.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == value)
            {
                view.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == value)
            {
                view.UploadedWL.Have.Add(nom);
            }
        }
        return View(view);
    }



    [HttpPost]
    public IActionResult recupererValeurs(string member)
    {
        var allnames = listPC.KHJ;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursPSH()
    {
        var allnames = listPC.PSH;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursJYH()
    {
        var allnames = listPC.JYH;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursKYS()
    {
        var allnames = listPC.KYS;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursCSN()
    {
        var allnames = listPC.CSN;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursSMG()
    {
        var allnames = listPC.SMG;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursJWY()
    {
        var allnames = listPC.JWY;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpPost]
    public IActionResult recupererValeursCJH()
    {
        var allnames = listPC.CJH;
        foreach (List<string> liste in allnames)
        {
            foreach (string nom in liste)
            {
                var value = Request.Form[nom];

                switch (value)
                {
                    case "I":
                        break;
                    case "H":
                        _model.Have.Add(nom);
                        break;
                    case "W":
                        _model.Want.Add(nom);
                        break;
                    case "P":
                        _model.TopPriority.Add(nom);
                        break;
                }
            }
        }

        return RedirectToAction("Create");
    }

    [HttpGet]
    public IActionResult Telecharger()
    {
        var Model = _model.PathLists();
        QuestPDF.Settings.EnableDebugging = true;
        var pdf = new Document(Model).GeneratePdf();
        
        using (var memoryStream = new MemoryStream())
        {
            using (var zip = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
            {
                var file1 = zip.CreateEntry("WishListData.txt");
                using (var entryStream = file1.Open())
                using (var writer = new StreamWriter(entryStream))
                {
                    foreach (string element in _model.TopPriority)
                    {
                        writer.Write($"{element},");
                    }
                    writer.Write(".");
                    foreach (string element in _model.Want)
                    {
                        writer.Write($"{element},");
                    }
                    writer.Write(".");
                    foreach (string element in _model.Have)
                    {
                        writer.Write($"{element},");
                    }

                }

                var pdfEntry = zip.CreateEntry("Wishlist.pdf");
                using (var entryStream = pdfEntry.Open())
                {
                    entryStream.Write(pdf, 0, pdf.Length);
                }
            }

            memoryStream.Seek(0, SeekOrigin.Begin);
            return File(memoryStream.ToArray(), "application/zip", "WishList.zip");
        }
    }
}