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
        mview.UploadedWL = _model;
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
    
    [HttpGet]
    public IActionResult MPage(string valeur)
    {
        var view = new ModelView();
        view.member = valeur;
        var ListPCs = _pcservice.GetAllPCs(valeur);
        for (int i = 0; i < ListPCs.Count(); i++)
        {
            view.Questions.Add(new ImageQuestion { Name = valeur + "/" + ListPCs[i].Name, Selection = "I", pc = ListPCs[i] });
        }
        return View(view);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult recupererValeurs(ModelView view)
    {
        if (view?.Questions == null || view.Questions.Count == 0)
        {
            return BadRequest("Questions vides !");
        }

        if (view.Questions == null)
            view.Questions = new List<ImageQuestion>();

        string member = view.member;

        // Remplir les listes en fonction de Selection
        _model.Have.AddRange(view.Questions
            .Where(q => q.Selection == "H")
            .Select(q => q.Name)
            .ToList());

        _model.Want.AddRange(view.Questions
            .Where(q => q.Selection == "W")
            .Select(q => q.Name)
            .ToList());

        _model.TopPriority.AddRange(view.Questions
            .Where(q => q.Selection == "P")
            .Select(q => q.Name)
            .ToList());

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