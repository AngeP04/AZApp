using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AZapp.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using System.IO.Compression;


namespace AZapp.Controllers;

public class MemberController : Controller
{
    public static WishList _model = new WishList();
    private readonly ListPC listPC = new ListPC();

    [HttpGet]
    public IActionResult Create()
    {
        return View();
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


    public IActionResult KHJ()
    {
        ModelView khj = new ModelView();
        khj.ListPCMember = listPC.KHJ;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "KHJ")
            {
                khj.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "KHJ")
            {
                khj.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "KHJ")
            {
                khj.UploadedWL.Have.Add(nom);
            }
        }
        return View(khj);
    }

    public IActionResult PSH()
    {
        ModelView psh = new ModelView();
        psh.ListPCMember = listPC.PSH;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "PSH")
            {
                psh.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "PSH")
            {
                psh.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "PSH")
            {
                psh.UploadedWL.Have.Add(nom);
            }
        }
        return View(psh);
    }

    public IActionResult JYH()
    {
        ModelView jyh = new ModelView();
        jyh.ListPCMember = listPC.JYH;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "JYH")
            {
                jyh.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "JYH")
            {
                jyh.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "JYH")
            {
                jyh.UploadedWL.Have.Add(nom);
            }
        }
        return View(jyh);
    }

    public IActionResult KYS()
    {
        ModelView kys = new ModelView();
        kys.ListPCMember = listPC.KYS;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "KYS")
            {
                kys.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "KYS")
            {
                kys.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "KYS")
            {
                kys.UploadedWL.Have.Add(nom);
            }
        }
        return View(kys);
    }

    public IActionResult CSN()
    {
        ModelView csn = new ModelView();
        csn.ListPCMember = listPC.CSN;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "CSN")
            {
                csn.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "CSN")
            {
                csn.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "CSN")
            {
                csn.UploadedWL.Have.Add(nom);
            }
        }
        return View(csn);
    }

    public IActionResult SMG()
    {
        ModelView smg = new ModelView();
        smg.ListPCMember = listPC.SMG;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "SMG")
            {
                smg.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "SMG")
            {
                smg.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "SMG")
            {
                smg.UploadedWL.Have.Add(nom);
            }
        }
        return View(smg);
    }

    public IActionResult JWY()
    {
        ModelView jwy = new ModelView();
        jwy.ListPCMember = listPC.JWY;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "JWY")
            {
                jwy.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "JWY")
            {
                jwy.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "JWY")
            {
                jwy.UploadedWL.Have.Add(nom);
            }
        }
        return View(jwy);
    }

    public IActionResult CJH()
    {
        ModelView cjh = new ModelView();
        cjh.ListPCMember = listPC.CJH;
        foreach (string nom in _model.TopPriority)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "CJH")
            {
                cjh.UploadedWL.TopPriority.Add(nom);
            }
        }
        foreach (string nom in _model.Want)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "CJH")
            {
                cjh.UploadedWL.Want.Add(nom);
            }
        }
        foreach (string nom in _model.Have)
        {
            if (nom != "" && nom.Substring(nom.Count() - 3, 3) == "CJH")
            {
                cjh.UploadedWL.Have.Add(nom);
            }
        }
        return View(cjh);
    }

    [HttpPost]
    public IActionResult recupererValeursKHJ()
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